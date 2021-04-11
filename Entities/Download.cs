using System;
using VideoLibrary;
using System.IO;

namespace YoutubeDownloads.Entities
{
    public class Download
    {
        
        private string _path = @"C:\Youtubedownloads\";
        public string Url { get; set; }

        public Download(string url)
        {
            Url = url;
        }

        public void Make()
        {
            try
            {
                //Chama o metodo para criacao de diretorios
                CreateDir();

                var Youtube = YouTube.Default;
                var video = Youtube.GetVideo(Url);
                File.WriteAllBytes(_path + video.FullName, video.GetBytes());
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.ToString());
            }
        }

        //Metodo para criar a pasta para salvar os videos
        public void CreateDir()
        {
            //Se a pasta já existir (rodando o programa pela segunda vez) ele ignora o metodo para nao sobrescreve-la, se nao ele cria a pasta para salvar os videos
            if (Directory.Exists(_path))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(_path);
            }
        }
    }
}