#pragma checksum "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719ecebb3d2592ea36e3a4d0a12fc1b154087a2f"
// <auto-generated/>
#pragma warning disable 1591
namespace Receipts.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Receipts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/workspaces/Cooking-Recipe/Receipts/_Imports.razor"
using Receipts.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listrecipes")]
    public partial class ListRecipies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Suas Receitas</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Visualize aqui suas receitas</p>");
#nullable restore
#line 11 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
 if (receipts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                <th>Nome</th>\r\n                <th>Data</th>\r\n                <th>Ações</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 27 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
             foreach (var receipt in receipts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", "/recipe/" + (
#nullable restore
#line 30 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                                          receipt.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, 
#nullable restore
#line 30 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                                                       receipt.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                         receipt.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                         receipt.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-danger");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
                                                                                   () => DeleteRecipe(receipt.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Deletar");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.AddMarkupContent(26, "<button type=\"button\" class=\"btn btn-primary\">editar</button>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/workspaces/Cooking-Recipe/Receipts/Pages/ListRecipies.razor"
       
    private List<Receipt> receipts = new List<Receipt>();

    protected override async Task OnInitializedAsync()
    {
        receipts = await _receiptService.ListAll();
    }

    private async Task DeleteRecipe(Guid id)
    {
        await _receiptService.DeleteReceipt(id);
        NavManager.NavigateTo("/listrecipes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.Services.ReceiptService _receiptService { get; set; }
    }
}
#pragma warning restore 1591
