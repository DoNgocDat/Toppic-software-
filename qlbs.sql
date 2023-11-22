

create database qlbs;
use qlbs;

create table taikhoan (
    tentaikhoan nvarchar(50) primary key NOT NULL,
	email varchar(100) NOT NULL,
    tenhienthi nvarchar(50) NOT NULL,
    matkhau nvarchar(50) NOT NULL,
	loaitaikhoan nvarchar(50) NOT NULL,
);

create table  danhmuc (
    madanhmuc int identity constraint mdm_pk primary key NOT NULL,
    tendanhmuc nvarchar(50) NOT NULL
);

create table  sach (
    masach int identity constraint msp_pk primary key NOT NULL,
	madanhmuc int constraint mdm_fk foreign key references danhmuc(madanhmuc) on delete cascade on update cascade not null,
    tensach nvarchar(200) NOT NULL,
    giasach float NOT NULL,
    tacgia nvarchar(50) NOT NULL,
	ngayxuatban date NOT NULL,
);

create table  hoadon (
    mahoadon int identity constraint mhd_pk  primary key NOT NULL,
    ngaygiao date NOT NULL,
    tenkhachhang nvarchar(100) NOT NULL,
    diachi nvarchar(250) NOT NULL,
    dienthoai nvarchar(50) NOT NULL
);

create table  chitiethoadon (
    machitiet int identity constraint mct_pk  primary key NOT NULL,
    mahoadon int NOT NULL,
    masach int NULL,
    soluong int default 1  NOT NULL,
    giasach  float NOT NULL,
    thanhtien int NOT NULL,
    foreign key (mahoadon) references hoadon(mahoadon),
	foreign key (masach) references sach(masach)
);

create table giohang (
    magiohang int identity constraint mgh_pk  primary key NOT NULL,
	masach int NULL,
	madanhmuc int NULL,
	tensach nvarchar(50)NOT NULL,
    giasach float NOT NULL,
	tacgia nvarchar(50) NOT NULL,
	ngayxuatban date NOT NULL,
	foreign key (masach) references sach(masach)
);

create table donhang (
    madonhang int identity constraint mdh_pk  primary key NOT NULL,
	tenkhachhang nvarchar(50) NULL,
	diachi nvarchar(50)NOT NULL,
	sodienthoai int NULL,
	masach int NULL,
	tensach nvarchar(50)NOT NULL,
    giasach float NOT NULL,
	ngaymua date NULL ,
	tinhtrang nvarchar(50)  NULL,
    foreign key (masach) references sach(masach)
);

create table  chitietsanpham (
    machitietsp int identity constraint mctsp_pk  primary key NOT NULL,
    masach int NULL,
    tensach nvarchar (50) NOT NULL,
    giasach  float NOT NULL,
    tacgia nvarchar (50) NOT NULL,
	mota nvarchar (200) NOT NULL,
	foreign key (masach) references sach(masach)
);

insert into giohang values
  ( 1,3,N'Đắc nhân tâm', 120000, 'Dale Carnegie', '2022-06-01'),
  (2, 3,N'Nhà giả kim', 150000,  'Paulo Coelho', '2022-06-02');
select  *from giohang ;

insert into  donhang values
    (N'Phú',N'Hoài Nhơn',07733,1, N'Đắc nhân tâm', 120000,'2023-11-3', N'Chờ thanh toán'),
    (N'Đạt',N'Phú Yên',03377,2, N'Nhà giả kim', 150000,'2023-11-2', N'Vận chuyển'),
    (N'Phú',N'Hoài Đức',09987,3, N'Số đỏ', 80000,'2023-11-1',N'Đang giao');
select * from donhang ;

insert into taikhoan values 
  ( 'admin','admin@gmail.com','admin','cntt',1),
  ('phu','phudo@gmail.com',N'Phú Đô','7703',0),
  ('dat','ngocdat@gmail.com','Dat','123',0),
  ('hung','hung@gmail.com',N'Hùng Còi','123',0),
  ('dung','dung@gmail.com','Dung','123',0)
