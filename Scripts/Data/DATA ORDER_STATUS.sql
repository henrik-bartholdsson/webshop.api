



INSERT INTO ORDER_STATUS([OrderStatusText])
VALUES
		('New'),
		('In Progress'),
		('Shiped'),
		('Canceld'),
		('Done')



select * from ORDER_STATUS


truncate table ORDER_STATUS






  update ORDERS
  set OrderStatusId = 1
  where UserId = '80a4b93d-c51c-4e9c-a5a1-27f3410569ea'