using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public interface IDMSFile
    {
         String Name { get; set; }

         string FilePath { get; set; }

         String Description { get; set; }
    }
}
