
using System.Runtime.Serialization.Formatters; 
/**
double  daq;
double soat;
double min;
Console.Write("Daqiqa sonini kriteng:");
daq = Convert.ToInt64(Console.ReadLine());
soat = Math.Floor(daq/60); 
min = daq%60;
Console.WriteLine($"{soat} : {min}");
*/

/**
int yosh;
Key:
Console.Write("Yoshingizni kriteng:");
yosh = Convert.ToInt16(Console.ReadLine());
if(yosh<0)
{
    Console.WriteLine("Yosh manfiy bo'lmaydi."); goto Key;
} 
if(yosh<=12 && yosh>=0) Console.WriteLine("bola:"); 
if(yosh<=19 && yosh>=13) Console.WriteLine("o'smir:"); 
if(yosh<=59 && yosh>=20) Console.WriteLine("katta:");
if(yosh>=60)  Console.WriteLine("qari:");  
*/
/**
int fan1;
int fan2;
int fan3;
float bal;
Console.WriteLine("Uchta fandan olgan balingizni kriteng (0 dan 100 gacha):");
Console.Write("Birinchi fan  = ");
fan1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Ikkinchi fan  = ");
fan2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Uchinchi fan  = ");
fan3 = Convert.ToInt16(Console.ReadLine());
bal = (fan1+fan2+fan3)/3;
Console.WriteLine(bal);
string massaje = 
    (100<=bal)||(bal>=80)
        ? "Alo":
    (79<=bal)||(bal>=60)
        ? "Yaxshi":
    (59<=bal)||(bal>=40)
        ? "Qoniqarli"
        : "Qoniqarsiz";

Console.WriteLine(massaje);
*/


int num;
int tasodifiy;
Random rd = new Random();
tasodifiy = rd.Next(0,100);
Key:
Console.Write("1 dan 100 gacha bo'lgan tasodifiy son kiritng: ");
num = Convert.ToInt16(Console.ReadLine());
string massaje =
    num==tasodifiy
        ? "Tabriklaymiz siz tasodifiy sonni topdingiz!"
        : "Topa olmadingiz Qaytadan o'rinib ko'ring!";  
if(num!=tasodifiy)
{
    string massaje1 = 
    num>tasodifiy
        ?"Kiritgan son katta:"
        :"Kiritgan son kichkina:";
    Console.WriteLine(massaje1);
}
Console.WriteLine(massaje);
if(num!=tasodifiy)
{
    goto Key;
}



