#pragma checksum "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ae8744a626e1b92ead725c069bb803e6982ec6"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages.Danh_Muc
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Word\New_Blazor\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Word\New_Blazor\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Word\New_Blazor\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Word\New_Blazor\Web\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Word\New_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
using Controller.Danh_Muc;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc/san_pham")]
    public partial class San_Pham : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Sản phẩm page </h1>\r\n");
            __builder.AddMarkupContent(1, "<h4>Thông tin sản phẩm</h4>");
#nullable restore
#line 12 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
 if (p_objData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Web.Pages.Danh_Muc.San_Pham.TypeInference.CreateDxDataGrid_0(__builder, 3, 4, 
#nullable restore
#line 18 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                       p_objData

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 19 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                              OnRowDeleting

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 20 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                (dataItem) => OnRowStarting(dataItem)

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 21 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                  () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 22 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                          DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(10);
                __builder2.AddAttribute(11, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(13);
                __builder2.AddAttribute(14, "Caption", "ID");
                __builder2.AddAttribute(15, "Field", "Auto_ID");
                __builder2.AddAttribute(16, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 25 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(18);
                __builder2.AddAttribute(19, "Caption", "Mã sản phẩm");
                __builder2.AddAttribute(20, "Field", "Ma_San_Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(22);
                __builder2.AddAttribute(23, "Caption", "Tên sản phẩm");
                __builder2.AddAttribute(24, "Field", "Ten_San_Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.Web.Pages.Danh_Muc.San_Pham.TypeInference.CreateDxDataGridComboBoxColumn_1(__builder2, 26, 27, "Don_Vi_Tinh_ID", 28, 
#nullable restore
#line 28 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                    p_objData_Don_Vi_Tinh

#line default
#line hidden
#nullable disable
                , 29, "Đơn vị tính", 30, "Auto_ID", 31, "Ten_Don_Vi_Tinh");
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.Web.Pages.Danh_Muc.San_Pham.TypeInference.CreateDxDataGridComboBoxColumn_2(__builder2, 33, 34, "Loai_San_Pham_ID", 35, 
#nullable restore
#line 30 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                      p_objData_Loai_San_Pham

#line default
#line hidden
#nullable disable
                , 36, "Loại sản phẩm", 37, "Auto_ID", 38, "Ten_Loai_San_Pham");
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(40);
                __builder2.AddAttribute(41, "Caption", "Ghi chú");
                __builder2.AddAttribute(42, "Field", "Ghi_Chu");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(44);
                __builder2.AddAttribute(45, "Caption", "Deleted");
                __builder2.AddAttribute(46, "Field", "deleted");
                __builder2.AddAttribute(47, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 33 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(49);
                __builder2.AddAttribute(50, "Caption", "Created");
                __builder2.AddAttribute(51, "Field", "Created");
                __builder2.AddAttribute(52, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 34 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                       false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(54);
                __builder2.AddAttribute(55, "Caption", "Created By");
                __builder2.AddAttribute(56, "Field", "Created_By");
                __builder2.AddAttribute(57, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 35 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(59);
                __builder2.AddAttribute(60, "Caption", "Last Update");
                __builder2.AddAttribute(61, "Field", "Last_Updated");
                __builder2.AddAttribute(62, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 36 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(64);
                __builder2.AddAttribute(65, "Caption", "Last Update By");
                __builder2.AddAttribute(66, "Field", "Last_Updated_By");
                __builder2.AddAttribute(67, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 37 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            , 68, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(69);
                __builder2.AddAttribute(70, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 40 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                              EditContext

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 40 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                     HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(73);
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(75);
                        __builder4.AddAttribute(76, "Caption", "Mã sản phẩm: ");
                        __builder4.AddAttribute(77, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(79);
                            __builder5.AddAttribute(80, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                    EditContext.Ma_San_Pham

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(81, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Ma_San_Pham = __value, EditContext.Ma_San_Pham))));
                            __builder5.AddAttribute(82, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditContext.Ma_San_Pham));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(84);
                        __builder4.AddAttribute(85, "Caption", "Tên sản phẩm: ");
                        __builder4.AddAttribute(86, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                          12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(87, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(88);
                            __builder5.AddAttribute(89, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                    EditContext.Ten_San_Pham

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(90, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Ten_San_Pham = __value, EditContext.Ten_San_Pham))));
                            __builder5.AddAttribute(91, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditContext.Ten_San_Pham));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(92, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(93);
                        __builder4.AddAttribute(94, "Caption", "Đơn vị tính: ");
                        __builder4.AddAttribute(95, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(96, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __Blazor.Web.Pages.Danh_Muc.San_Pham.TypeInference.CreateDxComboBox_3(__builder5, 97, 98, 
#nullable restore
#line 54 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                               p_objData_Don_Vi_Tinh

#line default
#line hidden
#nullable disable
                            , 99, "Auto_ID", 100, "Ten_Don_Vi_Tinh", 101, "Select item ...", 102, 
#nullable restore
#line 58 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                     EditContext.Don_Vi_Tinh_ID

#line default
#line hidden
#nullable disable
                            , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Don_Vi_Tinh_ID = __value, EditContext.Don_Vi_Tinh_ID)), 104, () => EditContext.Don_Vi_Tinh_ID);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(105, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(106);
                        __builder4.AddAttribute(107, "Caption", "Loại sản phẩm: ");
                        __builder4.AddAttribute(108, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                           12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __Blazor.Web.Pages.Danh_Muc.San_Pham.TypeInference.CreateDxComboBox_4(__builder5, 110, 111, 
#nullable restore
#line 63 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                               p_objData_Loai_San_Pham

#line default
#line hidden
#nullable disable
                            , 112, "Auto_ID", 113, "Ten_Loai_San_Pham", 114, "Select item ...", 115, 
#nullable restore
#line 67 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                     EditContext.Loai_San_Pham_ID

#line default
#line hidden
#nullable disable
                            , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Loai_San_Pham_ID = __value, EditContext.Loai_San_Pham_ID)), 117, () => EditContext.Loai_San_Pham_ID);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(118, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(119);
                        __builder4.AddAttribute(120, "Caption", "Ghi chú: ");
                        __builder4.AddAttribute(121, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 70 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(122, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxMemo>(123);
                            __builder5.AddAttribute(124, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                 EditContext.Ghi_Chu

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(125, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Ghi_Chu = __value, EditContext.Ghi_Chu))));
                            __builder5.AddAttribute(126, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditContext.Ghi_Chu));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(127, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(128);
                        __builder4.AddAttribute(129, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 75 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(130, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(131, "div");
                            __builder5.AddAttribute(132, "class", "text-danger");
                            __builder5.OpenElement(133, "p");
                            __builder5.AddContent(134, 
#nullable restore
#line 78 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                    Error

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(135, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(136);
                        __builder4.AddAttribute(137, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 82 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(138, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(139, "div");
                            __builder5.AddAttribute(140, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(141);
                            __builder5.AddAttribute(142, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 85 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                       ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(143, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 85 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(144, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(145, "\r\n                                ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(146);
                            __builder5.AddAttribute(147, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 86 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                       ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(148, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                                                                      OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(149, "Text", "Cancel");
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 150, (__value) => {
#nullable restore
#line 18 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
                                         _Grid = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 94 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\San_Pham.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDM_Loai_San_Pham_Controller _db_Loai_San_Pham { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDM_Don_Vi_Tinh_Controller _db_Don_Vi_Tinh { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDM_San_Pham_Controller _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
namespace __Blazor.Web.Pages.Danh_Muc.San_Pham
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Action<T> __arg1, int __seq2, global::System.Action<T> __arg2, int __seq3, global::System.Action __arg3, int __seq4, global::DevExpress.Blazor.DataGridEditMode __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::System.Action<global::DevExpress.Blazor.DxDataGrid<T>> __arg7)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "RowRemoving", __arg1);
        __builder.AddAttribute(__seq2, "RowEditStart", __arg2);
        __builder.AddAttribute(__seq3, "RowInsertStart", __arg3);
        __builder.AddAttribute(__seq4, "EditMode", __arg4);
        __builder.AddAttribute(__seq5, "Columns", __arg5);
        __builder.AddAttribute(__seq6, "EditFormTemplate", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::DevExpress.Blazor.DxDataGrid<T>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<T> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Field", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Caption", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<T> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Field", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Caption", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_3<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueFieldName", __arg1);
        __builder.AddAttribute(__seq2, "TextFieldName", __arg2);
        __builder.AddAttribute(__seq3, "NullText", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_4<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueFieldName", __arg1);
        __builder.AddAttribute(__seq2, "TextFieldName", __arg2);
        __builder.AddAttribute(__seq3, "NullText", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
