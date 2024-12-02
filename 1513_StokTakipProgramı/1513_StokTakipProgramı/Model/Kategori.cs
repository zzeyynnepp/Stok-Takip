using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _1513_StokTakipProgramı.Model
{
    
    public class Kategori
    {
        [Key]

        public int Id { get; set; }

        public string KategoriAdi { get; set; }

        // İlişki : Bir Kategorinin birden fazla ürüne sahip olabilir

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();

    }
}
