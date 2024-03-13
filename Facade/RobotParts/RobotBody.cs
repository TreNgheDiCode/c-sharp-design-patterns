namespace Design_Pattern.Facade.RobotParts
{
    public class RobotBody
    {
        public static void CreateHands()
        {
            Console.WriteLine("Handsmanufactured");
        }
        
        public static void CreateRemainingParts()
        {
            Console.WriteLine("Remaining parts (other than hands) are created");
        }
        
        public static void DestroyHands()
        {
            Console.WriteLine("The robot's hands are destroyed");
        }
        
        public static void DestroyRemainingParts()
        {
            Console.WriteLine("The robot's remaining parts are destroyed");
        }
    }
}
