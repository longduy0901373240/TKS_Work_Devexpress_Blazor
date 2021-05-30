using DataLayer;
using DevExpress.Blazor;
using Entity.Danh_Muc;
using Entity.XNK;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace Web.Pages.XNK
{
    public partial class Xuat_Kho_Management
    {
        #region Biến lọc ngày tháng
        DateTime StartDay { get; set; } = DateTime.Now.AddMonths(-1);
        DateTime EndDay { get; set; } = DateTime.Now;
        #endregion

        #region DxDataGrid
        DxDataGrid<CXNK_Xuat_Kho> _Grid_Xuat_Kho;
        DxDataGrid<CXNK_Xuat_Kho_Chi_Tiet> _Grid_Xuat_Kho_Chi_Tiet;
        #endregion

        #region List objData
        private List<CXNK_Xuat_Kho> p_objData_Xuat_Kho;
        private List<CXNK_Xuat_Kho_Chi_Tiet> p_objData_Xuat_Kho_Chi_Tiet;
        private List<CDM_Kho> p_objData_Kho;
        private List<CDM_Nha_Cung_Cap> p_objData_Nha_Cung_Cap;
        private List<CDM_San_Pham> p_objData_San_Pham;
        #endregion

        #region objItem in EditFormtemplate Xuất kho
        public bool IsNewRow_Xuat_Kho { get; set; }
        public string Error_Xuat_Kho { get; set; }
        CXNK_Xuat_Kho p_objItem_Xuat_Kho = new CXNK_Xuat_Kho();
        #endregion

        #region objItem in EditFormtemplate Xuất kho chi tiết
        public bool IsNewRow_Xuat_Kho_Chi_Tiet { get; set; }
        public string Error_Xuat_Kho_Chi_Tiet { get; set; }
        CXNK_Xuat_Kho_Chi_Tiet p_objItem_Xuat_Kho_Chi_Tiet = new CXNK_Xuat_Kho_Chi_Tiet();
        #endregion

        int p_Auto_ID = 0;
        protected override async Task OnInitializedAsync()
        {
            p_objData_Kho = await _db_Kho.List_DM_Kho();
            p_objData_Nha_Cung_Cap = await _db_Nha_cung_cap.List_DM_Nha_Cung_Cap();
            p_objData_San_Pham = await _db_San_Pham.List_DM_San_Pham();
            p_objData_Xuat_Kho = await _db_Xuat_Kho.List_XNK_Xuat_Kho();
        }

        #region function Xuất Kho
        void OnCancelButtonClick_Xuat_Kho()
        {
            _Grid_Xuat_Kho.CancelRowEdit();
            p_objItem_Xuat_Kho = null;
            Error_Xuat_Kho = "";
        }
        async void OnRowStarting_Xuat_Kho(CXNK_Xuat_Kho p_objItem)
        {
            p_Auto_ID = 0;
            if (p_objItem == null)
            {
                p_objItem_Xuat_Kho = new CXNK_Xuat_Kho();
                p_objItem_Xuat_Kho.Ngay_Xuat_Kho = DateTime.Now;
                IsNewRow_Xuat_Kho = true;
                p_objData_Xuat_Kho_Chi_Tiet = new List<CXNK_Xuat_Kho_Chi_Tiet>();

            }
            else
            {
                p_objItem_Xuat_Kho = p_objItem;
                p_objItem_Xuat_Kho.Ngay_Xuat_Kho = DateTime.Now;
                IsNewRow_Xuat_Kho = false;
                p_objData_Xuat_Kho_Chi_Tiet = await _db_Xuat_Kho_Chi_Tiet.F40021_List_XNK_Xuat_Kho_Chi_Tiet_By_Xuat_Kho_ID(p_objItem.Auto_ID);
                foreach (CXNK_Xuat_Kho_Chi_Tiet item in p_objData_Xuat_Kho_Chi_Tiet)
                {
                    item.Auto_ID = p_Auto_ID;
                    p_Auto_ID++;
                }
            }
        }
        void HandleValiSubmit_Xuat_Kho()
        {
            SqlConnection v_conn = null;
            SqlTransaction v_trans = null;
            try
            {
                v_conn = CSqlHelper.CreateConnection(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String);
                v_conn.Open();
                v_trans = v_conn.BeginTransaction();
                CXNK_Xuat_Kho v_obj = p_objItem_Xuat_Kho;
                if (IsNewRow_Xuat_Kho == true)
                {
                    v_obj.Last_Updated_By = "admin";
                    double v_dbTong_So_Luong = 0;
                    double v_dbTong_Tri_Gia = 0;
                    foreach (CXNK_Xuat_Kho_Chi_Tiet item in p_objData_Xuat_Kho_Chi_Tiet)
                    {
                        v_dbTong_So_Luong += item.So_Luong;
                        v_dbTong_Tri_Gia += item.So_Luong * item.Don_Gia;
                    }
                    v_obj.Tong_So_Luong = v_dbTong_So_Luong;
                    v_obj.Tong_Tri_Gia = v_dbTong_Tri_Gia;
                    v_obj.Auto_ID = _db_Xuat_Kho.Insert_XNK_Xuat_Kho(v_conn, v_trans, v_obj);
                }
                else
                {
                    v_obj.Last_Updated_By = "Long";
                    double v_dbTong_So_Luong = 0;
                    double v_dbTong_Tri_Gia = 0;
                    foreach (CXNK_Xuat_Kho_Chi_Tiet item in p_objData_Xuat_Kho_Chi_Tiet)
                    {
                        v_dbTong_So_Luong += item.So_Luong;
                        v_dbTong_Tri_Gia += item.So_Luong * item.Don_Gia;
                    }
                    v_obj.Tong_So_Luong = v_dbTong_So_Luong;
                    v_obj.Tong_Tri_Gia = v_dbTong_Tri_Gia;
                    _db_Xuat_Kho.Update_XNK_Xuat_Kho(v_obj);
                    _db_Xuat_Kho_Chi_Tiet.F40021_Delete_XNK_Xuat_Kho_Chi_Tiet_By_Xuat_Kho_ID(v_obj.Auto_ID, v_obj.Last_Updated_By);
                }
                foreach (CXNK_Xuat_Kho_Chi_Tiet item in p_objData_Xuat_Kho_Chi_Tiet)
                {
                    item.Xuat_Kho_ID = v_obj.Auto_ID;
                    _db_Xuat_Kho_Chi_Tiet.Insert_XNK_Xuat_Kho_Chi_Tiet(v_conn, v_trans, item);
                }
                v_trans.Commit();
                _Grid_Xuat_Kho.CancelRowEdit();
                LoadData();
                Error_Xuat_Kho = "";
            }
            catch (Exception ex)
            {
                Error_Xuat_Kho = ex.Message;
            }
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        async void OnRowDeleting_Xuat_Kho(CXNK_Xuat_Kho p_obj)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                _db_Xuat_Kho.F4002_Delete_XNK_Xuat_Kho(p_obj.Auto_ID, p_obj.Last_Updated_By);
            }
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        #endregion

        #region function Xuất Kho chi tiết
        void OnCancelButtonClick_Xuat_Kho_Chi_Tiet()
        {
            _Grid_Xuat_Kho_Chi_Tiet.CancelRowEdit();
            p_objItem_Xuat_Kho_Chi_Tiet = null;
            Error_Xuat_Kho_Chi_Tiet = "";
        }
        void OnRowStarting_Xuat_Kho_Chi_Tiet(CXNK_Xuat_Kho_Chi_Tiet p_objItem)
        {
            if (p_objItem == null)
            {
                p_objItem_Xuat_Kho_Chi_Tiet = new CXNK_Xuat_Kho_Chi_Tiet();
                IsNewRow_Xuat_Kho_Chi_Tiet = true;
            }
            else
            {
                p_objItem_Xuat_Kho_Chi_Tiet = p_objItem;
                IsNewRow_Xuat_Kho_Chi_Tiet = false;
            }
        }
        void HandleValiSubmit_Xuat_Kho_Chi_Tiet()
        {
            try
            {
                CXNK_Xuat_Kho_Chi_Tiet v_objItem = p_objItem_Xuat_Kho_Chi_Tiet;
                if (IsNewRow_Xuat_Kho_Chi_Tiet == true)
                {
                    v_objItem.Last_Updated_By = "admin";
                    v_objItem.Auto_ID = p_Auto_ID;
                    p_objData_Xuat_Kho_Chi_Tiet.Add(v_objItem);
                    p_Auto_ID++;
                }
                else
                {
                    v_objItem.Last_Updated_By = "Long";
                    var item = p_objData_Xuat_Kho_Chi_Tiet.FirstOrDefault(p => p.Auto_ID == v_objItem.Auto_ID);
                    if (item != null)
                        item = v_objItem;
                }
                _Grid_Xuat_Kho_Chi_Tiet.CancelRowEdit();
                _Grid_Xuat_Kho_Chi_Tiet.Refresh();
                Error_Xuat_Kho_Chi_Tiet = "";
            }
            catch (Exception ex)
            {
                Error_Xuat_Kho_Chi_Tiet = ex.Message;
            }
        }
        async void OnRowDeleting_Nhap_Kho_Chi_Tiet(CXNK_Xuat_Kho_Chi_Tiet p_obj)
        {
            bool isConfirmed = await IJS.InvokeAsync<bool>("confirm", "are you sure");
            if (isConfirmed)
            {
                p_objData_Xuat_Kho_Chi_Tiet.Remove(p_obj);
            }
            await _Grid_Xuat_Kho_Chi_Tiet.Refresh();
        }
        #endregion
    }
}
