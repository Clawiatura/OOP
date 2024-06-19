using OOPls7.Germany;
using OOPls7.Russia;
using OOPls7.UK;
Moscow moscow = new Moscow(12341);
Sevastopol sevastopol = new Sevastopol(412221);
Kalinighrad kalinin = new Kalinighrad(123214);
if(moscow.number > sevastopol.number)
{
    Console.WriteLine("Население Москвы больше чем население Севастополя");
}
if(moscow.number < sevastopol.number)
{
    Console.WriteLine("Население Севастополя больше чем население Москвы");
}

