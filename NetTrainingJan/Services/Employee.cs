namespace NetTrainingJan.Services
{
    //services
    // Employee.cs

    public interface IEmployeeService
    {
        string GetOutput();
    }

    public class EmployeeService : IEmployeeService
    {
        public string GetOutput()
        {
            return "Hello from Archana!";
        }
    }

}
