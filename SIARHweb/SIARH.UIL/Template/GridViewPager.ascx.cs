using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace SIARH.Template
{
    public partial class GridViewPager : System.Web.UI.UserControl
    {
        
        // Creo un objeto del tipo GridView
        private GridView _gridView;

        // Asigno al objeto GridView el GridView de la pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            Control c = Parent;
            while (c != null)
            {
                if (c is GridView)
                {
                    _gridView = (GridView)c;
                    break;
                }
                c = c.Parent;
            }
        }

        // Visualizar el número de página del GridView
        protected void TextBoxPage_TextChanged(object sender, EventArgs e)
        {
            if (_gridView == null)
            {
                return;
            }
            int page;
            if (int.TryParse(TextBoxPage.Text.Trim(), out page))
            {
                if (page <= 0)
                {
                    page = 1;
                }
                if (page > _gridView.PageCount)
                {
                    page = _gridView.PageCount;
                }

                _gridView.PageIndex = page - 1;
                Enlazar_ConDatosExternos();
            }
            TextBoxPage.Text = (_gridView.PageIndex + 1).ToString(CultureInfo.CurrentCulture);
        }

        // Cambiar la cantidad de registros por página según el valor elegido en el DropDownList
        protected void DropDownListPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_gridView == null)
            {
                return;
            }
            DropDownList dropdownlistpagersize = (DropDownList)sender;
            _gridView.PageSize = Convert.ToInt32(dropdownlistpagersize.SelectedValue, CultureInfo.CurrentCulture);
            int pageindex = _gridView.PageIndex;
            Session["PaginaActual"] = _gridView.PageIndex.ToString();
            Session["RegistrosPorPagina"] = _gridView.PageSize.ToString();

            Enlazar_ConDatosExternos();

            if (_gridView.PageIndex != pageindex)
            {
                //Si el índice de la página cambió, significa que la página anterior no era válida y se ha ajustado. Vuelva a enlazar al control de relleno con la página ajustada
                _gridView.DataBind();
            }
        }

        // Asigno los valores de página actual, cantidad de páginas y registros por página
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (_gridView != null)
            {
                LabelNumberOfPages.Text = _gridView.PageCount.ToString(CultureInfo.CurrentCulture);
                TextBoxPage.Text = (_gridView.PageIndex + 1).ToString(CultureInfo.CurrentCulture);
                DropDownListPageSize.SelectedValue = _gridView.PageSize.ToString(CultureInfo.CurrentCulture);
            }
        }

        // Enlazo los datos del GridView con el Pager
        protected void Enlazar_ConDatosExternos()
        {
            DataTable dt = Session["gvDataSource"] as DataTable;
            _gridView.DataSource = dt;
            _gridView.DataBind();
        }


    }
}


