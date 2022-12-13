using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Core.Other;

public class NestedClassGuard
{
	private int _maxLevel;
	private Dictionary<Type, int> _nestedClasses;
	public enum Operation
	{
		Add,
		Delete
	}

	public NestedClassGuard(int maxLevel)
	{
		_nestedClasses = new Dictionary<Type, int>();
		_maxLevel = maxLevel;
	}

	public void ChangeOccurance(Type type, Operation op)
	{
		switch (op)
		{
			case Operation.Add:
				{
					if (_nestedClasses.ContainsKey(type))
						_nestedClasses[type]++;
					else
						_nestedClasses.Add(type, 1);
				}
				break;
			case Operation.Delete:
				_nestedClasses[type]--;
				break;
			default:
				break;
		}

	}

    public bool IsStuck(Type type) => _nestedClasses[type] > _maxLevel;

}