using HtmlAgilityPack;
using System;
using System.Net;

namespace TranslatorClipboard
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Тема лох";
            var html = new HtmlDocument();
            using var wc = new WebClient();
            string htmlText = wc.DownloadString(@$"https://translate.google.com/?sl=ru&tl=en&text={ text }&op=translate");
            html.LoadHtml(htmlText);
            Console.WriteLine("Hello World!");
        }
    }
}
