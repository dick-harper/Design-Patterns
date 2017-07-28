namespace Design_Patterns.Console
{
    public class SingletonObject
    {
        private static SingletonObject instance;

        private SingletonObject() { }

        public static SingletonObject Instance
        {
            get
            {
                // lazy load feature
                if (instance == null)
                {
                    instance = new SingletonObject();
                }

                return instance;
            }
        }
    }
}