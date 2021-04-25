using System;

namespace FleetOfThings
{
    public class Thing
    {
        public readonly string Name;
        public bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
    }
}