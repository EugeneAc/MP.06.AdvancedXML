using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP._06.AdvancedXML
{
	public class Counters
	{
		private Dictionary<string, int> counters= new Dictionary<string, int>();

		public int GetCounterValue(string name)
		{
			return counters[name];
		}

		public void IncreaseCounter(string name)
		{
			int result = 1;
			counters.TryGetValue(name, out result);
			counters[name] = result + 1;
		}
	}

}
