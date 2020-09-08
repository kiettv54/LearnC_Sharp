-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th6 28, 2020 lúc 04:09 PM
-- Phiên bản máy phục vụ: 10.4.11-MariaDB
-- Phiên bản PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `quanlykns`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `baiviet`
--

CREATE TABLE `baiviet` (
  `MaBV` int(11) NOT NULL,
  `MaHD` int(11) NOT NULL,
  `TenBV` varchar(100) NOT NULL,
  `NoiDungTT` varchar(3000) NOT NULL,
  `NoiDungCT` varchar(10000) NOT NULL,
  `NgayTao` datetime DEFAULT NULL,
  `ThoigianKT` datetime NOT NULL,
  `HinhBV` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `devvn_tinhthanhpho`
--

CREATE TABLE `devvn_tinhthanhpho` (
  `matp` varchar(5) CHARACTER SET utf8 NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 NOT NULL,
  `type` varchar(30) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Đang đổ dữ liệu cho bảng `devvn_tinhthanhpho`
--

INSERT INTO `devvn_tinhthanhpho` (`matp`, `name`, `type`) VALUES
('01', 'Thành phố Hà Nội', 'Thành phố Trung ương'),
('02', 'Tỉnh Hà Giang', 'Tỉnh'),
('04', 'Tỉnh Cao Bằng', 'Tỉnh'),
('06', 'Tỉnh Bắc Kạn', 'Tỉnh'),
('08', 'Tỉnh Tuyên Quang', 'Tỉnh'),
('10', 'Tỉnh Lào Cai', 'Tỉnh'),
('11', 'Tỉnh Điện Biên', 'Tỉnh'),
('12', 'Tỉnh Lai Châu', 'Tỉnh'),
('14', 'Tỉnh Sơn La', 'Tỉnh'),
('15', 'Tỉnh Yên Bái', 'Tỉnh'),
('17', 'Tỉnh Hoà Bình', 'Tỉnh'),
('19', 'Tỉnh Thái Nguyên', 'Tỉnh'),
('20', 'Tỉnh Lạng Sơn', 'Tỉnh'),
('22', 'Tỉnh Quảng Ninh', 'Tỉnh'),
('24', 'Tỉnh Bắc Giang', 'Tỉnh'),
('25', 'Tỉnh Phú Thọ', 'Tỉnh'),
('26', 'Tỉnh Vĩnh Phúc', 'Tỉnh'),
('27', 'Tỉnh Bắc Ninh', 'Tỉnh'),
('30', 'Tỉnh Hải Dương', 'Tỉnh'),
('31', 'Thành phố Hải Phòng', 'Thành phố Trung ương'),
('33', 'Tỉnh Hưng Yên', 'Tỉnh'),
('34', 'Tỉnh Thái Bình', 'Tỉnh'),
('35', 'Tỉnh Hà Nam', 'Tỉnh'),
('36', 'Tỉnh Nam Định', 'Tỉnh'),
('37', 'Tỉnh Ninh Bình', 'Tỉnh'),
('38', 'Tỉnh Thanh Hóa', 'Tỉnh'),
('40', 'Tỉnh Nghệ An', 'Tỉnh'),
('42', 'Tỉnh Hà Tĩnh', 'Tỉnh'),
('44', 'Tỉnh Quảng Bình', 'Tỉnh'),
('45', 'Tỉnh Quảng Trị', 'Tỉnh'),
('46', 'Tỉnh Thừa Thiên Huế', 'Tỉnh'),
('48', 'Thành phố Đà Nẵng', 'Thành phố Trung ương'),
('49', 'Tỉnh Quảng Nam', 'Tỉnh'),
('51', 'Tỉnh Quảng Ngãi', 'Tỉnh'),
('52', 'Tỉnh Bình Định', 'Tỉnh'),
('54', 'Tỉnh Phú Yên', 'Tỉnh'),
('56', 'Tỉnh Khánh Hòa', 'Tỉnh'),
('58', 'Tỉnh Ninh Thuận', 'Tỉnh'),
('60', 'Tỉnh Bình Thuận', 'Tỉnh'),
('62', 'Tỉnh Kon Tum', 'Tỉnh'),
('64', 'Tỉnh Gia Lai', 'Tỉnh'),
('66', 'Tỉnh Đắk Lắk', 'Tỉnh'),
('67', 'Tỉnh Đắk Nông', 'Tỉnh'),
('68', 'Tỉnh Lâm Đồng', 'Tỉnh'),
('70', 'Tỉnh Bình Phước', 'Tỉnh'),
('72', 'Tỉnh Tây Ninh', 'Tỉnh'),
('74', 'Tỉnh Bình Dương', 'Tỉnh'),
('75', 'Tỉnh Đồng Nai', 'Tỉnh'),
('77', 'Tỉnh Bà Rịa - Vũng Tàu', 'Tỉnh'),
('79', 'Thành phố Hồ Chí Minh', 'Thành phố Trung ương'),
('80', 'Tỉnh Long An', 'Tỉnh'),
('82', 'Tỉnh Tiền Giang', 'Tỉnh'),
('83', 'Tỉnh Bến Tre', 'Tỉnh'),
('84', 'Tỉnh Trà Vinh', 'Tỉnh'),
('86', 'Tỉnh Vĩnh Long', 'Tỉnh'),
('87', 'Tỉnh Đồng Tháp', 'Tỉnh'),
('89', 'Tỉnh An Giang', 'Tỉnh'),
('91', 'Tỉnh Kiên Giang', 'Tỉnh'),
('92', 'Thành phố Cần Thơ', 'Thành phố Trung ương'),
('93', 'Tỉnh Hậu Giang', 'Tỉnh'),
('94', 'Tỉnh Sóc Trăng', 'Tỉnh'),
('95', 'Tỉnh Bạc Liêu', 'Tỉnh'),
('96', 'Tỉnh Cà Mau', 'Tỉnh');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoatdong`
--

CREATE TABLE `hoatdong` (
  `MaHD` int(11) NOT NULL,
  `TenHD` varchar(200) NOT NULL,
  `NgayTao` datetime NOT NULL,
  `DiaDiem` varchar(200) NOT NULL,
  `VBTrienKhai` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `quyen`
--

CREATE TABLE `quyen` (
  `MaQuyen` int(11) NOT NULL,
  `TenQuyen` varchar(50) NOT NULL,
  `MoTa` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `quyen`
--

INSERT INTO `quyen` (`MaQuyen`, `TenQuyen`, `MoTa`) VALUES
(1, 'Quản trị viên', 'Toàn quyền xử lý'),
(2, 'Biên tập viên', 'tạo mới,chỉnh sửa hoạt động ,bài viết'),
(3, 'thành viên', 'xem ,đăng ký hoạt động  và bài viết,chỉnh sửa hồ sơ');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thanhvien`
--

CREATE TABLE `thanhvien` (
  `MSSV` varchar(10) NOT NULL,
  `HoTen` varchar(50) NOT NULL,
  `MatKhau` varchar(130) NOT NULL,
  `MaLop` varchar(10) NOT NULL,
  `GioiTinh` varchar(5) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `NgaySinh` date DEFAULT NULL,
  `matp` varchar(5) DEFAULT NULL,
  `DienThoai` varchar(11) DEFAULT NULL,
  `HinhTV` varchar(50) DEFAULT NULL,
  `MaQuyen` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thanhvien`
--

INSERT INTO `thanhvien` (`MSSV`, `HoTen`, `MatKhau`, `MaLop`, `GioiTinh`, `Email`, `NgaySinh`, `matp`, `DienThoai`, `HinhTV`, `MaQuyen`) VALUES
('110117058', 'Nguyễn Huỳnh Hữu Tài', 'fefe48760c08a366897fd2a451eb6a3b0f7a625d149da7fb78b8e7b9e2f4ee5216a53f1883f2d7d9f2d7d8062beffd571020c21230b49f2f4b24fd0d6557657e', 'DA17TT', 'Nam', '110117058@sv.tvu.edu.vn', '1999-01-01', '84', '0123456789', NULL, 1),
('110117071', 'Nguyễn Hoàng Duy', '212d643b48c56e1a7c90b4055de7e7991ef3bee928cd342b08af9b73f7bd859fa58b437337c38811654bc7e9c45ef59b9ecda5f37a291da636794d2ade8e2724', 'DA17TT', 'Nam', '110117071@sv.tvu.edu.vn', NULL, NULL, NULL, NULL, 3),
('110117072', 'Dương Quốc Tuấn', 'c4250427dbfa9b2ef8fa928dafae700fd2f06edb413baa27869c0892d23f724b42fc8153d2303ceaf883824311464b08bc89b7a4e15611aed41dac791b49956e', 'DA17TT', 'Nam', '110117072@sv.tvu.edu.vn', NULL, NULL, NULL, NULL, 3),
('110117073', 'Nguyễn Văn Toàn', '8ba7289eba1c6edea41d7c0c3c9c4801e20e854740699d2ab505a6b4786442607dda3e494c33ade533f590957e64e65218ad174d90d5227ece82649e9ce4b465', 'DA17TT', 'Nam', '110117073@sv.tvu.edu.vn', NULL, NULL, NULL, NULL, 3),
('110117074', 'Phan Tuấn Kiệt', '351160ccb34201e736923bcade0882697a3c15e29bb524fc1a904e5fd66ffa677613f2bf0609106a8ea3e8bdb64e0a251f486e79b9133dc06580c29e97bc7000', 'DA17TT', 'Nam', '110117074@sv.tvu.edu.vn', '1999-04-05', '84', '0866850454', 'ak.jpg', 1),
('110117075', 'Huỳnh Diệu Hòa', '7617dfca7b0270ff01579bf3b59d46a401b3ad1fc5539bd0ff303d2297669f9fb791ed324103f7413668e31e635a5da37ba2d6d590770622c4ca31885e3570fc', 'DA17TT', 'Nam', '110117075@sv.tvu.edu.vn', NULL, NULL, NULL, NULL, 3),
('110117076', 'Nguyễn Thanh Hải', 'd6ec43f9044a112218cb79eaa33934d5b7dd117980d699642c6471a85a68f2ed2e9cfc1ead5a74abcceca0f57906754bc0577b22a57d2de532780e6076c49637', 'DA17TT', 'Nam', '110117076@sv.tvu.edu.vn', NULL, NULL, NULL, NULL, 3);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thanhvienbaiviets`
--

CREATE TABLE `thanhvienbaiviets` (
  `MaTVBV` int(11) NOT NULL,
  `MSSV` varchar(10) NOT NULL,
  `MaBV` int(11) NOT NULL,
  `NgayDK` datetime NOT NULL,
  `TrangThai` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `baiviet`
--
ALTER TABLE `baiviet`
  ADD PRIMARY KEY (`MaBV`),
  ADD KEY `hoatdongbaiviet` (`MaHD`);

--
-- Chỉ mục cho bảng `devvn_tinhthanhpho`
--
ALTER TABLE `devvn_tinhthanhpho`
  ADD PRIMARY KEY (`matp`);

--
-- Chỉ mục cho bảng `hoatdong`
--
ALTER TABLE `hoatdong`
  ADD PRIMARY KEY (`MaHD`);

--
-- Chỉ mục cho bảng `quyen`
--
ALTER TABLE `quyen`
  ADD PRIMARY KEY (`MaQuyen`);

--
-- Chỉ mục cho bảng `thanhvien`
--
ALTER TABLE `thanhvien`
  ADD PRIMARY KEY (`MSSV`),
  ADD KEY `thanhvienquyen` (`MaQuyen`);

--
-- Chỉ mục cho bảng `thanhvienbaiviets`
--
ALTER TABLE `thanhvienbaiviets`
  ADD PRIMARY KEY (`MaTVBV`),
  ADD KEY `thanhvienbv` (`MaBV`),
  ADD KEY `thanhvientgbaiviet` (`MSSV`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `baiviet`
--
ALTER TABLE `baiviet`
  MODIFY `MaBV` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `hoatdong`
--
ALTER TABLE `hoatdong`
  MODIFY `MaHD` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `quyen`
--
ALTER TABLE `quyen`
  MODIFY `MaQuyen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `thanhvienbaiviets`
--
ALTER TABLE `thanhvienbaiviets`
  MODIFY `MaTVBV` int(11) NOT NULL AUTO_INCREMENT;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `baiviet`
--
ALTER TABLE `baiviet`
  ADD CONSTRAINT `hoatdongbaiviet` FOREIGN KEY (`MaHD`) REFERENCES `hoatdong` (`MaHD`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `thanhvien`
--
ALTER TABLE `thanhvien`
  ADD CONSTRAINT `thanhvien_ibfk_1` FOREIGN KEY (`MaQuyen`) REFERENCES `quyen` (`MaQuyen`);

--
-- Các ràng buộc cho bảng `thanhvienbaiviets`
--
ALTER TABLE `thanhvienbaiviets`
  ADD CONSTRAINT `thanhvienbv` FOREIGN KEY (`MaBV`) REFERENCES `baiviet` (`MaBV`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `thanhvientgbaiviet` FOREIGN KEY (`MSSV`) REFERENCES `thanhvien` (`MSSV`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
