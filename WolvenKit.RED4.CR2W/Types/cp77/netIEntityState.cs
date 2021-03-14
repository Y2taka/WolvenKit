using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netIEntityState : CVariable
	{
		[Ordinal(0)] [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(1)] [RED("persistentID")] public CUInt64 PersistentID { get; set; }

		public netIEntityState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}