create database VillageInfo
use VillageInfo
go
create table Pepoles (
	id int primary key identity(1,1),
	username varchar(40) not null, --姓名
	usedname varchar(50) null, --曾用名
	gender int default(0), --性别
	birthday varchar(10) null, --出生日期
	nation varchar(20) null, --民族
	political varchar(10) null, --政治面貌
	idcard varchar(18) not null, --身份证号
	natives varchar(50) null, --户籍所在地
	populate int default(1), --人口
	[address] varchar(50) null, --家庭住址
	military varchar(50) null, --兵役状况
	marriage varchar(10) null, --婚姻状况
	education varchar(20) null, --文化程度
	phone varchar(15) null, --联系电话
	photo varchar(50) null, --照片
	ftype varchar(10) null, --户口类型
	fid int null, --家庭id
	fship varchar(10) null --关系
)