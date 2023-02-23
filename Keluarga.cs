using System;

public class HelloWorld
{
    static public void Main()
    {
        familyhobi ak = new familyhobi();
        familyhobi ayah = new Ayah();
        familyhobi ibu = new Ibu();
        familyhobi anak = new Anak();
        familyhobi adik = new Adik();

        familydata ayahku = new familydata("Abdur Rosyid", 43, 0895614756845);
        familydata ibuku = new familydata("Asmaul Hasina", 41, 0895632344188);
        familydata aku = new familydata("Muhammad Wildan A", 16, +6283347678998);
        familydata adikku = new familydata("Ayana shaa", 3, 0);

        Console.WriteLine("data ayah:\n" + ayahku.nama + "\n" + ayahku.umur + "\n" + ayahku.nohp);
        ayah.Hobi();
        Console.WriteLine("data ibu:\n" + ibuku.nama + "\n" + ibuku.umur + "\n" + ibuku.nohp);
        ibu.Hobi();
        Console.WriteLine("data anak:\n" + aku.nama + "\n" + aku.umur + "\n" + aku.nohp);
        anak.Hobi();
        Console.WriteLine("data anak:\n" + adikku.nama + "\n" + adikku.umur + "\n" + adikku.nohp);
        adik.Hobi();



    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;

        public familydata(string Nama, int Umur, long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }



    }
    class familyhobi
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Menonton TV");
        }
    }
    class Ibu : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Mengaji");
        }
    }
    class Anak : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Menonton film");
        }
    }
    class Adik : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Menonton Anime");
        }
    }


}
