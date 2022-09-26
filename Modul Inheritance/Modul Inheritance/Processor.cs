class Processor
{
    public string merk;
    public string tipe;
}

namespace ProcessorClass
{
    class Intel : Processor
    {
        public Intel() 
        {
            merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7() 
        {
            tipe = "Core i7";
        }
    }

    class AMD : Processor
    {
        public AMD() 
        {
            merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RAYZEN";
        }
    }

    class Athlon : AMD
    {
        public Athlon() 
        {
            tipe = "ATHLON";
        }
    }
}
