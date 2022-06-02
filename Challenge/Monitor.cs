using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public  class Monitor
    {
        public Dictionary<int, Dictionary<int, double>> GroupScore(List<Employee> employees)
        {

            Dictionary<int, Dictionary<int, double>> groupedScores = new();

            var byMonth = employees.GroupBy(e => e.AnsweredOn.Month).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var month in byMonth)
            {
                var groups = month.Value.GroupBy(emp => emp.GroupId).ToDictionary(group => group.Key, group => group.Sum(emp => emp.ScoreAverge()) / group.Count());

                groupedScores[month.Key] = groups;
            }

            return groupedScores;
        }

    }
}

    


        
    
                
            
        
        
    

