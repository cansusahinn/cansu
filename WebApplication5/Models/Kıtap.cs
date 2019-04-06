using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Kıtap
    {
        public int KıtapId { get; set; }
        public string KıtapAdi { get; set; }
        public DateTime KıtapBasimTarihi { get; set; }
        public int YazarId { get; set; }
        public int KıtapTuruId { get; set; }
        public virtual Yazar Yazari { get; set; }
        public virtual KıtapTuru KitabinTürü { get; set; }

    }
}