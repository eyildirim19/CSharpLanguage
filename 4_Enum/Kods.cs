using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Enum
{
    // ENumlarda sabitlerimiz otomatik numaralandırılır..
    public enum Role
    {
        Admin,
        Uye,
        Anonim // son değer
    }
    // istersek değerleri değiştirebiliriz...
    public enum Cinsiyet
    {
        Kadin = 1,
        Erkek = 3 // son değer
    }
    public class Uye
    {
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        //  public string Rol { get; set; }
        public Role Rol { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
    }
}