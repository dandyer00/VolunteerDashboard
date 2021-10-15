﻿--CREATE DATABASE Hack29

Use Hack29
CREATE TABLE Users
(
	userId INT PRIMARY KEY IDENTITY(1,1),
	firstName VARCHAR(50) NOT NULL,
	lastName VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	phone VARCHAR(50) NOT NULL,
	location VARCHAR(50) NOT NULL,
	postalCode VARCHAR(50)	NOT NULL
)

CREATE TABLE Events
(
	eventId INT PRIMARY KEY IDENTITY(1,1),
	eventName VARCHAR(50) NOT NULL,
	userId VARCHAR(50) NOT NULL,
	eventTime timestamp NOT NULL,
	workflowInstanceId VARCHAR(50) NOT NULL
)