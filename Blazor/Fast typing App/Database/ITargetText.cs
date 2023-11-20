using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_typing_App.Database
{
    public interface ITargetText
    {
        public Task<T> GetObjectAsync<T>(string id);
    }
}