select * from taikhoan;

insert into danhmuc values 
  (N'Sách Việt Nam'),
  (N'Sách Của Bộ GD&DT'),
  (N'Sách Nước Ngoài')
select * from danhmuc;

insert into sach values 
    ( 3,N'Đắc nhân tâm', 120000, 'Dale Carnegie', '2022-06-01'),
    ( 3,N'Nhà giả kim', 150000,  'Paulo Coelho', '2022-06-02'),
    ( 1,N'Số đỏ', 80000,  N'Vũ Trọng Phụng',  '2021-06-03'),
    ( 1,N'Dế Mèn phiêu lưu ký', 70000,  N'Tô Hoài', '2022-06-04'),
    ( 1,N'Kính vạn hoa', 90000,  N'Nguyễn Nhật Ánh', '2020-06-05'),
    ( 1,N'Bên kia bầu trời', 95000,  N'Nguyễn Ngọc Thuần', '2022-06-06'),
    ( 1,N'Chú bé rồng và cái cây thần', 105000,  N'Nguyễn Nhật Ánh', '2022-06-07'),
    ( 1,N'Lỗi của mẹ', 80000,  N'Trác Phong Nguyên',  '2023-06-08'),
    ( 1,N'Tắt đèn', 95000,  N'Ngô Tất Tố', '2021-06-09'),
    ( 3,N'Từ điển Sinh viên', 120000,  N'Nguyễn Quang Dũng',  '2021-06-10'),
    ( 1,N'Đường đến danh ca vọng cổ', 90000, N'Nguyễn Nhật Ánh', '2022-06-11'),
    ( 1,N'Kính vạn hoa', 90000,  N'Nguyễn Nhật Ánh', '2021-06-12'),
    ( 1,N'Ru', 75000, N'Kim Thúy', '2021-06-13'),
    ( 1,N'Những câu chuyện về Rùa', 85000, N'Vũ Trọng Phụng',  '2022-06-14'),
    ( 1,N'Mắt biếc', 95000,  N'Nguyễn Nhật Ánh',  '2022-06-15'),
    ( 1,N'Hồi trường mở', 70000,  N'Đỗ Trọng Huỳnh', '2021-06-16'),
    ( 3,N'Tôi tài giỏi, bạn cũng thế', 80000, 'Adam Khoo', '2021-06-17'),
    ( 3,N'Từ điển Oxford', 180000, 'Oxford University Press', '2023-06-18'),
    ( 3,N'Những nguyên lý cơ bản của chủ nghĩa Mác-Lênin', 90000, 'Vladimir Lenin', '2021-06-19'),
    (3,N'Bắt trẻ đồng xanh', 85000, 'J.D. Salinger', '2022-06-20'),
    (1,N'Cây chuối non', 95000, 'Nguyễn Nhật Ánh', '2021-06-21'),
    (3,N'Sapiens: Tóm tắt lược sử loài người', 110000, 'Yuval Noah Harari', '2022-06-22'),
    (3,N'Diary of a Wimpy Kid', 70000, 'Jeff Kinney', '2021-06-23'),
    (3,N'The Alchemist', 120000, 'Paulo Coelho', '2022-06-24'),
    (3,N'Harry Potter and the Philosopher', 150000, 'J.K. Rowling', '2022-06-25'),
    (3,N'The Great Gatsby', 90000, 'F. Scott Fitzgerald', '2023-06-26'),
    (3,N'To Kill a Mockingbird', 80000, 'Harper Lee', '2021-06-27'),
    (3,N'1984', 100000, 'George Orwell', '2023-06-28'),
    (3,N'Pride and Prejudice', 95000, 'Jane Austen', '2022-06-29'),
    (3,N'The Lord of the Rings', 180000, 'J.R.R. Tolkien', '2023-06-30'),
    (3,N'The Catcher in the Rye', 85000, 'J.D. Salinger', '2023-07-01'),
    (3,N'The Little Prince', 90000, 'Antoine de Saint-Exupéry', '2023-07-02'),
    (3,N'The Hobbit', 95000, 'J.R.R. Tolkien', '2023-07-03'),
    (3,N'The Da Vinci Code', 120000, 'Dan Brown', '2023-07-04'),
    (2,N'Toàn thư văn học Việt Nam', 130000, N'Bộ Văn hóa - Thông tin', '2023-07-05'),
    (2,N'Tiếng Việt 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-07-06'),
    (2,N'Tiếng Việt 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-07'),
    (2,N'Tiếng Việt 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-07-08'),
    (2,N'Tiếng Việt 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-07-09'),
    (2,N'Toán 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-07-10'),
    (2,N'Toán 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-11'),
    (2,N'Toán 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-07-12'),
    (2,N'Toán 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-07-13'),
    (2,N'Tiếng Anh 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-07-14'),
    (2,N'Tiếng Anh 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-15'),
    (2,N'Tiếng Anh 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-07-16'),
    (2,N'Tiếng Anh 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-07-17'),
    (2,N'Tự điển Hán Việt', 120000, N'Phạm Quỳnh', '2023-07-18'),
    (2,N'Tự điển Việt Hán', 120000, N'Phạm Quỳnh', '2023-07-19'),
    (2,N'Tự điển Anh Việt', 120000, N'Phạm Quỳnh', '2023-07-20'),
    (2,N'Tự điển Việt Anh', 120000, N'Phạm Quỳnh', '2023-07-21'),
    (2,N'Lịch sử 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-07-22'),
    (2,N'Lịch sử 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-23'),
    (2,N'Lịch sử 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-07-24'),
    (2,N'Lịch sử 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-07-25'),
    (2,N'Địa lý 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-07-26'),
    (2,N'Địa lý 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-27'),
    (2,N'Địa lý 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-07-28'),
    (2,N'Địa lý 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-07-29'),
    (2,N'Hình học 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-07-30'),
    (2,N'Hình học 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-31'),
    (2,N'Hình học 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-31'),
    (2,N'Hình học 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-07-31'),
    (2,N'Hình học 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-01'),
    (2,N'Hình học 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-02'),
    (2,N'Khoa học 4 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-03'),
    (2,N'Khoa học 4 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-04'),
    (2,N'Khoa học 4 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-05'),
    (2,N'Khoa học 4 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-06'),
    (2,N'Tiếng Việt 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-07'),
    (2,N'Tiếng Việt 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-08'),
    (2,N'Tiếng Việt 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-09'),
    (2,N'Tiếng Việt 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-10'),
    (2,N'Toán 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-11'),
    (2,N'Toán 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-12'),
    (2,N'Toán 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-13'),
    (2,N'Toán 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-14'),
    (2,N'Tiếng Anh 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-15'),
    (2,N'Tiếng Anh 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-16'),
    (2,N'Tiếng Anh 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-17'),
    (2,N'Tiếng Anh 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-18'),
    (2,N'Lịch sử 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-19'),
    (2,N'Lịch sử 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-20'),
    (2,N'Lịch sử 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-21'),
    (2,N'Lịch sử 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-22'),
    (2,N'Địa lý 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-23'),
    (2,N'Địa lý 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-24'),
    (2,N'Địa lý 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-25'),
    (2,N'Địa lý 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-26'),
    (2,N'Hình học 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-27'),
    (2,N'Hình học 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-08-28'),
    (2,N'Hình học 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-29'),
    (2,N'Hình học 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-08-29'),
    (2,N'Hình học 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-08-30'),
    (2,N'Khoa học 5 tập 1', 75000, N'Bộ GD&ĐT', '2023-08-31'),
    (2,N'Khoa học 5 tập 2', 75000, N'Bộ GD&ĐT', '2023-09-01'),
    (2,N'Khoa học 5 tập 3', 75000, N'Bộ GD&ĐT', '2023-09-02'),
    (2,N'Khoa học 5 tập 4', 75000, N'Bộ GD&ĐT', '2023-09-03'),
    (2,N'Tiếng Việt 6 tập 1', 75000, N'Bộ GD&ĐT', '2023-09-04'),
    (2,N'Tiếng Việt 6 tập 2', 75000, N'Bộ GD&ĐT', '2023-09-05'),
    (2,N'Tiếng Việt 6 tập 3', 75000, N'Bộ GD&ĐT', '2023-09-06'),
    (2,N'Tiếng Việt 6 tập 4', 75000, N'Bộ GD&ĐT', '2023-09-07'),
    (2,N'Toán 6 tập 1', 75000, N'Bộ GD&ĐT', '2023-09-08'),
    (1,N'Kính vạn hoa 2', 87000, N'Nguyễn Nhật Ánh', '2021-02-03'),
    (1,N'Con chim xanh biếc bay về', 63000, N'Phan Y Yên', '2020-03-10'),
    (1,N'Sóng', 67000, N'Vũ Trọng Phụng', '2022-04-15'),
    (1,N'Bên kia bầu trời 2', 72000, N'Nguyễn Ngọc Thuần', '2020-05-20'),
    (3,N'Nhà Giả Kim', 78000, N'Paulo Coelho', '2021-06-25'),
    (3,N'Tây Du Ký', 79000, N'Ngô Thừa Ân', '2022-07-30'),
    (3,N'Sapiens: Từ quá khứ đến tương lai', 98000, N'Yuval Noah Harari', '2021-08-04'),
    (1,N'Vợ nhặt', 75000, N'Nguyễn Nhật Ánh', '2021-09-09'),
    (3,N'Làm chủ tư duy', 82000, N'Napoleon Hill', '2022-10-14'),
    (1,N'Bóng ma trong nhà hát', 69000, N'Nguyễn Quang Vinh', '2021-11-19'),
    (1,N'Tiếng hát từ hồn quê', 73000, N'Trương Bích Ngọc', '2020-12-24'),
    (1,N'Người truyền lửa', 84000, N'Lê Thẩm Dương', '2022-01-29'),
    (1,N'Truyện Kiều', 95000, N'Nguyễn Du', '2021-02-03'),
    (3,N'Đời ngắn đừng ngủ dài', 88000, N'Robin Sharma', '2023-03-10'),
    (3,N'Đắc nhân tâm 2', 91000, N'Dale Carnegie', '2022-04-15'),
    (1,N'Chuột không cần biết cười', 67000, N'Trác Phong Nguyên', '2021-05-20'),
    (1,N'Ngày xưa có một chuyện tình', 75000, N'Nguyễn Nhật Ánh', '2020-06-25'),
    (1,N'Bố già', 79000, N'Trần Thị Ngọc Mai', '2020-07-30'),
    (1,N'Tôi đã làm bên cạnh Tổng thống', 71000, N'Trần Nhật Túy', '2021-08-04'),
    (1,N'Cây cam ngọt của tôi', 78000, N'Trác Phong Nguyên', '2022-09-09'),
    (3,N'Chúa đảo xanh', 68000, N'Peter Benchley', '2020-10-14'),
    (3,N'Mỹ thuật trên tờ tiền', 82000, N'Spencer Johnson', '2022-11-19'),
    (3,N'Con đường mật mã', 69000, N'Dan Brown', '2021-12-24'),
    (1,N'Cánh đồng bất tận', 76000, N'Nguyễn Ngọc Thuần', '2022-01-29'),
    (3,N'Sức mạnh của tiềm thức', 73000, N'Joseph Murphy', '2021-02-03'),
    (3,N'Truyện cổ tích Andersen', 88000, N'Hans Christian Andersen', '2020-03-10'),
    (1,N'Tôi thấy hoa vàng trên cỏ xanh 2', 95000, N'Nguyễn Nhật Ánh', '2020-04-15'),
    (3,N'Trăm năm cô đơn', 92000, N'Gabriel García Márquez', '2022-05-20'),
    (1,N'Mắt biếc 2', 78000, N'Nguyễn Nhật Ánh', '2021-06-25'),
    (3,N'Cuốn theo chiều gió', 89000, N'Margaret Mitchell', '2022-07-30')
 select *from sach
