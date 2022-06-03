
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/21/2022 02:33:42
-- Generated from EDMX file: D:\ltwin\endproj\ModelQLTV.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QLTV];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_NXBSach]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Saches] DROP CONSTRAINT [FK_NXBSach];
GO
IF OBJECT_ID(N'[dbo].[FK_TheLoaiSach]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Saches] DROP CONSTRAINT [FK_TheLoaiSach];
GO
IF OBJECT_ID(N'[dbo].[FK_SachTacGia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Saches] DROP CONSTRAINT [FK_SachTacGia];
GO
IF OBJECT_ID(N'[dbo].[FK_TheMuon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Muons] DROP CONSTRAINT [FK_TheMuon];
GO
IF OBJECT_ID(N'[dbo].[FK_MuonChiTietMuon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChiTietMuons] DROP CONSTRAINT [FK_MuonChiTietMuon];
GO
IF OBJECT_ID(N'[dbo].[FK_SachChiTietMuon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChiTietMuons] DROP CONSTRAINT [FK_SachChiTietMuon];
GO
IF OBJECT_ID(N'[dbo].[FK_YeuCauMuonThe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[YeuCauMuons] DROP CONSTRAINT [FK_YeuCauMuonThe];
GO
IF OBJECT_ID(N'[dbo].[FK_YeuCauMuonChiTietYeuCau]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChiTietYeuCaus] DROP CONSTRAINT [FK_YeuCauMuonChiTietYeuCau];
GO
IF OBJECT_ID(N'[dbo].[FK_SachChiTietYeuCau]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChiTietYeuCaus] DROP CONSTRAINT [FK_SachChiTietYeuCau];
GO
IF OBJECT_ID(N'[dbo].[FK_TheDocGia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Thes] DROP CONSTRAINT [FK_TheDocGia];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[NXBs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NXBs];
GO
IF OBJECT_ID(N'[dbo].[TheLoais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TheLoais];
GO
IF OBJECT_ID(N'[dbo].[TacGias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TacGias];
GO
IF OBJECT_ID(N'[dbo].[Saches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Saches];
GO
IF OBJECT_ID(N'[dbo].[Thes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Thes];
GO
IF OBJECT_ID(N'[dbo].[Muons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Muons];
GO
IF OBJECT_ID(N'[dbo].[DocGias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocGias];
GO
IF OBJECT_ID(N'[dbo].[ChiTietMuons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChiTietMuons];
GO
IF OBJECT_ID(N'[dbo].[YeuCauMuons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[YeuCauMuons];
GO
IF OBJECT_ID(N'[dbo].[ChiTietYeuCaus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChiTietYeuCaus];
GO
IF OBJECT_ID(N'[dbo].[TaiKhoans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TaiKhoans];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'NXBs'
CREATE TABLE [dbo].[NXBs] (
    [MaNXB] int IDENTITY(1,1) NOT NULL,
    [TenNXB] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TheLoais'
CREATE TABLE [dbo].[TheLoais] (
    [MaTheLoai] int IDENTITY(1,1) NOT NULL,
    [TenTheLoai] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TacGias'
CREATE TABLE [dbo].[TacGias] (
    [MaTacGia] int IDENTITY(1,1) NOT NULL,
    [TenTacGia] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Saches'
CREATE TABLE [dbo].[Saches] (
    [MaSach] int IDENTITY(1,1) NOT NULL,
    [MaNXB] int  NOT NULL,
    [MaTheLoai] int  NOT NULL,
    [MaTacGia] int  NOT NULL,
    [TenSach] nvarchar(max)  NOT NULL,
    [NamXB] int  NOT NULL,
    [SoLuong] int  NOT NULL
);
GO

-- Creating table 'Thes'
CREATE TABLE [dbo].[Thes] (
    [MaThe] int IDENTITY(1,1) NOT NULL,
    [NgayBatDau] datetime  NOT NULL,
    [NgayKetThuc] datetime  NOT NULL,
    [GhiChu] nvarchar(max)  NULL,
    [MaDG] int  NOT NULL
);
GO

-- Creating table 'Muons'
CREATE TABLE [dbo].[Muons] (
    [MaMuon] int IDENTITY(1,1) NOT NULL,
    [MaThe] int  NOT NULL,
    [NgayMuon] datetime  NOT NULL,
    [GhiChu] nvarchar(max)  NULL
);
GO

-- Creating table 'DocGias'
CREATE TABLE [dbo].[DocGias] (
    [MaDG] int IDENTITY(1,1) NOT NULL,
    [TenDG] nvarchar(max)  NOT NULL,
    [DiaChi] nvarchar(max)  NULL,
    [SDT] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ChiTietMuons'
CREATE TABLE [dbo].[ChiTietMuons] (
    [MaMuon] int  NOT NULL,
    [MaSach] int  NOT NULL,
    [DaTra] int  NOT NULL,
    [NgayTra] datetime  NULL,
    [NgayHetHan] datetime  NOT NULL,
    [TinhTrangSach] nvarchar(max)  NULL
);
GO

-- Creating table 'YeuCauMuons'
CREATE TABLE [dbo].[YeuCauMuons] (
    [MaYC] int IDENTITY(1,1) NOT NULL,
    [MaThe] int  NOT NULL,
    [NgayYeuCau] datetime  NOT NULL
);
GO

-- Creating table 'ChiTietYeuCaus'
CREATE TABLE [dbo].[ChiTietYeuCaus] (
    [MaYC] int  NOT NULL,
    [MaSach] int  NOT NULL,
    [SoLuong] int  NOT NULL
);
GO

-- Creating table 'TaiKhoans'
CREATE TABLE [dbo].[TaiKhoans] (
    [MaTaiKhoan] int IDENTITY(1,1) NOT NULL,
    [TenDangNhap] nvarchar(max)  NOT NULL,
    [MatKhau] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MaNXB] in table 'NXBs'
ALTER TABLE [dbo].[NXBs]
ADD CONSTRAINT [PK_NXBs]
    PRIMARY KEY CLUSTERED ([MaNXB] ASC);
GO

-- Creating primary key on [MaTheLoai] in table 'TheLoais'
ALTER TABLE [dbo].[TheLoais]
ADD CONSTRAINT [PK_TheLoais]
    PRIMARY KEY CLUSTERED ([MaTheLoai] ASC);
GO

-- Creating primary key on [MaTacGia] in table 'TacGias'
ALTER TABLE [dbo].[TacGias]
ADD CONSTRAINT [PK_TacGias]
    PRIMARY KEY CLUSTERED ([MaTacGia] ASC);
GO

-- Creating primary key on [MaSach] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [PK_Saches]
    PRIMARY KEY CLUSTERED ([MaSach] ASC);
GO

-- Creating primary key on [MaThe] in table 'Thes'
ALTER TABLE [dbo].[Thes]
ADD CONSTRAINT [PK_Thes]
    PRIMARY KEY CLUSTERED ([MaThe] ASC);
GO

-- Creating primary key on [MaMuon] in table 'Muons'
ALTER TABLE [dbo].[Muons]
ADD CONSTRAINT [PK_Muons]
    PRIMARY KEY CLUSTERED ([MaMuon] ASC);
GO

-- Creating primary key on [MaDG] in table 'DocGias'
ALTER TABLE [dbo].[DocGias]
ADD CONSTRAINT [PK_DocGias]
    PRIMARY KEY CLUSTERED ([MaDG] ASC);
GO

-- Creating primary key on [MaSach], [MaMuon] in table 'ChiTietMuons'
ALTER TABLE [dbo].[ChiTietMuons]
ADD CONSTRAINT [PK_ChiTietMuons]
    PRIMARY KEY CLUSTERED ([MaSach], [MaMuon] ASC);
GO

-- Creating primary key on [MaYC] in table 'YeuCauMuons'
ALTER TABLE [dbo].[YeuCauMuons]
ADD CONSTRAINT [PK_YeuCauMuons]
    PRIMARY KEY CLUSTERED ([MaYC] ASC);
GO

-- Creating primary key on [MaYC], [MaSach] in table 'ChiTietYeuCaus'
ALTER TABLE [dbo].[ChiTietYeuCaus]
ADD CONSTRAINT [PK_ChiTietYeuCaus]
    PRIMARY KEY CLUSTERED ([MaYC], [MaSach] ASC);
GO

-- Creating primary key on [MaTaiKhoan] in table 'TaiKhoans'
ALTER TABLE [dbo].[TaiKhoans]
ADD CONSTRAINT [PK_TaiKhoans]
    PRIMARY KEY CLUSTERED ([MaTaiKhoan] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaNXB] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [FK_NXBSach]
    FOREIGN KEY ([MaNXB])
    REFERENCES [dbo].[NXBs]
        ([MaNXB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NXBSach'
CREATE INDEX [IX_FK_NXBSach]
ON [dbo].[Saches]
    ([MaNXB]);
GO

-- Creating foreign key on [MaTheLoai] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [FK_TheLoaiSach]
    FOREIGN KEY ([MaTheLoai])
    REFERENCES [dbo].[TheLoais]
        ([MaTheLoai])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TheLoaiSach'
CREATE INDEX [IX_FK_TheLoaiSach]
ON [dbo].[Saches]
    ([MaTheLoai]);
GO

-- Creating foreign key on [MaTacGia] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [FK_SachTacGia]
    FOREIGN KEY ([MaTacGia])
    REFERENCES [dbo].[TacGias]
        ([MaTacGia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SachTacGia'
CREATE INDEX [IX_FK_SachTacGia]
ON [dbo].[Saches]
    ([MaTacGia]);
GO

-- Creating foreign key on [MaThe] in table 'Muons'
ALTER TABLE [dbo].[Muons]
ADD CONSTRAINT [FK_TheMuon]
    FOREIGN KEY ([MaThe])
    REFERENCES [dbo].[Thes]
        ([MaThe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TheMuon'
CREATE INDEX [IX_FK_TheMuon]
ON [dbo].[Muons]
    ([MaThe]);
GO

-- Creating foreign key on [MaMuon] in table 'ChiTietMuons'
ALTER TABLE [dbo].[ChiTietMuons]
ADD CONSTRAINT [FK_MuonChiTietMuon]
    FOREIGN KEY ([MaMuon])
    REFERENCES [dbo].[Muons]
        ([MaMuon])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MuonChiTietMuon'
CREATE INDEX [IX_FK_MuonChiTietMuon]
ON [dbo].[ChiTietMuons]
    ([MaMuon]);
GO

-- Creating foreign key on [MaSach] in table 'ChiTietMuons'
ALTER TABLE [dbo].[ChiTietMuons]
ADD CONSTRAINT [FK_SachChiTietMuon]
    FOREIGN KEY ([MaSach])
    REFERENCES [dbo].[Saches]
        ([MaSach])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaThe] in table 'YeuCauMuons'
ALTER TABLE [dbo].[YeuCauMuons]
ADD CONSTRAINT [FK_YeuCauMuonThe]
    FOREIGN KEY ([MaThe])
    REFERENCES [dbo].[Thes]
        ([MaThe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_YeuCauMuonThe'
CREATE INDEX [IX_FK_YeuCauMuonThe]
ON [dbo].[YeuCauMuons]
    ([MaThe]);
GO

-- Creating foreign key on [MaYC] in table 'ChiTietYeuCaus'
ALTER TABLE [dbo].[ChiTietYeuCaus]
ADD CONSTRAINT [FK_YeuCauMuonChiTietYeuCau]
    FOREIGN KEY ([MaYC])
    REFERENCES [dbo].[YeuCauMuons]
        ([MaYC])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaSach] in table 'ChiTietYeuCaus'
ALTER TABLE [dbo].[ChiTietYeuCaus]
ADD CONSTRAINT [FK_SachChiTietYeuCau]
    FOREIGN KEY ([MaSach])
    REFERENCES [dbo].[Saches]
        ([MaSach])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SachChiTietYeuCau'
CREATE INDEX [IX_FK_SachChiTietYeuCau]
ON [dbo].[ChiTietYeuCaus]
    ([MaSach]);
GO

-- Creating foreign key on [MaDG] in table 'Thes'
ALTER TABLE [dbo].[Thes]
ADD CONSTRAINT [FK_TheDocGia]
    FOREIGN KEY ([MaDG])
    REFERENCES [dbo].[DocGias]
        ([MaDG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TheDocGia'
CREATE INDEX [IX_FK_TheDocGia]
ON [dbo].[Thes]
    ([MaDG]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------