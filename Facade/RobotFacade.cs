using Design_Pattern.Facade.RobotParts;

namespace Design_Pattern.Facade
{
    public class RobotFacade
    {
        public RobotFacade()
        {
        }
        
        public static void ConstructMilanoRobot()
        {
            Console.WriteLine("Creation of a Milano Robot Start");
            RobotColor.SetDefaultColor();
            RobotHands.SetMilanoHands();
            RobotBody.CreateHands();
            RobotBody.CreateRemainingParts();
            Console.WriteLine("Milano Robot Creation End");
            Console.WriteLine();
        }
        
        public static void ConstructRobonautRobot()
        {
            Console.WriteLine("Initiating the creational process of a Robonaut Robot");
            RobotColor.SetGreenColor();
            RobotHands.SetRobonautHands();
            RobotBody.CreateHands();
            RobotBody.CreateRemainingParts();
            Console.WriteLine("A Robonaut Robot is created");
            Console.WriteLine();
        }
        
        public static void DestroyMilanoRobot()
        {
            Console.WriteLine("Milano Robot's destruction process is started"); RobotHands.ResetMilanoHands();
            RobotBody.DestroyHands();
            RobotBody.DestroyRemainingParts();
            Console.WriteLine("Milano Robot's destruction process is over");
            Console.WriteLine();
        }
        
        public static void DestroyRobonautRobot()
        {
            Console.WriteLine("Initiating a Robonaut Robot's destruction process.");
            RobotHands.ResetRobonautHands();
            RobotBody.DestroyHands();
            RobotBody.DestroyRemainingParts();
            Console.WriteLine("A Robonaut Robot is destroyed");
            Console.WriteLine();
        }
    }
}
