-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 12 Jan 2022 pada 08.44
-- Versi server: 10.4.21-MariaDB
-- Versi PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbreminder`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_reminder`
--

CREATE TABLE `tbl_reminder` (
  `reminder_pembuat` varchar(50) NOT NULL,
  `reminder_untuk` varchar(50) NOT NULL,
  `reminder_kode` varchar(50) NOT NULL,
  `reminder_tentang` varchar(75) NOT NULL,
  `reminder_detail` text NOT NULL,
  `reminder_tanggal` date NOT NULL,
  `reminder_tanggal_acara` datetime NOT NULL,
  `reminder_tanggal_dibuat` datetime NOT NULL,
  `reminder_status` varchar(20) NOT NULL,
  `reminder_tanggal_statusselesai` datetime NOT NULL,
  `reminder_selesai_note` text NOT NULL,
  `reminder_dihapus` varchar(5) NOT NULL,
  `reminder_tanggal_dihapus` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_reminder`
--

INSERT INTO `tbl_reminder` (`reminder_pembuat`, `reminder_untuk`, `reminder_kode`, `reminder_tentang`, `reminder_detail`, `reminder_tanggal`, `reminder_tanggal_acara`, `reminder_tanggal_dibuat`, `reminder_status`, `reminder_tanggal_statusselesai`, `reminder_selesai_note`, `reminder_dihapus`, `reminder_tanggal_dihapus`) VALUES
('ADMINISTRATOR', 'DIREKSI', 'RMD.DIR.2021.12.0001', 'KONTRAK PERJANJIAN PT SAMATOR', 'KONTRAK KERJASAMA HABIS BULAN DESEMBER', '2021-12-22', '2021-12-29 10:00:00', '2021-12-29 09:26:52', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', NULL),
('ADMINISTRATOR', 'DIREKSI', 'RMD.DIR.2021.12.0002', 'KUNJUNGAN PRESENTASI BALAI KOTA', 'PRESENTASI PELAYANAN RSOS KE BALAIKOTA', '2022-01-01', '2022-01-10 09:30:00', '2021-12-29 09:27:33', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', '0000-00-00 00:00:00'),
('ADMINISTRATOR', 'DIREKSI', 'RMD.DIR.2021.12.0003', 'TES REMINDER', '1', '2021-12-30', '2021-12-30 14:55:00', '2021-12-30 14:12:23', 'SELESAI', '2021-12-30 14:55:21', 'DISELESAIKAN DENGAN BAIK', 'YA', '2022-01-03 14:14:04'),
('ADMINISTRATOR', 'FARMASI', 'RMD.FM.2021.12.0001', 'PERTEMUAN DENGAN SALES KALBE', 'RAPAT MENGENAI KERJASAMA DENGAN KALBE', '2021-11-18', '2021-12-29 14:31:00', '2021-12-29 09:25:38', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', NULL),
('ADMINISTRATOR', 'FARMASI', 'RMD.FM.2021.12.0004', '1312', '121221', '2021-12-31', '2021-12-31 11:42:00', '2021-12-31 11:42:33', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'YA', '2021-12-31 14:47:27'),
('ADMINISTRATOR', 'IT', 'RMD.IT.2021.12.0001', 'ZOOM DENGAN DR. OEN', 'MEETING PERSIAPAN HUT YKI', '2021-11-17', '2021-11-20 10:00:00', '2021-12-29 09:24:26', 'SELESAI', '2021-12-29 14:34:53', 'SELESAI', 'TIDAK', NULL),
('ADMINISTRATOR', 'IT', 'RMD.IT.2021.12.0002', 'INPUT DIHAPUS MELALUI MENU UTAMA', 'TES', '2021-12-30', '2021-12-30 10:20:00', '2021-12-30 10:20:37', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'YA', '2021-12-30 10:20:58'),
('ADMINISTRATOR', 'LOGISTIK', 'RMD.LGS.2021.12.0001', 'INKASO TAHUNAN', 'LAPORAN INKASO TAHUNAN KE MANAJEMEN', '2022-01-20', '2022-01-25 09:30:00', '2021-12-29 09:28:06', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', NULL),
('ADMINISTRATOR', 'LOGISTIK', 'RMD.LGS.2021.12.0002', '123123', '123123', '2021-12-31', '2021-12-31 11:42:00', '2021-12-31 11:42:29', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'YA', '2021-12-31 14:47:31');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_reminderdireksi`
--

CREATE TABLE `tbl_reminderdireksi` (
  `reminder_pembuat` varchar(50) NOT NULL,
  `reminder_untuk` varchar(50) NOT NULL,
  `reminder_kode` varchar(50) NOT NULL,
  `reminder_tentang` varchar(75) NOT NULL,
  `reminder_detail` text NOT NULL,
  `reminder_tanggal` date NOT NULL,
  `reminder_tanggal_acara` datetime NOT NULL,
  `reminder_tanggal_dibuat` datetime NOT NULL,
  `reminder_status` varchar(20) NOT NULL,
  `reminder_tanggal_statusselesai` datetime NOT NULL,
  `reminder_selesai_note` text NOT NULL,
  `reminder_dihapus` varchar(5) NOT NULL,
  `reminder_tanggal_dihapus` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_reminderdireksi`
--

INSERT INTO `tbl_reminderdireksi` (`reminder_pembuat`, `reminder_untuk`, `reminder_kode`, `reminder_tentang`, `reminder_detail`, `reminder_tanggal`, `reminder_tanggal_acara`, `reminder_tanggal_dibuat`, `reminder_status`, `reminder_tanggal_statusselesai`, `reminder_selesai_note`, `reminder_dihapus`, `reminder_tanggal_dihapus`) VALUES
('ADMINISTRATOR', 'DIREKSI', 'RMD.DIR.2021.12.0001', 'KONTRAK PERJANJIAN PT SAMATOR', 'KONTRAK KERJASAMA HABIS BULAN DESEMBER', '2021-12-22', '2021-12-29 10:00:00', '2021-12-29 09:26:52', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', NULL),
('ADMINISTRATOR', 'DIREKSI', 'RMD.DIR.2021.12.0002', 'KUNJUNGAN PRESENTASI BALAI KOTA', 'PRESENTASI PELAYANAN RSOS KE BALAIKOTA', '2022-01-01', '2022-01-10 09:30:00', '2021-12-29 09:27:33', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', '0000-00-00 00:00:00'),
('ADMINISTRATOR', 'DIREKSI', 'RMD.DIR.2021.12.0003', 'TES REMINDER', '1', '2021-12-30', '2021-12-30 14:55:00', '2021-12-30 14:12:23', 'SELESAI', '2021-12-30 14:55:21', 'DISELESAIKAN DENGAN BAIK', 'YA', '2022-01-03 14:14:04');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_reminderfarmasi`
--

CREATE TABLE `tbl_reminderfarmasi` (
  `reminder_pembuat` varchar(50) NOT NULL,
  `reminder_untuk` varchar(50) NOT NULL,
  `reminder_kode` varchar(50) NOT NULL,
  `reminder_tentang` varchar(75) NOT NULL,
  `reminder_detail` text NOT NULL,
  `reminder_tanggal` date NOT NULL,
  `reminder_tanggal_acara` datetime NOT NULL,
  `reminder_tanggal_dibuat` datetime NOT NULL,
  `reminder_status` varchar(20) NOT NULL,
  `reminder_tanggal_statusselesai` datetime NOT NULL,
  `reminder_selesai_note` text NOT NULL,
  `reminder_dihapus` varchar(5) NOT NULL,
  `reminder_tanggal_dihapus` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_reminderfarmasi`
--

INSERT INTO `tbl_reminderfarmasi` (`reminder_pembuat`, `reminder_untuk`, `reminder_kode`, `reminder_tentang`, `reminder_detail`, `reminder_tanggal`, `reminder_tanggal_acara`, `reminder_tanggal_dibuat`, `reminder_status`, `reminder_tanggal_statusselesai`, `reminder_selesai_note`, `reminder_dihapus`, `reminder_tanggal_dihapus`) VALUES
('ADMINISTRATOR', 'FARMASI', 'RMD.FM.2021.12.0001', 'PERTEMUAN DENGAN SALES KALBE', 'RAPAT MENGENAI KERJASAMA DENGAN KALBE', '2021-11-18', '2021-12-29 14:31:00', '2021-12-29 09:25:38', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', NULL),
('ADMINISTRATOR', 'FARMASI', 'RMD.FM.2021.12.0004', '1312', '121221', '2021-12-31', '2021-12-31 11:42:00', '2021-12-31 11:42:33', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'YA', '2021-12-31 14:47:27');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_reminderit`
--

CREATE TABLE `tbl_reminderit` (
  `reminder_pembuat` varchar(50) NOT NULL,
  `reminder_untuk` varchar(50) NOT NULL,
  `reminder_kode` varchar(50) NOT NULL,
  `reminder_tentang` varchar(75) NOT NULL,
  `reminder_detail` text NOT NULL,
  `reminder_tanggal` date NOT NULL,
  `reminder_tanggal_acara` datetime NOT NULL,
  `reminder_tanggal_dibuat` datetime NOT NULL,
  `reminder_status` varchar(20) NOT NULL,
  `reminder_tanggal_statusselesai` datetime NOT NULL,
  `reminder_selesai_note` text NOT NULL,
  `reminder_dihapus` varchar(5) NOT NULL,
  `reminder_tanggal_dihapus` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_reminderit`
--

INSERT INTO `tbl_reminderit` (`reminder_pembuat`, `reminder_untuk`, `reminder_kode`, `reminder_tentang`, `reminder_detail`, `reminder_tanggal`, `reminder_tanggal_acara`, `reminder_tanggal_dibuat`, `reminder_status`, `reminder_tanggal_statusselesai`, `reminder_selesai_note`, `reminder_dihapus`, `reminder_tanggal_dihapus`) VALUES
('ADMINISTRATOR', 'IT', 'RMD.IT.2021.12.0001', 'ZOOM DENGAN DR. OEN', 'MEETING PERSIAPAN HUT YKI', '2021-11-17', '2021-11-20 10:00:00', '2021-12-29 09:24:26', 'SELESAI', '2021-12-29 14:34:53', 'SELESAI', 'TIDAK', NULL),
('ADMINISTRATOR', 'IT', 'RMD.IT.2021.12.0002', 'INPUT DIHAPUS MELALUI MENU UTAMA', 'TES', '2021-12-30', '2021-12-30 10:20:00', '2021-12-30 10:20:37', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'YA', '2021-12-30 10:20:58');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_reminderlogistik`
--

CREATE TABLE `tbl_reminderlogistik` (
  `reminder_pembuat` varchar(50) NOT NULL,
  `reminder_untuk` varchar(50) NOT NULL,
  `reminder_kode` varchar(50) NOT NULL,
  `reminder_tentang` varchar(75) NOT NULL,
  `reminder_detail` text NOT NULL,
  `reminder_tanggal` date NOT NULL,
  `reminder_tanggal_acara` datetime NOT NULL,
  `reminder_tanggal_dibuat` datetime NOT NULL,
  `reminder_status` varchar(20) NOT NULL,
  `reminder_tanggal_statusselesai` datetime NOT NULL,
  `reminder_selesai_note` text NOT NULL,
  `reminder_dihapus` varchar(5) NOT NULL,
  `reminder_tanggal_dihapus` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_reminderlogistik`
--

INSERT INTO `tbl_reminderlogistik` (`reminder_pembuat`, `reminder_untuk`, `reminder_kode`, `reminder_tentang`, `reminder_detail`, `reminder_tanggal`, `reminder_tanggal_acara`, `reminder_tanggal_dibuat`, `reminder_status`, `reminder_tanggal_statusselesai`, `reminder_selesai_note`, `reminder_dihapus`, `reminder_tanggal_dihapus`) VALUES
('ADMINISTRATOR', 'LOGISTIK', 'RMD.LGS.2021.12.0001', 'INKASO TAHUNAN', 'LAPORAN INKASO TAHUNAN KE MANAJEMEN', '2022-01-20', '2022-01-25 09:30:00', '2021-12-29 09:28:06', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'TIDAK', NULL),
('ADMINISTRATOR', 'LOGISTIK', 'RMD.LGS.2021.12.0002', '123123', '123123', '2021-12-31', '2021-12-31 11:42:00', '2021-12-31 11:42:29', 'BELUM TERLAKSANA', '0000-00-00 00:00:00', '', 'YA', '2021-12-31 14:47:31');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `user_id` varchar(10) NOT NULL,
  `user_name` varchar(30) NOT NULL,
  `user_pass` varchar(16) NOT NULL,
  `user_status` varchar(30) NOT NULL,
  `user_kode` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`user_id`, `user_name`, `user_pass`, `user_status`, `user_kode`) VALUES
('admin', 'ADMINISTRATOR', 'admin', 'admin', 'ADM'),
('direksi', 'DIREKSI', 'direksi', 'admin', 'DIR'),
('farmasi', 'FARMASI', 'farmasi', 'user', 'FM'),
('it', 'IT', 'it', 'user', 'IT'),
('logistik', 'LOGISTIK', 'logistik', 'user', 'LGS');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_reminder`
--
ALTER TABLE `tbl_reminder`
  ADD PRIMARY KEY (`reminder_kode`);

--
-- Indeks untuk tabel `tbl_reminderdireksi`
--
ALTER TABLE `tbl_reminderdireksi`
  ADD PRIMARY KEY (`reminder_kode`);

--
-- Indeks untuk tabel `tbl_reminderfarmasi`
--
ALTER TABLE `tbl_reminderfarmasi`
  ADD PRIMARY KEY (`reminder_kode`);

--
-- Indeks untuk tabel `tbl_reminderit`
--
ALTER TABLE `tbl_reminderit`
  ADD PRIMARY KEY (`reminder_kode`);

--
-- Indeks untuk tabel `tbl_reminderlogistik`
--
ALTER TABLE `tbl_reminderlogistik`
  ADD PRIMARY KEY (`reminder_kode`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
