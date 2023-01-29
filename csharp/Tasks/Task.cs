using System;
using System.Collections.Generic;

namespace Tasks
{
	public class Task
	{
        public Identifier Identifier = 0;

        public Description Description = "";

		public Done Done = false;
	
		public Task() { }

		public override string ToString()
			=> string.Join(string.Empty, Identifier) + " "
			+ string.Join(string.Empty, Description);
	
	}

    public class Done
    {
        public static implicit operator Done(bool done)
        {
            throw new NotImplementedException();
        }
    }

    public class Description
    {
        public static implicit operator Description(string description)
        {
            throw new NotImplementedException();
        }
    }

    public class Identifier
    {
        public static implicit operator Identifier(int identifier)
        {
            throw new NotImplementedException();
        }
    }
}
