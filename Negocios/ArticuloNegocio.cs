using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominios;

namespace Negocios
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccessoDatos datos = new AccessoDatos();
            
            try
            {         
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, I.ImagenUrl, A.Precio from ARTICULOS A, IMAGENES I, MARCAS M, CATEGORIAS C WHERE A.Id = I.IdArticulo AND A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.codigo = (string)datos.Lector["Codigo"];
                    articulo.nombre = (string)datos.Lector["Nombre"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    articulo.marca = new Marca();
                    articulo.marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.categoria = new Categoria();
                    articulo.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.imagen = new Imagen();
                    articulo.imagen.Url = (string)datos.Lector["ImagenUrl"];
                    articulo.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(articulo);

                }

               
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<string> listarNombres()
        {
            List<string> lista = new List<string>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre from ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string nombre;
                    nombre = (string)lector["Nombre"];
                    lista.Add(nombre);
                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
