select * from CATEGORY
/* CLEAN
DELETE FROM CATEGORY
*/

INSERT INTO CATEGORY (ID, TITLE, DESCRIPTION, SORT_ORDER, PARENT_ID, REDIRECT_TO_ID, ACTIVE)
VALUES
	(9123,'Hårddiskar', 'Lagring för din dator eller NAS', 1, null, null, 1),
		(1231,'3.5" diskar', 'Vanliga diskar som passar tex till desktop datorer', 1, 9123, null, 1),
		(1232,'2.5" diskar', 'Mindre format som passa laptops', 1, 9123, null, 1),
	(9456,'SSD diskar', 'Snabbare än hårddiskar', 1, null, null, 1),
		(4561,'2.5" SSD', 'Some description', 1, 9456, null, 1),
		(4562,'M.2', 'Mindre variant av SSD', 1, 9456, null, 1),
	(9789,'Bildskärmar', 'Some description', 1, null, null, 1),
		(7891,'24" skärmar', 'Lagom', 1, 9789, null, 1),
		(7892,'27" skärmar', 'Lite större', 1, 9789, null, 1),
		(7893,'32" skärmar', 'Stor', 1, 9789, null, 1),
	(9891, 'Tangentbord', '', 1, null, null, 1),
		(8911, 'Gaming', '', 1, 9891, null, 1),
		(8912, 'Vanliga', '', 1, 9891, null, 1)




/*
UPDATE CATEGORY
SET ACTIVE = 1
WHERE PRODUCT_ID = 5
*/

/*
DROP TABLE CATEGORY
*/