using Events;

Keyboard keyboard = new Keyboard();
keyboard.KeyPressed += OnKeyPressed;
Console.WriteLine("Нажмите на одну из кнопок на клавиатуре: A,B,1");
char keyUser = char.Parse(Console.ReadLine());
if (keyUser == 'A')
{
    keyboard.PressA();
}
else if (keyUser == 'B')
{
    keyboard.PressB();
}
else if (keyUser == '1')
{
    keyboard.Press1();
}
else
{
    Console.WriteLine("Такой кнопки нет");
}
static void OnKeyPressed(char key)
{
    
    Console.WriteLine($"Клавиша '{key}' нажата.");
}
