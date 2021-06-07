using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class MyList<T>
	{
		public void Add(T value)
		{
			Node<T> ddd = new Node<T>();
			ddd.value = value;
			if (firstElement == null)
			{
				firstElement = ddd;
			}
			else
			{
				GetLast().next = ddd;
			}
		}
			Node<T> firstElement;
			Node<T> GetLast()
			{
				Node<T> last = firstElement;
				while(last.next != null)
				{
					last = last.next;
				}
				return last;
			}
			public void Print()
			{
				Node<T> last = firstElement;
				while(last != null)
				{
					Console.WriteLine(last.value);
					last = last.next;
				}
			}
		public void Add2(T v1)
		{
			Node<T> b = new Node<T>();
			b.value = v1;
			if (firstElement != null)
			{
				firstElement.prev = b;
				b.next = firstElement;
				firstElement = b;
			}
			else firstElement = b;
		}
	}
}
