CREATE TABLE tblAdvertising(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
purchase VARCHAR(30) NOT NULL,
cost FLOAT,
type VARCHAR(30) NOT NULL,
info TEXT,
picture VARCHAR(100));

CREATE TABLE tblUser(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nickname VARCHAR(20) UNIQUE NOT NULL,
password VARCHAR(MAX) NOT NULL);

CREATE TABLE tblPerson (
user_id INT NOT NULL UNIQUE,
name VARCHAR(20) NOT NULL,
surname VARCHAR(20) NOT NULL,
phone_number INT NOT NULL,
born_date DATE NOT NULL,
address VARCHAR(50) NOT NULL,
FOREIGN KEY (user_id) REFERENCES tblUser(id));

CREATE TABLE tblSpecialQuestion (
user_id INT NOT NULL UNIQUE,
quetion TEXT NOT NULL,
answer VARCHAR(20) NOT NULL,
FOREIGN KEY (user_id) REFERENCES tblUser(id));

CREATE TABLE tblProduct(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
name VARCHAR(30) NOT NULL,
cost FLOAT NOT NULL,
type VARCHAR(30) NOT NULL,
brand VARCHAR(30) NOT NULL)

CREATE TABLE tblPurchaseHistory(
user_id INT NOT NULL,
product_id INT NOT NULL,
date DATE NOT NULL,
FOREIGN KEY (product_id) REFERENCES tblProduct(id),
FOREIGN KEY (user_id) REFERENCES tblUser(id));



INSERT INTO tblAdvertising(purchase,cost,type,info,picture) VALUES 
('Pasta',25,'macaroni','Delicious pasta dishes from classic spaghetti Bolognese to easy salmon linguine. Find the perfect pasta recipe for a midweek meal or entertaining guests.','/Pasta.jpeg'),
('Mivina',5,'macaroni','Potato powder, Palm oil, Iodized salt, Croutons (wheat flour, vegetable oil, salt, yeast), Roasted onion (onion, vegetable oil, wheat flour, salt), Flavor enhancer (E621), Mushrooms, Sugar, Mushroom flavo','/Mivina.jpeg'),
('Funta',15,'water','Bright, bubbly and popular, Fanta is the soft drink that intensifies fun. Introduced in 1940, Fanta is the second oldest brand of The Coca-Cola Company.','/Funta.jpg'),
('Sprite',16,'water','Sprite – це вибуховий, освіжаючий смак лимона і лайму та шалений драйв кожного дня! Sprite дає тобі свободу від спраги и заряджає тебе свіжістю! Цей вибухово-освіжаючий напій був вперше представлений у США в 1961 році. Сьогодні Sprite продається у більш ніж у 190 країнах світу та є одним з найпопулярніших газованих напоїв. ','/Sprite.jpg'),
('Roshen',30,'sweet','«Роше́н» (Roshen) — украинская кондитерская корпорация, один из крупнейших производителей кондитерских изделий Украины и Восточной Европы, входит в тридцатку крупнейших производителей кондитерских изделий мира. Главный офис компании расположен в Киеве. Продукция представлена в более чем 30 странах мира, включая Казахстан, Республику Беларусь, страны Кавказа, Средней Азии, ЕС, США, Молдавию, Китай, Израиль, Латвию, Литву, Иорданию, Японию.','/Roshen.jpg'),
('Svitoch',30,'sweet','Iсторія «Світоч» розпочалась ще у далекому 1882 році у Львові, який свого часу називали шоколадною столицею Європи. У 1998 році фабрика «Світоч» увійшла до складу компанії Nestle S.A., таке співробітництво надало «Світочу» нові можливості. Сьогодні «Світоч» - сучасне високотехнологічне, науково містке підприємство, що динамічно розвивається. У 2010 році насамперед за рахунок інноваційних рішень був розширений асортимент кондитерських виробів, представлених торговельними марками Nestlé та «Світоч». Кондитерський бізнес Nestlé в Україні став найбільш зростаючим кондитерським бізнесом Nestlé в країнах Європи, продемонструвавши зростання у 33% в порівнянні з 2009 роком.','/Swetoch.jpg');

INSERT INTO tblUser(nickname,password) VALUES 
('kunorom','dd26ea8b2bc48d1b4038b99e4fdf612a'),
('ivan228','2c42e5cf1cdbafea04ed267018ef1511'),
('dima7','0f5b25cd58319cde0e6e33715b66db4c');

INSERT INTO tblPerson(name,surname,phone_number,born_date,address,user_id) VALUES 
('Roman','Kunovskyi',0987241896,'2000-2-5','I Frunka 4',1),
('Ivan','Vynavskyi',0984354365,'2000-2-12','S Mazepy 7',2),
('Dmitro','Levkovich',0678903534,'2000-11-20','Sholom 3',3);

INSERT INTO tblSpecialQuestion(quetion,answer,user_id) VALUES 
('Where are you study?','LNU',1),
('Who are you?','Dodeck',2),
('What is your favorite song?','Umorist',3);

INSERT INTO tblProduct(name,cost,type,brand) VALUES 
('Pasta',2.5,'macaroni','Boroshno'),
('Mivina',0.5,'macaroni','Mivina'),
('Sprite',3,'water','Coca-Cola'),
('Fanta',3.1,'water','Coca-Cola'),
('Coca-Cola',2.9,'water','Coca-Cola'),
('Chokolate',4.5,'sweet','Roshen'),
('Chokolate',4,'sweet','Svitoch');


INSERT INTO tblPurchaseHistory(date,user_id,product_id) VALUES 
('2010-2-5',2,7),
('2010-4-4',2,4),
('2010-5-5',2,6),
('2010-6-7',2,5),
('2010-8-9',3,2),
('2012-3-10',3,1),
('2012-12-15',3,1),
('2012-2-5',1,5),
('2014-4-4',3,2),
('2015-2-2',2,3),
('2016-5-6',1,4),
('2017-1-1',1,7),
('2018-1-2',1,6);