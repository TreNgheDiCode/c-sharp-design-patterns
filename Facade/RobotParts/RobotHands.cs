namespace Design_Pattern.Facade.RobotParts
{
    public class RobotHands
    {
        public static void SetMilanoHands()
        {
            Console.WriteLine("The robot will have EH1 Milano hands");
        }
        
        public static void SetRobonautHands()
        {
            Console.WriteLine("The robot will have Robonaut hands");
        }
        
        public static void ResetMilanoHands()
        {
            Console.WriteLine("EH1 Milano hands are about to be destroyed");
        }
        
        public static void ResetRobonautHands()
        {
            Console.WriteLine("Robonaut hands are about to be destroyed");
        }
    }
}
