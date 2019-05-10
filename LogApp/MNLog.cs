using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApp
{
	public class MNLog
	{

		static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public static void Info(string title, string msg)
		{
			try
			{
				logger.Info($"{title}, \t{msg}");
			}
			catch
			{
				// 
			}
		}
	}
}
