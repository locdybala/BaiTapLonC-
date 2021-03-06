USE [qlbs]
GO
/****** Object:  Table [dbo].[tb_sach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_sach](
	[maSach] [int] IDENTITY(1,1) NOT NULL,
	[tenSach] [nvarchar](50) NULL,
	[maLoaiSach] [int] NULL,
	[maTacGia] [int] NULL,
	[namXuatBan] [date] NULL,
	[giaBia] [int] NULL,
 CONSTRAINT [PK_tb_sach] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[sach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sach] as
	select * from tb_sach
GO
/****** Object:  Table [dbo].[tb_cthoadon]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_cthoadon](
	[maHoaDon] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC,
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ctphieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ctphieunhap](
	[maPhieuNhap] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC,
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_hoadon]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_hoadon](
	[maHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[maKhachHang] [int] NULL,
	[ngaylap] [date] NULL,
	[manv] [int] NULL,
 CONSTRAINT [PK_tb_hoadon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_khachhang]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_khachhang](
	[maKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenKhachHang] [nvarchar](50) NULL,
	[diachiKH] [nvarchar](50) NULL,
	[sdtKH] [nchar](10) NULL,
 CONSTRAINT [PK_tb_khachhang] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_loaisach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_loaisach](
	[maLoaiSach] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiSach] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_loaisach] PRIMARY KEY CLUSTERED 
(
	[maLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_nhacungcap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_nhacungcap](
	[maNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[tenNhaCungCap] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[sdtNhaCungCap] [nvarchar](10) NULL,
	[ghichu] [nvarchar](255) NULL,
	[chietkhau] [float] NULL,
 CONSTRAINT [PK_tb_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[maNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_nhanvien]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_nhanvien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[tenNhanVien] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[sdtNhanVien] [nvarchar](10) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[diaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_nhanvien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_phieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_phieunhap](
	[maPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[maNhanVien] [int] NULL,
	[maNhaCungCap] [int] NULL,
	[ngayNhap] [date] NULL,
 CONSTRAINT [PK_tb_phieunhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_tacgia]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tacgia](
	[maTacGia] [int] IDENTITY(1,1) NOT NULL,
	[tenTacGia] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](3) NULL,
	[ngaySinh] [date] NULL,
	[trinhdo] [nvarchar](50) NULL,
	[coquan] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_tacgia] PRIMARY KEY CLUSTERED 
(
	[maTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_taikhoan]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_taikhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[position] [int] NULL,
 CONSTRAINT [PK_tb_taikhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (1, 1, 6)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (1, 2, 5)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (1, 6, 4)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (1, 9, 2)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (2, 2, 3)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (2, 6, 5)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (3, 11, 4)
INSERT [dbo].[tb_cthoadon] ([maHoaDon], [maSach], [soLuong]) VALUES (4, 8, 1)
GO
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (1, 2, 10)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (1, 6, 10)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (1, 7, 10)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (2, 1, 6)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (2, 6, 5)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (2, 7, 1)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (3, 8, 5)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (3, 11, 5)
INSERT [dbo].[tb_ctphieunhap] ([maPhieuNhap], [maSach], [soLuong]) VALUES (4, 6, 2)
GO
SET IDENTITY_INSERT [dbo].[tb_hoadon] ON 

INSERT [dbo].[tb_hoadon] ([maHoaDon], [maKhachHang], [ngaylap], [manv]) VALUES (1, 1, CAST(N'2021-05-02' AS Date), 1)
INSERT [dbo].[tb_hoadon] ([maHoaDon], [maKhachHang], [ngaylap], [manv]) VALUES (2, 2, CAST(N'2021-05-04' AS Date), 2)
INSERT [dbo].[tb_hoadon] ([maHoaDon], [maKhachHang], [ngaylap], [manv]) VALUES (3, 1, CAST(N'2021-05-05' AS Date), 3)
INSERT [dbo].[tb_hoadon] ([maHoaDon], [maKhachHang], [ngaylap], [manv]) VALUES (4, 3, CAST(N'2021-05-29' AS Date), 6)
SET IDENTITY_INSERT [dbo].[tb_hoadon] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_khachhang] ON 

INSERT [dbo].[tb_khachhang] ([maKhachHang], [tenKhachHang], [diachiKH], [sdtKH]) VALUES (1, N'Ngô Đình lộc', N'thạch thất', N'366280440 ')
INSERT [dbo].[tb_khachhang] ([maKhachHang], [tenKhachHang], [diachiKH], [sdtKH]) VALUES (2, N'Nguyễn Hồng Quân', N'Chàng Sơn - Thạch Thất', N'0333732000')
INSERT [dbo].[tb_khachhang] ([maKhachHang], [tenKhachHang], [diachiKH], [sdtKH]) VALUES (3, N'Nguyễn Văn Khánh', N'Thạch Xá - Thạch Thất', N'0338940203')
INSERT [dbo].[tb_khachhang] ([maKhachHang], [tenKhachHang], [diachiKH], [sdtKH]) VALUES (4, N'Nguyễn Hoàng Long', N'Chàng Sơn - Thạch Thất', N'0234567482')
INSERT [dbo].[tb_khachhang] ([maKhachHang], [tenKhachHang], [diachiKH], [sdtKH]) VALUES (5, N'Nguyễn Thủy Tiên', N'Phú Xuyên', N'0352676543')
SET IDENTITY_INSERT [dbo].[tb_khachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_loaisach] ON 

INSERT [dbo].[tb_loaisach] ([maLoaiSach], [tenLoaiSach]) VALUES (1, N'Chính trị – pháp luật')
INSERT [dbo].[tb_loaisach] ([maLoaiSach], [tenLoaiSach]) VALUES (2, N'Khoa học công nghệ – Kinh tế')
INSERT [dbo].[tb_loaisach] ([maLoaiSach], [tenLoaiSach]) VALUES (3, N'Văn học nghệ thuật')
INSERT [dbo].[tb_loaisach] ([maLoaiSach], [tenLoaiSach]) VALUES (8, N'Giáo trình')
SET IDENTITY_INSERT [dbo].[tb_loaisach] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_nhacungcap] ON 

INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (1, N'Nhà sách Kim Đồng', N'Hà Nội', N'0333333333', N'Nhà cung cấp lớn', 0.12)
INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (2, N'Nhà sách Hồng Đức', N'Bắc Giang', N'0234122131', N'Hơi xa', 0.2)
INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (3, N'Nhà sách Đoán Xem', N'Cà Mau', N'0111122221', N'Không', 0.3)
INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (4, N'Nhà sách Thiên Đường', N'Ba Vì', N'0987652431', N'Không', 0.2)
INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (5, N'Nhà sách Lộc Phát', N'Sơn Tây', N'023456672', N'Không', 0.3)
INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (6, N'Nhà sách Hà Nội', N'hà nội', N'0999999999', N'Không', 0.3)
INSERT [dbo].[tb_nhacungcap] ([maNhaCungCap], [tenNhaCungCap], [diaChi], [sdtNhaCungCap], [ghichu], [chietkhau]) VALUES (7, N'Nhà sách Trí Tuệ', N'Hà nội', N'1111111111', N'123', 0.2)
SET IDENTITY_INSERT [dbo].[tb_nhacungcap] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_nhanvien] ON 

INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (1, N'Nguyễn Thị Thảo', CAST(N'1900-01-01' AS Date), N'283423423', N'Nữ', N'Chàng Sơn')
INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (2, N'Ngô Đình Lộc', CAST(N'2000-11-10' AS Date), N'02222223', N'Nam', N'Thạch Thất')
INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (3, N'Nguyễn hồng Quân', CAST(N'2000-01-01' AS Date), N'0333732000', N'Nam', N'Chàng Sơn')
INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (4, N'Nguyễn Văn B', CAST(N'2000-11-10' AS Date), N'0222222312', N'Nữ', N'Thạch Thất')
INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (5, N'Nguyễn Văn C', CAST(N'2000-01-01' AS Date), N'0111121223', N'Nam', N'Thạch Xá')
INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (6, N'Nguyễn Văn D', CAST(N'2020-02-04' AS Date), N'0231234567', N'Nam', N'Hà Nội')
INSERT [dbo].[tb_nhanvien] ([maNhanVien], [tenNhanVien], [ngaySinh], [sdtNhanVien], [gioitinh], [diaChi]) VALUES (7, N'Ngô Đình Phúc', CAST(N'2002-08-24' AS Date), N'0345625312', N'Nam', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[tb_nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_phieunhap] ON 

INSERT [dbo].[tb_phieunhap] ([maPhieuNhap], [maNhanVien], [maNhaCungCap], [ngayNhap]) VALUES (1, 1, 1, CAST(N'2021-05-02' AS Date))
INSERT [dbo].[tb_phieunhap] ([maPhieuNhap], [maNhanVien], [maNhaCungCap], [ngayNhap]) VALUES (2, 1, 4, CAST(N'2021-05-02' AS Date))
INSERT [dbo].[tb_phieunhap] ([maPhieuNhap], [maNhanVien], [maNhaCungCap], [ngayNhap]) VALUES (3, 2, 5, CAST(N'2021-04-27' AS Date))
INSERT [dbo].[tb_phieunhap] ([maPhieuNhap], [maNhanVien], [maNhaCungCap], [ngayNhap]) VALUES (4, 1, 1, CAST(N'2021-05-04' AS Date))
INSERT [dbo].[tb_phieunhap] ([maPhieuNhap], [maNhanVien], [maNhaCungCap], [ngayNhap]) VALUES (5, 6, 5, CAST(N'2021-05-28' AS Date))
SET IDENTITY_INSERT [dbo].[tb_phieunhap] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_sach] ON 

INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (1, N'Đời Là Thế ', 1, 2, CAST(N'2000-11-11' AS Date), 30000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (2, N'Chế tạo máy tính', 2, 1, CAST(N'1999-02-03' AS Date), 50000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (6, N'Cuộc thi trí tuệ', 2, 3, CAST(N'2000-01-01' AS Date), 50000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (7, N'Chế tạo Robot', 2, 4, CAST(N'2000-01-01' AS Date), 50000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (8, N'Trí tuệ con người', 2, 2, CAST(N'2019-01-01' AS Date), 2000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (9, N'Lộc dybala', 2, 1, CAST(N'2000-01-01' AS Date), 20000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (11, N'Cách để làm giàu', 3, 1, CAST(N'2019-01-01' AS Date), 60000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (12, N'Ronaldo tiểu sử', 1, 1, CAST(N'2018-01-01' AS Date), 100000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (14, N'Mắt Biếc', 3, 1, CAST(N'2019-06-18' AS Date), 250000)
INSERT [dbo].[tb_sach] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [giaBia]) VALUES (17, N'Cuộc Đời Của Ronaldo', 1, 1, CAST(N'2021-09-15' AS Date), 200000)
SET IDENTITY_INSERT [dbo].[tb_sach] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_tacgia] ON 

INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (1, N'Ngô Đình Lộc ', N'Nam', CAST(N'2000-11-10' AS Date), N'Giáo sư', N'Thanh')
INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (2, N'Nguyễn Nhật Ánh', N'Nam', CAST(N'2000-05-17' AS Date), N'Thạc Sĩ', N'NXB kim đồng')
INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (3, N'Nguyễn Minh Nhật', N'Nam', CAST(N'2000-10-18' AS Date), N'Tiến sĩ', N'NXB Hợp Tác')
INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (4, N'Trang Hạ', N'Nữ', CAST(N'2000-01-01' AS Date), N'Giáo sư', N'NXB Kinh Môn')
INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (5, N'Anh Khang', N'Nam', CAST(N'2000-01-01' AS Date), N'Thạc sĩ', N'NXB Đoán xem')
INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (6, N'Hồ Xuân Hương', N'Nữ', CAST(N'1971-04-01' AS Date), N'Giáo Sư', N'Đoán xem')
INSERT [dbo].[tb_tacgia] ([maTacGia], [tenTacGia], [gioiTinh], [ngaySinh], [trinhdo], [coquan]) VALUES (7, N'Nguyễn Văn A', N'Nam', CAST(N'2021-05-11' AS Date), N'ABC', N'ABC')
SET IDENTITY_INSERT [dbo].[tb_tacgia] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_taikhoan] ON 

INSERT [dbo].[tb_taikhoan] ([id], [ten], [username], [password], [position]) VALUES (1, N'Ngô Đình Lộc', N'admin', N'admin', 1)
INSERT [dbo].[tb_taikhoan] ([id], [ten], [username], [password], [position]) VALUES (2, N'Nhân viên', N'loc', N'loc1', 0)
INSERT [dbo].[tb_taikhoan] ([id], [ten], [username], [password], [position]) VALUES (3, N'Nguyễn Văn Tiến', N'nhanvien1', N'1', 0)
SET IDENTITY_INSERT [dbo].[tb_taikhoan] OFF
GO
ALTER TABLE [dbo].[tb_cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_cthoadon_tb_hoadon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[tb_hoadon] ([maHoaDon])
GO
ALTER TABLE [dbo].[tb_cthoadon] CHECK CONSTRAINT [FK_tb_cthoadon_tb_hoadon]
GO
ALTER TABLE [dbo].[tb_cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_cthoadon_tb_sach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tb_sach] ([maSach])
GO
ALTER TABLE [dbo].[tb_cthoadon] CHECK CONSTRAINT [FK_tb_cthoadon_tb_sach]
GO
ALTER TABLE [dbo].[tb_ctphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_ctphieunhap_tb_phieunhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[tb_phieunhap] ([maPhieuNhap])
GO
ALTER TABLE [dbo].[tb_ctphieunhap] CHECK CONSTRAINT [FK_tb_ctphieunhap_tb_phieunhap]
GO
ALTER TABLE [dbo].[tb_ctphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_ctphieunhap_tb_sach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tb_sach] ([maSach])
GO
ALTER TABLE [dbo].[tb_ctphieunhap] CHECK CONSTRAINT [FK_tb_ctphieunhap_tb_sach]
GO
ALTER TABLE [dbo].[tb_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_hoadon_tb_khachhang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[tb_khachhang] ([maKhachHang])
GO
ALTER TABLE [dbo].[tb_hoadon] CHECK CONSTRAINT [FK_tb_hoadon_tb_khachhang]
GO
ALTER TABLE [dbo].[tb_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_hoadon_tb_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_nhanvien] ([maNhanVien])
GO
ALTER TABLE [dbo].[tb_hoadon] CHECK CONSTRAINT [FK_tb_hoadon_tb_nhanvien]
GO
ALTER TABLE [dbo].[tb_phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_phieunhap_tb_nhacungcap] FOREIGN KEY([maNhaCungCap])
REFERENCES [dbo].[tb_nhacungcap] ([maNhaCungCap])
GO
ALTER TABLE [dbo].[tb_phieunhap] CHECK CONSTRAINT [FK_tb_phieunhap_tb_nhacungcap]
GO
ALTER TABLE [dbo].[tb_phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_phieunhap_tb_nhanvien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[tb_nhanvien] ([maNhanVien])
GO
ALTER TABLE [dbo].[tb_phieunhap] CHECK CONSTRAINT [FK_tb_phieunhap_tb_nhanvien]
GO
ALTER TABLE [dbo].[tb_sach]  WITH CHECK ADD  CONSTRAINT [FK_tb_sach_tb_loaisach] FOREIGN KEY([maLoaiSach])
REFERENCES [dbo].[tb_loaisach] ([maLoaiSach])
GO
ALTER TABLE [dbo].[tb_sach] CHECK CONSTRAINT [FK_tb_sach_tb_loaisach]
GO
ALTER TABLE [dbo].[tb_sach]  WITH CHECK ADD  CONSTRAINT [FK_tb_sach_tb_tacgia] FOREIGN KEY([maTacGia])
REFERENCES [dbo].[tb_tacgia] ([maTacGia])
GO
ALTER TABLE [dbo].[tb_sach] CHECK CONSTRAINT [FK_tb_sach_tb_tacgia]
GO
/****** Object:  StoredProcedure [dbo].[checkdangnhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE procedure [dbo].[checkdangnhap]
	@username varchar(50),@password nvarchar(50)
	as 
		begin
		  select * from tb_dangnhap dn where dn.username=@username and dn.password=@password
		  end
GO
/****** Object:  StoredProcedure [dbo].[checktrangthai]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[checktrangthai]
	@iddangnhap varchar(50)
	as 
		begin
		  select trangthai from tb_dangnhap  where iddangnhap=@iddangnhap 
		  end
GO
/****** Object:  StoredProcedure [dbo].[deletedangnhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[deletedangnhap]
	@username varchar(50)
	as 
		begin
		  delete from tb_dangnhap where username=@username
		  end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_cthoadon]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[proc_cap_nhap_cthoadon]
@maHoaDon int,@maSach int,@soLuong int
as
	begin		
		update tb_cthoadon
		set soLuong=@soLuong
		where maHoaDon=@maHoaDon and maSach=@maSach;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_ctphieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_cap_nhap_ctphieunhap]
@maPhieuNhap int,@maSach int,@soLuong int
as
	begin		
		update tb_ctphieunhap
		set soLuong=@soLuong
		where maPhieuNhap=@maPhieuNhap and maSach=@maSach;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_hd]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_cap_nhap_hd]
@maHoaDon int,@maKhachHang int,@ngaylap date
as
	begin		
		update tb_hoadon
		set maKhachHang=@maKhachHang,ngaylap=@ngaylap
		where maHoaDon=@maHoaDon;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_kh]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_cap_nhap_kh]
@maKhachHang int,@tenKhachHang nvarchar(50),@diaChi nvarchar(50),@sdtKH nchar(10)
as
	begin		
		update tb_khachhang
		set tenKhachHang=@tenKhachHang,diachiKH=@diaChi,sdtKH=@sdtKH
		where maKhachHang=@maKhachHang;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_loaisach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_cap_nhap_loaisach]
@maLoaiSach int,@tenLoaiSach nvarchar(50)
as
	begin		
		update tb_loaisach
		set tenLoaiSach=@tenLoaiSach
		where maLoaiSach=@maLoaiSach;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_ncc]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_cap_nhap_ncc]
@maNhaCungCap int,@tenNhaCungCap nvarchar(50),@diaChi nvarchar(50),@sdtNhaCungCap nvarchar(10),@ghichu nvarchar(255),@chietkhau float
as
	begin		
		update tb_nhacungcap
		set tenNhaCungCap=@tenNhaCungCap,diaChi=@diaChi,sdtNhaCungCap=@sdtNhaCungCap,ghichu=@ghichu,chietkhau=@chietkhau
		where maNhaCungCap=@maNhaCungCap;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_nv]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_cap_nhap_nv]
@maNhanVien int,@tenNhanVien nvarchar(50),@ngaySinh date,@sdtNhanVien nvarchar(10),@gioitinh nvarchar(3),@diaChi nvarchar(50)
as
	begin		
		update tb_nhanvien
		set tenNhanVien=@tenNhanVien,ngaySinh=@ngaySinh,sdtNhanVien=@sdtNhanVien,gioitinh=@gioitinh,diaChi=@diaChi
		where maNhanVien=@maNhanVien;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_phieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_cap_nhap_phieunhap]
@maPhieuNhap int,@maNhanVien int,@maNhaCungCap int,@ngayNhap date
as
	begin		
		update tb_phieunhap
		set maNhanVien=@maNhanVien,maNhaCungCap=@maNhaCungCap,ngayNhap=@ngayNhap
		where maPhieuNhap=@maPhieuNhap;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_sach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_cap_nhap_sach]
@maSach int,@maLoaiSach int,@tenSach nvarchar(50),@maTacGia int,@namXuatBan date,@giaBia int
as
	begin		
		update tb_sach
		set maLoaiSach=@maLoaiSach,tenSach=@tenSach,maTacGia=@maTacGia,namXuatBan=@namXuatBan,giaBia=@giaBia
		where maSach=@maSach;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_tacgia]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_cap_nhap_tacgia]
@maTacGia int,@tenTacGia nvarchar(50),@gioiTinh nvarchar(3),@ngaySinh date,@trinhdo nvarchar(50) ,@coquan nvarchar(50)
as
	begin		
		update tb_tacgia
		set tenTacGia=@tenTacGia,gioiTinh=@gioiTinh,ngaySinh=@ngaySinh,trinhdo=@trinhdo,coquan=@coquan
		where maTacGia=@maTacGia;
	
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_in_cthoadon]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_in_cthoadon]
	@maHoaDon int
	as 
		begin
			declare @tong float;
			set @tong=0;
			select @tong= SUM( tb_cthoadon.soLuong * tb_sach.giaBia ) from tb_cthoadon,tb_sach where tb_cthoadon.maSach=tb_sach.maSach
			and maHoaDon=@maHoaDon
			
			select @maHoaDon as maHoaDon,tb_cthoadon.maSach,tb_sach.tenSach,tb_cthoadon.soLuong,tb_sach.giaBia, (tb_cthoadon.soLuong*tb_sach.giaBia) as [thanhtien], tb_hoadon.ngaylap,tb_khachhang.tenKhachHang,@tong as [tongtien]
			from tb_cthoadon,tb_sach,tb_hoadon,tb_khachhang
			where tb_sach.maSach=tb_cthoadon.maSach and tb_cthoadon.maHoaDon=tb_hoadon.maHoaDon and tb_hoadon.maKhachHang=tb_khachhang.maKhachHang and tb_cthoadon.maHoaDon=@maHoaDon

	end
GO
/****** Object:  StoredProcedure [dbo].[proc_in_ctphieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_in_ctphieunhap]
	@maPhieuNhap int
	as 
		begin
			declare @tong float;
			set @tong=0;
			select @tong= SUM( tb_ctphieunhap.soLuong * tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau) ) from tb_ctphieunhap,tb_sach,tb_phieunhap,tb_nhacungcap where  tb_ctphieunhap.maSach=tb_sach.maSach and tb_ctphieunhap.maPhieuNhap=tb_phieunhap.maPhieuNhap and tb_phieunhap.maNhaCungCap=tb_nhacungcap.maNhaCungCap and tb_ctphieunhap.maPhieuNhap =@maPhieuNhap
			
			
			select @maPhieuNhap as maPhieuNhap,tb_ctphieunhap.maSach,tb_sach.tenSach,tb_ctphieunhap.soLuong, tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau) as giaban, (tb_ctphieunhap.soLuong*(tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau))) as [thanhtien], tb_nhacungcap.tenNhaCungCap,tb_phieunhap.ngayNhap,@tong as [tongtien]
			from tb_ctphieunhap,tb_sach,tb_phieunhap,tb_nhacungcap
			where tb_sach.maSach=tb_ctphieunhap.maSach and tb_ctphieunhap.maPhieuNhap=tb_phieunhap.maPhieuNhap and tb_phieunhap.maNhaCungCap=tb_nhacungcap.maNhaCungCap  and tb_ctphieunhap.maPhieuNhap=@maPhieuNhap

	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_cthoadon]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_them_cthoadon]
	@maHoaDon int,@maSach int,@soLuong int
as
	begin		
		insert into tb_cthoadon(maHoaDon,maSach,soLuong) VALUES (@maHoaDon,@maSach,@soLuong);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_ctphieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_them_ctphieunhap]
	@maPhieuNhap int,@maSach int,@soLuong int
as
	begin		
		insert into tb_ctphieunhap(maPhieuNhap,maSach,soLuong) VALUES (@maPhieuNhap,@maSach,@soLuong);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_hd]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_them_hd]
	@maKhachHang int,@ngaylap date
as
	begin		
		insert into tb_hoadon(maKhachHang,ngaylap) VALUES (@maKhachHang,@ngaylap);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_kh]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_them_kh]
	@tenKhachHang nvarchar(50),@diaChi nvarchar(50),@sdtKH nchar(10)
as
	begin		
		insert into tb_khachhang(tenKhachHang,diachiKH,sdtKH) VALUES (@tenKhachHang,@diaChi,@sdtKH);
	end

	
GO
/****** Object:  StoredProcedure [dbo].[proc_them_loaisach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[proc_them_loaisach]
@tenLoaiSach nvarchar(50)
as
	begin		
		insert into tb_loaisach(tenLoaiSach) VALUES (@tenLoaiSach);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_ncc]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_them_ncc]
	@tenNhaCungCap nvarchar(50),@diaChi nvarchar(50),@sdtNhaCungCap nvarchar(10),@ghichu nvarchar(255),@chietkhau float
as
	begin		
		insert into tb_nhacungcap(tenNhaCungCap,diaChi,sdtNhaCungCap,ghichu,chietkhau) VALUES (@tenNhaCungCap,@diaChi,@sdtNhaCungCap,@ghichu,@chietkhau);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_nv]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_them_nv]
	@tenNhanVien nvarchar(50),@ngaySinh date,@sdtNhanVien nvarchar(10),@gioitinh nvarchar(3),@diaChi nvarchar(50)
as
	begin		
		insert into tb_nhanvien(tenNhanVien,ngaySinh,sdtNhanVien,gioitinh,diaChi) VALUES (@tenNhanVien,@ngaySinh,@sdtNhanVien,@gioitinh,@diaChi);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_phieunhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_them_phieunhap]
	@maNhanVien int,@maNhaCungCap int,@ngayNhap date
as
	begin		
		insert into tb_phieunhap(maNhanVien,maNhaCungCap,ngayNhap) VALUES (@maNhanVien,@maNhaCungCap,@ngayNhap);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_sach]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_them_sach]
@tenSach nvarchar(50),@maloaisach int,@maTacGia int,@namXuatBan date,@giaBia int
as
	begin		
		insert into tb_sach (maLoaiSach,tenSach,maTacGia,namXuatBan,giaBia) VALUES (@maloaisach,@tenSach,@maTacGia,@namXuatBan,@giaBia);
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_tacgia]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_them_tacgia]
@tenTacGia nvarchar(50),@gioiTinh nvarchar(3),@ngaySinh date,@trinhdo nvarchar(50) ,@coquan nvarchar(50)
as
	begin		
		insert into tb_tacgia(tenTacGia,gioiTinh,ngaySinh,trinhdo,coquan) VALUES (@tenTacGia,@gioiTinh,@ngaySinh,@trinhdo,@coquan);
	end
GO
/****** Object:  StoredProcedure [dbo].[spinsertdangnhap]    Script Date: 9/12/2021 3:49:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spinsertdangnhap]
	@username varchar(50),@password nvarchar(50),@position int
	as 
		begin
		  insert into tb_dangnhap(username,password,position) values(@username,@password,@position)
		  end
GO
