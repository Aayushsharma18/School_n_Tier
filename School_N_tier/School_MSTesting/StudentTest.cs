using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School_Buinesslogic.Models;
using School_DataAccess.Models;
using School_Modles.Models;
using School_Services.Interface;
using School_Services.Models;
using School_Services.Repository;

namespace School_MSTesting;

[TestClass]
public class StudentTest
{
    private IMapperClass _test = null!;

    [TestInitialize]
    public void SetUp()
    {
        _test = new ConvertEntityToDTO();
    }

    #region Student

    [TestMethod]
    [DataTestMethod]
    public void Convert_Student_TO_BL_TO_DTO_OkResult()
    {
        //Arrange
        var studentdata = new Student()
        {
            Id = 1,
            Name = "Ajay",
            Address = "Bhopal",
            DateOfBirth = DateTime.Now,
            GradeId = 1,
            Height = 6,
            Photo = "jpg.jpg",
            TeacherId = 1,
            Weight = 40
        };
        var studentdataBL = new Student_BL()
        {
            Id = 1,
            Name = "Ajay",
            Address = "Bhopal",
            DateOfBirth = DateTime.Now,
            GradeId = 1,
            Height = 6,
            Photo = "jpg.jpg",
            TeacherId = 1,
            Weight = 40
        };

        //Act
        var dataBL = _test.ConvertStudentEntityToBL(studentdata);
        var dataDTO = _test.ConvertStudentBLToDTO(studentdataBL);

        //Assert
        Assert.IsInstanceOfType(dataBL, typeof(Student_BL));
        Assert.IsInstanceOfType(dataDTO, typeof(Student_DTO));
        // Assert.AreEqual(dataBL, studentdataBL);
    }

    [TestMethod]
    [DataTestMethod]
    public void Convert_Student_TO_BL_TO_DTO_Error()
    {
        //Arange
        var studentdata = new Student()
        {
            Id = 1,
            Name = "Ajay",
            Address = "Bhopal",
            DateOfBirth = DateTime.Now,
            GradeId = 1,
            Height = 6,
            Photo = "jpg.jpg",
            TeacherId = 1,
            Weight = 40
        };
        var studentdataBL = new Student_BL()
        {
            Id = 1,
            Name = "Ajay",
            Address = "Bhopal",
            DateOfBirth = DateTime.Now,
            GradeId = 1,
            Height = 6,
            Photo = "jpg.jpg",
            TeacherId = 1,
            Weight = 40
        };

        //Act
        var dataBL = _test.ConvertStudentEntityToBL(studentdata);
        var dataDTO = _test.ConvertStudentBLToDTO(studentdataBL);

        //Assert
        Assert.AreNotEqual(studentdata, dataBL);
        Assert.AreNotEqual(studentdataBL, dataDTO);
    }

    #endregion

    #region Teacher

    [TestMethod]
    [DataTestMethod]
    public void Convert_Teacher_TO_BL_TO_DTO_OkResult()
    {
        //Arrange
        var teacherdata = new Teacher()
        {
            Id = 1,
            Name = "Vinay",
            Phone = 9888585874,
            DateOfBirth = DateTime.Now,
        };
        //Act
        var dataBL = _test.ConvertTeacherEntityToBL(teacherdata);
        var dataDTO = _test.ConvertTeacherBLToDTO(dataBL);

        //Assert
        Assert.IsInstanceOfType(dataBL, typeof(Teacher_BL));
        Assert.IsInstanceOfType(dataDTO, typeof(Teacher_DTO));
    }

    [TestMethod]
    [DataTestMethod]
    public void Convert_Teacher_TO_BL_TO_DTO_Error()
    {
        //Arrnage
        var teacherdata = new Teacher()
        {
            Id = 1,
            Name = "Vinay",
            Phone = 9888585874,
            DateOfBirth = DateTime.Now,
        };

        //Act
        var dataBL = _test.ConvertTeacherEntityToBL(teacherdata);
        var dataDTO = _test.ConvertTeacherBLToDTO(dataBL);

        //Assert
        Assert.IsInstanceOfType(dataBL, typeof(Teacher_BL));
        Assert.IsInstanceOfType(dataDTO, typeof(Teacher_DTO));
    }

    #endregion

    #region Grade

    [TestMethod]
    [DataTestMethod]
    public void Convert_Grade_TO_BL_TO_DTO_OkResult()
    {
        //Arrange
        var grade = new Grade()
        {
            Id = 1,
            Name = "Good",
            Section = "A"
        };

        //Act
        var gradeBL = _test.ConvertGradeEntityToBL(grade);
        var gradeDTO = _test.ConvertGradeBLToDTO(gradeBL);

        //Assert
        Assert.IsInstanceOfType(gradeBL, typeof(Grade_BL));
        Assert.IsInstanceOfType(gradeDTO, typeof(Grade_DTO));
        // Assert.AreSame(gradeBL, gradeDTO);
    }

    [TestMethod]
    [DataTestMethod]
    public void Convert_Grade_TO_BL_TO_DTO_Error()
    {
        //Arrange
        var grade = new Grade()
        {
            Id = 1,
            Name = "Good",
            Section = "A"
        };

        //Act
        var dataBL = _test.ConvertGradeEntityToBL(grade);
        var dataDTO = _test.ConvertGradeBLToDTO(dataBL);

        //Assert
        Assert.IsInstanceOfType(dataBL, typeof(Grade_BL));
        Assert.IsInstanceOfType(dataDTO, typeof(Grade_DTO));
    }

    #endregion
}