using OnionAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Domain.Entities
{
    public class Mudurluk:BaseEntity
    {
        public int MudurlukKodu { get; set; }
        public string MudurlukAdi { get; set; }
        public int MudurlukBolgeKodu { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
    }
}
