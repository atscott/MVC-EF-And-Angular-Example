CREATE TABLE [dbo].[tblEnrollment] (
    [Id]        INT NOT NULL,
    [CourseId]  INT NOT NULL,
    [StudentId] INT NOT NULL,
    [Grade]     INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblEnrollment_tblCourse] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[tblCourse] ([Id]),
    CONSTRAINT [FK_tblEnrollment_tblStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[tblStudent] ([Id])
);

