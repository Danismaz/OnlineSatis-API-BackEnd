using DataTransfer.Abstract;

namespace DataTransfer.Concrete;

public class CreateCategoryDto : BaseDto
{
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
}