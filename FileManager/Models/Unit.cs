namespace FileManager.Models
{
    public class Unit : IObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public string AreaId { get; set; }
        public bool Check_Status { get; set; }
    }
}
