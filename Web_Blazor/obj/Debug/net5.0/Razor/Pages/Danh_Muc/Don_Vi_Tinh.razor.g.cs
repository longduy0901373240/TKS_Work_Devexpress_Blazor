#pragma checksum "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c8c4783557658f7f62a984957fd9c2b3ab4665d"
// <auto-generated/>
#pragma warning disable 1591
namespace Web_Blazor.Pages.Danh_Muc
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Web_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\_Imports.razor"
using Web_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
using Controller.Danh_Muc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
using Entity.Danh_Muc;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc/don_vi_tinh")]
    public partial class Don_Vi_Tinh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> ????n v??? t??nh page </h1>\n");
            __builder.AddMarkupContent(1, "<h4>Th??ng tin ????n v??? t??nh</h4>");
#nullable restore
#line 9 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
 if (p_objData is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-striped");
            __builder.AddMarkupContent(5, @"<thead><tr><th> Auto ID</th>
                <th> T??n ????n v??? t??nh</th>
                <th> Deleted</th>
                <th> Created</th>
                <th> Created By</th>
                <th> Last Updated</th>
                <th> Last Updated By</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 28 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
             foreach (var p_objItem in p_objData)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 31 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.Auto_ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 32 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.Ten_Don_Vi_Tinh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 33 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.deleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.Created

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.Created_By

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 36 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.Last_Updated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 37 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
                         p_objItem.Last_Updated_By

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Work\TKS_Work_Devexpress_Blazor\Web_Blazor\Pages\Danh_Muc\Don_Vi_Tinh.razor"
       
    private IList<CDM_Don_Vi_Tinh> p_objData;
    protected override async Task OnInitializedAsync()
    {
        p_objData = await _db.List_DM_Don_Vi_Tinh();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDM_Don_Vi_Tinh_Controller _db { get; set; }
    }
}
#pragma warning restore 1591
