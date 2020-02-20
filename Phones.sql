USE PhoneSpecs;
CREATE TABLE Phones
(
	Id INT PRIMARY KEY IDENTITY,
	ModelID INT NOT NULL,
	Brand NVARCHAR(15) NOT NULL,
	Model NVARCHAR(25) NOT NULL,
	ScreenSize FLOAT NOT NULL,
	ScreenRes NVARCHAR (15) NOT NULL,
	ScreenType NVARCHAR (15) NOT NULL,
	RAM INT NOT NULL,
	ROM INT NOT NULL,
	OS NVARCHAR (10) NOT NULL,
	FrontCamera NVARCHAR (10) NOT NULL,
	Camera NVARCHAR (10) NOT NULL,
	Processor NVARCHAR (15) NOT NULL,
	Cores NVARCHAR (10) NOT NULL,
	Battery INT NOT NULL,
	Weight INT NOT NULL
);
INSERT INTO Phones VALUES
(1,'Apple','IPhone 11',6.2,'1792 x 828','IPS',4,128,'IOS','12MP','12+12','A13','2+4',3046,194),
(1,'Apple','IPhone 11 Pro',5.8,'2436 x 1125','OLED',4,128,'IOS','12MP','12+12+12','A13','2+4',3190,188),
(1,'Apple','IPhone 11 Pro MAX',6.5,'2436 x 1125','OLED',3,256,'IOS','12MP','12+12+12','A13','2+4',3969,226),
(1,'Apple','IPhone X',5.8,'2436 x 1125','OLED',3,64,'IOS','7MP','12+12','A11','6',2716,176),
(1,'Apple','IPhone XS',5.8,'2436 x 1125','OLED',4,64,'IOS','7MP','12+12','A12','6',2568,177),
(1,'Apple','IPhone XR',6.1,'1792 x 828','IPS',3,64,'IOS','7MP','12','A12','6',2942,194),
(2,'Samsung','S20',6.2,'3200 x 1440','DAMOLED',8,128,'Android','10MP','64+12+12','Exynos 990','2+2+4',4000,163),
(2,'Samsung','S20 Plus',6.7,'3200 x 1440','DAMOLED',8,128,'Android','10MP','64+12+12','Exynos 990','2+2+4',4500,186),
(2,'Samsung','S20 Ultra',6.9,'3200 x 1440','DAMOLED',12,128,'Android','40MP','108+48+12','Exynos 990','2+2+4',5000,222),
(2,'Samsung','Note 10',6.3,'2280 x 1080','DAMOLED',8,256,'Android','10MP','12+12+16','Exynos 9825','2+2+4',3500,168),
(2,'Samsung','Note 10+',6.8,'3040 x 1440','DAMOLED',12,256,'Android','10MP','12+12+16','Exynos 9825','2+9+4',4300,196),
(2,'Samsung','S10',6.1,'3040 x 1440','DAMOLED',8,128,'Android','10MP','12+12+16','Exynos 9820','2+2+4',3400,157),
(2,'Samsung','S10+',6.4,'3040 x 1440','DAMOLED',8,128,'Android','10+8MP','12+12+16','Exynos 9820','2+2+4',4100,175)