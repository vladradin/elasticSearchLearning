using Nest;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel;



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

    [Date(Format = "yyyy-MM-dd")]
    public DateTime DateOfJoining { get; set; }

    public string Address { get; set; }

    [Text]
    [TypeConverter(typeof(StringEnumConverter))]
    public Gender Gender { get; set; }

    public int Age { get; set; }

    [Text]
    [TypeConverter(typeof(StringEnumConverter))]
    public MaritalStatus MaritalStatus { get; set; }

    public string Interests { get; set; }
}

namespace ElasticSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ElasticClient(new Uri("http://localhost:9200"));

            if (client.IndexExists("companyDatabase").Exists)
                client.DeleteIndex("companyDatabase");

            var rsp = client.CreateIndex("companyDatabase", i => i
                              .Mappings(mp => mp
                                .Map<Employee>(emp => emp
                                    .AutoMap())));

                                          
        }
    }
}
