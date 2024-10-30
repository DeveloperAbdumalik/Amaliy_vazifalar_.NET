
using BOOK.Class;
Console.WriteLine("Kitob nomini kiriting");
string name = Console.ReadLine();
Console.WriteLine("Qanchaga sotib olmoqchisiz");
int narx = Convert.ToInt32(Console.ReadLine());
Book book = new Book(name, narx);

book.Author = "Malikshox";
book.Price = 236;
book.DisplayInfo();
book.DefirencePriceCalculate(narx);
book.DefirencePrice();