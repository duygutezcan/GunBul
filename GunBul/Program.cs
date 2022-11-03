// See https://aka.ms/new-console-template for more information
Basla();

void Basla()

{
    Console.Clear();
    Console.WriteLine("Kaçıncı Gündeyiz");
    int gun = Convert.ToInt32(Console.ReadLine());
    if (gun == 1)
    {
        Console.WriteLine("Bugün Pazartesi");
    }
    else if (gun == 2)
    {
        Console.WriteLine("Bugün Salı");
    }
    else if (gun == 3)
    {
        Console.WriteLine("Bugün Çarşamba");
    }
    else if (gun == 4)
    {
        Console.WriteLine("Bugün Perşembe");
    }
    else if (gun == 5)
    {
        Console.WriteLine("Bugün Cuma");
    }
    else if (gun == 6)
    {
        Console.WriteLine("Bugün Cumartesi");
    }
    else if (gun == 7)
    {
        Console.WriteLine("Bugün Pazar");
    }
    else
    {
        Console.WriteLine("Yanlış Gün Girdiniz");
    }
    Console.WriteLine("Devam için enter a basın");
    Console.ReadLine();
    Basla();
   
}
