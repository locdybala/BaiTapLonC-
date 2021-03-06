USE [master]
GO
/****** Object:  Database [QUANLYBANSACH]    Script Date: 5/12/2021 12:05:58 AM ******/
CREATE DATABASE [QUANLYBANSACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYBANSACH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QUANLYBANSACH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYBANSACH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QUANLYBANSACH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QUANLYBANSACH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYBANSACH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYBANSACH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYBANSACH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYBANSACH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYBANSACH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYBANSACH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYBANSACH] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYBANSACH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYBANSACH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYBANSACH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYBANSACH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYBANSACH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYBANSACH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYBANSACH', N'ON'
GO
ALTER DATABASE [QUANLYBANSACH] SET QUERY_STORE = OFF
GO
USE [QUANLYBANSACH]
GO
/****** Object:  Table [dbo].[tb_hoadon]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_hoadon](
	[maHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[maNhanVien] [int] NULL,
	[sdtKhachHang] [nvarchar](10) NULL,
	[ngayXuat] [date] NULL,
 CONSTRAINT [PK_tb_hoadon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_khachhang]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_khachhang](
	[sdtKhachHang] [nvarchar](10) NOT NULL,
	[tenKhachHang] [nvarchar](50) NULL,
	[diaChiKhachHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_khachhang] PRIMARY KEY CLUSTERED 
(
	[sdtKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[tenNhanVien] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[sdtNhanVien] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_sach]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_sach](
	[maSach] [int] IDENTITY(1,1) NOT NULL,
	[maLoaiSach] [int] NULL,
	[tenSach] [nvarchar](50) NULL,
	[maTacGia] [int] NULL,
	[namXuatBan] [date] NULL,
	[giaSach] [int] NULL,
 CONSTRAINT [PK_tb_sach] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_chitiethoadon]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_chitiethoadon](
	[maHoaDon] [int] NOT NULL,
	[maSach] [int] NULL,
	[soLuongBan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_CTPX]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_CTPX] as 
 SELECT tb_hoadon.maHoaDon, tb_NhanVien.tenNhanVien,tb_khachhang.tenKhachHang,tb_hoadon.ngayXuat,tb_sach.tenSach,tb_sach.giaSach, tb_chitiethoadon.soLuongBan, 
 (tb_chitiethoadon.soLuongBan*tb_sach.giaSach) as thanhTien,
 

 (Select Sum(tb_sach.giaSach* tb_chitiethoadon.soLuongBan) from tb_chitiethoadon,tb_sach where tb_sach.maSach=tb_chitiethoadon.maSach) as TongTien

 from
  tb_hoadon,tb_NhanVien,tb_khachhang,tb_sach,tb_chitiethoadon 
 where  
  tb_hoadon.maHoaDon=tb_chitiethoadon.maHoaDon and tb_hoadon.maNhanVien= tb_NhanVien.maNhanVien and tb_hoadon.sdtKhachHang=tb_khachhang.sdtKhachHang and tb_sach.maSach=tb_chitiethoadon.maSach
GO
/****** Object:  Table [dbo].[tb_nhacungcap]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_nhacungcap](
	[maNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[tenNhaCungCap] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[sdtNhaCungCap] [nvarchar](50) NULL,
	[chietKhau] [int] NULL,
	[ghiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[maNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_phieunhap]    Script Date: 5/12/2021 12:05:58 AM ******/
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
/****** Object:  Table [dbo].[tb_ctphieunhap]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ctphieunhap](
	[maPhieuNhap] [int] NOT NULL,
	[maSach] [int] NULL,
	[soLuongNhap] [int] NULL,
	[giaNhap] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_gianhap]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_gianhap] as
 Select tb_sach.maSach, tb_sach.giaSach*(1-(tb_nhacungcap.chietKhau/100)) as giaNhap from tb_sach,tb_nhacungcap,tb_ctphieunhap,tb_phieunhap where tb_sach.maSach=tb_ctphieunhap.maSach and tb_nhacungcap.maNhaCungCap=tb_phieunhap.maNhaCungCap and tb_phieunhap.maPhieuNhap=tb_ctphieunhap.maPhieuNhap
GO
/****** Object:  View [dbo].[v_CTPN]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[v_CTPN] as
 Select tb_phieunhap.maPhieuNhap,tb_NhanVien.tenNhanVien,tb_nhacungcap.tenNhaCungCap,tb_phieunhap.ngayNhap,tb_sach.tenSach,
 v_gianhap.giaNhap,
 tb_ctphieunhap.soLuongNhap,
 (v_gianhap.giaNhap*tb_ctphieunhap.soLuongNhap) as thanhTien,
 (select sum(v_gianhap.giaNhap*tb_ctphieunhap.soLuongNhap) from v_gianhap,tb_sach,tb_ctphieunhap where tb_sach.maSach=v_gianhap.maSach and tb_sach.maSach=tb_ctphieunhap.maSach) as TongTien
 from tb_sach,tb_ctphieunhap,tb_phieunhap,tb_nhacungcap,tb_NhanVien,v_gianhap 
 where tb_sach.maSach= tb_ctphieunhap.maSach and tb_sach.maSach=v_gianhap.maSach and tb_nhacungcap.maNhaCungCap=tb_phieunhap.maNhaCungCap and tb_NhanVien.maNhanVien=tb_phieunhap.maNhanVien and tb_phieunhap.maPhieuNhap=tb_ctphieunhap.maPhieuNhap
GO
/****** Object:  Table [dbo].[tb_loaisach]    Script Date: 5/12/2021 12:05:58 AM ******/
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
/****** Object:  Table [dbo].[tb_tacgia]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_tacgia](
	[maTacGia] [int] IDENTITY(1,1) NOT NULL,
	[tenTacGia] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[trinhDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_tacgia] PRIMARY KEY CLUSTERED 
(
	[maTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_taikhoan]    Script Date: 5/12/2021 12:05:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_taikhoan](
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_taikhoan] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_chitiethoadon_tb_hoadon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[tb_hoadon] ([maHoaDon])
GO
ALTER TABLE [dbo].[tb_chitiethoadon] CHECK CONSTRAINT [FK_tb_chitiethoadon_tb_hoadon]
GO
ALTER TABLE [dbo].[tb_chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_chitiethoadon_tb_sach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tb_sach] ([maSach])
GO
ALTER TABLE [dbo].[tb_chitiethoadon] CHECK CONSTRAINT [FK_tb_chitiethoadon_tb_sach]
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
ALTER TABLE [dbo].[tb_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_hoadon_tb_khachhang] FOREIGN KEY([sdtKhachHang])
REFERENCES [dbo].[tb_khachhang] ([sdtKhachHang])
GO
ALTER TABLE [dbo].[tb_hoadon] CHECK CONSTRAINT [FK_tb_hoadon_tb_khachhang]
GO
ALTER TABLE [dbo].[tb_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_tb_hoadon_tb_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[tb_NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[tb_hoadon] CHECK CONSTRAINT [FK_tb_hoadon_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_phieunhap_tb_nhacungcap] FOREIGN KEY([maNhaCungCap])
REFERENCES [dbo].[tb_nhacungcap] ([maNhaCungCap])
GO
ALTER TABLE [dbo].[tb_phieunhap] CHECK CONSTRAINT [FK_tb_phieunhap_tb_nhacungcap]
GO
ALTER TABLE [dbo].[tb_phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_tb_phieunhap_tb_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[tb_NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[tb_phieunhap] CHECK CONSTRAINT [FK_tb_phieunhap_tb_NhanVien]
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
USE [master]
GO
ALTER DATABASE [QUANLYBANSACH] SET  READ_WRITE 
GO
