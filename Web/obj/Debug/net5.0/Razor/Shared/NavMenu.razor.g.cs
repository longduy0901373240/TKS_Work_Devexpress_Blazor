#pragma checksum "D:\Work\TKS_Work_Devexpress_Blazor\Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18832ee8d2b70c29a5ea1788ba77ab694d03dab2"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.DxTreeView>(0);
            __builder.AddAttribute(1, "AllowSelectNodes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\Work\TKS_Work_Devexpress_Blazor\Web\Shared\NavMenu.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "CssClass", "app-sidebar");
            __builder.AddAttribute(3, "Nodes", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(4);
                __builder2.AddAttribute(5, "NavigateUrl", "");
                __builder2.AddAttribute(6, "Text", "Overview");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(8);
                __builder2.AddAttribute(9, "NavigateUrl", "datagrid");
                __builder2.AddAttribute(10, "Text", "Data Grid");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(12);
                __builder2.AddAttribute(13, "Text", "Danh Mục");
                __builder2.AddAttribute(14, "Nodes", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(15);
                    __builder3.AddAttribute(16, "NavigateUrl", "/danh_muc/don_vi_tinh");
                    __builder3.AddAttribute(17, "Text", "Đơn Vị Tính");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(19);
                    __builder3.AddAttribute(20, "NavigateUrl", "/danh_muc/drill_down");
                    __builder3.AddAttribute(21, "Text", "Drill Down");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(23);
                    __builder3.AddAttribute(24, "NavigateUrl", "/danh_muc/kho");
                    __builder3.AddAttribute(25, "Text", "Kho");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(27);
                    __builder3.AddAttribute(28, "NavigateUrl", "/danh_muc/loai_san_pham");
                    __builder3.AddAttribute(29, "Text", "Loại Sản Phẩm");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(31);
                    __builder3.AddAttribute(32, "NavigateUrl", "/danh_muc/mau_column");
                    __builder3.AddAttribute(33, "Text", "Màu Column");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(35);
                    __builder3.AddAttribute(36, "NavigateUrl", "/danh_muc/nha_cung_cap");
                    __builder3.AddAttribute(37, "Text", "Nhà Cung Cấp");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(39);
                    __builder3.AddAttribute(40, "NavigateUrl", "/danh_muc/san_pham");
                    __builder3.AddAttribute(41, "Text", "Sản Phẩm");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(43);
                __builder2.AddAttribute(44, "Text", "Xuất Nhập Kho");
                __builder2.AddAttribute(45, "Nodes", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(46);
                    __builder3.AddAttribute(47, "NavigateUrl", "/xnk/nhap_kho_management");
                    __builder3.AddAttribute(48, "Text", "Nhập Kho");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(50);
                    __builder3.AddAttribute(51, "NavigateUrl", "/xnk/xuat_kho_management");
                    __builder3.AddAttribute(52, "Text", "Xuất Kho");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(54);
                __builder2.AddAttribute(55, "Text", "Bản Đồ");
                __builder2.AddAttribute(56, "Nodes", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(57);
                    __builder3.AddAttribute(58, "NavigateUrl", "/dx/maps");
                    __builder3.AddAttribute(59, "Text", "Maps");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(61);
                    __builder3.AddAttribute(62, "NavigateUrl", "/dx/xe");
                    __builder3.AddAttribute(63, "Text", "Thông Tin Xe");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(65);
                    __builder3.AddAttribute(66, "NavigateUrl", "/dx/tai_xe");
                    __builder3.AddAttribute(67, "Text", "Thông Tin Tài Xế");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(69);
                    __builder3.AddAttribute(70, "NavigateUrl", "/dx/giao_hang");
                    __builder3.AddAttribute(71, "Text", "Giao Hàng");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(73);
                    __builder3.AddAttribute(74, "NavigateUrl", "/dx/nhan_hang");
                    __builder3.AddAttribute(75, "Text", "Nhận Hàng");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(77);
                    __builder3.AddAttribute(78, "NavigateUrl", "/dx/do_management");
                    __builder3.AddAttribute(79, "Text", "DO");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(81);
                    __builder3.AddAttribute(82, "NavigateUrl", "/dx/trip");
                    __builder3.AddAttribute(83, "Text", "Trip");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
