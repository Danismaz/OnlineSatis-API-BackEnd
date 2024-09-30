using Entities.Consts;

namespace DataTransfer.Abstract;

public abstract class BaseDto
{

    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public Status Status { get; set; }
}