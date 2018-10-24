using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    interface IDMSVersion
    {
        string DocName { get; set; }

        string DocDescription { get; set; }

        string DocNo { get; set; }

        List<IDMSFile> Files { get; set; }
        
    }
}
