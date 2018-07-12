using FileServer.Infraestructure.Repository.Repositories;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace FileServer.Infraestructure.Repository.Behaviour.Test
{
    [Binding]
    public class StudentRepositoryInsertSteps
    {
        protected StudentRepository repository = new StudentRepository();

        protected Student student;

        [Given(@"I have an Student without Id")]
        public void GivenIHaveAnStudentWithoutId()
        {
            student = new Student(new DateTime(1990, 6, 22));
        }
        
        [When(@"I run the method Insert of STudent Repository")]
        public void WhenIRunTheMethodInsertOfSTudentRepository()
        {
            repository.Insert(student);
        }
        
        [Then(@"the Student Repository should return a Student with Id")]
        public void ThenTheStudentRepositoryShouldReturnAStudentWithId()
        {
            student.Id.Should().Be(1);

            student.Age.Should().Be(28);

        }
    }
}
