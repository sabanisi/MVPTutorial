using System;

namespace MySystem
{
    public class SystemUtility
    {
        private SystemUtility()
        {
            throw new Exception("Utilityクラスを作成しようとしています");
        }

        public static void SafeCall(Action action)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}