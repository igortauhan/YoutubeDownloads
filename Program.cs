using System;
using YoutubeDownloads.Entities;

namespace YoutubeDownloads
{
    class Program
    {
        static void Main(string[] args)
        {
            String Url;

            Console.Write("Cole aqui a URL do vídeo: ");
            Url = Console.ReadLine(); 

            //instancia o objeto "d" e atribui a URL na property URL
            Download d = new Download(Url);
            d.Make();
        }
    }
}
