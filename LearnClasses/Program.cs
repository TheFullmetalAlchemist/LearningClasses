using System;
using System.Security.Cryptography.X509Certificates;

namespace LearnClasses
{
    public class PresentationObject
    {
       public int Height{get; set;}
       public int Width{get; set;}

       public void Copy(){
            System.Console.WriteLine("object is copied");
       }
       public void Duplicate(){
        System.Console.WriteLine("object is duplicated");
       }
    }
    public class Text : PresentationObject{
        public int Fontsize{get; set;}
        public int Fontname{get; set;}

        public void Hyperlink(string URL){
            System.Console.WriteLine("URL is added" + URL);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var text= new Text();
            text.Width=100;
            text.Copy();
        }
    } 
}
