-- Create database if it doesn’t exist and select it
CREATE DATABASE IF NOT EXISTS `student_management_db`;
USE `student_management_db`;

-- Drop tables in correct dependency order
DROP TABLE IF EXISTS `enrolled_courses`;
DROP TABLE IF EXISTS `courses`;
DROP TABLE IF EXISTS `students`;

-- Create students table
CREATE TABLE `students` (
  `student_id` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(50) NOT NULL,
  `last_name` VARCHAR(50) NOT NULL,
  `email` VARCHAR(100) DEFAULT NULL,
  PRIMARY KEY (`student_id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Create courses table
CREATE TABLE `courses` (
  `course_code` VARCHAR(50) NOT NULL,
  `course_name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`course_code`),
  UNIQUE KEY `course_code_UNIQUE` (`course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Create enrolled_courses table
CREATE TABLE `enrolled_courses` (
  `student_id` INT NOT NULL,
  `course_code` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`student_id`,`course_code`),
  KEY `enrolled_courses_ibfk_2` (`course_code`),
  CONSTRAINT `enrolled_courses_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE,
  CONSTRAINT `enrolled_courses_ibfk_2` FOREIGN KEY (`course_code`) REFERENCES `courses` (`course_code`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- -------------------------------------------------------------
-- Insert sample data
-- -------------------------------------------------------------

-- Students
INSERT INTO `students` (`first_name`, `last_name`, `email`) VALUES
('Alice', 'Johnson', 'alice.johnson@example.com'),
('Bob', 'Smith', 'bob.smith@example.com'),
('Carol', 'Davis', 'carol.davis@example.com'),
('David', 'Brown', 'david.brown@example.com'),
('Ella', 'Wilson', 'ella.wilson@example.com'),
('Frank', 'Garcia', 'frank.garcia@example.com'),
('Grace', 'Martinez', 'grace.martinez@example.com'),
('Hank', 'Lopez', 'hank.lopez@example.com'),
('Ivy', 'Gonzalez', 'ivy.gonzalez@example.com'),
('Jack', 'Anderson', 'jack.anderson@example.com');

-- Courses
INSERT INTO `courses` (`course_code`, `course_name`) VALUES
('CS101', 'Introduction to Computer Science'),
('MATH201', 'Calculus I'),
('ENG150', 'English Literature'),
('BIO110', 'General Biology'),
('HIST210', 'World History'),
('PHY120', 'Physics Fundamentals'),
('CHEM130', 'Introductory Chemistry'),
('PSY200', 'Psychology Basics');

-- Enroll students in random courses
INSERT INTO `enrolled_courses` (`student_id`, `course_code`) VALUES
(1, 'CS101'),
(1, 'MATH201'),
(2, 'ENG150'),
(2, 'BIO110'),
(3, 'CS101'),
(3, 'PHY120'),
(4, 'CHEM130'),
(5, 'PSY200'),
(5, 'HIST210'),
(6, 'MATH201'),
(6, 'CS101'),
(7, 'ENG150'),
(8, 'BIO110'),
(8, 'CHEM130'),
(9, 'CS101'),
(10, 'PSY200'),
(10, 'HIST210');
