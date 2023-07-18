
create database SchoolDb
use schoolDb
create table Branch (
	BranchId bigint primary key not null identity (1,1),
	BranchLocation varchar(500),
	BranchName varchar(100),
);

create table [Shift] (
	ShiftId bigint primary key not null identity(1,1),
	ShiftName varchar(20),
	ShiftType varchar(10),
	StartTime varchar(20),
	EndTime varchar(20),
);

create table Section (
	SectionId bigint primary key not null identity(1,1),
	SectionName varchar(20)
);

create table [Group] (
	GroupId bigint primary key not null identity(1,1),
	GroupName varchar(30)
);

create table [Session] (
	SessionId bigint primary key not null identity(1,1),
	SessionName varchar(30)
);

create table Designation (
	DesignationId bigint primary key not null identity(1,1),
	DesignationName varchar(50)
);

create table Campus (
	CampusId uniqueidentifier primary key not null,
	BranchId bigint references Branch(BranchId),
	CampusName varchar(100),
	[Location] varchar(500)
);

create table CampusShift (
	CampusShiftId bigint primary key not null identity(1,1),
	ShiftId bigint references [Shift](ShiftId),
	CampusId uniqueidentifier references Campus(CampusId)
);

create table Building(
	BuildingId bigint primary key not null identity(1,1),
	CampusId uniqueidentifier references Campus(CampusId),
	BuildingName varchar(50)
);

create table Room (
	RoomId bigint primary key not null identity(1,1),
	BuildingId bigint references Building(BuildingId),
	RoomNumber int,
	Capacity int
);

create table Curriculum (
	CurriculumId bigint primary key not null identity(1,1),
	CurriculumName varchar(30)
);

create table CampusCurriculum (
	CampusCurriculumId bigint primary key not null identity(1,1),
	CurriculumId bigint references Curriculum(CurriculumId),
	CampusId uniqueidentifier references Campus(CampusId)
);

create table Class (
	ClassId bigint primary key not null identity(1,1),
	CurriculumId bigint references Curriculum(CurriculumId),
	ClassName varchar(20)
);

create table [Subject] (
	SubjectId bigint primary key not null identity(1,1),
	ClassId bigint references Class(ClassId),
	ClassName varchar(20)
);

create table ClassRoutine (
	ClassRoutineId bigint primary key not null identity(1,1),
	ClassId bigint references Class(ClassId),
	SubjectId bigint references [Subject](SubjectId),
	RoomId bigint references Room(RoomId),
	Shiftid bigint references [Shift](ShiftId),
	SectionId bigint references Section(SectionId),
	[WeekDay] varchar(30),
	StartTime varchar(50),
	EndTime varchar(50),
	Duration varchar(50)
);

create table Exam (
	ExamId bigint primary key not null identity(1,1),
	SubjectId bigint references [Subject](SubjectId),
	ExamName varchar(50),
	ExamDate DateTime,
	ExamDuration varchar(50),
	StartTime varchar(50),
	EndTime varchar(50),
	TotalMarks int,
	PassingMarks int,
	ExamStatus varchar(50)
);

create table GradingSystem (
	GradeId bigint primary key not null identity(1,1),
	Classid bigint references Class(Classid),
	GradeName varchar(20),
	MaxMarks int,
	MinimumMarks int
);

create table Student (
	StudentId bigint primary key not null identity(1,1),
	CampusId uniqueidentifier references Campus(CampusId),
	SectionId bigint references Section(SectionId),
	GroupId bigint references [Group](GroupId),
	SessionId bigint references [Session](SessionId),
	ShiftId bigint references [Shift](ShiftId),
	ClassId bigint references Class(ClassId),
	FirstName varchar(50),
	LastName varchar(50),
	Photo varchar(1000),
	Gender varchar(20),
	RollNumber varchar(100),
	DateOfBirth DateTime,
	BirthCertificate varchar(500),
	AdmissionDate DateTime,
	Religion varchar(20),
	Nationality varchar(50),
	PreviousSchool varchar(500),
	GPA decimal,
	FatherName varchar(100),
	MotherName varchar(100),
	FatherNID varchar(50),
	MotherNID varchar(50),
	FatherOccupation varchar(100),
	FatherPhoneNumber varchar(14),
	FatherEmail varchar(100),
	MotherOccupation varchar(100),
	MotherPhoneNumber varchar(14),
	MotherEmail varchar(100),
	PresentAddress varchar(1000),
	PermanentAddress varchar(1000)
);

