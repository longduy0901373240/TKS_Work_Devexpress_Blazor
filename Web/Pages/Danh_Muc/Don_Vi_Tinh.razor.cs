using DevExpress.Blazor;
using Entity.Danh_Muc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.Danh_Muc
{
    public partial class Don_Vi_Tinh
    {
        private List<CDM_Don_Vi_Tinh> p_objData;
        DxDataGrid<CDM_Don_Vi_Tinh> _Grid;
        //---------------------------------------------------------------------------------------------------------
        CDM_Don_Vi_Tinh EditContext = new CDM_Don_Vi_Tinh();
        public bool IsNewRow { get; set; }
        public string Error { get; set; }
        //---------------------------------------------------------------------------------------------------------
        protected override async Task OnInitializedAsync()
        {
            p_objData = await _db.List_DM_Don_Vi_Tinh();
        }
        Task OnInitNewRow(Dictionary<string, object> values)
        {
            values.Add("Last_Updated_By", "admin");
            return Task.CompletedTask;
        }
        async void OnRowInserting(Dictionary<string, object> p_obj)
        {
            CDM_Don_Vi_Tinh v_obj = new CDM_Don_Vi_Tinh();
            v_obj.Ten_Don_Vi_Tinh = p_obj["Ten_Don_Vi_Tinh"].ToString();
            v_obj.Last_Updated_By = p_obj["Last_Updated_By"].ToString();
            _db.Insert_DM_Don_Vi_Tinh(v_obj);
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);

        }
        async void OnRowDeleting(CDM_Don_Vi_Tinh p_objItem)
        {
            bool isConfirmed = await JS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
                _db.Delete_DM_Don_Vi_Tinh(p_objItem.Auto_ID, p_objItem.Last_Updated_By);
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowUpdating(CDM_Don_Vi_Tinh item, Dictionary<string, object> itemProperties)
        {
            itemProperties.Add("Last_Updated_By", "long");
            item.Ten_Don_Vi_Tinh = itemProperties["Ten_Don_Vi_Tinh"].ToString();
            item.Last_Updated_By = "Long";

            _db.Update_DM_Don_Vi_Tinh(item);
        }
        //---------------------------------------------------------------------------------------------------------
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CDM_Don_Vi_Tinh p_obj)
        {
            if (p_obj == null)
            {
                EditContext = new CDM_Don_Vi_Tinh();
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
                CDM_Don_Vi_Tinh v_obj = EditContext;
                if (IsNewRow == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    _db.F2001_Insert_DM_Don_Vi_Tinh(v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    _db.F2001_Update_DM_Don_Vi_Tinh(v_obj);
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
