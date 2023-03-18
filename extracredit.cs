namespace Extracredit
{
    class HumanPlayer{
        private int points;
        public HumanPlayer(int initial)
        {
            points = initial;
        }
        public int GetPoints(){
            return points;
        }
        public void WinRound(){
            points +=5;
        }
        public void LoseRound(){
            points -=5;
        }
        public string HumanDecision(){
            string s = Console.ReadLine();
            while(!(s.Equals("rock")|| s.Equals("paper")|| s.Equals("scissors")))
            {
                Console.WriteLine("Invalid Input");
                s = Console.ReadLine();
            }
            return s;
        
        }
   class ComputerPlayer{
    public string ComputerDecision(){
        Random rnd = new Random ();
        int rnd_num = rnd.Next(0,2);
        if (rnd_num == 0)
        return "rock";
        if (rnd_num == 1)
        return "paper";
        return "scissors";
    }
     
    }  
    
 class RockPaperScissors
    {
        static void Main(string[] args)
        {
            HumanPlayer h = new HumanPlayer(5);
            ComputerPlayer c = new ComputerPlayer();
        
            while (true)
            {
                Console.WriteLine("****Rock Paper Scissors, Start!!****");
                Console.WriteLine("You Have " + h.GetPoints() + " Points");
                Console.WriteLine("Please input your choice : rock, paper or scissors.");
                string hPl = h.HumanDecision();
                string cPl = c.ComputerDecision();
                Console.WriteLine("Your Decision : " + hPl);
                Console.WriteLine("Computer Decision : " + cPl);
                
            switch (cPl)
            {
                case "rock":
                if (hPl == "rock")
                {
                    Console.WriteLine("The computer chose Rock!");
                    Console.WriteLine("Draw!");
                    Console.WriteLine("You have: " + h.GetPoints());
                }
                    
                
                else if (hPl == "scissors")
                {
                    Console.WriteLine("The computer chose Rock!");
                    Console.WriteLine("You Lose!");
                    h.LoseRound();
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (hPl == "paper")
                {
                    Console.WriteLine("The computer chose Rock!");
                    Console.WriteLine("You Win!");
                    h.WinRound();
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                    break;
            
                case "paper":
            
                if (hPl == "paper")
                {
                    Console.WriteLine("The computer chose Paper!");
                    Console.WriteLine("Draw!");
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (hPl == "rock")
                {
                    Console.WriteLine("The computer chose Paper!");
                    Console.WriteLine("You Lose!");
                    h.LoseRound();
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (hPl == "scissors")
                {
                    Console.WriteLine("The computer chose Paper!");
                    Console.WriteLine("You Win!");
                    h.WinRound();
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                    break;
            
                case "scissors":
                if (hPl == "scissors")
                {
                    Console.WriteLine("The computer chose Scissors!");
                    Console.WriteLine("Draw!");
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (hPl == "paper")
                {
                    Console.WriteLine("The computer chose Scissors!");
                    Console.WriteLine("You Lose!");
                    h.LoseRound();
                    Console.WriteLine("Current score: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (hPl == "rock")
                {
                    Console.WriteLine("The computer chose Scissors!");
                    Console.WriteLine("You Win!");
                    h.WinRound();
                    Console.WriteLine("You have: " + h.GetPoints());
                    Console.ReadKey();
                    Console.Clear();
                }
                break;

                default:

                break;
            }
                    
            }
        }
    }
    }
}

               
            
        
    

    

               
