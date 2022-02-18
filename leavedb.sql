-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 18, 2015 at 06:32 AM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `leavedb`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE IF NOT EXISTS `employee` (
  `EMPID` varchar(60) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` varchar(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` varchar(25) DEFAULT NULL,
  `REMAININGLEAVE` double NOT NULL,
  `DEFAULTLEAVE` double NOT NULL,
  `ONLEAVE` tinyint(1) NOT NULL,
  PRIMARY KEY (`EMPID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`, `REMAININGLEAVE`, `DEFAULTLEAVE`, `ONLEAVE`) VALUES
('0000110', 'Shermaine', 'Layam', 'Canete', 'Coloso St., Kabankalan City', '09187477496', 'Single', '1991-07-05', 'Coloso St., Kabankalan City\n', 'FEMALE', NULL, '09178598695', 30, 30, 0),
('0000111', 'Airish', 'Tabujara', 'Baluyot', 'Tuyom, Cauayan, Negros Occidental', '09123445456', 'Single', '1990-04-01', 'Tuyom, Cauayan, Negros Occidental\n', 'FEMALE', NULL, '09098324732', 26, 30, 1),
('0000112', 'Justine Ann', 'Gomez', 'Lopez', 'Kabankalan City', '09087234548', 'Single', '1990-04-07', 'Kabankalan City\n', 'FEMALE', NULL, '09098732463', 29, 30, 1),
('0000113', 'Janno', 'Palacios', 'Echalar', 'Socorro, Kabankalan City', '09097364743', 'Single', '1989-06-05', 'Socorro, Kabankalan City\n', 'MALE', NULL, '09083547782', 29, 30, 1),
('0000114', 'Joeane Mar', 'Genit', 'Shen', 'Kabankalan City', '09123546788', 'Married', '1987-05-04', 'Kabankalan City\n', 'MALE', NULL, '09092124327', 24, 30, 1),
('0000115', 'Cedrex', 'Caguales', 'Pandoy', 'Burgos St., Kabankalan City', '09087623647', 'Married', '1990-05-05', 'Burgos St., Kabankalan City\n', 'MALE', NULL, '09125465476', 19, 30, 1),
('0000116', 'Jed', 'Castro', 'Chu', 'Mabua, Cauayan, Negros Occidental', '09122343535', 'Single', '1990-05-04', 'Mabua, Cauayan, Negros Occidental\n', 'MALE', NULL, '09123435646', 22.5, 30, 1),
('0000117', 'Renalyn', 'Del Rosario', 'Indonilla', 'Coloso St., Kabankalan City', '09092372758', 'Married', '1989-04-04', 'Coloso St., Kabankalan City\n', 'FEMALE', NULL, '09097377548', 17, 30, 1),
('0000119', 'Charlene Princess', 'Consorte', 'Rivas', 'Candoni, Negros Occidental', '09126464385', 'Married', '1991-02-07', 'Candoni, Negros Occidental\n', 'FEMALE', NULL, '09122377588', 28, 30, 1),
('0000120', 'Richell', 'Moncatar', 'Belnas', 'Cauayan, Negros Occidental', '09123546885', 'Married', '1990-02-05', 'Cauayan, Negros Occidental\n', 'FEMALE', NULL, '09127747375', 30, 30, 0),
('0000121', 'Esoy', 'Oliverio', 'Banihit', 'Tabuk-Suba, Cauayan, Negros Occidental', '09078263638', 'Married', '1987-12-07', 'Tabuk-Suba, Cauayan, Negros Occidental\n', 'MALE', NULL, '09082364748', 30, 30, 1),
('0000122', 'Nancy', 'Malvas', 'Diaz', 'Kabankalan City', '09123435667', 'Single', '1989-02-03', 'Kabankalan City\n', 'FEMALE', NULL, '09012343546', 30, 30, 0),
('0000123', 'Giemar', 'Adolfo', 'Villanueva', 'Kabankalan City', '09098772636', 'Married', '1990-02-04', 'Kabankalan City\n', 'MALE', NULL, '09123598585', 27, 30, 1),
('0000124', 'Ollie', 'Lau', 'Chow', 'Toronto, Canada', '09876543222', 'Married', '1990-02-26', 'Canada', 'MALE', NULL, '09876545678', 47.5, 30, 0),
('0000126', 'Amcy', 'Bayoneta', 'Oliverio', 'Cauayan, Negros Occidental', '09087234664', 'Married', '1989-02-06', 'Cauayan, Negros Occidental', 'FEMALE', NULL, '09125363784', 25, 30, 1),
('000018', 'Krizia Alyssa', 'Oliverio', 'Malvas', 'Tabuk-Suba, Cauayan, Negros Occidental', '09176234859', 'Single', '1992-12-14', 'Rombang Sibalom, Antique', 'FEMALE', NULL, '09462789655', 5, 30, 0),
('000019', 'Maricris', 'Lobo', 'Bancal', 'Kabankalan City', '09123458790', 'Single', '1991-09-30', 'Kabankalan City', 'FEMALE', NULL, '09123435356', 30, 30, 0);

-- --------------------------------------------------------

--
-- Table structure for table `employee_workinfo`
--

CREATE TABLE IF NOT EXISTS `employee_workinfo` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `EMPID` int(30) NOT NULL,
  `d_rate` double DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL,
  `DEPARTMENT` varchar(50) NOT NULL,
  `w_type` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=51 ;

--
-- Dumping data for table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `EMPID`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`, `DEPARTMENT`, `w_type`) VALUES
(33, 18, 250, 'Weekly', 'Staff', NULL, '2011-08-07', 'IT', 'Regular'),
(34, 19, 250, 'Weekly', 'Staff', NULL, '2011-07-04', 'Human Resource Dept.', 'Regular'),
(35, 110, 250, 'Weekly', 'Staff', NULL, '2011-04-03', 'Human Resource Dept.', 'Regular'),
(36, 111, 200, 'Weekly', 'Clerk', NULL, '2011-02-09', 'Finance Dept.', 'Regular'),
(37, 112, 300, 'Weekly', 'Medication Committee', NULL, '2000-05-04', 'Human Resource Dept.', 'Regular'),
(38, 113, 350, 'Weekly', 'Ethics Committee', NULL, '2013-05-06', 'Corporate Planning Dept.', 'Regular'),
(39, 114, 200, 'Weekly', 'Lineman', NULL, '2012-05-04', 'Engineering Service Dept.', 'Regular'),
(40, 115, 200, 'Weekly', 'Lineman', NULL, '2011-06-05', 'Engineering Service Dept.', 'Regular'),
(41, 116, 250, 'Weekly', 'Election Committee', NULL, '2014-02-05', 'Corporate Planning Dept.', 'Regular'),
(42, 117, 300, 'Weekly', 'Medication Committee', NULL, '2013-03-05', 'Corporal Communication Dept.', 'Regular'),
(44, 119, 250, 'Weekly', 'Clerk', NULL, '2011-02-01', 'Finance Dept.', 'Regular'),
(45, 120, 200, 'Weekly', 'Clerk', NULL, '2013-02-04', 'Human Resource Dept.', 'Regular'),
(46, 121, 200, 'Weekly', 'Clerk', NULL, '2012-02-02', 'Corporate Planning Dept.', 'Regular'),
(47, 122, 200, 'Weekly', 'Clerk', NULL, '2012-02-03', 'Corporate Planning Dept.', 'Regular'),
(48, 123, 200, 'Weekly', 'Clerk', NULL, '2013-02-26', 'Human Resource Dept.', 'Regular'),
(49, 124, 200, 'Weekly', 'Audit Committee', NULL, '2014-02-26', 'Corporal Communication Dept.', 'Regular'),
(50, 126, 250, 'Weekly', 'Clerk', NULL, '2013-02-26', 'Corporal Communication Dept.', 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `leave`
--

CREATE TABLE IF NOT EXISTS `leave` (
  `LEAVEID` int(11) NOT NULL AUTO_INCREMENT,
  `EMPID` int(11) NOT NULL,
  `LEAVECODE` int(11) NOT NULL,
  `LEAVEFORMAT` varchar(30) NOT NULL,
  `LEAVEAPPLIED` varchar(50) NOT NULL,
  `DATEFROM` datetime NOT NULL,
  `DATETO` datetime NOT NULL,
  `LEAVEDATE` datetime NOT NULL,
  `LEAVEENDDATE` datetime NOT NULL,
  `NODAYS` double NOT NULL,
  `REASON` text NOT NULL,
  `DAYOFFSCHEDULE` datetime NOT NULL,
  `REMARKS` varchar(30) NOT NULL,
  `APPLIED` tinyint(1) NOT NULL,
  `STATUS` text NOT NULL,
  PRIMARY KEY (`LEAVEID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

--
-- Dumping data for table `leave`
--

INSERT INTO `leave` (`LEAVEID`, `EMPID`, `LEAVECODE`, `LEAVEFORMAT`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`, `LEAVEDATE`, `LEAVEENDDATE`, `NODAYS`, `REASON`, `DAYOFFSCHEDULE`, `REMARKS`, `APPLIED`, `STATUS`) VALUES
(1, 20425, 0, 'Without Pay', 'Sick', '2015-02-22 06:02:15', '2015-02-22 06:02:15', '2015-02-22 02:02:15', '0000-00-00 00:00:00', 1, '0', '2015-02-22 02:02:15', 'Approved', 1, 'Pending'),
(2, 20424, 0, 'Without Pay', 'Sick', '2015-02-25 06:31:25', '2015-02-25 12:31:25', '2015-02-25 07:31:25', '2015-02-25 07:31:25', 0, '0', '2015-02-25 07:31:25', 'Pending', 1, 'Pending'),
(3, 20425, 0, 'Without Pay', 'Sick', '2015-02-25 06:33:33', '2015-02-25 12:33:33', '2015-02-25 07:33:33', '2015-02-25 07:33:33', 0, '0', '2015-02-25 07:33:33', 'Pending', 1, 'Pending'),
(4, 20421, 0, 'With Pay', 'Sick', '2015-02-25 06:35:51', '2015-02-25 12:35:51', '2015-02-25 07:35:51', '2015-02-25 07:35:51', 0, 'asdasd', '2015-02-25 07:35:51', 'Pending', 1, 'Pending'),
(5, 20424, 0, 'Without Pay', 'Sick', '2015-02-25 06:37:36', '2015-02-25 12:37:36', '2015-02-25 07:37:36', '2015-02-25 07:37:36', 0.5, 'asdasdasasd', '2015-02-25 07:37:36', 'Pending', 1, 'Pending'),
(6, 116, 0, 'With Pay', 'Sick', '2015-02-26 12:05:22', '2015-02-26 12:05:22', '2015-02-04 12:05:22', '2015-02-11 12:05:22', 7, 'I have a fever.', '2015-02-06 12:05:22', 'Approved', 1, 'Pending'),
(7, 117, 0, 'With Pay', 'AccidentOnDuty', '2015-02-26 12:06:47', '2015-02-26 12:06:47', '2015-01-20 12:06:47', '2015-01-29 12:06:47', 9, 'Car Accident.', '2015-01-26 12:06:47', 'Approved', 1, 'Pending'),
(8, 118, 0, 'With Pay', 'Vacation', '2015-02-26 12:08:36', '2015-02-26 12:08:36', '2015-02-11 12:08:36', '2015-02-14 12:08:36', 3, 'Family Matter.', '2015-02-26 12:08:36', 'Approved', 1, 'Pending'),
(9, 111, 0, 'With Pay', 'Sick', '2015-02-26 12:09:28', '2015-02-26 12:09:28', '2015-02-03 12:09:28', '2015-02-06 12:09:28', 3, 'Chicken Pox.', '2015-02-26 12:09:28', 'Approved', 1, 'Pending'),
(10, 119, 0, 'With Pay', 'Sick', '2015-02-26 12:11:28', '2015-02-26 12:11:28', '2015-02-26 12:11:27', '2015-02-26 12:11:27', 0, 'im sick', '2015-02-26 12:11:28', 'Approved', 1, 'Pending'),
(11, 121, 0, 'With Pay', 'Sick', '2015-02-26 02:04:15', '2015-02-26 02:04:15', '2015-02-26 02:04:15', '2015-02-26 02:04:15', 0, 'Sick', '2015-02-26 02:04:15', 'Approved', 1, 'Pending'),
(12, 112, 0, 'With Pay', 'Vacation', '2015-02-26 02:10:09', '2015-02-26 02:10:09', '2015-02-26 02:10:09', '2015-02-28 02:10:09', 1, 'asdasd', '2015-02-26 02:10:09', 'Approved', 1, 'Pending'),
(13, 113, 0, 'Without Pay', 'Sick', '2015-02-26 02:10:47', '2015-02-26 02:10:47', '2015-02-26 02:10:47', '2015-02-28 02:10:47', 1, 'zxcz', '2015-02-26 02:10:47', 'Approved', 1, 'Pending'),
(14, 117, 0, 'With Pay', 'Paternity', '2015-02-26 02:11:19', '2015-02-26 02:11:19', '2015-02-26 02:11:19', '2015-03-01 02:11:19', 2, 'zXcszczx', '2015-02-26 02:11:19', 'Approved', 1, 'Pending'),
(15, 119, 0, 'With Pay', 'Sick', '2015-02-26 02:16:53', '2015-02-26 02:16:53', '2015-02-26 02:16:53', '2015-03-01 02:16:53', 2, 'sadadas', '2015-02-26 02:16:53', 'Approved', 1, 'Pending'),
(16, 117, 0, 'Without Pay', 'Sick', '2015-02-26 02:19:13', '2015-02-26 02:19:13', '2015-02-25 02:19:13', '2015-02-27 02:19:13', 2, 'zxcz', '2015-02-26 02:19:13', 'Approved', 1, 'Pending'),
(17, 111, 0, 'With Pay', 'Sick', '2015-02-26 02:29:58', '2015-02-26 02:29:58', '2015-02-25 02:29:58', '2015-02-26 02:29:58', 1, 'asdasd', '2015-02-26 02:29:58', 'Approved', 1, 'Pending'),
(18, 115, 0, 'Without Pay', 'Vacation', '2015-02-26 02:43:39', '2015-02-26 02:43:39', '2015-02-16 02:43:39', '2015-02-26 02:43:39', 10, 'asdasdas', '2015-02-26 02:43:39', 'Approved', 1, 'Pending'),
(19, 18, 0, 'With Pay', 'Vacation', '2015-02-26 09:22:16', '2015-02-26 09:22:16', '2015-02-01 09:22:16', '2015-02-28 09:22:16', 27, 'Libre ni Paris Hilton.', '2015-02-26 09:22:16', 'Cancelled', 1, 'Pending'),
(20, 114, 0, '', 'Sick', '2015-02-26 09:52:56', '2015-02-26 09:52:56', '2015-02-20 09:52:56', '2015-02-26 09:52:56', 6, 'Admitted to the Hospital.', '2015-02-26 09:52:56', 'Approved', 1, 'Pending'),
(21, 124, 0, 'With Pay', 'Paternity', '2015-02-26 07:21:44', '2015-02-26 05:30:44', '2015-02-26 10:21:44', '2015-02-27 10:21:44', 0.5, 'gonna watch over my wife', '2015-02-28 10:21:44', 'Cancelled', 1, 'Pending'),
(22, 126, 0, 'With Pay', 'Sick', '2015-02-26 12:25:55', '2015-02-26 12:25:55', '2015-02-05 12:25:55', '2015-02-10 12:25:55', 5, 'I have a fever.', '2015-02-26 12:25:55', 'Approved', 1, 'Pending'),
(23, 115, 0, 'Without Pay', 'Sick', '2015-03-12 01:40:13', '2015-03-12 01:40:13', '2015-03-12 01:40:13', '2015-03-14 01:40:13', 1, 'sick', '2015-03-12 01:40:13', 'Approved', 1, 'Approved'),
(24, 123, 0, 'Without Pay', 'Sick', '2015-03-12 01:57:51', '2015-03-12 01:57:51', '2015-03-12 01:57:51', '2015-03-15 01:57:51', 3, 'asdasda', '2015-03-12 01:57:51', 'Approved', 1, 'Approved'),
(25, 117, 0, 'With Pay', 'Sick', '2015-03-12 01:30:25', '2015-03-12 06:00:25', '2015-03-12 02:19:25', '2015-03-12 02:19:25', 0, 'asd', '2015-03-12 02:19:25', 'Approved', 1, 'Approved'),
(26, 116, 0, 'With Pay', 'Sick', '2015-03-12 01:30:41', '2015-03-12 06:00:41', '2015-03-12 02:21:41', '2015-03-12 02:21:41', 0.5, 'sadas', '2015-03-12 02:21:41', 'Approved', 1, 'Approved');

-- --------------------------------------------------------

--
-- Table structure for table `tblapproveleave`
--

CREATE TABLE IF NOT EXISTS `tblapproveleave` (
  `APPROVEDID` int(11) NOT NULL AUTO_INCREMENT,
  `LEAVEID` int(11) NOT NULL,
  `LEAVECODE` varchar(30) NOT NULL,
  `EMPID` varchar(30) NOT NULL,
  `NODAYSAPPROVE` int(30) NOT NULL,
  `user_id` varchar(30) NOT NULL,
  `STATUS` varchar(30) NOT NULL,
  PRIMARY KEY (`APPROVEDID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=19 ;

--
-- Dumping data for table `tblapproveleave`
--

INSERT INTO `tblapproveleave` (`APPROVEDID`, `LEAVEID`, `LEAVECODE`, `EMPID`, `NODAYSAPPROVE`, `user_id`, `STATUS`) VALUES
(1, 1, '0', '20425', 1, '12', 'APPROVE'),
(2, 6, '0', '0000116', 7, '12', 'APPROVE'),
(3, 7, '0', '0000117', 9, '12', 'APPROVE'),
(4, 8, '0', '0000118', 3, '12', 'APPROVE'),
(5, 9, '0', '0000111', 3, '12', 'APPROVE'),
(6, 9, '0', '0000111', 3, '12', 'APPROVE'),
(7, 9, '0', '0000111', 3, '12', 'APPROVE'),
(8, 10, '0', '0000119', 0, '12', 'APPROVE'),
(9, 11, '0', '0000121', 0, '12', 'APPROVE'),
(10, 13, '0', '0000113', 1, '12', 'APPROVE'),
(11, 12, '0', '0000112', 1, '12', 'APPROVE'),
(12, 14, '0', '0000117', 2, '12', 'APPROVE'),
(13, 16, '0', '0000117', 2, '12', 'APPROVE'),
(14, 15, '0', '0000119', 2, '12', 'APPROVE'),
(15, 17, '0', '0000111', 1, '10328', 'APPROVE'),
(16, 18, '0', '0000115', 10, '10328', 'APPROVE'),
(17, 20, '0', '0000114', 6, '10328', 'APPROVE'),
(18, 22, '0', '0000126', 5, '12', 'APPROVE');

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE IF NOT EXISTS `tblautonumber` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `STRT` varchar(30) NOT NULL,
  `END` int(11) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`id`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', 27, 1, 'employee'),
(2, '1032', 9, 1, 'user');

-- --------------------------------------------------------

--
-- Table structure for table `tbldepartment`
--

CREATE TABLE IF NOT EXISTS `tbldepartment` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DEPARTMENT` varchar(90) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `tbldepartment`
--

INSERT INTO `tbldepartment` (`ID`, `DEPARTMENT`) VALUES
(2, 'Corporal Communication Dept.'),
(3, 'Human Resource Dept.'),
(4, 'Corporate Planning Dept.'),
(5, 'Finance Dept.'),
(6, 'Engineering Service Dept.'),
(7, 'Transmission & Distribution Dept.');

-- --------------------------------------------------------

--
-- Table structure for table `tblleaveinfo`
--

CREATE TABLE IF NOT EXISTS `tblleaveinfo` (
  `LEAVEID` int(11) NOT NULL AUTO_INCREMENT,
  `EMPID` varchar(11) NOT NULL,
  `REASONS` varchar(30) NOT NULL,
  `LEAVEDAYS` int(11) NOT NULL,
  `DEFAULT` int(11) NOT NULL,
  PRIMARY KEY (`LEAVEID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=117 ;

--
-- Dumping data for table `tblleaveinfo`
--

INSERT INTO `tblleaveinfo` (`LEAVEID`, `EMPID`, `REASONS`, `LEAVEDAYS`, `DEFAULT`) VALUES
(1, '000017', 'SICK', 15, 0),
(2, '000017', 'MATERNITY', 15, 0),
(3, '000017', 'Vacation', 15, 0),
(4, '000017', 'Funeral', 15, 0),
(5, '000017', 'Paternity', 15, 0),
(6, '000017', 'Accident On Duty', 15, 0),
(7, '000018', 'SICK', 15, 0),
(8, '000018', 'MATERNITY', 15, 0),
(9, '000018', 'Vacation', 15, 0),
(10, '000018', 'Funeral', 15, 0),
(11, '000018', 'Paternity', 15, 0),
(12, '000018', 'Accident On Duty', 15, 0),
(13, '000019', 'SICK', 15, 0),
(14, '000019', 'MATERNITY', 15, 0),
(15, '000019', 'Vacation', 15, 0),
(16, '000019', 'Funeral', 15, 0),
(17, '000019', 'Paternity', 15, 0),
(18, '000019', 'Accident On Duty', 15, 0),
(19, '0000110', 'SICK', 15, 0),
(20, '0000110', 'MATERNITY', 15, 0),
(21, '0000110', 'Vacation', 15, 0),
(22, '0000110', 'Funeral', 15, 0),
(23, '0000110', 'Paternity', 15, 0),
(24, '0000110', 'Accident On Duty', 15, 0),
(25, '0000111', 'SICK', 15, 0),
(26, '0000111', 'MATERNITY', 15, 0),
(27, '0000111', 'Vacation', 15, 0),
(28, '0000111', 'Funeral', 15, 0),
(29, '0000111', 'Paternity', 15, 0),
(30, '0000111', 'Accident On Duty', 15, 0),
(31, '0000112', 'SICK', 15, 0),
(32, '0000112', 'MATERNITY', 15, 0),
(33, '0000112', 'Vacation', 15, 0),
(34, '0000112', 'Funeral', 15, 0),
(35, '0000112', 'Paternity', 15, 0),
(36, '0000112', 'Accident On Duty', 15, 0),
(37, '0000113', 'SICK', 15, 0),
(38, '0000113', 'MATERNITY', 15, 0),
(39, '0000113', 'Vacation', 15, 0),
(40, '0000113', 'Funeral', 15, 0),
(41, '0000113', 'Paternity', 15, 0),
(42, '0000113', 'Accident On Duty', 15, 0),
(43, '0000114', 'SICK', 15, 0),
(44, '0000114', 'MATERNITY', 15, 0),
(45, '0000114', 'Vacation', 15, 0),
(46, '0000114', 'Funeral', 15, 0),
(47, '0000114', 'Paternity', 15, 0),
(48, '0000114', 'Accident On Duty', 15, 0),
(49, '0000115', 'SICK', 15, 0),
(50, '0000115', 'MATERNITY', 15, 0),
(51, '0000115', 'Vacation', 15, 0),
(52, '0000115', 'Funeral', 15, 0),
(53, '0000115', 'Paternity', 15, 0),
(54, '0000115', 'Accident On Duty', 15, 0),
(55, '0000116', 'SICK', 15, 0),
(56, '0000116', 'MATERNITY', 15, 0),
(57, '0000116', 'Vacation', 15, 0),
(58, '0000116', 'Funeral', 15, 0),
(59, '0000116', 'Paternity', 15, 0),
(60, '0000116', 'Accident On Duty', 15, 0),
(61, '0000117', 'SICK', 15, 0),
(62, '0000117', 'MATERNITY', 15, 0),
(63, '0000117', 'Vacation', 15, 0),
(64, '0000117', 'Funeral', 15, 0),
(65, '0000117', 'Paternity', 15, 0),
(66, '0000117', 'Accident On Duty', 15, 0),
(67, '0000118', 'SICK', 15, 0),
(68, '0000118', 'MATERNITY', 15, 0),
(69, '0000118', 'Vacation', 15, 0),
(70, '0000118', 'Funeral', 15, 0),
(71, '0000118', 'Paternity', 15, 0),
(72, '0000118', 'Accident On Duty', 15, 0),
(73, '0000119', 'SICK', 15, 0),
(74, '0000119', 'MATERNITY', 15, 0),
(75, '0000119', 'Vacation', 15, 0),
(76, '0000119', 'Funeral', 15, 0),
(77, '0000119', 'Paternity', 15, 0),
(78, '0000119', 'Accident On Duty', 15, 0),
(79, '0000120', 'SICK', 15, 0),
(80, '0000120', 'MATERNITY', 15, 0),
(81, '0000120', 'Vacation', 15, 0),
(82, '0000120', 'Funeral', 15, 0),
(83, '0000120', 'Paternity', 15, 0),
(84, '0000120', 'Accident On Duty', 15, 0),
(85, '0000121', 'SICK', 15, 0),
(86, '0000121', 'MATERNITY', 15, 0),
(87, '0000121', 'Vacation', 15, 0),
(88, '0000121', 'Funeral', 15, 0),
(89, '0000121', 'Paternity', 15, 0),
(90, '0000121', 'Accident On Duty', 15, 0),
(91, '0000122', 'SICK', 15, 0),
(92, '0000122', 'MATERNITY', 15, 0),
(93, '0000122', 'Vacation', 15, 0),
(94, '0000122', 'Funeral', 15, 0),
(95, '0000122', 'Paternity', 15, 0),
(96, '0000122', 'Accident On Duty', 15, 0),
(97, '0000123', 'SICK', 15, 0),
(98, '0000123', 'MATERNITY', 15, 0),
(99, '0000123', 'Vacation', 15, 0),
(100, '0000123', 'Funeral', 15, 0),
(101, '0000123', 'Paternity', 15, 0),
(102, '0000123', 'Accident On Duty', 15, 0),
(103, '0000124', 'SICK', 15, 0),
(104, '0000124', 'MATERNITY', 15, 0),
(105, '0000124', 'Vacation', 15, 0),
(106, '0000124', 'Funeral', 15, 0),
(107, '0000124', 'Paternity', 15, 0),
(108, '0000124', 'Accident On Duty', 15, 0),
(109, '0000125', 'SICK', 15, 0),
(110, '0000125', 'MATERNITY', 15, 0),
(111, '0000125', 'Vacation', 15, 0),
(112, '0000125', 'Funeral', 15, 0),
(113, '0000125', 'Paternity', 15, 0),
(114, '0000125', 'Accident On Duty', 15, 0),
(115, '0000126', 'SICK', 15, 0),
(116, '0000126', 'Vacation', 15, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE IF NOT EXISTS `tblsettings` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRIPTION` text NOT NULL,
  `FORTHE` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `FORTHE`) VALUES
(1, 'Staff', 'Position'),
(2, 'Clerk', 'Position'),
(3, 'Election Committee', 'Position'),
(4, 'Audit Committee', 'Position'),
(5, 'Corporate Secretary', 'Position'),
(6, 'Medication Committee', 'Position'),
(7, 'Treasurer', 'Position'),
(8, 'Ethics Committee', 'Position'),
(9, 'Lineman', 'Position'),
(10, 'Teller', 'Position');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
  `user_id` int(30) NOT NULL AUTO_INCREMENT,
  `name` text,
  `username` varchar(60) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10329 ;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`user_id`, `name`, `username`, `pass`, `type`) VALUES
(12, 'janno palacios', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(10328, 'Alyssa', 'HR', '51bd95353aeda6615433bea21896c893ef5e62dc', 'HR Personnel');
