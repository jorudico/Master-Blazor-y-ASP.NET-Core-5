#pragma checksum "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentePadre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e77e2ba7f5346b8eac882ceedc74f4300332298"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/componentePadre")]
    public partial class ComponentePadre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Componente Padre Hijo</h1>\r\n\r\n");
            __Blazor.TiendaProducto_Server.Pages.PaginaBlazor.ComponentePadre.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 4 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentePadre.razor"
                        MensajeParaSubComponente

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenComponent<TiendaProducto_Server.Pages.PaginaBlazor.ComponentesBlazor.ComponenteHijo>(4);
                __builder2.AddAttribute(5, "MetodoBtnOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentePadre.razor"
                                      MostrarMensaje

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "Titulo", "Primer Componenete Hijo");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, " Contenido mostrado por RenderFragment desde componente principal");
                }
                ));
                __builder2.AddAttribute(9, "SegunChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Segundo contenido por RenderFragment");
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<TiendaProducto_Server.Pages.PaginaBlazor.ComponentesBlazor.SegundoComponenteHijo>(12);
            __builder.AddAttribute(13, "placeholder", "Placeholder determinado");
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "p");
            __builder.OpenElement(16, "b");
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentePadre.razor"
       TextoMensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\ComponentePadre.razor"
       




    private string MensajeParaSubComponente = "Este es un mensaje desde componente padre";
    private string TextoMensaje = "";
    private void MostrarMensaje(MouseEventArgs e)
    {
        TextoMensaje = "Texto desde componente padre";
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TiendaProducto_Server.Pages.PaginaBlazor.ComponentePadre
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
