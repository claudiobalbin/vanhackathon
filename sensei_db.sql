CREATE SCHEMA sensei AUTHORIZATION postgres;

CREATE TABLE sensei.license (
	id SERIAL,
	description varchar(100) NULL,
	user_number int NULL,
	storage_limit int NULL,
	creation_date date NULL
);

INSERT INTO sensei.license (description, user_number, storage_limit, creation_date) VALUES('free', 10, 10, now());
INSERT INTO sensei.license (description, user_number, storage_limit, creation_date) VALUES('bronze', 20, 50, now());
INSERT INTO sensei.license (description, user_number, storage_limit, creation_date) VALUES('gold', 50, 100, now());
INSERT INTO sensei.license (description, user_number, storage_limit, creation_date) VALUES('platinum', 100, 1000, now());

-- ==============================================

create table sensei.customers (
	id SERIAL, 
	email VARCHAR(300),
	license_id int not null,
	creation_date date null
);

INSERT INTO sensei.customers (email, license_id, creation_date) VALUES('john@company.com', 1, now());
INSERT INTO sensei.customers (email, license_id, creation_date) VALUES('mary@home.com', 1, now());
INSERT INTO sensei.customers (email, license_id, creation_date) VALUES('oliver@enterprise.com', 2, now());
INSERT INTO sensei.customers (email, license_id, creation_date) VALUES('jannet@business.com', 3, now());
INSERT INTO sensei.customers (email, license_id, creation_date) VALUES('paul@corp.com', 4, now());
