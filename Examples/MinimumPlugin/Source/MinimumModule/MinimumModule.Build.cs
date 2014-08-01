namespace UnrealBuildTool.Rules
{
    public class MinimumModule : ModuleRules
	{
        public MinimumModule(TargetInfo Target)
		{
			PublicDependencyModuleNames.AddRange(new string[] {"Core"});
		}
	}
}