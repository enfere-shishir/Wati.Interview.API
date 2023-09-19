namespace Wati.API.Common
{
    public static class StorageHelper
    {

        private static Dictionary<string, int>? _staticStorage;

        public static Dictionary<string, int> StaticStorageCache
        {
            get
            {
                if (_staticStorage == null)
                    _staticStorage = new Dictionary<string, int>();
                return _staticStorage;
            }
        }


        public static int GetResultFromStorage(int firstNumber, int secondNumber)
        {

            string key = firstNumber.ToString() + "_" + secondNumber.ToString();

            if (StaticStorageCache.ContainsKey(key))
            {
                return StaticStorageCache[key];
            }
            else
            {
                int sum = firstNumber + secondNumber;
                StaticStorageCache.Add(key, sum);
                return sum;
            }
        }

    }
}