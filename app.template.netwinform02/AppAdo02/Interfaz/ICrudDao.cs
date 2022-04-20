using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaz
{
    public interface ICrudDao<T>
    {
        //definir los métodos

        // de esta interface se heredarán los métodos para poder definirlas
        int create(T t);
        int update(T t);
        int delete(T t);
        T findForId(object t);
        List<T> readAll();
    }
}
