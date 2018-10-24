using System.Collections.Generic;

namespace FileManager.Models
{
    public class Area : IObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public bool Check_Status { get; set; }
            
        public string PlantId { get; set; }

        public List<Unit> Units { get; set; }
    }
}
