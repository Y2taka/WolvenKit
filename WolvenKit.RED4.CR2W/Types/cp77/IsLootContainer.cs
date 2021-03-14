using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsLootContainer : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] [RED("invert")] public CBool Invert { get; set; }

		public IsLootContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}