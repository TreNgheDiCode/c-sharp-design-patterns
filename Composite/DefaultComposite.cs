namespace Design_Pattern.Composite
{
    interface IEmployee
    {
        void PrintStructures();
    }
    
    class CompositeEmployee : IEmployee
    {
        private readonly string name;
        private readonly string dept;

        //The container for child objects
        private readonly List<IEmployee> controls;

        // constructor
        public CompositeEmployee(string name,
        string dept)
        {
            this.name = name;
            this.dept = dept;
            controls = new List<IEmployee>();
        }
    
        public void Add(IEmployee e)
        {
            controls.Add(e);
        }
    
        public void Remove(IEmployee e)
        {
            controls.Remove(e);
        }
    
        public void PrintStructures()
        {
            Console.WriteLine("\t" + this.name + " works in " + this.dept);
            foreach (IEmployee e in controls)
            {
                e.PrintStructures();
            }
        }
    }

    class Employee : IEmployee
    {
        private readonly string name;
        private readonly string dept;

        // constructor
        public Employee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }

        public void PrintStructures()
        {
            Console.WriteLine("\t\t"+this.name + " works in " + this.dept);
        }
    }
}
