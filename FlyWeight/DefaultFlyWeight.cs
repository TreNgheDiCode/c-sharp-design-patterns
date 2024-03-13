using Design_Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.FlyWeight
{
    /// <summary>
    /// The 'Flyweight' interface
    /// </summary>
    interface IRobot
    {
        void Print();
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class SmallRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("This is a small Robot");
        }
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class LargeRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("I am a large Robot");
        }
    }

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class RobotFactory
    {
        readonly Dictionary<string, IRobot> shapes = new();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }
        
        public IRobot GetRobotFromFactory(string robotType)
        {
            IRobot robotCategory;

            if (shapes.TryGetValue(robotType, out IRobot? value))
            {
                robotCategory = value;
            }
            else
            {
                switch (robotType)
                {
                    case "Small":
                        robotCategory = new SmallRobot();
                        shapes.Add("Small", robotCategory);
                        break;
                    case "Large":
                        robotCategory = new LargeRobot();
                        shapes.Add("Large", robotCategory);
                        break;
                    default:
                        throw new Exception("Robot Factory can create only small and large robots");
                }
            }

            return robotCategory;
        }
    }
}