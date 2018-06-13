using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movies
{
    public class DataEventArgs
    {
        public Dictionary<String, Panel> panels { get; set; }
        public String searchWord { get; set; }
        public String button { get; set; }
    }
}
