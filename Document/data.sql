create database VillageInfo
use VillageInfo
go
create table Pepoles (
	id int primary key identity(1,1),
	username varchar(40) not null, --����
	usedname varchar(50) null, --������
	gender int default(0), --�Ա�
	birthday varchar(10) null, --��������
	nation varchar(20) null, --����
	political varchar(10) null, --������ò
	idcard varchar(18) not null, --���֤��
	natives varchar(50) null, --�������ڵ�
	populate int default(1), --�˿�
	[address] varchar(50) null, --��ͥסַ
	military varchar(50) null, --����״��
	marriage varchar(10) null, --����״��
	education varchar(20) null, --�Ļ��̶�
	phone varchar(15) null, --��ϵ�绰
	photo varchar(50) null, --��Ƭ
	ftype varchar(10) null, --��������
	fid int null, --��ͥid
	fship varchar(10) null --��ϵ
)