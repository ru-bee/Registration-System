create database regissystem;
create table users(
username varchar (250) primary key not null,
email varchar (250) not null,
password varchar (250) not null,
)
select * from users;

drop table users;
