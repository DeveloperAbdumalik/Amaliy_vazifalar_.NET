/**
Vazifa menejeri:
Vazifalarni boshqarish uchun dastur yozing. Foydalanuvchi vazifalarni qo'shishi, o'chirishi va bajarilganligini 
belgilashi kerak. Dastur vazifalar ro'yxatini va ularning holatini saqlashi kerak.
 For loop, While loop yoki Forech-dan foydalaning, va Array yoki List-dan foydalaning.

 ikki
*/

List<string> vazifalar = new List<string>();   // Vazifalar ro'yxati
        List<bool> bajarilganVazifalar = new List<bool>(); // Vazifalarning bajarilgan yoki bajarilmagan holatini saqlash uchun ro'yxat

        bool davomEttirish = true;

        while (davomEttirish)
        {
            // Asosiy menyu
            Console.WriteLine("\nVazifa menejeri:");
            Console.WriteLine("1: Vazifa qo'shish");
            Console.WriteLine("2: Vazifani o'chirish");
            Console.WriteLine("3: Vazifani bajarilgan deb belgilash");
            Console.WriteLine("4: Barcha vazifalarni ko'rish");
            Console.WriteLine("5: Chiqish");
            Console.Write("Tanlovingiz: ");
            
            // Foydalanuvchi tanlovi
            int tanlov = Convert.ToInt32(Console.ReadLine());

            switch (tanlov)
            {
                case 1: // Vazifa qo'shish
                    Console.Write("Yangi vazifani kiriting: ");
                    string yangiVazifa = Console.ReadLine();
                    vazifalar.Add(yangiVazifa);         // Vazifani qo'shish
                    bajarilganVazifalar.Add(false);     // Bajarilmagan holatda qo'shamiz
                    Console.WriteLine("Vazifa qo'shildi.");
                    break;

                case 2: // Vazifani o'chirish
                    Console.WriteLine("O'chirilishi kerak bo'lgan vazifani raqamini kiriting:");
                    for (int i = 0; i < vazifalar.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {vazifalar[i]} - {(bajarilganVazifalar[i] ? "Bajarilgan" : "Bajarilmagan")}");
                    }

                    int uchirishRaqami = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (uchirishRaqami >= 0 && uchirishRaqami < vazifalar.Count)
                    {
                        vazifalar.RemoveAt(uchirishRaqami);
                        bajarilganVazifalar.RemoveAt(uchirishRaqami);
                        Console.WriteLine("Vazifa o'chirildi.");
                    }
                    else
                    {
                        Console.WriteLine("Noto'g'ri raqam.");
                    }
                    break;

                case 3: // Vazifani bajarilgan deb belgilash
                    Console.WriteLine("Bajarilgan deb belgilanishi kerak bo'lgan vazifani raqamini kiriting:");
                    for (int i = 0; i < vazifalar.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {vazifalar[i]} - {(bajarilganVazifalar[i] ? "Bajarilgan" : "Bajarilmagan")}");
                    }

                    int bajarilganRaqam = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (bajarilganRaqam >= 0 && bajarilganRaqam < vazifalar.Count)
                    {
                        bajarilganVazifalar[bajarilganRaqam] = true;
                        Console.WriteLine("Vazifa bajarilgan deb belgilandi.");
                    }
                    else
                    {
                        Console.WriteLine("Noto'g'ri raqam.");
                    }
                    break;

                case 4: // Barcha vazifalarni ko'rish
                    if (vazifalar.Count == 0)
                    {
                        Console.WriteLine("Vazifalar mavjud emas.");
                    }
                    else
                    {
                        Console.WriteLine("Vazifalar ro'yxati:");
                        for (int i = 0; i < vazifalar.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {vazifalar[i]} - {(bajarilganVazifalar[i] ? "Bajarilgan" : "Bajarilmagan")}");
                        }
                    }
                    break;

                case 5: // Dasturdan chiqish
                    davomEttirish = false;
                    Console.WriteLine("Dasturdan chiqildi.");
                    break;

                default: // Noto'g'ri tanlov
                    Console.WriteLine("Noto'g'ri tanlov. Iltimos, 1 dan 5 gacha raqam kiriting.");
                    break;
            }
        }