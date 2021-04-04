using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN_ychet
{
    public partial class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public int Deleted { get; set; }

        //public Equipment () { }

        //public Equipment(int Id, string Name, int Limit, int Deleted) 
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Limit = Limit;
        //    this.Deleted = Deleted;
        //}

    }
}
