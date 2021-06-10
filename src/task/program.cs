using System;

namespace task
{

    class Players
    {
        public string wieght = "100 kg ";
        private string hight = "190cm";

        protected string name = "Mohammad";
        public void Printinfo()
        {
            var Player = new Players();
     Console.WriteLine($"the private fieald is hight so we can accsess because we are in the same class {Player.hight}");

        }

    }
    class FootBallPlayer : Players
    {

        public void printStament()
        {
            Console.WriteLine("This is AFootball Player ");
            var footBall = new FootBallPlayer();


            Console.WriteLine($"The name of player we can accsess becuase we inherite from Players  {footBall.name} ");
            Console.WriteLine($"The wieght of Player ,we can accsess because it is public {footBall.wieght} ");
            //Console.WriteLine ($"The hight is private fieled  the accses just in the same class {footBall.hight } "); 

        }

    }

    class program
    {
        static void Main(string[] args)
        {
            var p1 = new Players();
            var p2 = new FootBallPlayer();
            p2.printStament();
            p1.Printinfo();
        }
    }
}


