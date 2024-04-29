using Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ImagenNegocio
    {
        public void agregar(Imagen nuevo)
        {
            AccessoDatos datos = new AccessoDatos();

            try
            {
                datos.setearConsulta("insert into IMAGENES(IdArticulo, ImagenUrl) values(@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", nuevo.Id);
                datos.setearParametro("@ImagenUrl", nuevo.Url);
                datos.ejecutarAccion();
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
    }
}
