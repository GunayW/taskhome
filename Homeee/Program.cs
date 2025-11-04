using Task9;

Item silah1=new ("AKM","Weapon",800,true);
Item silah2=new ("M416","Weapon",900,true);
Item silah3=new ("M24","Weapon",1200,false);
Item silah4=new ("AVM","Weapon",1300,false);

GameStats.RegisterItem(silah1);
GameStats.RegisterItem(silah2);
GameStats.RegisterItem(silah3);
GameStats.RegisterItem(silah4);


object obj = silah2;
Inventory playerinventory = new Inventory();
playerinventory[0] = silah3;
playerinventory[0].Use();
Item silah5 = (Item)obj;
IUsable silah6 = silah4;
silah6.Use();
ITradable silah7 = silah3;
silah7.Trade();