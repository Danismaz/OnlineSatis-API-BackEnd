namespace Business.Exceptions
{
    public sealed class MachineNotFoundException : NotFoundException
    {
        public MachineNotFoundException(Int64 MachineCode) : base($"Bu {MachineCode}'da sahip makina bulunamadı.")
        {
        }
    }
}
