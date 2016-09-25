using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE2 {
	static class Program {
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] Args) {
			if (Args.Length > 0 && Args[0].ToLower() == "-g")
			{
				//如果命令行参数为-g则显示图形界面
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			else
			{
				//否则显示命令行模式
				Console.WriteLine("Hello World");
			}
			
		}
	}
}
