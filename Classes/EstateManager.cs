using Assignment_2._0.Classes;
using Assignment_2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2.Classes
{
    class EstateManager : ListManager<Estate>
    {
        public EstateManager(ListBox listBox) : base(listBox)
        {
        }

    }
}
