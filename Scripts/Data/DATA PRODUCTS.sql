


INSERT INTO PRODUCT ([NAME], [PRICE], [EXTRA_PRICE], [EXTRA_PRICE_ACTIVE], [DESCRIPTION], [PARENT_CATEGORY_ID])
VALUES
	/* 3.5" H�rddiskar, 1231*/
		('Western Digital 3TB drive',899, 839, 1,'Western Digital 3TB NAS drive',1231),
		('Seagate Baracuda 2TB drive',799, 759, 0,'Seagate Baracuda 2TB drive 7200rpm fast hard drive',1231),
		('Maxtor 320 GB hard disk',899, 839, 0,'Old but reliable hard drive',1231),

	/* 2.5" H�rddiskar 1232*/
		('Seagate BaraCuda 1TB drive',699, 0, 0,'Seagate BaraCuda 1TB drive, perfect to increase your storage',1232),
		('Seagate Firecuda 1TB hybrid drive',779, 759, 1,'Seagate Firecuda 1TB drive with 32GB SSD cache to increase the performance.',1232),

	/* 2.5 SSD 4561 */
		('Samsung 850 Evo 1TB',1200, 839, 0,'Reliable SSD from Samsung, this disk have a 150 TBW and 5 year warranty',4561),
		('Kingston A400 120GB',349, 249, 1,'Kingstons stabila A400-enhet f�rb�ttrar dramatiskt upplevelsen av ditt befintliga system med otroliga start-, laddnings- och �verf�ringstider j�mf�rt med mekaniska h�rddiskar.',4561),
		('Kingston KC600 512GB',1049, 839, 0,'KC600 �r utrustad med den senaste 3D TLC NAND-teknologin samtidigt som den har st�d f�r en fullst�ndig s�kerhetssvit med AES maskinvarubaserade 256-bitars kryptering, TCG Opal och eDrive.',4561),
		('Crucial BX500 120GB',349, 0, 0,'V�sentlig prestanda',4561),
	

	/* M.2 SSD 4562*/
		('Intel 660p 1TB',1490, 839, 0,'Snabb och prisv�rd SSD med QLC-teknik',4561),
		('Intel 665p 2TB',3490, 839, 0,'Hastighet och prestanda till ett bra pris med senaste generationens QLC teknik.',4562),
		('Synology SNV3500 400GB',2249, 839, 0,'Synology SNV3000 serien �r den perfekta cache-disken till din server f�r att snabba upp applicationer och accesstider.',4562),
		
	/* Sk�rmar 24" 7891*/
		('ASUS 24" VG248QE 144 Hz',2590, 2390, 1,'En av Sveriges absolut popul�raste gamingsk�rmar. Den �r mycket ljusstark med en ljusstyrka p� hela 350 cd/m� och har 144 Hz uppdateringsfrekvens.',7891),
		('Acer 24" Nitro XV240YP IPS 165 Hz',2590, 839, 0,'XV240YP �r en FreeSync-kompatibel spelsk�rm med 165 Hz uppdateringhastighet via DisplayPort.',7891),

	/* Sk�rmar 27" 7892*/
		('LG 27'' UltraGear 27GN750 IPS 240 Hz',4999, 839, 0,'- 27� FHD (1920 x 1080) IPS- 1 ms responstid- G-Sync Compatible- 240 Hz uppdateringsfrekvens- HDR10 och 99 % sRGB- 3-sidig n�stintill raml�s design',7892),
		('ASUS 27" TUF Gaming VG279Q1R IPS 144 Hz',2990, 839, 0,'Snabb och prisv�rd SSD med QLC-teknik',7892),
		('Dell 27" UltraSharp U2720Q 4K USB-C',7990, 839, 0,'Naturlig f�rg�tergivning p� denna fantastiska 27-tums 4K-sk�rm som har den bredaste f�rgt�ckningen i sin klass. F� bred f�rgt�ckning med 95 % DCI-P3 � som t�cker ungef�r 25 % mer f�rgomf�ng �n sRGB � f�r verklig f�rg�tergivning. ',7892),

	/* Sk�rmar 32" 7893*/
		('HP 34" E344C VA Curved 21:9',6990, 839, 0,'Visa allt inneh�ll p� en och samma g�ng p� denna 34 tums v�lvda bildsk�rm med WQHD-uppl�sning och ett 21:9-bildf�rh�llande � samma sk�rmutrymme som hos flera bildsk�rmar utan en kant som kommer i v�gen.',7893),
		('BenQ 32'' PD3220U IPS 4K',13990, 839, 0,'F�r att tillfredsst�lla en designers behov av korrekt f�rgprestanda och samtidigt m�jligg�ra f�rb�ttrad �vergripande produktivitet levereras PD3220U med ett uppgraderat f�rgomf�ng som �r kompatibelt med DCI-P3 och Display P3 samt Thunderbolt 3-anslutning f�r en mer effektiv bild- och data�verf�ringsflexibilitet. Har �ven hela 85W Power Delivery.',7893),

	/* Tangentbord Gaming 8911*/
		('Ducky One 2 TKL Horizon MX Brown PBT Double-shot',1290, 839, 0,'TKL tangentbord med PBT plast och USB-C anslutning i tangentbordet',8911),
		('Ducky One 2 Mini (2020) MX Red RGB',1389, 839, 0,'Ducky One 2 Mini blev precis lite b�ttre. 2020 �rs modell har ett f�rb�ttrat kretskort och extra belysning under mellanslagstangenten. Dessutom har firmware skrivits om f�r en mer stabil skrivupplevelse.',8911),
		('QPAD MK-75 PRO',1590, 839, 0,'QPAD MK75 kommer med de popul�ra mekaniska Cherry MX-switcharna. De erbjuder en extremt h�g h�llbarhet med upp till 50 miljoner tangenttryckningar.',8911),

	/* Tangentbord vanliga 8912*/
		('Cherry DW 9000 Slim Kit',1290, 839, 0,'Cherry DW 9000 Slim �r ett tr�dl�st kit som s�tter nya standarder tack vare sin trendiga och slimmade design. Mus och tangentbord ansluts till datorn antingen �ver 2,4GHz RF via den medf�ljande USB-mottagaren eller via Bluetooth. Du kan v�xla mellan anslutningstyp snabbt och enkelt p� b�de mus och tangentbord.',8912),
		('Logitech K740 Illuminated',879, 839, 0,'Bakgrundsbelysningen g�r att alla tangenterna �r tydliga, ljusa och l�ttl�sta. Du kan �ven justera belysningen manuellt efter den omgivande belysningen. Tangentbordet har ett mjukt handledsst�d, normalstora tangenter och Logitechs PerfectStroke-tangentsystem, s� att varje nedslag blir bekv�mt, f�ljsamt och tyst. ',8912),
		('Microsoft Surface Keyboard',899, 839, 0,'Microsoft Surface Keyboard SC Bluetooth �r ett stilrent tangentbord med en design d�r varje detalj �r noga utt�nkt. Med sin ljusgr� finish matchar det din Surface perfekt och �r pricken �ver i f�r det v�lplanerade skrivbordet. Du kommer att tycka om den gedigna k�nslan n�r du arbetar. Tangentbordet �r enkelt att koppla till din Surface via tr�dl�s Bluetooth och batteriet ger dig kraft i ett helt �r.',8912),
		('Logitech Craft',1790, 839, 0,'Craft ger total kreativ kontroll vid skrivbordet, med en f�rstklassig skrivupplevelse, otroligt robust konstruktion och ett kreativt inmatningshjul som anpassar sig efter den app du anv�nder.',8912)



/*
UPDATE ITEMS
SET ExtraPriceActive = 1, ExtraPrice = 749
Where Name = 'Western Digital 3TB drive'
*/

/*
UPDATE ITEMS
SET Description = 'Old but reliable hard drive. Maximum read speed 75 MB/s'
Where Name = 'Maxtor 320 GB hard disk'
*/


/* CLEAN
DELETE FROM PRODUCT
*/