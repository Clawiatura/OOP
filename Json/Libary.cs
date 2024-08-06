using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Json
{
    internal class Libary
    {
        private const string Filepath = "C:\\DZ\\users.json";
        public List<Book> books = new List<Book>();
        
        
        public async void SerializeToJson(string filePath, List<Book> books)
        {
            
            
            using (FileStream fs = new FileStream("C:\\DZ\\users.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, books);
            }

            
            Console.WriteLine("Файл записан");

        }

        public async  void DeserializeToJson(string filePath)
        {

            using (FileStream fs = new FileStream(Filepath, FileMode.OpenOrCreate))
            {
                try
                {
                    List<Book>? Book = await JsonSerializer.DeserializeAsync<List<Book>>(fs);
                    books = Book;
                }
                catch { }
            }



        }
        public string Print()
        {
            string res = " ";
            foreach (Book us in books)
            {
                res += us.Author + " " + us.Title + " " + us.Genre + us.Year + "\n";
            };
            Console.WriteLine("считан");
            return res;
           
            
            
        }
    }
}
