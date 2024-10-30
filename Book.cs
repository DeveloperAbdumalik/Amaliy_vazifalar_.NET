using System.Security.Cryptography.X509Certificates;

namespace BOOK.Class
    {
        public class Book
        {
            private string title;
            private string author;
            private int price;


            public string Title { get; set; }
            public string Author { get; set; } 
            public int Price { get; set; }

            public int deferance {get; set;}


            public Book(string name,int narx)
            {
                Title = name;
                price = narx;

            }

              public void DisplayInfo()  
            {
                Console.WriteLine($"Kitob: {Title}, Muallif: {Author}, Narxi: {Price:C}");
            }
            
            public void DefirencePriceCalculate(int price)
            {
                if(Price>price) 
                {
                    deferance = Price-price;
                    Console.WriteLine($"Siz sotib olmoqchi bulgan kitob {deferance } ga Arzon siz ola olasiz:");
                }
                else if (Price<price) 
                {
                     deferance = price-Price;
                     Console.WriteLine($"Siz sotib olmoqchi bulgan kitob {deferance } ga qimmat:");
                }
                else deferance = (0); Console.WriteLine($"Siz sotib olmoqchi bulgan kitobni ola olasiz:");
            }

            public void DefirencePrice()
            {
                Console.WriteLine($"Siz sotib olmoqchi bulgan kitob {deferance } ga qimmat:");
            }

        }
    }