using System;



//{"mappings" : { "employees" : { "properties" : 

//{ "FirstName" : { "type" : "text" }, 
//"LastName" : { "type" : "text" }, 
//"Designation" : { "type" : "text" }, 
//"Salary" : { "type" : "integer" }, 
//"DateOfJoining" : 
//{ "type" : "date", "format": "yyyy-MM-dd" }, 
//"Address" : { "type" : "text" }, 
//"Gender" : { "type" : "text" }, 
//"Age" : { "type" : "integer" }, 
//"MaritalStatus" : { "type" : "text" }, 
//"Interests" : { "type" : "text" }}}}}'

public enum Gender
{
    Male,
    Female
}
public enum MaritalStatus
{
    Married,
    Unmarried,
    Divorced
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Designation { get; set; }
    public decimal Salary { get; set; }
    public DateTime DateOfJoining { get; set; }
    public string Address { get; set; }
    public Gender Gender { get; set; }
    public int Age { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public string Interests { get; set; }
}

namespace ElasticSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
