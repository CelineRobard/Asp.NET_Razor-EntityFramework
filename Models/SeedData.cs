using Microsoft.EntityFrameworkCore;
using DogRazor.Data;

namespace DogRazor.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DogRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DogRazorContext>>()))
            {
                if (context == null || context.Dog == null)
                {
                    throw new ArgumentNullException("Null DogRazorContext");
                }

                //Look for any movies.
                if (context.Dog.Any())
                    {
                        return;
                    }

                context.Dog.AddRange(
                    new Dog { Name = "Azawakh", Picture = "/img/azawakh.jpg" },
                    new Dog { Name = "Bulldog", Picture = "/img/bulldog.jpg" },
                    new Dog { Name = "Chow-Chow", Picture = "/img/chowchow.jpg" },
                    new Dog { Name = "Dogue Argentin", Picture = "/img/dogueargentin.jpg" },
                    new Dog { Name = "Eurasier", Picture = "/img/eurasier.jpg" },
                    new Dog { Name = "Fila Brasileiro", Picture = "/img/filabrasileiro.jpg" },
                    new Dog { Name = "Golden retriver", Picture = "/img/goldenretriver.jpg" },
                    new Dog { Name = "Hokkaido", Picture = "/img/hokkaido.jpg" },
                    new Dog { Name = "Irish Terrier", Picture = "/img/irishterrier.jpg" },
                    new Dog { Name = "Jack russell terrier", Picture = "/img/jackrussellterrier.jpg" },
                    new Dog { Name = "Komondor", Picture = "/img/komondor.jpg" },
                    new Dog { Name = "Léonberg", Picture = "/img/leonberg.jpg" },
                    new Dog { Name = "Malmute", Picture = "/img/malmute.jpg" },
                    new Dog { Name = "Norfolk-terrier", Picture = "/img/norfolkterrier.jpg" },
                    new Dog { Name = "Otterhound", Picture = "/img/otterhound.jpg" },
                    new Dog { Name = "Podenco d'Ibiza", Picture = "/img/podencodibiza.jpg" },
                    new Dog { Name = "Qimmiq", Picture = "/img/qimmiq.jpg" },
                    new Dog { Name = "Roltweiler", Picture = "/img/roltweiler.jpg" },
                    new Dog { Name = "Sharpei", Picture = "/img/sharpei.jpg" },
                    new Dog { Name = "Teckels", Picture = "/img/teckels.jpg" },
                    new Dog { Name = "Urugayen Cimarron", Picture = "/img/urugayencimarron.jpg" },
                    new Dog { Name = "Volpino Italien", Picture = "/img/volpinoitalien.jpg" },
                    new Dog { Name = "Welsh corgi cardigan", Picture = "/img/welshcorgicardigan.jpg" },
                    new Dog { Name = "Xoloitzcuintle", Picture = "/img/xoloitzcuintle.jpg" },
                    new Dog { Name = "Yokshire-terrier", Picture = "/img/yokshireterrier.jpg" },
                    new Dog { Name = "Zwergpinscher", Picture = "/img/zwergpinscher.jpg" }
                    );
                context.SaveChanges();
            }
        }
    }
}