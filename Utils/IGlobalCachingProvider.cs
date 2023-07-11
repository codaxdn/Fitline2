using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLine.utils
{
    public interface IGlobalCachingProvider
    {
        void AddItem(string key, object value);

        object GetItem(string key);
        object GetItem(string key, bool remove);
    }

}
