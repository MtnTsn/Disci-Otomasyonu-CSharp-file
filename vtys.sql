/*
Navicat MySQL Data Transfer

Source Server         : mustafa
Source Server Version : 50508
Source Host           : localhost:3306
Source Database       : vtys

Target Server Type    : MYSQL
Target Server Version : 50508
File Encoding         : 65001

Date: 2011-12-04 14:51:55
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `department`
-- ----------------------------
DROP TABLE IF EXISTS `department`;
CREATE TABLE `department` (
  `ID` int(4) NOT NULL AUTO_INCREMENT,
  `Dname` varchar(30) NOT NULL,
  `Dnumber` int(1) NOT NULL,
  `Mgr_ssn` int(10) NOT NULL,
  `Mgr_start_date` date NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Mgr_ssn` (`Mgr_ssn`),
  KEY `Dnumber` (`Dnumber`),
  CONSTRAINT `department_ibfk_1` FOREIGN KEY (`Mgr_ssn`) REFERENCES `employee` (`Ssn`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of department
-- ----------------------------

-- ----------------------------
-- Table structure for `dependent`
-- ----------------------------
DROP TABLE IF EXISTS `dependent`;
CREATE TABLE `dependent` (
  `ID` int(4) NOT NULL AUTO_INCREMENT,
  `Essn` int(10) NOT NULL,
  `Dependent_name` varchar(30) NOT NULL,
  `Sex` varchar(1) NOT NULL,
  `Bdate` date NOT NULL,
  `Relationship` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Essn` (`Essn`),
  CONSTRAINT `dependent_ibfk_2` FOREIGN KEY (`Essn`) REFERENCES `employee` (`Ssn`),
  CONSTRAINT `dependent_ibfk_1` FOREIGN KEY (`Essn`) REFERENCES `employee` (`Ssn`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of dependent
-- ----------------------------

-- ----------------------------
-- Table structure for `dept_locations`
-- ----------------------------
DROP TABLE IF EXISTS `dept_locations`;
CREATE TABLE `dept_locations` (
  `ID` int(4) NOT NULL AUTO_INCREMENT,
  `Dnumber` int(1) NOT NULL,
  `Dlocation` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Dnumber` (`Dnumber`),
  CONSTRAINT `dept_locations_ibfk_1` FOREIGN KEY (`Dnumber`) REFERENCES `department` (`Dnumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of dept_locations
-- ----------------------------

-- ----------------------------
-- Table structure for `employee`
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Fname` varchar(30) NOT NULL,
  `Minit` varchar(1) NOT NULL,
  `Lname` varchar(30) NOT NULL,
  `Ssn` int(10) NOT NULL,
  `Bdate` date DEFAULT NULL,
  `Address` varchar(40) NOT NULL,
  `Sex` varchar(1) NOT NULL,
  `Salary` int(6) NOT NULL,
  `Super_ssn` int(10) DEFAULT NULL,
  `Dno` int(1) NOT NULL,
  PRIMARY KEY (`ID`,`Ssn`),
  KEY `Ssn` (`Ssn`),
  KEY `Super_ssn` (`Super_ssn`),
  KEY `Dno` (`Dno`),
  CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`Dno`) REFERENCES `department` (`Dnumber`),
  CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`Super_ssn`) REFERENCES `employee` (`Ssn`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of employee
-- ----------------------------

-- ----------------------------
-- Table structure for `project`
-- ----------------------------
DROP TABLE IF EXISTS `project`;
CREATE TABLE `project` (
  `ID` int(4) NOT NULL AUTO_INCREMENT,
  `Pname` varchar(30) NOT NULL,
  `Pnumber` int(2) NOT NULL,
  `Plocation` varchar(30) NOT NULL,
  `Dnum` int(1) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Dnum` (`Dnum`),
  KEY `Pnumber` (`Pnumber`),
  CONSTRAINT `project_ibfk_1` FOREIGN KEY (`Dnum`) REFERENCES `department` (`Dnumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of project
-- ----------------------------

-- ----------------------------
-- Table structure for `works_on`
-- ----------------------------
DROP TABLE IF EXISTS `works_on`;
CREATE TABLE `works_on` (
  `ID` int(4) NOT NULL AUTO_INCREMENT,
  `Essn` int(10) NOT NULL,
  `Pno` int(2) NOT NULL,
  `Hours` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Essn` (`Essn`),
  KEY `Pno` (`Pno`),
  CONSTRAINT `works_on_ibfk_1` FOREIGN KEY (`Essn`) REFERENCES `employee` (`Ssn`),
  CONSTRAINT `works_on_ibfk_3` FOREIGN KEY (`Pno`) REFERENCES `project` (`Pnumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of works_on
-- ----------------------------
