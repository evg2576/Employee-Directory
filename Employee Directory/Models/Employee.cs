namespace Employee_Directory.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Image { get; set; }
    }
}
