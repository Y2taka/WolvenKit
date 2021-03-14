using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_StaticQuat : animIAnimNodeSourceChannel_Quat
	{
		[Ordinal(0)] [RED("data")] public Quaternion Data { get; set; }

		public animAnimNodeSourceChannel_StaticQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}