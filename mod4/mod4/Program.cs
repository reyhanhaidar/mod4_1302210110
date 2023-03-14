using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    internal class Program
    {

        public class Buah {
            public enum buah { Apel, aprikot, alpukat, pisang, paprika, blackberry, ceri, kelapa, jagung, kurma, durian, anggur, melon, semangka }

            public static string getKodeBuah(buah buah)
            {
                string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
                return kodebuah[(int)buah];
            }

        }

        public class posisikarakterGame{
            enum state { Terbang, Jongkok };

            public static void Main(string[] args)
            {
               
                Console.WriteLine("tombolx tombolw");

                state gerak = state.Terbang;
                String perintah = "tombolx ditekan";
                Console.WriteLine("masukan perintah :");

                perintah = Console.ReadLine();
                
                while (perintah == "tombolx ditekan" || perintah == "tombolw ditekan")
                {
                   
                    if (perintah == "tombolx ditekan")
                    {
                        gerak = state.Terbang;
                        Console.WriteLine("posisi landing");
                    }
                    else if (perintah == "tombolw ditekan"){
                        gerak = state.Jongkok;
                        Console.WriteLine("Posisi takeoff");
                    }

                } 
                
            }



        }
       


    }
}

