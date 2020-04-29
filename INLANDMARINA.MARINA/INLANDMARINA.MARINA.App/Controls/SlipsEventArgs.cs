using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INLANDMARINA.MARINA.App.Controls
{
    public class SlipsEventArgs : EventArgs
    {
        public string ID { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string DockID { get; set; }

    }
}