#pragma checksum "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb628f24fb79deb234a719bf81e8241587757dfc"
// <auto-generated/>
#pragma warning disable 1591
namespace Rob_master.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Rob_master;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Rob_master.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gt\Desktop\Rob-master\Rob-master\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
using Rob_master.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
using Rob_master.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Export")]
    public partial class Export : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Export</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-9");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "cedula del querellante a exportar");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                       cedula

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-3");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                           Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "btn btn-success");
            __builder.AddMarkupContent(21, "<span class=\"oi oi-magnifying-glass\" aria-hidden=\"true\"></span>Exportar");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n<br>\r\n");
#nullable restore
#line 14 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
 if (preview)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.OpenElement(26, "center");
            __builder.AddMarkupContent(27, "\r\n        <img src=\"/Online Review-pana.svg\" width=\"450\">\r\n        ");
            __builder.OpenElement(28, "code");
            __builder.AddContent(29, 
#nullable restore
#line 18 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
               message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 20 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
 if (ok)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "    <br><br>\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card text-white bg-dark mb-3");
            __builder.AddAttribute(35, "style", "max-width: 25rem;");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-header");
            __builder.AddContent(39, "Exportando caso ID #");
            __builder.AddContent(40, 
#nullable restore
#line 25 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                      querella.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card-body");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "h5");
            __builder.AddAttribute(46, "class", "card-title");
            __builder.AddContent(47, 
#nullable restore
#line 27 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                    querella.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "p");
            __builder.AddAttribute(50, "class", "card-text");
            __builder.AddContent(51, "el querellante de la cedula ");
            __builder.AddContent(52, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                              querella.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " ha denunciado a la fecha de ");
            __builder.AddContent(54, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                                                                           querella.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " por el concepto de robo de \"");
            __builder.AddContent(56, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                                                                                                                       querella.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, "\" con un valor de $RD ");
            __builder.AddContent(58, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                                                                                                                                                                  querella.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " efectuado en ");
            __builder.AddContent(60, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                                                                                                                                                                                               querella.Lugar

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " especificamente en la latitud ");
            __builder.AddContent(62, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                                                                                                                                                                                                                                             querella.Latitud

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(63, " y la longitud ");
            __builder.AddContent(64, 
#nullable restore
#line 28 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
                                                                                                                                                                                                                                                                                                             querella.Longitud

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, ", las desiciones seran tomadas en la corte.");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 31 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\Export.razor"
       
    Denuncias querella = new Denuncias();
    robosContext db = new robosContext();
    bool ok;
    bool preview = true;
    string cedula, message;

    public void Next()
    {
        try
        {
            ok = false;
            message = "";
            var query = from r in db.Denuncias
                        where r.Cedula == cedula
                        select r;
            querella = query.First();
            ok = true;
            preview = false;
        }
        catch (Exception)
        {
            preview = true;
            message = "No se encontro el robo para exportar";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
