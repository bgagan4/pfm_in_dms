using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    interface IObject
    {
         string Name { get; set; }
         string Description { get; set; } 
        string ID { get; set; }

        Boolean Check_Status
        {
            get;
            set;
        }
    }
}
