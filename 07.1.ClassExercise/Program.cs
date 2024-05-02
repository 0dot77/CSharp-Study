namespace _07._1.ClassExercise
{
    internal class Program
    {
        //private static CongressMan CongressKim = new CongressMan(50, "김의원");
        //private static ExecutiveOfficer ExecutiveHan = new ExecutiveOfficer(40, "한 행정관");
        //private static Assistant AssistantLee = new Assistant(30, "이 보좌관");
        //private static Clerk ClerkYoo = new Clerk(20, "유 사무관");
        private static void Main()
        {
            CongressMan CongressKim = new CongressMan(50, "김의원");
            ExecutiveOfficer ExecutiveHan = new ExecutiveOfficer(40, "한 행정관");
            Assistant AssistantLee = new Assistant(30, "이 보좌관");
            Clerk ClerkYoo = new Clerk(20, "유 사무관");


            Console.WriteLine("상황 1 : 김의원이 법안을 발의한다.");
            Console.WriteLine("##########################");

            CongressKim.MakeLaw();
            ClerkYoo.WriteDocument();

            Console.WriteLine("##########################");
            Console.WriteLine("상황 2 : 김의원이 한 행정관에게 연락한다.");
            Console.WriteLine("##########################");
            CongressKim.Shouting();
            ExecutiveHan.MakeDecision();
        }
    }
}
