using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN_ychet
{
    public partial class Units
    {
        public int Id { get; set; }
        public int EquipmetId { get; set; }
        public string Comissioned { get; set; }
        public int RoomId { get; set; }
        public int Deleted { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual Rooms Rooms { get; set; }

        //public Units() { }

        //public Units(int Id, int EquipmetId, string Comissioned, int RoomId, int Deleted)
        //{
        //    this.Id = Id;
        //    this.EquipmetId = EquipmetId;
        //    this.Comissioned = Comissioned;
        //    this.RoomId = RoomId;
        //    this.Deleted = Deleted;
        //}
    }
}
