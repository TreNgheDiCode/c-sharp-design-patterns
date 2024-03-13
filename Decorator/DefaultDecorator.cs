using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Decorator
{
    public abstract class Component
    {
        public abstract void MakeHouse();
    }

    public class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Original House is complete. It is closed for modification.");
        }
    }

    public abstract class AbstractDecorator : Component
    {
        protected Component com;

        public void SetTheComponent(Component c)
        {
            com = c;
        }

        public override void MakeHouse()
        {
            if (com != null)
            {
                com.MakeHouse(); //Delegating the task
            }
        }
    }

    public class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            //Decorating now.
            AddFloor();
            //You can put additional stuff as per your needs.
        }

        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }

    public class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            //Decorating now.
            PaintTheHouse();
            //You can put additional stuff as per your needs.
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
}
