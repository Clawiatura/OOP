using System.Collections.Generic;

//Массивы(Arrays): Создадим массив целых чисел от -10 до 10:

int[] numbers = { -10, -5, 0, 5, 10 };


//Списки(List): Инициализируем список строк с именами:

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };


//Стек(Stack): Создадим стек целых чисел и добавим элементы:

Stack<int> stack = new Stack<int>();

stack.Push(1); stack.Push(2); stack.Push(3);


//Операции со стеком: Извлечение элемента

int top = stack.Pop(); 


//Очередь(Queue): Создадим очередь строк:

Queue<string> queue = new Queue<string>();

queue.Enqueue("First"); queue.Enqueue("Second");


//Словари(Dictionary): 

Dictionary<string, int> wordLengths = new Dictionary<string, int> { { "apple", 5 }, { "banana", 6 } };


//Множества(HashSet): 

HashSet<int> uniqueNumbers = new HashSet<int>();

uniqueNumbers.Add(1); uniqueNumbers.Add(2);


//Коллекции KeyValuePair: 

List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();

people.Add(new KeyValuePair<string, int>("Alice", 30));