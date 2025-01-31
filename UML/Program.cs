﻿Architector stroitel = new Architector();
Builder carpenters = new Builder();
Electric whistleblower = new Electric();

stroitel.SetNextWorker(carpenters).SetNextWorker(whistleblower);
GiveCommand(stroitel, "Составить план здания");
GiveCommand(stroitel, "Установка дверей");
GiveCommand(stroitel, "Монтаж электропроводки");
GiveCommand(stroitel, "Облицовка стен");



void GiveCommand(IWorker worker, string command)
{
    string str = worker.Execute(command);
    if (str == "")
    {
        Console.WriteLine("Работа прервана");
        Environment.Exit(1);
    }
    else Console.WriteLine(str);
}

interface IWorker
{
    IWorker SetNextWorker(IWorker worker);
    string Execute(string command);
}
abstract class AbsWorker : IWorker
{
    private IWorker _nextWorker;
    public AbsWorker() => _nextWorker = null;

    public virtual string Execute(string command)
    {
        if (_nextWorker != null) return _nextWorker.Execute(command);
        return string.Empty;
    }
    public IWorker SetNextWorker(IWorker worker)
    {
        _nextWorker = worker;
        return worker;
    }
}
class Architector : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "Спроектируй дизайн") return "проектирую дизайн";
        else if (command == "Составить план здания") return "Составляю план здания";
        return base.Execute(command);
    }
}
class Builder : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "Залить фундамент") return "Заливаю фундамент";
        else if (command == "Возвести стены") return "Возвожу стены";
        else if (command == "Уложить кровлю") return "Укладываю кровлю";
        return base.Execute(command);
    }
}
class Electric : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "Монтаж электропроводки")
            return "Выполняю монтаж электропроводки";
        else if (command == "Монтаж электрооборудования")
            return "Выполняю монтаж электрооборудования";
        else if (command == "Монтаж розеток")
            return "Выполняю монтаж розеток";
        else if (command == "Монтаж осветительных приборов")
            return "Выполняю монтаж осветительных приборов";
        return base.Execute(command);
    }
}
class Otdelochnik : AbsWorker
{
    public override string Execute(string command)
    {
        if (command == "Заливка полов")
            return "Выполняю заливку полов";
        else if (command == "Облицовка стен")
            return "Выполняю облицовку стен";
        else if (command == "Покраска")
            return "Выполняю покраску";
        else if (command == "Поклейка обоев")
            return "Клею обои";
        else if (command == "Установка дверей")
            return "Устанавливаю двери";

        return base.Execute(command);
    }
}