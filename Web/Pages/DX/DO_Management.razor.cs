using DataLayer;
using DevExpress.Blazor;
using DevExpress.Blazor.Internal;
using Entity.Danh_Muc;
using Entity.DX;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace Web.Pages.DX
{
    public partial class DO_Management
    {
        #region Biến lọc ngày tháng
        DateTime StartDay { get; set; } = DateTime.Now.AddMonths(-1);
        DateTime EndDay { get; set; } = DateTime.Now;
        #endregion

        #region List objArr
        private List<CDX_DO> p_arr_DO;
        private List<CDX_DO_Chi_Tiet> p_arr_DO_Chi_Tiet;
        private List<CDX_Nhan_Hang> p_arr_Nhan_Hang;
        private List<CDX_Giao_Hang> p_arr_Giao_Hang;
        private List<CDM_San_Pham> p_arr_San_Pham;
        #endregion

        #region DxDataGrid
        DxDataGrid<CDX_DO> _Grid_DO;
        DxDataGrid<CDX_DO_Chi_Tiet> _Grid_DO_Chi_Tiet;
        #endregion

        #region objItem int EditFormtemplate DO
        public bool IsNewRow_DO { get; set; }
        public string Error_DO { get; set; }
        CDX_DO p_objItem_DO = new CDX_DO();
        #endregion

        #region objItem int EditFormtemplate DO chi tiết
        public bool IsNewRow_DO_Chi_Tiet { get; set; }
        public string Error_DO_Chi_Tiet { get; set; }
        CDX_DO_Chi_Tiet p_objItem_DO_Chi_Tiet = new CDX_DO_Chi_Tiet();
        #endregion

        int p_Auto_ID = 0;
        protected override async Task OnInitializedAsync()
        {
            p_arr_Giao_Hang = await _db_Giao_Hang.List_DX_Giao_Hang();
            p_arr_Nhan_Hang = await _db_Nhan_Hang.List_DX_Nhan_Hang();
            p_arr_San_Pham = await _db_San_Pham.List_DM_San_Pham();
            p_arr_DO = await _db_DO.List_DX_DO();
        }

        #region function DO
        void OnCancelButtonClick_DO()
        {
            _Grid_DO.CancelRowEdit();
            p_objItem_DO = null;
            Error_DO = "";
        }
        async void OnRowStarting_DO(CDX_DO p_objItem)
        {
            p_Auto_ID = 0;
            if (p_objItem == null)
            {
                p_objItem_DO = new CDX_DO();
                p_objItem_DO.Ngay_Giao_Hang = DateTime.Now;
                IsNewRow_DO = true;
                p_arr_DO_Chi_Tiet = new List<CDX_DO_Chi_Tiet>();
            }
            else
            {
                p_objItem_DO = p_objItem;
                p_objItem_DO.Ngay_Giao_Hang = DateTime.Now;
                IsNewRow_DO = false;
                p_arr_DO_Chi_Tiet = await _db_DO_Chi_Tiet.F50011_List_CDX_DO_Chi_Tiet_By_Nhap_Kho_ID(p_objItem.Auto_ID);
                foreach(CDX_DO_Chi_Tiet item in p_arr_DO_Chi_Tiet)
                {
                    item.Auto_ID = p_Auto_ID;
                    p_Auto_ID++;
                }    
            }
        }
        void HandleValiSubmit_DO()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();
                CDX_DO v_obj = p_objItem_DO;
                if(IsNewRow_DO == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    v_obj.Trang_Thai_ID = 1;
                    v_obj.Trip_ID = 0;
                    v_obj.Auto_ID = _db_DO.Insert_DX_DO(v_conn, v_trans, v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    _db_DO.Update_DX_DO(v_obj);
                    _db_DO_Chi_Tiet.F50011_Delete_DX_DO_Chi_Tiet_By_DO_ID(v_obj.Auto_ID, v_obj.Last_Updated_By);
                }
                foreach (CDX_DO_Chi_Tiet item in p_arr_DO_Chi_Tiet)
                {
                    item.DO_ID = v_obj.Auto_ID;
                    _db_DO_Chi_Tiet.Insert_DX_DO_Chi_Tiet(v_conn, v_trans, item);
                }
                v_trans.Commit();
                _Grid_DO.CancelRowEdit();
                LoadData();
                Error_DO = "";
            }
            catch (Exception ex)
            {
                Error_DO = ex.Message;
            }
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        async void OnRowDeleting_DO(CDX_DO p_obj)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_DO.F5001_Delete_XNK_Nhap_Kho(p_obj.Auto_ID, p_obj.Last_Updated_By);
            }
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        #endregion

        #region function DO Chi Tiết
        void OnCancelButtonClick_DO_Chi_Tiet()
        {
            _Grid_DO_Chi_Tiet.CancelRowEdit();
            p_objItem_DO_Chi_Tiet = null;
            Error_DO_Chi_Tiet = "";
        }
        void OnRowStarting_DO_Chi_Tiet(CDX_DO_Chi_Tiet p_objItem)
        {
            if (p_objItem == null)
            {
                p_objItem_DO_Chi_Tiet = new CDX_DO_Chi_Tiet();
                IsNewRow_DO_Chi_Tiet = true;
            }
            else
            {
                p_objItem_DO_Chi_Tiet = p_objItem;
                IsNewRow_DO_Chi_Tiet = false;
            }    
        }
        void HandleValiSubmit_DO_Chi_Tiet()
        {
            try
            {
                CDX_DO_Chi_Tiet v_objItem = p_objItem_DO_Chi_Tiet;
                if (IsNewRow_DO_Chi_Tiet == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    v_objItem.Auto_ID = p_Auto_ID;
                    p_arr_DO_Chi_Tiet.Add(v_objItem);
                    p_Auto_ID++;
                }
                else
                {
                    v_objItem.Last_Updated_By = "Long";
                    var item = p_arr_DO_Chi_Tiet.FirstOrDefault(p => p.Auto_ID == v_objItem.Auto_ID);
                    if (item != null)
                        item = v_objItem;
                }
                _Grid_DO_Chi_Tiet.CancelRowEdit();
                _Grid_DO_Chi_Tiet.Refresh();
                Error_DO_Chi_Tiet = "";
            }
            catch (Exception ex)
            {
                Error_DO_Chi_Tiet = ex.Message;
            }
        }
        async void OnRowDeleting_DO_Chi_Tiet(CDX_DO_Chi_Tiet p_obj)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if(isConfirmed)
            {
                p_arr_DO_Chi_Tiet.Remove(p_obj);
            }
            await _Grid_DO_Chi_Tiet.Refresh();
        }
        #endregion
    }
}
