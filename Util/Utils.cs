namespace Util
{
    public class Utils
    {
        public bool checkRequest<T>(T args)
        {
            if (args == null)
            {
                return false;
            }
            return true;
        }

    }
}
