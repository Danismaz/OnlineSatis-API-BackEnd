using System.Transactions;
using Business.ActionFilters;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using KYSProjectApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Order;

[ApiController]
[Route("api/[controller]")]
public class OrderController(
    IUserService userService,
    IProductService productService,
    IOrderService orderService,
    IOrderDetailService orderDetailService) : ControllerBase
{
    /* todo
    UI Tarafı
    Satın Al butonuna tıkla
    Ürün ID'si ve adedini al ( burada ürün çoklu veye tek de olabilir)
    kargo ID'sini al
    User Mail'i Al
    bunların hepsini sepet diye api'ye ilet

    BackEnd Tarafı
    Order Controller ile UI'dan gelen istegi karşıla

    order controller ile bir sipariş için order , orderDetail, kayıt yapılacak bu kayıtlar olumlu ise satılan ürünlerin adedi producttan düşülecek.
    */

    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [HttpPost("CreateOrder")]
    public async Task<IActionResult> CreateOrder([FromBody] CreateOrderVm model)
    {
        using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            try
            {
                // Kullanıcıyı email ile buluyoruz
                var user = await userService.GetByEmailAsync<GetUserDto>(x => x.Email == model.UserEmail);

                if (user is null)
                {
                    // Eğer kullanıcı bulunmazsa rollback edilir
                    return NotFound("User not found");
                }

                var orderDto = new CreateOrderDto()
                {
                    OrderDate = DateTime.Now,
                    UserCode = user.UserCode,
                    ShipperCode = model.ShipperCode
                };

                var orderResult = await orderService.AddAsync(orderDto);

                // Eğer kayıt başarılı olduysa
                if (!orderResult)
                {
                    return BadRequest("Order creation failed");
                }

                var orders = await orderService.GetFilteredListAsync<GetOrderDto>(
                    select: x => new GetOrderDto
                    {
                        OrderCode = x.OrderCode,
                        OrderDate = x.OrderDate,
                    },
                    where: x => x.OrderDate == orderDto.OrderDate
                );

                Int64 orderId;
                if (orders.Any())
                {
                    var order = orders.First();
                    orderId = order.OrderCode;
                }
                else
                {
                    return NotFound("Order not found");
                }

                List<CreateOrderDetailProductDto> products = new List<CreateOrderDetailProductDto>();

                foreach (CreateOrderProductsVm item in model.Products)
                {
                    var product = await productService.GetByIdAsync<GetProductDto>(x => x.ProductCode == item.ProductCode);
                    if (product is null)
                    {
                        return NotFound("Product not found. Transaction rolled back.");
                    }

                    CreateOrderDetailProductDto productDto = new CreateOrderDetailProductDto()
                    {
                        ProductCode = product.ProductCode,
                        ProductName = product.ProductName,
                        ProductPrice = product.ProductPrice,
                        Quantity = item.Quantity
                    };

                    products.Add(productDto);

                    // Stoktan düşme işlemini yapabilirsiniz
                    product.Stock -= item.Quantity;
                    await productService.UpdateAsync(product);
                }
                
                foreach (CreateOrderDetailProductDto detailProductDto in products)
                {
                    // Her ürün için CreateOrderDetailDto nesnesini oluşturuyoruz
                    CreateOrderDetailDto orderDetailDto = new CreateOrderDetailDto()
                    {
                        OrderCode = orderId, // Siparişin OrderCode bilgisini ekliyoruz
                        ProductCode = detailProductDto.ProductCode,
                        Price = detailProductDto.ProductPrice,
                        Quantity = detailProductDto.Quantity
                    };

                    // Veritabanına kayıt işlemi
                    var result = await orderDetailService.AddAsync(orderDetailDto);
    
                    if (!result)
                    {
                        return BadRequest("Order detail could not be added. Transaction rolled back.");
                    }
                }


                // Eğer tüm işlemler başarılı olursa transaction commit edilir
                transaction.Complete();

                return Ok();
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException?.Message ?? "No inner exception available.";
                var result = new
                {
                    Message = "An error occurred.",
                    Error = innerExceptionMessage,
                    // Inner exception ve diğer detayları eklemek için
                    StackTrace = ex.StackTrace // Gerekirse
                };
                // Hata detaylarını JSON formatında döndürün
                return StatusCode(500, result);
            }
        }
    }
}