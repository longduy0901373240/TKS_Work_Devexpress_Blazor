using DevExpress.Blazor;
using Entity.Danh_Muc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.Danh_Muc
{
    public partial class San_Pham
    {
        private List<CDM_San_Pham> p_objData;
        private List<CDM_Don_Vi_Tinh> p_objData_Don_Vi_Tinh;
        private List<CDM_Loai_San_Pham> p_objData_Loai_San_Pham;
        DxDataGrid<CDM_San_Pham> _Grid;
        //---------------------------------------------------------------------------------------------------------
        CDM_San_Pham EditContext = new CDM_San_Pham();
        public bool IsNewRow { get; set; }
        public string Error { get; set; }
        //---------------------------------------------------------------------------------------------------------
        protected override async Task OnInitializedAsync()
        {
            p_objData_Don_Vi_Tinh = await _db_Don_Vi_Tinh.List_DM_Don_Vi_Tinh();
            p_objData_Loai_San_Pham = await _db_Loai_San_Pham.List_DM_Loai_San_Pham();
            p_objData = await _db.List_DM_San_Pham();
        }
        async void OnRowDeleting(CDM_San_Pham p_objItem)
        {

            bool isConfirmed = await JS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db.Delete_DM_San_Pham(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            }
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CDM_San_Pham p_obj)
        {
            if (p_obj == null)
            {
                EditContext = new CDM_San_Pham();
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
                CDM_San_Pham v_obj = EditContext;
                if (IsNewRow == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    _db.F3003_Insert_DM_San_Pham(v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    _db.F3003_Update_DM_San_Pham(v_obj);
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