create table StudentClassRoutine (
	StudentClassRoutineId bigint primary key not null identity(1,1),
	ClassRoutineId bigint references ClassRoutine(ClassRoutineId),
	StudentId bigint references Student(StudentId)
);

create table StudentPayment (
	StudentPaymentId bigint primary key not null identity(1,1),
	StudentId bigint references Student(StudentId),
	PaymentDate DateTime,
	PaymentAmmount decimal(8,2),
	PaymentType varchar(50),
	PaymentReference varchar(50),
	PaymentStatus varchar(30)
);

create table StudentSubject (
	StudentSubjectId bigint primary key not null identity(1,1),
	SubjectId bigint references [Subject](SubjectId),
	StudentId bigint references Student(StudentId)
);

create table StudentExamRoutine (
	StudentExamRoutineId bigint primary key not null identity(1,1),
	ExamId bigint references Exam(ExamId),
	StudentId bigint references Student(StudentId),
);

create table StudentPromotion (
	StudentPromotionId bigint primary key not null identity(1,1),
	StudentId bigint references Student(StudentId),
	ClassId bigint references Class(ClassId),
	PromotionDate DateTime,
	PromotionStatus bit,
	PromotionReason varchar(500),
	PromotionApprover varchar(50)
);

create table StudentResult (
	StudentResultId bigint primary key not null identity(1,1),
	StudentId bigint references Student(StudentId),
	SubjectId bigint references [Subject](SubjectId),
	GradeId bigint references GradingSystem(GradeId),
	ObtainedMark decimal(8,2)
);


create table StudentPortal (
	StudentPortalId bigint primary key not null identity(1,1),
	StudentId bigint references Student(StudentId),
	UserName varchar(50),
	[Password] varchar(11)
);

create table Teacher (
	TeacherId bigint primary key not null identity(1,1),
	FirstName varchar(50),
	LastName varchar(50),
	Photo varchar(500),
	Gender varchar(20),
	MaritalStatus varchar(20),
	DateOfBirth DateTime,
	NID varchar(50),
	Religion varchar(30),
	Phone varchar(14),
	Email varchar(100),
	Nationality varchar(30),
	Qualification varchar(50),
	Salary varchar(20)
);

create table TeacherSubject (
	TeacherSubjectId bigint primary key not null identity(1,1),
	SubjectId bigint references [Subject](SubjectId),
	TeacherId bigint references Teacher(TeacherId),
);

create table TeacherClassRoutine (
	TeacherClassRoutineId bigint primary key not null identity(1,1),
	ClassRoutineId bigint references ClassRoutine(ClassRoutineId),
	TeacherId bigint references Teacher(TeacherId)
);

create table TeacherExamRoutine (
	TeacherExamRoutineId bigint primary key not null identity(1,1),
	ExamId bigint references Exam(ExamId),
	TeacherId bigint references Teacher(TeacherId)
);

create table TeacherDesignation (
	TeacherDesignationId bigint primary key not null identity(1,1),
	DesignationId bigint references Designation(DesignationId),
	TeacherId bigint references Teacher(TeacherId),
);

create table TeacherPromotion (
	TeacherPromotionId bigint primary key not null identity(1,1),
	TeacherId bigint references Teacher(TeacherId),
	PromotionDate DateTime,
	PromotionStatus bit,
	PromotionReason varchar(100),
	PromotionApprover varchar(50)
);

create table TeacherPortal (
	TeacherPortalId bigint primary key not null identity(1,1),
	TeacherId bigint references Teacher(TeacherId),
	UserName varchar(50),
	[Password] varchar(11)
);

create table [Stuff] (
	StuffId bigint primary key not null identity(1,1),
	[Name] varchar(30),
	Email varchar(50),
	Phone varchar(14),
	[Address] varchar(500),
	Gender varchar(10),
	DateOfBirth DateTime,
	Qualification varchar(50),
	Religion varchar(20),
	AssignedTo varchar(50)
);

create table SuperAdmin (
	SuperAdminId bigint primary key not null identity(1,1),
	[Name] varchar(30),
	Gender varchar(20),
	Photo varchar(500),
	Email varchar(50),
	Phone varchar(14)
);

Create table [Admin] (
	AdminId bigint primary key not null identity(1,1),
	Teacherid bigint references Teacher(TeacherId),
	UserName varchar(50),
	[Password] varchar(11),
	StudentManagement bit,
	TeacherManagement bit,
	StuffManagement bit,
	PaymentManagement bit,
	ExamManagement bit,
	ClassRoutineManagement bit,
	SubjectManagement bit,
	ResultManagement bit
);