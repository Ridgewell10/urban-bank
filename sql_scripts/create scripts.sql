

-- public."Account" definition

-- Drop table

-- DROP TABLE public."Account";

CREATE TABLE public."Account" (
	"Id" serial not null,
	"AccountType" varchar(45) NOT NULL,
	"createdAt" timestamptz NOT NULL,
	"OwnerId" int4 NOT NULL,
	CONSTRAINT "Account_PK" PRIMARY KEY ("Id")
);


-- public."Account" foreign keys

ALTER TABLE public."Account" ADD CONSTRAINT "Account_Owner_FK" FOREIGN KEY ("OwnerId") REFERENCES "Owner"("Id");

-- public."Owner" definition

-- Drop table

-- DROP TABLE public."Owner";

CREATE TABLE public."Owner" (
	"Id" serial NOT NULl,
	"Name" varchar(60) NULL,
	"DateOfBirth" timestamp NOT NULL,
	"Address" varchar(100) NULL,
	CONSTRAINT "Owner_PK" PRIMARY KEY ("Id")
);