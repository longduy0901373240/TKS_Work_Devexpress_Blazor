using DevExpress.Blazor;
using Entity.Danh_Muc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.Danh_Muc
{
    public partial class Nha_Cung_Cap
    {
        private List<CDM_Nha_Cung_Cap> p_objData;
        DxDataGrid<CDM_Nha_Cung_Cap> _Grid;
        //---------------------------------------------------------------------------------------------------------
        CDM_Nha_Cung_Cap EditContext = new CDM_Nha_Cung_Cap();
        public bool IsNewRow { get; set; }
        public string Error { get; set; }
        //---------------------------------------------------------------------------------------------------------
        protected override async Task OnInitializedAsync()
        {
            p_objData = await _db.List_DM_Nha_Cung_Cap();
        }
        async void OnRowDeleting(CDM_Nha_Cung_Cap p_objItem)
        {

            bool isConfirmed = await JS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db.Delete_DM_Nha_Cung_Cap(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CDM_Nha_Cung_Cap p_obj)
        {
            if (p_obj == null)
            {
                EditContext = new CDM_Nha_Cung_Cap();
                IsNewRow = true;
            }
            else
            {
                EditContext = p_obj;
                IsNewRow = false;
            }

        }
        void OnCancelButtonClick()
        {
            _Grid.CancelRowEdit();
            EditContext = null;
            Error = "";
        }
        void HandleValiSubmit()
        {
            try
            {
                CDM_Nha_Cung_Cap v_obj = EditContext;
                if (IsNewRow == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    _db.F3004_Insert_DM_Nha_Cung_Cap(v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    _db.F3004_Update_DM_Nha_Cung_Cap(v_obj);
                }
                _Grid.CancelRowEdit();
                LoadData();
                Error = "";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
    }
}
