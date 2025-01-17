# Registering custom skills
Creation of custom skills is done through the [SkillManager](xref:JotunnLib.Managers.SkillManager) singleton class.
This will automatically take care of incrementing the skill's SkillType (unique numerical ID), so there will be no conflicts between skills added by various mods.

## Example
To create a new skill, you must call the RegisterSkill function.

This should be called from within your mod's `Awake` method, and it will return a randomly generated SkillType for your new skill.
```cs
namespace TestMod
{
    [BepInPlugin("com.bepinex.plugins.jotunnlib.testmod", "JotunnLib Test Mod", "0.0.1")]
    [BepInDependency("com.bepinex.plugins.jotunnlib")]
    class TestMod : BaseUnityPlugin
    {
        public static Skills.SkillType TestSkillType = 0;

        private void Awake()
        {
            TestSkillType = SkillManager.Instance.RegisterSkill("Testing", "A nice testing skill");
        }
    }
}
```

_Note: Unless you actually have any levels in your skill, it won't show up in the skils menu. You must first raise your skill (either using a command, or actually implementing a way to earn levels) in order to be able to see it_

This is what it should look like in game:

![Our Skill in Game](../../images/data/test-skill.png "Our Skill in Game")