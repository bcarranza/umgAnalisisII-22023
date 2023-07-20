using System;

namespace ComponentDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a component.
            var component = new Component();

            // Distribute the component to two different machines.
            var machine1 = new Machine();
            machine1.AddComponent(component);

            var machine2 = new Machine();
            machine2.AddComponent(component);

            // Use the component on both machines.
            machine1.UseComponent();
            machine2.UseComponent();
        }
    }

    class Component
    {
        public void Use()
        {
            Console.WriteLine("The component is being used.");
        }
    }

    class Machine
    {
        private Component _component;

        public void AddComponent(Component component)
        {
            _component = component;
        }

        public void UseComponent()
        {
            _component.Use();
        }
    }
}
