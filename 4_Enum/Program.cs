namespace _4_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumuratioin");
            Uye u = new Uye();
            u.KullaniciAdi = "btuser";
            u.Password = "123";
            //u.Rol = "admin";
            u.Rol = Role.Admin;
            u.Cinsiyet = Cinsiyet.Kadin;

            // bütün sayfaları görsün...
            Uye u1 = new Uye();
            u1.KullaniciAdi = "misafir";
            u1.Password = "321";
            u1.Rol = Role.Anonim;
            u1.Cinsiyet = Cinsiyet.Kadin;

            // 1. enum sabitinin değeri int olarak alınabilir
            int a = (int)Role.Admin; // 0 atanır
            int b = (int)Role.Uye; // 1 atanır
            int c = (int)Role.Anonim;


            MesajVer(u);
            MesajVer(u1);
        }
        static void MesajVer(Uye p)
        {
            // switch tab tab ile blok oluşturulur. Switch içerisine enum tipindeki üyeyi yazıldığımızda tab enter yaparsak caselere bütün sabit yazılacaktır
            switch (p.Rol)
            {
                case Role.Admin:
                    Console.WriteLine("Hoş Geldin Admin");
                    break;
                case Role.Uye:
                    Console.WriteLine("Hoş geldin üye");
                    break;
                case Role.Anonim:
                    Console.WriteLine("meraba anonim");
                    break;
                default:
                    break;
            }

            switch ((int)p.Rol)
            {
                case 1:
                    Console.WriteLine("Hoş Geldin Admin");
                    break;
                case 2:
                    Console.WriteLine("Hoş geldin üye");
                    break;
                case 3:
                    Console.WriteLine("meraba anonim");
                    break;
                default:
                    break;
            }
        }
    }
}