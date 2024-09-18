//Basics.Tanlash bo’limi uchun 3-amaliy vazifa
/**
string str;
int n = 0;
Console.Write("So'z kiriting: = ");
str = Console.ReadLine();
int uzunlik = Convert.ToInt32(str.Length);
for(int i=0; i<uzunlik/2; i++)
{
    if(str[i] !=str[uzunlik-i-1])
    {
        n++;
    } 
}
if(n==0)Console.WriteLine("Palindrom:");
else Console.WriteLine("Palindrom emas:");
*/
/**
Console.Write("Temperaturani Selsiyusda kiriting: ");
        double selsiyus = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("1: Fahrenheit ga o'girish");
        Console.WriteLine("2: Kelvin ga o'girish");
        Console.WriteLine("3: Ikkala o'lchov birligiga o'girish");
        Console.Write("Qaysi o'lchovga o'girishni tanlaysiz: ");
        
        int tanlov = Convert.ToInt32(Console.ReadLine());
        
        switch (tanlov)
        {
            case 1:
                double fahrenheit = (selsiyus * 9 / 5) + 32;
                Console.WriteLine($"Selsiyus: {selsiyus}, Fahrenheit: {fahrenheit}");
                break;
            
            case 2:
                double kelvin = selsiyus + 273.15;
                Console.WriteLine($"Selsiyus: {selsiyus}, Kelvin: {kelvin}");
                break;
            
            case 3:
                fahrenheit = (selsiyus * 9 / 5) + 32;
                kelvin = selsiyus + 273.15;
                Console.WriteLine($"Selsiyus: {selsiyus}, Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");
                break;
            
            default:
                Console.WriteLine("Noto'g'ri tanlov. Iltimos, 1, 2 yoki 3 ni tanlang.");
                break;
        }
        */


/**
List<int> my_list = new List<int>();
int r = 0;
Console.WriteLine("5 ta son kiriting: ");
for(int i=0; i<5; i++)
{
    my_list.Add(Convert.ToInt16(Console.ReadLine()));
}
Console.WriteLine("Qanday tartibda sartirofka qilinsin:");
Console.WriteLine("Kupayish tartibida: 1");
Console.WriteLine("Kamayish tartibida: 2");
int tanlov = Convert.ToInt32(Console.ReadLine());
my_list.Sort();
switch (tanlov)
        {
            case 1:
                foreach(int value in my_list)
                Console.WriteLine(value);
                break;
            
            case 2:
                for(int i=0; i<5; i++)
                {
                    Console.WriteLine($"{my_list[4-i]}");
                }
                break;
            
            default:
                Console.WriteLine("Noto'g'ri tanlov. Iltimos, 1, yoki 2 ni tanlang.");
                break;
        }
*/


Console.Write("Matin kiriting: ");
string mt = Console.ReadLine();
char[] belgilar= mt.ToCharArray();
bool[] tashrifBelgisi = new bool[mt.Length];

        for (int i = 0; i < belgilar.Length; i++)
        {
            // Agar bu simvolni ilgari ko'rgan bo'lsak, o'tkazib yuboramiz
            if (tashrifBelgisi[i])
                continue;

            int sanash = 1;

            for (int j = i + 1; j < belgilar.Length; j++)
            {
                if (belgilar[i] == belgilar[j])
                {
                    sanash++;
                    tashrifBelgisi[j] = true;  // Ushbu belgini qayta ko'rib chiqmaslik uchun belgiliymiz
                }
            }

            // Natijalarni chiqaramiz
            Console.WriteLine($"'{belgilar[i]}': {sanash} martta");
        }

