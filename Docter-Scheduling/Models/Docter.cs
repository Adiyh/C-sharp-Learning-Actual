public class Doctor
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
    public Dictionary<int, DateTime> SlotMap { get; set; } = new();
}
