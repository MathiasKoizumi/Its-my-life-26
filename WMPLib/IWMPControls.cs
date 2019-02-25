using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib
{
	[ComImport]
	[CompilerGenerated]
	[Guid("74C09E02-F828-11D2-A74B-00A0C905F36E")]
	[TypeIdentifier]
	public interface IWMPControls
	{
		void _VtblGap1_1();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(51)]
		void play();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(52)]
		void stop();
	}
}
