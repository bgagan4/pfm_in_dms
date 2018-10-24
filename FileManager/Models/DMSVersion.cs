using System.Collections.Generic;

namespace FileManager.Models
{
   public class DMSVersion:IDMSVersion, IObject
    {
        public string DocName { get; set; }
        public string DocDescription { get; set; }
        public string DocNo { get; set; }
        public List<IDMSFile> Files { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public bool Check_Status { get; set; }
        public string UnitId { get; internal set; }
        public string TagId { get; internal set; }
    }
}
