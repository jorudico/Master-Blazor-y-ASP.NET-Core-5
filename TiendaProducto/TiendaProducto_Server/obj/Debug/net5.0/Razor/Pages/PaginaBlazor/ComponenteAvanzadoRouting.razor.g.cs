#pragma checksum "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponenteAvanzadoRouting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c07c8dd8d1c99f09c1cf9add5c4ba9b1bbec8ae9"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/componenteavanzadorouting")]
    public partial class ComponenteAvanzadoRouting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ComponenteAvanzadoRouting</h3>\r\n");
            __builder.OpenElement(1, "h4");
            __builder.AddContent(2, "Parametro 1: ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponenteAvanzadoRouting.razor"
                  Param1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "h4");
            __builder.AddContent(6, "Parametro 2: ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponenteAvanzadoRouting.razor"
                  Param2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "p");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponenteAvanzadoRouting.razor"
                                              CargarParametros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Cargar Parametros");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponenteAvanzadoRouting.razor"
                                          Retroceder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Retroceder");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponenteAvanzadoRouting.razor"
       
    private string Param1;
    private string Param2;

    private void CargarParametros()
    {
        var absoluteUri = new Uri(NavigationManager.Uri);
        var ConsultaParametros = System.Web.HttpUtility.ParseQueryString(absoluteUri.Query);

        Param1 = ConsultaParametros["param1"];
        Param2 = ConsultaParametros["param2"];
    }


    private void Retroceder()
    {
        NavigationManager.NavigateTo("componenteRouting");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
