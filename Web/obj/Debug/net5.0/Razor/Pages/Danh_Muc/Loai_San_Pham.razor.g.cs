#pragma checksum "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21eb12e8924e8c6a465a2728f691b37228de135"
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
#line 3 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
using Controller.Danh_Muc;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc/loai_san_pham")]
    public partial class Loai_San_Pham : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1> Loại sản phẩm page </h1>\r\n");
            __builder.AddMarkupContent(1, "<h4>Thông tin loại sản phẩm</h4>");
#nullable restore
#line 10 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
 if (p_objData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Web.Pages.Danh_Muc.Loai_San_Pham.TypeInference.CreateDxDataGrid_0(__builder, 3, 4, 
#nullable restore
#line 16 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                       p_objData

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 17 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                              OnRowDeleting

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 18 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                (dataItem) => OnRowStarting(dataItem)

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 19 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                  () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 20 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
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
#line 23 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(18);
                __builder2.AddAttribute(19, "Caption", "Tên Loại Sản Phẩm");
                __builder2.AddAttribute(20, "Field", "Ten_Loai_San_Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(22);
                __builder2.AddAttribute(23, "Caption", "Deleted");
                __builder2.AddAttribute(24, "Field", "deleted");
                __builder2.AddAttribute(25, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 25 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(27);
                __builder2.AddAttribute(28, "Caption", "Created");
                __builder2.AddAttribute(29, "Field", "Created");
                __builder2.AddAttribute(30, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 26 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                       false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(32);
                __builder2.AddAttribute(33, "Caption", "Created By");
                __builder2.AddAttribute(34, "Field", "Created_By");
                __builder2.AddAttribute(35, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 27 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridDateEditColumn>(37);
                __builder2.AddAttribute(38, "Caption", "Last Update");
                __builder2.AddAttribute(39, "Field", "Last_Updated");
                __builder2.AddAttribute(40, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 28 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(42);
                __builder2.AddAttribute(43, "Caption", "Last Update By");
                __builder2.AddAttribute(44, "Field", "Last_Updated_By");
                __builder2.AddAttribute(45, "EditorVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 29 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            , 46, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(47);
                __builder2.AddAttribute(48, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                              EditContext

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 32 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                     HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(51);
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(53);
                        __builder4.AddAttribute(54, "Caption", "Tên loại sản phẩm: ");
                        __builder4.AddAttribute(55, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                               12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(57);
                            __builder5.AddAttribute(58, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                    EditContext.Ten_Loai_San_Pham

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(59, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Ten_Loai_San_Pham = __value, EditContext.Ten_Loai_San_Pham))));
                            __builder5.AddAttribute(60, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditContext.Ten_Loai_San_Pham));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(62);
                        __builder4.AddAttribute(63, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(65, "div");
                            __builder5.AddAttribute(66, "class", "text-danger");
                            __builder5.OpenElement(67, "p");
                            __builder5.AddContent(68, 
#nullable restore
#line 42 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
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
                        __builder4.AddMarkupContent(69, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(70);
                        __builder4.AddAttribute(71, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(73, "div");
                            __builder5.AddAttribute(74, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(75);
                            __builder5.AddAttribute(76, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 49 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                       ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(77, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(78, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(79, "\r\n                                ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(80);
                            __builder5.AddAttribute(81, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 50 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                       ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(82, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                                                                      OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(83, "Text", "Cancel");
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
            , 84, (__value) => {
#nullable restore
#line 16 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
                                         _Grid = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 58 "D:\Word\New_Blazor\Web\Pages\Danh_Muc\Loai_San_Pham.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDM_Loai_San_Pham_Controller _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
namespace __Blazor.Web.Pages.Danh_Muc.Loai_San_Pham
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
    }
}
#pragma warning restore 1591