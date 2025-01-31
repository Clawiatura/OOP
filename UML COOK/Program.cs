using System.IO;

Officiant officiant = new Officiant();
Cook cook = new Cook();

officiant.ExucuteWork("Заказ на пасту");




interface IMediator
{
    void Notify(Employee employee, string msg);
}
abstract class Employee
{
    protected IMediator Mediator;
    public Employee(IMediator mediator) => Mediator = mediator;
    public void SetMediator(IMediator mediator) => Mediator = mediator;
}
class Officiant : Employee
{
    public Officiant(IMediator mediator = null!) : base(mediator) { }
    public void ExucuteWork(string work)
    {
        Console.WriteLine("Официант передал кассиру:" + work);
        //Mediator.Notify(this, work);
    }
    public void SetWork(bool state)
    {
        if (state) Console.WriteLine("Официант занят");
        else Console.WriteLine("Официант свободен");
    }
}
class Cook : Employee
{
    private string text;
    public Cook(IMediator mediator = null!) : base(mediator) { }
    public void GiveCommand(string _text)
    {
        text = _text;
        if (text == "") Console.WriteLine("Заказа нет");
        else Console.WriteLine("Нужно заказать:" + text);
        Mediator.Notify(this, text);
    }
}

class Deployment : Employee
{
    public Deployment(IMediator mediator) : base(mediator)
    {

    }
    public void Explorer(string _text)
    {
        if (_text == "") Console.WriteLine("Заказа нет");
        else Console.WriteLine("Нужно привести:" + _text);
    }
}
class Cashier : Employee
{


    public Cashier(IMediator mediator) : base(mediator) { }



    public void Process(string order)
    {
        if (string.IsNullOrEmpty(order))
        {
            Console.WriteLine("Ошибка: пустой заказ.");
            return;
        }

        Console.WriteLine("Кассир обработал заказ: " + order);
        Mediator.Notify(this, $"Заказ принят: {order}");
    }

}

