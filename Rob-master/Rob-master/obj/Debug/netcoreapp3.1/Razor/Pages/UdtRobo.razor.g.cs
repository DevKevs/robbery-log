#pragma checksum "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2cd7287c1078fff3d30126504c30e1ef2707648"
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
#line 2 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
using Rob_master.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
using Rob_master.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UdtRobo")]
    public partial class UdtRobo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ingresar id para actualizar Robo</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-9");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Id del robo");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                       id

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id, culture: global::System.Globalization.CultureInfo.InvariantCulture));
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
#line 10 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                           Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "btn btn-success");
            __builder.AddMarkupContent(21, "<span class=\"oi oi-magnifying-glass\" aria-hidden=\"true\"></span>Siguiente");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n<br>\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card p-4");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<h4>Actualizar un robo</h4>\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.AddMarkupContent(32, "<label><b>Cedula querellante</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", "Example: 40233211958");
            __builder.AddAttribute(36, "maxlength", "11");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.AddMarkupContent(44, "<label><b>Nombre completo</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "placeholder", "Nombre");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombre = __value, nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.AddMarkupContent(55, "<label><b>Detalle del robo</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "placeholder", "Que se robaron");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      desc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => desc = __value, desc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.AddMarkupContent(66, "<label><b>Valor en $RD</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "placeholder", "Valor en $RD");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      valor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => valor = __value, valor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "form-group");
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.AddMarkupContent(77, "<label><b>Lugar del hecho</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "class", "form-control");
            __builder.AddAttribute(80, "placeholder", "Lugar del hecho");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      lugar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lugar = __value, lugar));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "form-group");
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.AddMarkupContent(88, "<label><b>Latitud en decimales</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "class", "form-control");
            __builder.AddAttribute(91, "placeholder", "Latitud");
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      lat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lat = __value, lat));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "form-group");
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.AddMarkupContent(99, "<label><b>Longitud en decimales</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "class", "form-control");
            __builder.AddAttribute(102, "placeholder", "Longitud");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                      lon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lon = __value, lon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    <br> \r\n");
#nullable restore
#line 52 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
 if (ok)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "     ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "form-group");
            __builder.AddAttribute(110, "style", "align-content: center");
            __builder.AddMarkupContent(111, "\r\n         ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                           Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "class", "btn btn-primary");
            __builder.AddContent(115, "Actualizar Robo");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 57 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "alert alert-success d-flex align-items-center");
            __builder.AddAttribute(121, "role", "alert");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "div");
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.OpenElement(125, "b");
            __builder.AddContent(126, 
#nullable restore
#line 60 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
                message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor"
       
    int? id;
    Denuncias querella = new Denuncias();
    robosContext db = new robosContext();
    Dataprocess exe = new Dataprocess();
    bool ok = false;
    string cedula, nombre, desc, lugar, message;
    double? lat, lon, valor;

    public void Next()
    {
        try
        {
            message = "";
            var query = from r in db.Denuncias
                        where r.Id == id
                        select r;
            Denuncias registro = query.First();
            cedula = registro.Cedula;
            nombre = registro.Nombre;
            desc = registro.Descripcion;
            valor = registro.Valor;
            lugar = registro.Lugar;
            lat = registro.Latitud;
            lon = registro.Longitud;
            ok = true;
        }
        catch (Exception)
        {

            message = "Id incorrecto...";
        }

    }
    public void Update()
    {
        try
        {
            message = "";
            querella.Id = id;
            querella.Cedula = cedula;
            querella.Nombre = nombre;
            querella.Descripcion = desc;
            querella.Valor = valor;
            querella.Lugar = lugar;
            querella.Latitud = lat;
            querella.Longitud = lon;

            exe.UpdateRobo(querella);
            message = "Robo actualizado con exito";
        }
        catch (Exception)
        {

            message = "No fue posible actualizar el registro...";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591