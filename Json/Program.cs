using Json;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;
Libary libary = new Libary();


List<Book> books = new List<Book>
        {
            new Book("zxc", "pussa", "asdsa", 1949),
            new Book("asdasda", "qwe", "asd", 1960),
            new Book("xzxz", "Jpaa", "Raas", 1813)
        };

libary.SerializeToJson("\"C:\\\\DZ\\\\users.json\"", books);










libary.DeserializeToJson("C:\\DZ\\users.json");
Console.WriteLine(libary.Print());
//Вроде как все работает, но считывает файл через раз( не всегда в консолье его видно, иногда даже 1 раз из 5 может считать) не могу понять в чем ошибка)
