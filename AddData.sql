Use Hack29

SET IDENTITY_INSERT Users ON;
Insert into Users (userId, firstName, lastName, email, phone, location, postalCode)
values 
	(678, 'Nino', 'Schurter', 'nino@bike.com', '999-111-3456', 'Switzerland', '123456'),
	(679, 'Luke', 'Skywalker', 'jedi@space.org', '000-111-3456', 'Tatooine', '111111'),
	(860, 'Micky', 'Mouse', 'micky@disney.com', '246-802-4680', 'Orlando', '213061'),
	(459, 'Bob', 'roberts', 'bob@bob.com', '333-999-0101', 'MargarittaVille', '31214');

SET IDENTITY_INSERT Events ON;
insert into events (eventId, eventName, userID, workflowInstanceId, eventCode)
values
	(567, 'FormCompleted', 678, 2345, 100),
	(568, 'FromCompleted', 679, 334455, 100),
	(569, 'FormCompleted', 459, 2589, 100);