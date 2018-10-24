using System.Collections.Generic;

namespace FileManager.Models
{
    public class Plant : IObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public bool Check_Status { get; set; }

        public List<Area> Areas { get; set; }
    }
}
