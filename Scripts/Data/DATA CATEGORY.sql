
INSERT INTO CATEGORY (PRODUCT_ID, TITLE, DESCRIPTION, SORT_ORDER, PARENT_ID, REDIRECT_TO_ID, ACTIVE)
VALUES
	(1,'First Level A', 'Some description', 1, null, null, 1),
	(2,'Second Level A', 'Some description', 1, 1, null, 1),
	(3,'First Level B', 'Some description', 1, null, null, 1),
	(4,'Second Level B', 'Some description', 1, 3, null, 1),
	(5,'Second Level B', 'Some description', 1, 3, null, 1),
	(6,'Third Level B', 'Some description', 1, 5, null, 1),
	(7,'Second Level A', 'Some description', 1, 1, null, 1)


UPDATE CATEGORY
SET PARENT_ID = 2
WHERE PRODUCT_ID = 3




select * from CATEGORY


/* CLEAN
TRUNCATE TABLE CATEGORY
*/

/*
DROP TABLE CATEGORY
*/