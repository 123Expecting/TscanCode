using XLua;
namespace Assets.Scripts.Logic.Battle {
    public static class BattleUtility {
        private static ProfileDelegate _profile = null;

        public static void Initialize(LuaEnv lua)  {
            //ProfileReport����û�ж��壬ֱ�ӷ���
            _profile = lua.Global.GetInPath<ProfileDelegate>("BattleUtility.ProfileReport");
        }

        public static void LuaProfileReport()        {
            _profile(); 
        }
    }
}
