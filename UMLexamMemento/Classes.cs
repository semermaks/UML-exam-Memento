using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLexamMemento
{
	public class Originator
	{
		public bool?[,] arr { get; set; } = new bool?[3, 3];

		public Memento CreateMemento()
		{
			return new Memento(arr);
		}

		public void SetMemento(Memento memento)
		{
			Console.WriteLine("Restoring state...");
			arr = memento.State;
		}
	}

	public class Memento
	{
		public bool?[,] State { get; }

		public Memento(bool?[,] state)
		{
			State = state;
		}
	}

	public class Caretaker
	{
		public Memento Memento { set; get; }
	}
}
