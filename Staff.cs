using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class Staff
    {
        private long ID;
        private string Name;
        private string Surname;
        private int Salary;
        private int Exp;    // Deneyim
        private int City;   // Yaşadığı şehir  
        private int Akademik;
        private int Dil;
        private int Yoneticilik;



        /*
         * Belgeli ing bilgisi                          0.20
         * İngilizce eğitim veren okul mezunu           0.20
         * Belgeli diğer yabancı dil ( her dil için )   0.05
         */
        
        /*
         * Mesleki Y.Lisans         0.10    Value: 1
         * Mesleki Doktora          0.30    Value: 2
         * Mesleki Doçentlik        0.35    Value: 3
         * Herhangi Y.Lisans        0.05    Value: 4
         * Herhangi Doktora/Doc     0.15    Value: 5
         * 
         */
        
        
        
         
        /* 10:İstanbul                                      0.15
         * 51:Ankara                                        0.10
         * 31:İzmir                                         0.10
         * 42:Kocaeli,Sakarya,Düzce,Bolu,Yalova             0.05
         * 21:Edirne,Kırklareli,Tekirdağ                    0.05
         * 90:Trabzon,Ordu,Giresun,Rize,Artvin,Gümüşhane    0.03
         * 41:Bursa,Eskişehir,Bilecik                       0.03
         * 32:Aydın,Denizli,Muğla                           0.03
         * 62:Adana,Mersin                                  0.03
         * 22:Balıkesir,Çanakkale                           0.03
         * 61:Antalya,Isparta,Burdur                        0.03
          */
    }
}
