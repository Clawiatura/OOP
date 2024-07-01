using AutoBase;
Reis reis = new Reis { reis = "Севастополь - Москва" };
Car car = new Car { NameCar = "Mersedes", techCar = 100 };
Voditel voditel = new Voditel { name = "Иван", ageVoditel = 75 };

Dispetcher isp = new Dispetcher();
isp.distribute(voditel.name,car.NameCar,reis.reis );
isp.otstranit(voditel.name, voditel.ageVoditel);
voditel.RepairCar();
voditel.reisVupolnen();