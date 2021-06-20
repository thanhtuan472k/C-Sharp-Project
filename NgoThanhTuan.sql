Create table UserAccount (
	ID varchar(100) not null primary key,
	UserName varchar(100) not null unique,
	Password varchar(100) not null,
	StatusAcc nvarchar(100) check (StatusAcc in ('Blocked', 'Accept'))
)

Insert into UserAccount
Values	('admin', 'admin', 'admin', 'Accept'),
		('User01', 'tuan123', 'tuan123', 'Accept'),
		('User02', 'an123', 'an123', 'Accept');

Insert into UserAccount
Values	('User03', 'nam123', 'nam123', 'Blocked'),
		('User04', 'nu123', 'nu123', 'Accept'),
		('User05', 'tan123', 'tan123', 'Accept'),
		('User06', 'thien2k', 'thien2k', 'Accept'),
		('User07', 'thanh123', 'thanh123', 'Accept'),
		('User08', 'duy2000@gmail.com', 'duy123', 'Accept'),
		('User09', 'ho123', 'ho123', 'Accept');

		Insert into UserAccount
Values
		('admin1', 'admin1', 'admin1', 'Blocked'),
		('admin2', 'admin2', 'admin2', 'Blocked'),
		('admin3', 'admin3', 'admin3', 'Blocked');
		
Create table Category(
	IDCategory varchar(100) not null primary key,
	NameCategory nvarchar(150),
	Description nvarchar(150),
)

Insert into Category 
Values	('GHE', N'Ghế Ngồi', null),
		('DEN', N'Đèn Bàn', null),
		('BAN', N'Bàn Học', null),
		('DECOR', N'Đồ Decor', null);

Create table Product (
	ID varchar(100) not null primary key,
	IDCategory varchar(100) foreign key  references Category(IDCategory),
	NameProduct nvarchar(150) not null,
	UnitCost decimal(18, 0) not null,
	Quantity int,
	ImageProduct nvarchar(150),
	Description nvarchar(150),
	StatusProduct varchar(100) check (StatusProduct in (N'Còn', N'Hết'))
)


/* Tạo dữ liệu giả ko có hình ảnh*/
Insert into Product
Values	('GHE01', 'GHE', N'Ghế Xoay Hòa Phát', 1250000, 10, null, N'Ghế xoay Hòa Phát chất lượng cao giá rẻ, thuận tiện cho dân văn phòng', N'Còn'),
		('BAN01', 'BAN', N'Bàn Ikea', 1500000, 5, null, N'Bàn Gaming IKEA cực chất, mang kiểu dáng mới, thể hiện phong cách riêng của người sở hữu.', N'Còn'),
		('GHE02', 'GHE', N'GHẾ VĂN PHÒNG LƯNG CAO GLC27', 2700000, 5, null,  N'Được thiết kế lưng tựa dạng lưới dệt thông thoáng,giúp bạn thoải mái khi làm việc..', N'Còn' ),
		('DEN01', 'DEN', N'Đèn vành đai sao Thổ', 500000, 10, null, N'Đèn hiện có 4 tông màu chủ đạo có thể thảy đổi được', N'Còn' );

select * from UserAccount
select * from Category
select * from Product

