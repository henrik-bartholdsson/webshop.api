SELECT * FROM PRODUCT


INSERT INTO PRODUCT ([NAME], [PRICE], [EXTRA_PRICE], [EXTRA_PRICE_ACTIVE], [DESCRIPTION], [PARENT_CATEGORY_ID])
VALUES
('Western Digital 3TB drive',899, 839, 1,'Western Digital 3TB NAS drive',2),
('Seagate Baracuda 2TB drive',799, 759, 0,'Seagate Baracuda 2TB drive 7200rpm fast hard drive',2),
('Maxtor 320 GB hard disk',899, 839, 0,'Old but reliable hard drive',2)


/*
INSERT INTO PRODUCT ([NAME], [PRICE], [EXTRA_PRICE], [EXTRA_PRICE_ACTIVE], [DESCRIPTION], [PARENT_CATEGORY_ID])
VALUES
('Logitech Illuminated Keyboard K740',799, 839, 0,'Full size low profile and silent keyboard with chicklet keys',1),
('Docky Shine 2 mini',1495, 759, 0,'Gaming keyboard with sherry MX brown switches',1),
('Microsoft Surface Keyboard',899, 839, 0,'Wireless keyboard with awsome typing experiance and battery life that last for decades.',1)
*/

UPDATE ITEMS
SET ExtraPriceActive = 1, ExtraPrice = 749
Where Name = 'Western Digital 3TB drive'

UPDATE ITEMS
SET Description = 'Old but reliable hard drive. Maximum read speed 75 MB/s'
Where Name = 'Maxtor 320 GB hard disk'