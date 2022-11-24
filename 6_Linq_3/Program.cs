namespace _6_Linq_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();
            users.Add(new Users() { UserName = "ayilmaz", Gender = Gender.E });
            users.Add(new Users() { UserName = "ikuroglu", Gender = Gender.E });
            users.Add(new Users() { UserName = "aaydogdu", Gender = Gender.K });
            users.Add(new Users() { UserName = "mtugan", Gender = Gender.K });
            users.Add(new Users() { UserName = "gcaliskan", Gender = Gender.E });

            List<Users> utemp = new List<Users>();
            foreach (var item in users)
                if (item.Gender == Gender.K)
                    utemp.Add(item);

            // nesnelerde kriter belirleme...
            IEnumerable<Users> kusers = (from u in users
                                         where u.Gender == Gender.K
                                         select u).ToList();

            // select ifadesi....
            // query'de select ile ne seçilirse sonuç kümesi o tipte olacaktır...

            // bütün userlari seçme
            IEnumerable<Users> allusers = (from u in users
                                           select u); // Users listesi çıkar...

            // dizinin elemanını almak için index operatörü ile List kullandık..IEnumarable [] uygulanmıyor
            List<Gender> genders = (from a in users
                                    select a.Gender).ToList();

            #region "enumu değer olarak okuma"
            // Enum olarak alalım
            Gender x = genders[0];
            int gvalue = (int)genders[0];
            #endregion

            IEnumerable<string> usernames = (from a in users
                                             select a.UserName);

            List<int> li = new List<int>() { 4, 1, 8, 4 };
            var nums = (from l in li
                        select l); // int koleksiyonu döner

            // (from a in users
            //            select a.UserName, a.Gender);
            // yerine
            // (from a in users
            //    select new { a.UserName,a.Gender });
            // eğer kümeden birden fazla alan çıkacaks select new ifadesi kullanılmalıdır. çünkü selectten sonra , ile alan ayırmak yerine new ifadesi'Nin amacı aslında kümeden çıkacak verinin tipini belirlemektir. (tip güvenliğidir)

            // select ile new ifadesini kullanarak tip belirleyebiliriz...new UserDTO ile kümeden çıkak elemanlarını tipini UserDTO olarak belirliyoruz...
            IEnumerable<UserDTO> userDTOs = (from a in users
                                             select new UserDTO
                                             {
                                                 Kadi = a.UserName,
                                                 Mail = a.Email
                                             });
            // new ifadesinde eğer tip belirlenmezse geriye anonymous type dönecektir..
            // anonim tür kullanmanın mantığı fiziki bir class oluşturmadan runtimeda oluşacak bir class oluşturmaktır. yani runtime'da oluşur. daha sonra silinir..
            // anonymous type (anonim tip) => c#'ta tipi belli olmayan türlerdir...
            // anonim tipler var ifadeleri ile kullanılır
            // anonim türler sayesinde veri okumada dto objeleri oluşuturmaktan kurtuluruz...

            var anonimUser = (from a in users
                              select new
                              {
                                  a.UserName,
                                  a.Gender
                              });

            foreach (var item in anonimUser)
            {
                Console.WriteLine($"{item.UserName}{item.Gender}");
            }


            // bir tane anonim tip tanımlayalım..
            var anonim = new
            {
                Ders = "C#",
                Kredi = 5,
                Can = false
            };

            // NOT : Anonim türler'de 
            Console.WriteLine($"{anonim.Ders} {anonim.Kredi}{anonim.Can}");
        }
    }
}