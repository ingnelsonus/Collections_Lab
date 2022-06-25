using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections_Lab.Entity;

namespace Collections_Lab
{
    internal class LambdaExpressions
    {        
        public void lambdasExample()
        {
            //Retorna valor.
            //Func<int,int> fnlambda = (a) => a * 2;
            //Console.WriteLine(fnlambda(2));    


            ///No retorna ningun valor
            //Action fnlamda = () => Console.WriteLine("Hola from lambda");
            //fnlamda();

            ///Retorna un valor booleano.
            //Predicate<int> fnbool = (a) => a>1?true:false;
            //Console.WriteLine(fnbool(1));

            //Mejorar apartir de c# 10
            //var fn=bool(int a) => a>1?true:false;
            //Console.WriteLine(fn(2));

            //Comparativo c#9 suma vs c#10 sum2
            //Func<int, int, int> suma = (a, b) => a + b;
            //var sum2=(int a,int b)=>a+ b;

            //guardar una funcion nativa.
            //var pow = Math.Pow;

            //retorno hibrido. retornamos 1 o "0"
            //var p = object (bool e) => e ? 1 : "0";
            //Console.WriteLine(p(false).GetType());

            //var closure = Action (int n) =>
            //{
            //    int i = 0;

            //    return () =>
            //    {
            //        i++;

            //        if (i < n)
            //            Console.WriteLine($"Se ejecuto {i}");
            //        else
            //            Console.WriteLine("Se terminaron las ejecuciones");        
            //    };
            //};

            //var executor = closure(2);
            //executor();
            //executor();
        }

        public void lambdasplusLinq()
        {
            var myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var NumbersOver5 = myNumbers.Where(n => n > 5);

        }

        public void lambdasAndlinq_2()
        {
            var gameList = new List<Game>
            {
                new Game{Name="Death Stranding",ReleaseDate=new DateTime(2022,6,23), StreamScore=9},
                new Game{Name="Dark Souls 3",ReleaseDate=new DateTime(2015,3,24), StreamScore=9},
                new Game{Name="CyberPunk 2077",ReleaseDate=new DateTime(2020,9,17), StreamScore=7},
                new Game{Name="Valheim",ReleaseDate=new DateTime(2021,2,2), StreamScore=9}
            };


            bool allHave9ScoreBetter = gameList.All(g => g.StreamScore > 9);


            IEnumerable<string> gameNames = gameList.Select(g => g.Name);
            List<string> gameNamesList = gameList.Select(g => g.Name).ToList();


            List<StarRating> starRatings = gameList.Select(g=>new StarRating
            {
                Name=g.Name,
                Stars=g.StreamScore*0.5

            }).ToList();


            Game gameWithScoreof2 = gameList.FirstOrDefault(g => g.StreamScore == 2);


            var suggestedGames = gameList
                .Where(g => g.StreamScore > 9 && g.ReleaseDate.Year > 2018)
                .OrderBy(g => g.StreamScore)
                .Take(3);


        }




    }
}
