using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrideStorage.Model
{
    class Food
    {
        public string Type      { get; set; }

        public string Animal    { get; set; }

        public string Name      { get; set; }

        public int Weight       { get; set; }

        public int Amount       { get; set; }

        public DateTime Date    { get; set; }

        public int Drawer       { get; set; }
    }
}
