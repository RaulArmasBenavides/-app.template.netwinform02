using CapaDatos.Entity;
using CapaDatos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Controller
{
   public class ProyectoBll
    {

        //variable de la clase ProductoDao
        ProyectoDAO dao;
        //constructor
        public ProyectoBll()
        {
            dao = new ProyectoDAO();
        }

        //metodos de negocio
        public DataTable ProyectoListar()
        {
            try
            {
                return dao.listaProyectos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ProyectoAdicionar(Proyecto reg)
        {
            try
            {
                dao.create(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ProyectoActualizar(Proyecto reg)
        {
            try
            {
                dao.update(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ProyectoEliminar(Proyecto reg)
        {
            try
            {
                dao.delete(reg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Proyecto ProyectoBuscar(object p)
        {
            return dao.findForId(p);
        }

    }
}
