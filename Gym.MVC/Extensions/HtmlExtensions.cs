namespace Gym.MVC.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class HtmlExtensions
    {
        public static string GetImporteFormateado(this HtmlHelper html, decimal saldo)
        {
            var signo = "DB";
            if (saldo < 0)
            {
                signo = "CR";
                saldo *= -1;
            }

            var saldoFormateado = string.Format("{0} {1}", GetImporteFormateadoSinSigno(html, saldo), signo);
            return saldoFormateado;
        }

        public static string GetPixelesFormateado(this HtmlHelper html, object valor) => valor.ToString() + "px";

        public static string GetCotizacionFormateadaSinSigno(this HtmlHelper html, decimal cotizacion) => $"{cotizacion:#,0.0000}";

        public static string GetPorcentajeFormateado(this HtmlHelper html, decimal porcentaje) => $"{porcentaje:#,0.0000}";

        public static string GetPrecio3Formateado(this HtmlHelper html, decimal precio) => $"{precio:#,0.000}";

        public static string GetPorcentaje2Formateado(this HtmlHelper html, decimal porcentaje) => $"{porcentaje:#,0.00}";

        public static string GetPrecio4Formateado(this HtmlHelper html, decimal precio) => $"{precio:#,0.0000}";

        public static string GetCantidadFormateada(this HtmlHelper html, decimal cantidad) => $"{cantidad:#,0.000}";

        public static string GetKgFormateado(this HtmlHelper html, int kg) => $"{kg:#,0}";

        public static string GetKgFormateado(this HtmlHelper html, long kg) => $"{kg:#,0}";

        public static string GetKgFormateado(this HtmlHelper html, decimal kg) => $"{kg:#,0}";

        public static string GetFechaFormateada(this HtmlHelper html, DateTime? fecha) => fecha.HasValue ? $"{fecha:dd/MM/yyyy}" : string.Empty;

        public static string GetPeriodo(this HtmlHelper html, DateTime? fecha) => fecha.HasValue ? $"{fecha:MM/yyyy}" : string.Empty;

        public static string GetImporteFormateadoSinSigno(this HtmlHelper html, decimal importe) => importe.ToString("N", new CultureInfo("es-ES"));

        public static MvcHtmlString ComboMultiple(this HtmlHelper html, IEnumerable<ComboDto> source, string Id, bool utilizaIdString = false) => ComboBase(html, source, true, Id, utilizaIdString);

        public static MvcHtmlString Combo(this HtmlHelper html, IEnumerable<ComboDto> source, string Id, bool utilizaIdString = false) => ComboBase(html, source, false, Id, utilizaIdString);

        public static MvcHtmlString CheckBoxMasComboMultiple(this HtmlHelper html, string checkBoxId, string checkBoxText, bool checkBoxChecked, string cboId, string cboText, IEnumerable<ComboDto> source)
        {
            var panel = new TagBuilder("div");
            panel.AddCssClass("panel");
            panel.AddCssClass("panel-default");
            panel.AddCssClass("col-xs-12");

            var panelBody = new TagBuilder("div");
            panelBody.AddCssClass("panel-body");

            var checkbox = new TagBuilder("div");
            checkbox.AddCssClass("form-group");
            checkbox.AddCssClass("checkbox");
            checkbox.AddCssClass("col-sm-3");
            checkbox.AddCssClass("col-xs-12");

            var label = new TagBuilder("label");
            label.Attributes.Add("for", checkBoxId);

            var grupoCombo = new TagBuilder("div");
            grupoCombo.AddCssClass("form-group");
            grupoCombo.AddCssClass("col-sm-9");
            grupoCombo.AddCssClass("col-xs-12");

            var labelCbo = new TagBuilder("label");
            labelCbo.Attributes.Add("for", cboId);
            labelCbo.AddCssClass("col-xs-3");
            labelCbo.AddCssClass("control-label");

            var cbo = new TagBuilder("div");
            cbo.AddCssClass("col-xs-9");
            cbo.AddCssClass("control-activable");

            label.InnerHtml += $"{html.CheckBox(checkBoxId, checkBoxChecked, new { @class = "checkbox-activador" }).ToHtmlString()}{checkBoxText}";
            checkbox.InnerHtml += label.ToString();
            labelCbo.SetInnerText(cboText);
            cbo.InnerHtml += html.ComboMultiple(source, cboId).ToString();
            grupoCombo.InnerHtml += $"{labelCbo}\n{cbo}";
            panelBody.InnerHtml += $"{checkbox}\n{grupoCombo}";
            panel.InnerHtml += panelBody.ToString();

            return MvcHtmlString.Create(panel.ToString());
        }

        private static SelectList GetSelectList(IEnumerable<ComboDto> source, string campoId) => new SelectList(source, campoId, nameof(ComboDto.Descripcion));

        private static MvcHtmlString ComboBase(this HtmlHelper html, IEnumerable<ComboDto> source, bool multiple, string Id, bool utilizaIdString)
        {
            var atributos = new Dictionary<string, object>()
            {
                { "class" , "selectpicker form-control" },
                { "data-live-search" , "true" },
                { "data-live-search-placeholder" , "Buscar" },
                { "data-actions-box" , "true" },
                { "data-container" ,"body" },
                { "id" , Id }
            };

            if (multiple)
                atributos.Add("multiple", string.Empty);

            var campoId = utilizaIdString ? nameof(ComboDto.IdString) : nameof(ComboDto.Id);

            return html.DropDownList(Id, GetSelectList(source, campoId), atributos);
        }
    }
}