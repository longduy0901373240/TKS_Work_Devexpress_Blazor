#pragma checksum "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6768560bf9ec6a26232b77baf137d31217ddcc30"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages.DX
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
using Controller.DX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
using Entity.DX;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dx/trip")]
    public partial class Trip : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Trip page</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Th??ng tin trip</h4>");
#nullable restore
#line 16 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
 if (p_arrTrip == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 19 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxDataGrid_0(__builder, 3, 4, 
#nullable restore
#line 22 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                      p_arrTrip

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 23 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                          DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 24 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                  () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 25 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                (item) => OnRowStarting(item)

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(9);
                __builder2.AddAttribute(10, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(12);
                __builder2.AddAttribute(13, "Caption", "DO ID");
                __builder2.AddAttribute(14, "Field", "DO_ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxDataGridComboBoxColumn_1(__builder2, 16, 17, "T??i X???", 18, "Tai_Xe_ID", 19, 
#nullable restore
#line 29 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                               p_arrTai_Xe

#line default
#line hidden
#nullable disable
                , 20, "Auto_ID", 21, "Ten_Tai_Xe");
                __builder2.AddMarkupContent(22, "\r\n            ");
                __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxDataGridComboBoxColumn_2(__builder2, 23, 24, "Xe", 25, "Xe_ID", 26, 
#nullable restore
#line 31 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                       p_arrXe

#line default
#line hidden
#nullable disable
                , 27, "Auto_ID", 28, "Ten_Xe");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxDataGridComboBoxColumn_3(__builder2, 30, 31, "Giao h??ng", 32, "Giao_Hang_ID", 33, 
#nullable restore
#line 33 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                     p_arrGiao_Hang

#line default
#line hidden
#nullable disable
                , 34, "Auto_ID", 35, "So_Phieu_Giao");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxDataGridComboBoxColumn_4(__builder2, 37, 38, "Nh???n h??ng", 39, "Nhan_Hang_ID", 40, 
#nullable restore
#line 35 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                     p_arrNhan_Hang

#line default
#line hidden
#nullable disable
                , 41, "Auto_ID", 42, "So_Phieu_Nhan");
            }
            , 43, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(44);
                __builder2.AddAttribute(45, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                             EditContext

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                   HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(48);
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(50);
                        __builder4.AddAttribute(51, "Caption", "DO ID: ");
                        __builder4.AddAttribute(52, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                   12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxComboBox_5(__builder5, 54, 55, 
#nullable restore
#line 43 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                              p_arrDO

#line default
#line hidden
#nullable disable
                            , 56, "Auto_ID", 57, 
#nullable restore
#line 44 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                DataGridFilteringMode.Contains

#line default
#line hidden
#nullable disable
                            , 58, "{0} - {1} - {2}", 59, 
#nullable restore
#line 43 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                     EditContext.DO_ID

#line default
#line hidden
#nullable disable
                            , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.DO_ID = __value, EditContext.DO_ID)), 61, () => EditContext.DO_ID, 62, (__builder6) => {
                                __builder6.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(63);
                                __builder6.AddAttribute(64, "FieldName", "Auto_ID");
                                __builder6.AddAttribute(65, "Caption", "ID");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(66, "\r\n                                ");
                                __builder6.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(67);
                                __builder6.AddAttribute(68, "FieldName", "So_Phieu_Giao");
                                __builder6.AddAttribute(69, "Caption", "S??? phi???u giao");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(70, "\r\n                                ");
                                __builder6.OpenComponent<DevExpress.Blazor.DxListEditorColumn>(71);
                                __builder6.AddAttribute(72, "FieldName", "So_Phieu_Nhan");
                                __builder6.AddAttribute(73, "Caption", "S??? phi???u nh???n");
                                __builder6.CloseComponent();
                            }
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(74, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(75);
                        __builder4.AddAttribute(76, "Caption", "T??i X???: ");
                        __builder4.AddAttribute(77, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                    12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxComboBox_6(__builder5, 79, 80, 
#nullable restore
#line 54 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                  p_arrTai_Xe

#line default
#line hidden
#nullable disable
                            , 81, "Auto_ID", 82, "Ten_Tai_Xe", 83, 
#nullable restore
#line 54 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                     EditContext.Tai_Xe_ID

#line default
#line hidden
#nullable disable
                            , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Tai_Xe_ID = __value, EditContext.Tai_Xe_ID)), 85, () => EditContext.Tai_Xe_ID);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(87);
                        __builder4.AddAttribute(88, "Caption", "Xe: ");
                        __builder4.AddAttribute(89, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 58 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(90, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __Blazor.Web.Pages.DX.Trip.TypeInference.CreateDxComboBox_7(__builder5, 91, 92, 
#nullable restore
#line 60 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                              p_arrXe

#line default
#line hidden
#nullable disable
                            , 93, "Auto_ID", 94, "Ten_Xe", 95, 
#nullable restore
#line 60 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                     EditContext.Xe_ID

#line default
#line hidden
#nullable disable
                            , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditContext.Xe_ID = __value, EditContext.Xe_ID)), 97, () => EditContext.Xe_ID);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(98, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(99);
                        __builder4.AddAttribute(100, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 64 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(101, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(102, "div");
                            __builder5.AddAttribute(103, "class", "text-danger");
                            __builder5.OpenElement(104, "p");
                            __builder5.AddContent(105, 
#nullable restore
#line 67 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
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
                        __builder4.AddMarkupContent(106, "\r\n                    ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(107);
                        __builder4.AddAttribute(108, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 71 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(110, "div");
                            __builder5.AddAttribute(111, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(112);
                            __builder5.AddAttribute(113, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 74 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                       ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(114, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(115, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(116, "\r\n                                ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(117);
                            __builder5.AddAttribute(118, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 75 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                       ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(119, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                                                                      OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(120, "Text", "Cancel");
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
            , 121, (__value) => {
#nullable restore
#line 22 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
                                       _Grid = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 83 "D:\Work\Repositories\TKS_Work_Devexpress_Blazor\Web\Pages\DX\Trip.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDX_Nhan_Hang_Controller _db_Nhan_Hang { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDX_Giao_Hang_Controller _db_Giao_Hang { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDX_Xe_Controller _db_Xe { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDX_Tai_Xe_Controller _db_Tai_Xe { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDX_DO_Controller _db_DO { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CDX_Trip_Controller _db_Trip { get; set; }
    }
}
namespace __Blazor.Web.Pages.DX.Trip
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::DevExpress.Blazor.DataGridEditMode __arg1, int __seq2, global::System.Action __arg2, int __seq3, global::System.Action<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5, int __seq6, global::System.Action<global::DevExpress.Blazor.DxDataGrid<T>> __arg6)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "EditMode", __arg1);
        __builder.AddAttribute(__seq2, "RowInsertStart", __arg2);
        __builder.AddAttribute(__seq3, "RowEditStart", __arg3);
        __builder.AddAttribute(__seq4, "Columns", __arg4);
        __builder.AddAttribute(__seq5, "EditFormTemplate", __arg5);
        __builder.AddComponentReferenceCapture(__seq6, (__value) => { __arg6((global::DevExpress.Blazor.DxDataGrid<T>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Caption", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Data", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Caption", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Data", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Caption", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Data", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Caption", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Data", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_5<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::DevExpress.Blazor.DataGridFilteringMode __arg2, int __seq3, global::System.String __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueFieldName", __arg1);
        __builder.AddAttribute(__seq2, "FilteringMode", __arg2);
        __builder.AddAttribute(__seq3, "EditFormat", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_6<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueFieldName", __arg1);
        __builder.AddAttribute(__seq2, "TextFieldName", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_7<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TData> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueFieldName", __arg1);
        __builder.AddAttribute(__seq2, "TextFieldName", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
