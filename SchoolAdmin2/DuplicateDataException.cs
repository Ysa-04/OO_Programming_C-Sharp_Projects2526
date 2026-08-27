using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmin2
{
    internal class DuplicateDataException : ApplicationException
    {
		private Object object1;

		public Object Object1
		{
			get { return object1; }
			private set { object1 = value; }
		}

		private Object object2;

		public Object Object2
		{
			get { return object2; }
			set { object2 = value; }
		}

		public DuplicateDataException(string message, Object o1, Object o2) : base(message)
		{
			this.Object1 = o1;
			this.Object2 = o2;
		}


	}
}
