using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public int YOR { get; set; } 
    }

    public class MoviesHelper
    {
        List<Movies> li = new List<Movies>()
            {
                new Movies(){ MovieId=100, MovieName="Bahubali", Actor="Prabhas",
        Actress="Tamanna", YOR=2015 },
                new Movies(){ MovieId=200, MovieName="Bahubali2", Actor="Prabhas",
        Actress="Anushka", YOR=2017 },
                new Movies(){ MovieId=300, MovieName="Robot", Actor="Rajini",
        Actress="Aish", YOR=2010 },
                new Movies(){ MovieId=400, MovieName="3 idiots", Actor="Amir",
        Actress="kareena", YOR=2009 },
                new Movies(){ MovieId=500, MovieName="Saaho", Actor="Prabhas",
        Actress="shraddha", YOR=2019 },
            };

        public void MoviesMethod()
        {
            //1. display list of movienames acted by prabhas
            //var res = from t in li
            //          where t.Actor == "Prabhas"
            //          select t.MovieName;

            //2. display list of all movies released in year 2019 
            //var res = from t in li
            //          where t.YOR == 2019
            //          select t.MovieName;

            //3. display the list of movies who acted together by prabhas and anushka 
            //var res = from t in li
            //          where t.Actor == "Prabhas" && t.Actress == "Anushka"
            //          select t.MovieName;

            //4. display the list of all actress who acted with prabhas 
            //var res = from t in li
            //          where t.Actor == "Prabhas"
            //          select t.Actress;

            //5. display the list of all movies released from 2010 - 2018 
            //var res = from t in li
            //         where t.YOR >=2010 && t.YOR <= 2018
            //         select t.MovieName;

            //6. sort YOR in descending order and display all its records 
            //var res = from t in li
            //          orderby t.YOR descending
            //          select new {t.MovieId , t.MovieName, t.Actor, t.Actress, t.YOR};

            //7. display max movies acted by each actor 
            //var res = from t in li
            //          group t by t.Actor into m
            //          select new { Actor = m.Key, Count = m.Count() };

            //8. display the name of all movies which is 5 characters long 
            //var res = from t in li
            //          where t.MovieName.Length == 5
            //          select t.MovieName;

            //9.display names of actor and actress where movie released in year 2017, 2009 and 2019
            //var res = from t in li
            //          where t.YOR == 2017 || t.YOR == 2019 || t.YOR == 2009
            //          select new {t.Actor, t.Actress};

            //10.display the name of movies which start with 'b' and ends with 'i' 
            //var res = from t in li
            //          where t.MovieName.ToLower().StartsWith("b") && t.MovieName.ToLower().EndsWith("i")
            //          select t.MovieName;

            //11.display name of actress who not acted with Rajini and print in descending order
            //var res = from t in li
            //          where t.Actor != "Rajini"
            //          orderby t.Actress descending
            //          select t.Actress;

            //12. display records in following format 
            //eg:
            //movie name     cast
            //Bahubali     prabhas - tammanna
            var res = from t in li
                      select new
                      {
                          MovieName = t.MovieName,
                          Cast = t.Actor + "-" + t.Actress
                      };


            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
