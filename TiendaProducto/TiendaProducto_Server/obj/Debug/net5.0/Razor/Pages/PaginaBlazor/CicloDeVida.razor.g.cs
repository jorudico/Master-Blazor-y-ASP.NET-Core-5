#pragma checksum "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f9cb8988de836ad999f86dfa499e1298bb0cd3a"
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
#nullable restore
#line 2 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cicloDeVida")]
    public partial class CicloDeVida : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Ciclo de Vida</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border");
            __builder.OpenComponent<TiendaProducto_Server.Pages.PaginaBlazor.ComponentesBlazor.CicloDeVidaComponent>(3);
            __builder.AddAttribute(4, "CountValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
                                       currentCount

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Current count: ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<br> ");
            __builder.AddContent(15, 
#nullable restore
#line 13 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
       Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
                               EmpezarConteo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Empezar Conteo");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
 foreach (var item in EventType)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, 
#nullable restore
#line 16 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
     item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "<hr>");
#nullable restore
#line 18 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\CicloDeVida.razor"
       
    private int currentCount = 0;
    List<string> EventType = new List<string>();
    private int Count = 5;

    private void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInitialized()
    {
        EventType.Add("Se esta llamando a Onitialized");
        base.OnInitialized();
    }

    protected override async Task OnInitializedAsync()
    {
        EventType.Add("Se esta llamando a OnInitializedAsync");

    }



    protected override void OnParametersSet()
    {
        EventType.Add("Se esta llamando a OnParametersSet");
    }

    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("Se esta llamando a OnParametersSetAsync");


    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            currentCount = 111;
        }
        else
        {
            currentCount = 999;
        }
        EventType.Add("Se esta llamando a OnAfterRender");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("Se esta llamando a OnAfterRenderAsync");
    }

    protected override bool ShouldRender()
    {
        EventType.Add("Se esta llamando a ShouldRender");
        return true;
    }

    void EmpezarConteo()
    {
        var timer = new Timer(TimeCallback,null,1000,1000);
    }

    void TimeCallback(object state)
    {
        if (Count >0)
        {
            Count--;
            InvokeAsync(StateHasChanged);
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
