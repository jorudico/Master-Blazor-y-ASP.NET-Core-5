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
#nullable restore
#line 2 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\DemoTienda.razor"
using Modelo;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoTienda")]
    public partial class DemoTienda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Jorudico\Desktop\Proyecto_Blazor\TiendaProducto\TiendaProducto_Server\Pages\PaginaBlazor\DemoTienda.razor"
       

    List<LibroBlazor> ListaLibros = new List<LibroBlazor>();
    List<LibroBeneficios> ListaBeneficios = new List<LibroBeneficios>();


    protected override void OnInitialized()
    {
        base.OnInitialized();
        ListaLibros.Add(new LibroBlazor()
        {
            Id = 101,
            NombreLibro = "C# basico",
            Agotado = true,
            Precio = 39,
            LibroTipo = new List<LibroTipo>
{
            new LibroTipo{Id=1,Nombre="Programacion",Valor=10},
            new LibroTipo{Id=1,Nombre="Diseño",Valor=20}

        }
        });
        ListaLibros.Add(new LibroBlazor()
        {
            Id = 102,
            NombreLibro = "C# Avanzado",
            Agotado = true,
            Precio = 68,
            LibroTipo = new List<LibroTipo>
{
            new LibroTipo{Id=1,Nombre="Programacion",Valor=10},
            new LibroTipo{Id=1,Nombre="Diseño",Valor=20}

        }
        });


        ListaBeneficios.Add(new LibroBeneficios
        {
            Id = 111,
            Nombre = "Libro gratis",
            Descripcion = "libro gratis por la proxima compra"
        });
        ListaBeneficios.Add(new LibroBeneficios
        {
            Id = 113,
            Nombre = "Autografo",
            Descripcion = "Autografo del autor"
        });
        ListaBeneficios.Add(new LibroBeneficios
        {
            Id = 114,
            Nombre = "Descuento",
            Descripcion = "Descuento en libros premium"
        });

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
