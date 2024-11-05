using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}

//Field => int x; gibi değişken direkt sınıfın içinde tanımlanır, en üstte

//Variable => metot içinde tanımlanan degişkenler

//Property => degişken get, set alıyorsa denir