using NUnit.Framework;

namespace meep.Core.Tests.Win32PInvokeTests
{
	[TestFixture]
	public class SoundTests
	{
		[Test]
		public void TryCallWin32Function()
		{
			Sound.MessageBeep(BeepTypes.IconExclamation);
		}
	}
}