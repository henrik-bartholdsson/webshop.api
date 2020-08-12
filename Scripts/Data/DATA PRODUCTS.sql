SELECT * FROM PRODUCT


INSERT INTO PRODUCT ([NAME], [PRICE], [EXTRA_PRICE], [EXTRA_PRICE_ACTIVE], [DESCRIPTION])
VALUES
('Western Digital 3TB drive',899, 839, 1,'Western Digital 3TB NAS drive'),
('Seagate Baracuda 2TB drive',799, 759, 0,'Seagate Baracuda 2TB drive 7200rpm fast hard drive'),
('Maxtor 320 GB hard disk',899, 839, 0,'Old but reliable hard drive')



UPDATE ITEMS
SET ExtraPriceActive = 1, ExtraPrice = 749
Where Name = 'Western Digital 3TB drive'

UPDATE ITEMS
SET Description = 'Old but reliable hard drive. Maximum read speed 75 MB/s'
Where Name = 'Maxtor 320 GB hard disk'