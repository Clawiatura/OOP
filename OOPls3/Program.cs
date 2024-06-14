//using OOPls3;

//mass mas = new mass(10);
//mas.Fill();
//mas.Prin();

//mas.Mix();
//mas.Prin();

//Console.WriteLine(mas.Diff());

using OOPls3;

Library mylib = new Library();

mylib.AddBook(new Book("Книга 2", "Пушкин", 1232));
mylib.AddBook(new Book("Книга 1", "Гоголь", 1444));
mylib.AddBook(new Book("Книга 3", "Моголь", 1132));
mylib.Print();


mylib.RemoveBook(new Book("Книга 1", "Гоголь", 1444));
mylib.Print();

mylib.SearchAuthor("Пушкин");
mylib.Print();

mylib.Sort();
mylib.Print();


