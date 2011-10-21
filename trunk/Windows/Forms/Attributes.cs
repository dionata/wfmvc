using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFMVC.Windows.Forms
{
    public class ViewAttribute : Attribute
    {
        public Type Type { get; private set; }

        public ViewAttribute(Type type)
        {
            this.Type = type;
        }
    }
}
