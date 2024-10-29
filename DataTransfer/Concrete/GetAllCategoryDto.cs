using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class GetAllCategoryDto :BaseDto
{
    public Int64 CategoryCode { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    
}