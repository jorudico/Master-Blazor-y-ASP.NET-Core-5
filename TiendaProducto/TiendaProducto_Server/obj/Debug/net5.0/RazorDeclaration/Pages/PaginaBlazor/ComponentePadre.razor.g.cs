// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TiendaProducto_Server.Pages.PaginaBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using TiendaProducto_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using TiendaProducto_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\_Imports.razor"
using TiendaProducto_Server.Pages.PaginaBlazor.ComponentesBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/componentePadre")]
    public partial class ComponentePadre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentePadre.razor"
       
    private string TextoMensaje = "";
    private void MostrarMensaje(MouseEventArgs e)
    {
        TextoMensaje = "Texto desde componente padre";
    }

        public Dictionary<string, object> InputAtributosPadre { get; set; } = new Dictionary<string, object>()
    {
        { "required","required" },
        { "placeholder","Ingrese nombre del libro desde padre" },
        { "maxlength",5 },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
