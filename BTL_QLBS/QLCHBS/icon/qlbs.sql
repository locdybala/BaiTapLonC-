USE [qlbs]
GO
/****** Object:  Table [dbo].[tb_sach]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  View [dbo].[sach]    Script Date: 5/11/2021 10:46:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sach] as
	select * from tb_sach
GO
/****** Object:  Table [dbo].[tb_admin]    Script Date: 5/11/2021 10:46:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_admin](
	[id] [int] NOT NULL,
	[tenhienthi] [nvarchar](50) NULL,
	[tendangnhap] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_cthoadon]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_ctphieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_hoadon]    Script Date: 5/11/2021 10:46:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_hoadon](
	[maHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[maKhachHang] [int] NULL,
	[ngaylap] [date] NULL,
 CONSTRAINT [PK_tb_hoadon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_khachhang]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_loaisach]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_nhacungcap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_nhanvien]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_phieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  Table [dbo].[tb_tacgia]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_cthoadon]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_ctphieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_hd]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_kh]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_loaisach]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_ncc]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_nv]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_phieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_sach]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_cap_nhap_tacgia]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_in_cthoadon]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_in_ctphieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
			
			
			select @maPhieuNhap as maPhieuNhap,tb_ctphieunhap.maSach,tb_sach.tenSach,tb_ctphieunhap.soLuong, tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau) as giaban, ( tb_ctphieunhap.soLuong * tb_sach.giaBia-(tb_sach.giaBia*tb_nhacungcap.chietkhau) ) as [thanhtien], tb_nhacungcap.tenNhaCungCap,tb_phieunhap.ngayNhap,@tong as [tongtien]
			from tb_ctphieunhap,tb_sach,tb_phieunhap,tb_nhacungcap
			where tb_sach.maSach=tb_ctphieunhap.maSach and tb_ctphieunhap.maPhieuNhap=tb_phieunhap.maPhieuNhap and tb_phieunhap.maNhaCungCap=tb_nhacungcap.maNhaCungCap  and tb_ctphieunhap.maPhieuNhap=@maPhieuNhap

	end
GO
/****** Object:  StoredProcedure [dbo].[proc_them_cthoadon]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_ctphieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_hd]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_kh]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_loaisach]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_ncc]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_nv]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_phieunhap]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_sach]    Script Date: 5/11/2021 10:46:08 AM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_them_tacgia]    Script Date: 5/11/2021 10:46:08 AM ******/
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
