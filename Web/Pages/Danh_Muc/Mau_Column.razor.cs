using DevExpress.Blazor;
using Entity.Danh_Muc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.Danh_Muc
{
    public partial class Mau_Column
    {
        private List<CDM_Mau_Column> p_objData;
        DxDataGrid<CDM_Mau_Column> _Grid;
        //---------------------------------------------------------------------------------------------------------
        CDM_Mau_Column EditContext = new CDM_Mau_Column();
        public bool IsNewRow { get; set; }
        public string Error { get; set; }
        //---------------------------------------------------------------------------------------------------------
        protected override async Task OnInitializedAsync()
        {
            p_objData = await _db.List_DM_Mau_Column();
        }
        async void OnRowDeleting(CDM_Mau_Column p_objItem)
        {

            bool isConfirmed = await JS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db.Delete_DM_Mau_Column(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CDM_Mau_Column p_obj)
        {
            if (p_obj == null)
            {
                EditContext = new CDM_Mau_Column();
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
                CDM_Mau_Column v_obj = EditContext;
                if (IsNewRow == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    _db.Insert_DM_Mau_Column(v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    _db.Update_DM_Mau_Column(v_obj);
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
