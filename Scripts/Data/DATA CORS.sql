
INSERT INTO CORS ([ADDRESS], [ACTIVE], [COMMENT])
VALUES ('http://localhost:3000',1, 'For the React JS App')




/* Some cors that should not be allowed by the API
*****************************************************
INSERT INTO CORS ([ADDRESS], [ACTIVE], [COMMENT])
VALUES
('*',1, 'This should be filtered out by the api\WebShopService\GetListOfAllActiveCors()'),
('http://localhost:666',0, 'This should be filtered out by the api\WebShopService\GetListOfAllActiveCors()')
*****************************************************
*/

select * from cors

truncate table CORS

UPDATE CORS
SET ACTIVE = 1
Where Address = 'http://localhost:3000'