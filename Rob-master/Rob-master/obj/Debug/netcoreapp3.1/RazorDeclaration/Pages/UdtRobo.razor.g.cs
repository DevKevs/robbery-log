#pragma checksum "C:\Users\gt\Desktop\Rob-master\Rob-master\Pages\UdtRobo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2cd7287c1078fff3d30126504c30e1ef2707648"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
