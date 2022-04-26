using BilgeAdam.MVCStyla.Helpers;
using BilgeAdam.MVCStyla.Models;
using System.ComponentModel;
using System.Threading.Tasks;
using System;

namespace BilgeAdam.MVCStyla.Managers
{
    public class ReceiptManager
    {
        public List<ReceiptViewModel> GetReceipts()
        {
            var r1 = new ReceiptBuilder().CreateReceipt("Tavuk Lolipop", 1)
                                         .WithTariff(@"Bagetlerimizi kıkırdak kısmından bıçakla temizliyoruz, kemik dışarda olacak şekilde, sosu için malzemeleri karıştırma kabına koyup, karıştırıyoruz.
                                                       Bagetleri içine koyup, güzelce karıştırıp, 1 saate yakın buzdolabında dinlendiriyoruz.
                                                       Dinlenen bagetlerin kemik kısmına alufolie ile kapatıp, fırın tepsisine dik olacak şekilde yerleştiriyoruz(Benim tavuk için ayrı bir tepsim vardı) isteğe göre yanına patates havuç gibi sebzeler koyabilirsiniz.
                                                       200 derece fırında kontrollü şekilde pişiyoruz, görüntüsü ve lezzeti ile acı tatlı çok lezzetli bir lolipop ☺️🤗şimdiden afiyet olsun")
                                         .WithImageCode(1)
                                         .AddItem("1 çay bardağı zeytinyağ")
                                         .AddItem("3 yemek kaşığı soya sosu")
                                         .AddItem("2 yemek kaşığı barbekü sos")
                                         .AddItem("1 tatlı kaşığı toz kırmızı biber")
                                         .AddItem("Karabiber")
                                         .Build();

            var r2 = new ReceiptBuilder().CreateReceipt("Sıvı Yağlı Şekerpare Tarifi", 2)
                                         .WithTariff(@"Öncelikle tatlımızın şerbetini hazırlayalım. Bunun için uygun bir tencereye su ve  toz şekeri alarak kaynamaya bırakalım.
                                                       Yaklaşık 10 dakika kadar kaynadıktan sonra limon suyunu ekleyelim ve 5 dakika daha kaynatarak şerbeti soğumaya bırakalım.
                                                       Hamuru için yoğurma kabına ayçiçek yağı, vanilya ve yumurtayı alarak çırpalım.
                                                       Ardından üzene  pudra şekerini ilave ederek karıştırmaya devam edelim.")
                                         .WithImageCode(2)
                                         .AddItem("1 su bardağı Ayçiçek Yağı")
                                         .AddItem("1 su bardağı irmik")
                                         .AddItem("3 adet yumurta")
                                         .Build();

            var r3 = new ReceiptBuilder().CreateReceipt("Kakaolu İrmik Tatlısı", 3)
                                         .WithTariff(@"Öncelikle tatlımızın şerbetini hazırlayalım. Bunun için uygun bir tencereye su ve  toz şekeri alarak kaynamaya bırakalım.
                                                       Yaklaşık 10 dakika kadar kaynadıktan sonra limon suyunu ekleyelim ve 5 dakika daha kaynatarak şerbeti soğumaya bırakalım.
                                                       Hamuru için yoğurma kabına ayçiçek yağı, vanilya ve yumurtayı alarak çırpalım.
                                                       Ardından üzene  pudra şekerini ilave ederek karıştırmaya devam edelim.")
                                         .WithImageCode(3)
                                         .AddItem("125 gram margarin")
                                         .AddItem("Yarım çay bardağı sıvı yağ")
                                         .AddItem("1 adet yumurta")
                                         .AddItem("3 yemek kaşığı pudra şekeri")
                                         .AddItem("2 dolu yemek kaşığı kakao")
                                         .Build();

            return new List<ReceiptViewModel> 
            { 
                r1,
                r2,
                r3
            };
        }
    }
}
