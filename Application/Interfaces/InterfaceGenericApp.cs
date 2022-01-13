using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add (T obj);
        Task Update(T obj);
        Task Delete(T obj);
        Task<T> GetEntityById(int Id);
        Task<List<T>> List();
    }
}
