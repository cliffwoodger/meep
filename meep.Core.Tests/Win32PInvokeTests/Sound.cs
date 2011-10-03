using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace meep.Core.Tests.Win32PInvokeTests
{
	sealed class Sound
	{
		public static void MessageBeep(BeepTypes type)
		{
			if (!MessageBeep((UInt32)type))
			{
				Int32 err = Marshal.GetLastWin32Error();
				throw new Win32Exception(err);
			}
		}

		[DllImport("User32.dll", SetLastError = true)]
		static extern Boolean MessageBeep(UInt32 beepType);

		private Sound() { }
	}
}