#pragma checksum "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentesBlazor\EditaEliminaButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c708485b8f6c68868c7cbe64d7d38e571100c4d"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaProducto_Server.Pages.PaginaBlazor.ComponentesBlazor
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
    public partial class EditaEliminaButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentesBlazor\EditaEliminaButton.razor"
 if (EsAdmin)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<input type=\"button\" class=\"btn btn-danger\" value=\"Eliminar\">\r\n    <input type=\"button\" class=\"btn btn-success\" value=\"Editar\">");
#nullable restore
#line 7 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentesBlazor\EditaEliminaButton.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentesBlazor\EditaEliminaButton.razor"
      
    [Parameter]
    public bool EsAdmin { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
