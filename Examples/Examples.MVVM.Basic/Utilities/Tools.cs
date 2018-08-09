using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.MVVM.Basic.Utilities
{
    public static class Tools
    {
        public static T JsonDeserialize<T>(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);
            string value = File.ReadAllText(fileName);
            return (T)JsonConvert.DeserializeObject<T>(value);
        }
    }
}
