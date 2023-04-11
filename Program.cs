using System;
using System.Collections.Generic;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }

    public Address(string street, string city, string postalCode)
    {
        Street = street;
        City = city;
        PostalCode = postalCode;
    }
}

public class Student
{
    private string lastName;
    private string firstName;
    private string patronymic;
    private DateTime birthDate;
    private Address homeAddress;
    private string phoneNumber;
    private List<int> examScores;
    private List<int> quizScores;
    private List<int> homeworkScores;

    public Student(string lastName, string firstName, string patronymic, DateTime birthDate,
                   Address homeAddress, string phoneNumber)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.patronymic = patronymic;
        this.birthDate = birthDate;
        this.homeAddress = homeAddress;
        this.phoneNumber = phoneNumber;
        examScores = new List<int>();
        quizScores = new List<int>();
        homeworkScores = new List<int>();
    }

    public Student(string lastName, string firstName, DateTime birthDate,
                   Address homeAddress, string phoneNumber)
        : this(lastName, firstName, "", birthDate, homeAddress, phoneNumber)
    {
    }

    public Student(string lastName, string firstName, string patronymic, DateTime birthDate)
        : this(lastName, firstName, patronymic, birthDate, null, null)
    {
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public Address HomeAddress
    {
        get { return homeAddress; }
        set { homeAddress = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public List<int> ExamScores
    {
        get { return examScores; }
    }

    public List<int> QuizScores
    {
        get { return quizScores; }
    }

    public List<int> HomeworkScores
    {
        get { return homeworkScores; }
    }

    public override string ToString()
    {
        return string.Format("Name: {0} {1} {2}\nBirth Date: {3}\nHome Address: {4}\nPhone Number: {5}\nExam Scores: {6}\nQuiz Scores: {7}\nHomework Scores: {8}",
                             lastName, firstName, patronymic, birthDate.ToShortDateString(), homeAddress == null ? "" : homeAddress.ToString(), phoneNumber,
                             string.Join(", ", examScores), string.Join(", ", quizScores), string.Join(", ", homeworkScores));
    }
}