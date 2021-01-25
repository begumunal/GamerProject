using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
     class GamerMethods
    {
        public void Add(Gamer gamer)
        {
            NewGamer newGamer = new NewGamer();
            if (gamer.TcNo == newGamer.TcNo)
            {
                 Console.WriteLine("Üye kaydedildi.");
            }
            else
            {
                Console.WriteLine("zaten kayıtlısınız");
            }
           
        }
        public void Updete(Gamer gamer)
        {
            Console.WriteLine("bilgileriniz güncellendi.");
        }
        public void delete(Gamer gamer)
        {
            OldGamer oldGamer = new OldGamer();
            if (gamer.TcNo == oldGamer.TcNo)
            {
                  Console.WriteLine("üye kaydnınız silindi.");
            }
            else
            {
                Console.WriteLine("böyle bir üye bulunmamakta");
            }
            
        }
    }
}
