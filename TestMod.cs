// 新建一个极简插件（命名为TestMod.cs）
using BepInEx;
using HarmonyLib;

namespace TestMod
{
    [BepInPlugin("com.test.mod", "Test Mod", "1.0.0")]
    public class TestMod : BaseUnityPlugin
    {
        private void Awake()
        {
            // 只初始化Harmony，不打任何补丁
            new Harmony("com.test.mod").PatchAll();
            Logger.LogInfo("极简插件加载完成，未打任何补丁");
        }
    }
}