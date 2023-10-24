using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IBaseRepo<T> where T : class
    {
        IEnumerable<T> GetAll();


        
    }
}
