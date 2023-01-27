using System;
using System.Collections.Generic;

namespace Tasks
{
	public class Task
	{
        public long Identifier = 0;

        public string Description = "";

		public bool Done = false;
	
		public Task() { }

		public override string ToString()
			=> string.Join(string.Empty, Identifier) + " "
			+ string.Join(string.Empty, Description);
	
	}
}
