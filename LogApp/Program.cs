﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("hello");
			MNLog.Info("Tên file", "Nội dung lỗi");
			Console.ReadKey();
		}
	}
}
