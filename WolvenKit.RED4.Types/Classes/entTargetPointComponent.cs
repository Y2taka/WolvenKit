
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTargetPointComponent : entIPlacedComponent
	{

		public entTargetPointComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
		}
	}
}