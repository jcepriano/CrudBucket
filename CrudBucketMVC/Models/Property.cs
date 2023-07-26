namespace CrudBucketMVC.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public Owner Owner { get; set; }
    }
}
