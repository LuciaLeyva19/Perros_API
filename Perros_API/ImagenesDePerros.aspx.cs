using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Perros_API
{
    public partial class ImagenesDePerros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerImagenPerro();
            }
        }
        protected void btnObtenerImagen_Click(object sender, EventArgs e)
        {
            ObtenerImagenPerro();
        }

        private void ObtenerImagenPerro()
        {
            string urlApi = "https://dog.ceo/api/breeds/image/random";

            HttpWebRequest solicitud = (HttpWebRequest)WebRequest.Create(urlApi);
            solicitud.Method = "GET";

            using (HttpWebResponse respuesta = (HttpWebResponse)solicitud.GetResponse())
            {
                using (StreamReader lector = new StreamReader(respuesta.GetResponseStream()))
                {
                    string ImagenRespuesta = lector.ReadToEnd();

                    JObject json = JObject.Parse(ImagenRespuesta);
                    string urlImagen = json["message"].ToString();

                    imgPerro.ImageUrl = urlImagen;
                }
            }
        }
    }
}