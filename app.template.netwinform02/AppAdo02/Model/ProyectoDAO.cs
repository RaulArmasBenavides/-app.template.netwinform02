using app.template.netwinform02.Database;
using app.template.netwinform02.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.template.netwinform02.Model
{
    public class ProyectoDAO
    {
        //metodos de consulta

        public void create(Proyecto reg)
        {
            using (var cn = AccesoDB.getConnection())
            {
                int IdProducto = -1;
                SqlCommand cmd = new SqlCommand("usp_Producto_Adicionar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", reg.idProyecto);
                cmd.Parameters.AddWithValue("@Monto", reg.monto);
                cmd.Parameters.AddWithValue("@Fecha", reg.fecha);
                SqlParameter par = cmd.Parameters.Add("@IdProducto", SqlDbType.Int);
                par.Direction = ParameterDirection.Output;
                int n = cmd.ExecuteNonQuery();
                if (n > 0) IdProducto = (int)par.Value;
            }
        }//end

        public void update(Proyecto reg)
        {
            using (var cn = AccesoDB.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_Producto_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProyecto", reg.idProyecto);
                cmd.Parameters.AddWithValue("@Monto", reg.monto);
                cmd.Parameters.AddWithValue("@Fecha", reg.fecha);
                cmd.ExecuteNonQuery();
            }

        }//end

        public void delete(Proyecto reg)
        {
            using (var cn = AccesoDB.getConnection())
            {
              SqlCommand cmd = new SqlCommand("usp_Producto_Eliminar", cn);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@idProyecto", reg.idProyecto);
              cmd.ExecuteNonQuery();
            }
        }//end

        public DataTable listaProyectos()
        {
            DataTable dt;
            using (var cn = AccesoDB.getConnection())
            {
                SqlDataAdapter dap = new SqlDataAdapter("usp_Proyecto_Listar", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                dap.Fill(dt);
            }
            return dt;
        }



       

    }
}
