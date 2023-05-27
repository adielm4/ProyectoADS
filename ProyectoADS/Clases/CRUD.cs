using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proyecto
{
    class CRUD
    {
        Conexion conexion = new Conexion();

        /*----------------------USUARIO---------------------------------*/
        public string autentificarse(string usuario, string pass)
        {
            string tipo="";
                conexion.conectar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = Conexion.conn;
                comm.CommandText = "select idRol from usuario where usuario = @usuario and pass = @pass";
                comm.Parameters.AddWithValue("usuario", usuario);
                comm.Parameters.AddWithValue("pass", pass);
                tipo = Convert.ToString(comm.ExecuteScalar());
                conexion.desconectar();
            return tipo;
        }

        public int idUsuarioLogeado(string usuario, string pass)
        {
            int idLogeado = 0;
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "select id from usuario where usuario = @usuario and pass = @pass";
            comm.Parameters.AddWithValue("usuario", usuario);
            comm.Parameters.AddWithValue("pass", pass);
            idLogeado = Convert.ToInt32(comm.ExecuteScalar());
            conexion.desconectar();

            return idLogeado;
        }

        public void insertarUsuario(int idRol,int idDepartamento,string nombre, string username, string password)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "Insert into usuario values (@idRol,@idDepa,@nombre,@username,@pass)";
            comm.Parameters.AddWithValue("idRol", idRol);
            comm.Parameters.AddWithValue("idDepa", idDepartamento);
            comm.Parameters.AddWithValue("nombre", nombre);
            comm.Parameters.AddWithValue("username", username);
            comm.Parameters.AddWithValue("pass", password);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

        public void updateUsuario(int id,int idRol, int idDepartamento, string nombre, string username, string password)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "Update usuario set idRol = @idRol,idDepartamento=@idDepa,nombre=@nombre,usuario=@username,pass= @pass where id=@id";
            comm.Parameters.AddWithValue("id", id);
            comm.Parameters.AddWithValue("idRol", idRol);
            comm.Parameters.AddWithValue("idDepa", idDepartamento);
            comm.Parameters.AddWithValue("nombre", nombre);
            comm.Parameters.AddWithValue("username", username);
            comm.Parameters.AddWithValue("pass", password);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

        public void eliminarUsuario(int id)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "delete from usuario where id=@id";
            comm.Parameters.AddWithValue("id", id);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

        //------------------------------------OTROS----------------------------------//
        public DataTable verCasos(int idUsuario)
        {
            conexion.conectar();
            SqlCommand cmd = new SqlCommand("select id,descripcion from caso where programador=" + idUsuario, Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.desconectar();
            return dt;
        }

        public DataTable verTodasMisBitacoras(int idUsuario)
        {
            conexion.conectar();
            SqlCommand cmd = new SqlCommand("select id,=" + idUsuario, Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.desconectar();
            return dt;
        }

        public DataTable verBitacoras(string bitacora)
        {
            SqlCommand cmd = new SqlCommand("select id as 'N°', idCaso as 'ID caso', descripcion as 'Descripción' from bitacora where idCaso=@id", Conexion.conn);
            cmd.Parameters.AddWithValue("id", bitacora);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable verUsuario()
        {
            conexion.conectar();
            string query = "select * from usuario";
            SqlDataAdapter da = new SqlDataAdapter(query, Conexion.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Datos1");
            conexion.desconectar();
            return ds.Tables[0];
        }
        public DataTable verSolicitudesPorIdUsuario(int idLogueado, int estado)
        {
            SqlCommand cmd = new SqlCommand();

            if (estado == 0)
            {
                cmd = new SqlCommand("select s.id as ID, s.descripcion as 'Descripción', CONCAT(DAY(s.fechaEntrega), '/', MONTH(fechaEntrega), '/', YEAR(fechaEntrega)) as 'Fecha de Creación', d.descripcion as 'Departamento', e.nombre as Estado, s.estado as id_estado from solicitud s inner join usuario u on u.id = s.usuarioCreacion inner join departamento d on u.idDepartamento = d.id inner join estados e on s.estado = e.id_estado where s.usuarioCreacion = " + idLogueado, Conexion.conn);

            }
            else
            {
                cmd = new SqlCommand("select s.id as ID, s.descripcion as 'Descripción', CONCAT(DAY(s.fechaEntrega), '/', MONTH(fechaEntrega), '/', YEAR(fechaEntrega)) as 'Fecha de Creación', d.descripcion as 'Departamento', e.nombre as Estado, s.estado as id_estado from solicitud s inner join usuario u on u.id = s.usuarioCreacion inner join departamento d on u.idDepartamento = d.id inner join estados e on s.estado = e.id_estado where s.usuarioCreacion = " + idLogueado + " and s.estado = '" + estado + "'", Conexion.conn);
            }
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable verDepartamento()
        {
            conexion.conectar();
            string query = "select id as ID, descripcion as 'Nombre departamento' from departamento";
            SqlDataAdapter da = new SqlDataAdapter(query, Conexion.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Datos1");
            conexion.desconectar();
            return ds.Tables["Datos1"];
        }

        public DataTable verRoles()
        {
            conexion.conectar();
            string query = "select * from rol where id != 1";
            SqlDataAdapter da = new SqlDataAdapter(query, Conexion.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Datos");
            conexion.desconectar();
            return ds.Tables["Datos"];
        }
        /* ----------------------DEPARTAMENTO------------------------------------*/
        public void insertarDepartamento(string descripcion)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "Insert into departamento values (@descripcion)";
            comm.Parameters.AddWithValue("descripcion", descripcion);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

        public void actualizarDepartamento(int id,string descrip)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "update departamento set descripcion=@des where id=@id";
            comm.Parameters.AddWithValue("id", id);
            comm.Parameters.AddWithValue("des", descrip);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

        public void eliminarDepartamento(int id)
        {
            try
            {
                conexion.conectar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = Conexion.conn;
                comm.CommandText = "delete from departamento where id= @id";
                comm.Parameters.AddWithValue("id", id);
                comm.ExecuteNonQuery();
                conexion.desconectar();
            }
            catch(Exception)
            {
                MessageBox.Show("No se puede borrar debido a que hay usuarios en ese departamento!");
            }
        }
        /* *************** Tester ************** */
        public DataTable VerCasosTester(int idTester)
        {
            conexion.conectar();
            string query = "Select c.id, descripcion, CONCAT(porcentaje_avance, '%') as 'Avance', CONCAT(DAY(c.fecha_limite), '/', MONTH(c.fecha_limite), '/', YEAR(c.fecha_limite)) as 'Fecha Limite', u.nombre as 'Programador' from caso c inner join usuario u on u.id = c.programador where c.tester = " + idTester;
            SqlDataAdapter da = new SqlDataAdapter(query, Conexion.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Datos1");
            conexion.desconectar();
            return ds.Tables["Datos1"];
        }
        public void ActualizarObservaciones(string id, string observacion)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "Update caso set observaciones = @observacion where id = @id;";
            comm.Parameters.AddWithValue("id", id);
            comm.Parameters.AddWithValue("observacion", observacion);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

        public void ActualizarFechaLimiteCaso(string idCaso)
        {
            conexion.conectar();
            SqlCommand command = new SqlCommand();
            command.Connection = Conexion.conn;
            DateTime nuevaFecha = DateTime.Now.AddDays(7);
            command.CommandText = "update caso set fecha_limite = @nuevaFecha where id = @id;";
            command.Parameters.AddWithValue("nuevaFecha", nuevaFecha);
            command.Parameters.AddWithValue("id", idCaso);
            command.ExecuteNonQuery();
            conexion.desconectar();
        }
        public void AprobarCaso(string id, DateTime fechaProduccion)
        {
            conexion.conectar();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conexion.conn;
            comm.CommandText = "Update caso set observaciones = 'Finalizado', fecha_produccion = @fecha where id = @id;";
            comm.Parameters.AddWithValue("id", id);
            comm.Parameters.AddWithValue("fecha", fechaProduccion);
            comm.ExecuteNonQuery();
            conexion.desconectar();
        }

    }
}
