using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment2.Singleton
{
    public class Singleton
    {
        static Singleton _instance;
        private IEnumerable<string> _classData;
        private Random rng = new Random();
        private static object _lock = new object();
        private Singleton()
        {
            _classData = new List<string>()
            {
                "test",
                "data",
                "only"
            };
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public string GetRandomClassData()
        {
            return _classData.ElementAt(rng.Next(_classData.Count()));
        }
    }
}
