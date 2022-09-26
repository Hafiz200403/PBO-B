using ProcessorClass;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new Predator();
   

        //Soal 1
        Console.WriteLine("Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //Soal 2
        Console.WriteLine("\nSoal 2");
        //laptop1.Ngoding();

        //Soal 3
        Console.WriteLine("\nSoal 3");
        Vga vga1 = new Nvidia();
        Processor processor1 = new CoreI5();
        Console.WriteLine("Spesifikasi laptop 1 \n" + "Merk VGA : " + vga1  + "\nMerk Processor : " + processor1.merk + "\nTipe Processor : " + processor1.tipe);

        //Soal 4
        Console.WriteLine("\nSoal 4");
        predator.BermainGame();

        //Soal 5
        Console.WriteLine("\nSoal 5");
        //ACER acer = new Predator();
        //acer.BermainGame();
    }
}
