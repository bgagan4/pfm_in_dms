using System.Collections.Generic;

namespace FileManager.Models
{
    public class Tag : IObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public string UnitId { get; set; }
        public bool Check_Status
        {
            get;
            set;
        }
        public List<IDMSFile> Files { get; set; }
    }
}
