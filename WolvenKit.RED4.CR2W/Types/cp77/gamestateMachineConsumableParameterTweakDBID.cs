using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineConsumableParameterTweakDBID : gamestateMachineActionParameterTweakDBID
	{
		[Ordinal(2)] [RED("consumed")] public CBool Consumed { get; set; }

		public gamestateMachineConsumableParameterTweakDBID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}