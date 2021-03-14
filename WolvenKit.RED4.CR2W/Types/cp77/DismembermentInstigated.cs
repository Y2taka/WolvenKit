using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentInstigated : redEvent
	{
		[Ordinal(0)] [RED("bodyPart")] public CEnum<EHitReactionZone> BodyPart { get; set; }

		public DismembermentInstigated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}