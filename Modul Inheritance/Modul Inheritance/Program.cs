using ProcessorClass;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new Predator();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();
        laptop2.vga = new AMD();
        laptop2.processor = new Ryzen();
        predator.vga = new AMD();
        predator.processor = new CoreI7();



        //Soal 1
        Console.WriteLine("Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //Soal 2
        Console.WriteLine("\nSoal 2");
        //laptop1.Ngoding();

        //Soal 3
        Console.WriteLine("\nSoal 3");
        Console.WriteLine("Spesifikasi laptop 1 \n" + "Merk VGA : " + laptop1.vga  + "\nMerk Processor : " + laptop1.processor.merk + "\nTipe Processor : " + laptop1.processor.tipe);

        //Soal 4
        Console.WriteLine("\nSoal 4");
        predator.BermainGame();

        //Soal 5
        Console.WriteLine("\nSoal 5");
        //ACER acer = new Predator();
        //acer.BermainGame();
    }
}
