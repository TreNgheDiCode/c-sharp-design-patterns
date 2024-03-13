using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Proxy
{
    public class DefaultProxy
    {
        /// <summary>
        /// Abstract class Subject
        /// </summary>
        public abstract class Subject
        {
            public abstract void DoSomeWork();
        }

        /// <summary>
        /// ConcreteSubject class
        /// </summary>
        public class ConcreteSubject : Subject
        {
            public override void DoSomeWork()
            {
                Console.WriteLine("ConcreteSubject.DoSomeWork()");
            }
        }

        /// <summary>
        /// Proxy class
        /// </summary>
        public class Proxy : Subject
        {
            Subject cs;
            public override void DoSomeWork()
            {
                Console.WriteLine("Proxy call happening now...");

                //Lazy initialization:We'll not instantiate until the method is //called
                cs ??= new ConcreteSubject();

                cs.DoSomeWork();
            }
        }
    }
}
