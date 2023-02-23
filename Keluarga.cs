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
        Console.WriteLine("Nama Ayah : mujib");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 42");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 083599726401");
    }
    public override void hobi()
    {
        Console.WriteLine("hobi : menjahit");
    }
}
class Ibu : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Ibu : susi");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 40");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 086453821987");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi : ngaji");
    }
}
class Aku : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Namaku : Muhammad Wildan A");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 16");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 0895811273050");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi :  Mendengarkan Musik");
    }
} 

class Adik : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Adik : Rosa");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 14");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 082377668493");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi :  turu");
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
        Keluarga myAdik = new Adik();

        
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
        myAdik.nama();
        myAdik.noHP();
        myAdik.umur();
        myAdik.hobi();
        myKeluarga.enter();
    }
}
