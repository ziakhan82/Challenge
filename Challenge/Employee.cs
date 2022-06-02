using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Challenge
{

    public class unite
    {
        public List<Employee> Employees { get; set; }
    }
  public  class Employee
    {
        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }

        [JsonPropertyName("groupId")]
        public int GroupId { get; set; }

        [JsonPropertyName("answeredOn")]
        public string AnsweredOnString { get; set; }

        public DateTime AnsweredOn
        {
            get
            {
                return DateTime.Parse(AnsweredOnString);
            }
        }

        [JsonPropertyName("answer1")]
        public int Answer1 { get; set; }

        [JsonPropertyName("answer2")]
        public int Answer2 { get; set; }

        [JsonPropertyName("answer3")]
        public int Answer3 { get; set; }

        [JsonPropertyName("answer4")]
        public int Answer4 { get; set; }

        [JsonPropertyName("answer5")]
        public int Answer5 { get; set; }

        public double ScoreAverge()
        {
           
               return (Answer1 + Answer2 + Answer3 + Answer4 + Answer5) / 5;
        }

      

    }







}
