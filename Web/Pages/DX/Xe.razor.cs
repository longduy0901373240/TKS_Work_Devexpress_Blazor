using DevExpress.Blazor;
using Entity.DX;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.DX
{
    public partial class Xe
    {
        private List<CDX_Xe> p_arrData;
        DxDataGrid<CDX_Xe> _Grid;
        //---------------------------------------------------------------------------------------------------------
        CDX_Xe EditContext = new CDX_Xe();
        public bool IsNewRow { get; set; }
        public string Error { get; set; }
        //---------------------------------------------------------------------------------------------------------
        protected override async Task OnInitializedAsync()
        {
            p_arrData = await _db.List_DX_Xe();
        }
        //---------------------------------------------------------------------------------------------------------
        async void OnRowDeleting(CDX_Xe p_objItem)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
                _db.Delete_DX_Xe(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            LoadData();
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CDX_Xe p_obj)
        {
            if (p_obj == null)
            {
                EditContext = new CDX_Xe();
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
                CDX_Xe v_obj = EditContext;
                if (IsNewRow == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    _db.Insert_DX_Xe(v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    _db.Update_DX_Xe(v_obj);
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
