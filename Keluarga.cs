class Keluarga


{

    public virtual void nama()
    {
        Console.WriteLine("nama");
    }
    public virtual void umur()
    {
        Console.WriteLine("umur");
    }

    public virtual void noHP()
    {
        Console.WriteLine("no HP");
    }

    public virtual void hobi()
    {
        Console.WriteLine("hobi");
    }

    public void enter()
    {
        Console.WriteLine("");
    }

}

class Ayah : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Ayah : Agus");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 50");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 083287446723");
    }
    public override void hobi()
    {
        Console.WriteLine("hobi : ngegame");
    }
}

class Ibu : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Ibu : Yuli");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 40");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 083298420723");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi : Mabar");
    }
}

class Aku : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Namaku : Markus");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 16");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 089482174609");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi : Belajar");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Keluarga myKeluarga = new Keluarga();
        Keluarga myAyah = new Ayah();
        Keluarga myIbu = new Ibu();
        Keluarga myAku = new Aku();

        myKeluarga.nama();
        myAyah.nama();
        myAyah.umur();
        myAyah.noHP();
        myAyah.hobi();
        myKeluarga.enter();
        myIbu.nama();
        myIbu.noHP();
        myIbu.umur();
        myIbu.hobi();
        myKeluarga.enter();
        myAku.nama();
        myAku.noHP();
        myAku.umur();
        myAku.hobi();
        myKeluarga.enter();

    }
}
