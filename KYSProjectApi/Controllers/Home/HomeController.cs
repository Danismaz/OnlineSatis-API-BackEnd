using AutoMapper;
using Business.ActionFilters;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using Entities.Consts;
using KYSProjectApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Home;

[Route("api/[controller]")]
[ApiController]
public class HomeController (IUserService userService,IEmailService emailService,IMapper mapper) : ControllerBase
{
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [HttpPost("ContactUsAsync")]
    public async Task<IActionResult> ContactUsAsync([FromBody]ContactUsVm model)
    {
        var userIsRegistered = await userService.AnyAsync(x=> x.Email==model.Email && x.Status!=Status.Passive);
        var contactUsDto = mapper.Map<ContactUsDto>(model);
        await emailService.ContactUsAsync(contactUsDto, userIsRegistered);
        return Ok();
    }
    
    
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [HttpPost("PostCommentAsync")]
    public async Task<IActionResult> PostCommentAsync([FromBody] CommentVm model)
    {
        if (string.IsNullOrEmpty(model.Comment))
        {
            return BadRequest("Yorum boş olamaz.");
        }

        // Yorumun metin dosyasına yazılması
        // var commentLine = $"Name: {model.Name}\"\\n\" Email: {model.Email}\"\\n\" Comment: {model.Comment}\"\\n\" Date: {model.CreatedDate:yyyy-MM-dd HH:mm}";
        var commentLine = $"Date: {model.CreatedDate:yyyy-MM-dd HH:mm} - Name: {model.Name} - Email: {model.Email} - Comment: {model.Comment}";
        await System.IO.File.AppendAllTextAsync("comments.txt", commentLine + "\n");

        return Ok(new { Message = "Yorum başarıyla kaydedildi." });
    }

    [HttpGet("GetComments")]
    public IActionResult GetComments()
    {
        if (!System.IO.File.Exists("comments.txt"))
        {
            return NotFound("Yorum dosyası bulunamadı.");
        }

        var comments = System.IO.File.ReadAllLines("comments.txt");
        return Ok(comments);
    }
    [HttpGet("GetCommentByEmail")]
    public IActionResult GetCommentByEmail([FromQuery] string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return BadRequest("Geçersiz e-posta adresi.");
        }
        if (!System.IO.File.Exists("comments.txt"))
        {
            return NotFound("Yorum dosyası bulunamadı.");
        }

        var comments = System.IO.File.ReadAllLines("comments.txt");
        var commentsByEmail = new List<string>();
        foreach (var item in comments)
        {
            if (item.Contains(email))
            {
                commentsByEmail.Add(item);
            }
        }
        return Ok(commentsByEmail.Count>0 ?commentsByEmail :"Bu emaile ait yorum bulunamadı.");
    }


}
