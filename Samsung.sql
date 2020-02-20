USE Phones;
CREATE TABLE Samsung
(
	Id INT PRIMARY KEY IDENTITY,
	Model NVARCHAR(20) NOT NULL,
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
INSERT INTO Samsung
VALUES
('S20',6.2,'3200 x 1440','DAMOLED',8,128,'Android','10MP','64+12+12','Exynos 990','2+2+4',4000,163),
('S20 Plus',6.7,'3200 x 1440','DAMOLED',8,128,'Android','10MP','64+12+12','Exynos 990','2+2+4',4500,186),
('S20 Ultra',6.9,'3200 x 1440','DAMOLED',12,128,'Android','40MP','108+48+12','Exynos 990','2+2+4',5000,222),
('Note 10',6.3,'2280 x 1080','DAMOLED',8,256,'Android','10MP','12+12+16','Exynos 9825','2+2+4',3500,168),
('Note 10+',6.8,'3040 x 1440','DAMOLED',12,256,'Android','10MP','12+12+16','Exynos 9825','2+9+4',4300,196),
('S10',6.1,'3040 x 1440','DAMOLED',8,128,'Android','10MP','12+12+16','Exynos 9820','2+2+4',3400,157),
('S10+',6.4,'3040 x 1440','DAMOLED',8,128,'Android','10+8MP','12+12+16','Exynos 9820','2+2+4',4100,175)
