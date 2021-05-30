using DevExpress.Blazor;
using Entity.DX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.DX
{
    public partial class Trip
    {
        private List<CDX_Trip> p_arrTrip;
        private List<CDX_DO> p_arrDO;
        private List<CDX_Tai_Xe> p_arrTai_Xe;
        private List<CDX_Xe> p_arrXe;
        private List<CDX_Giao_Hang> p_arrGiao_Hang;
        private List<CDX_Nhan_Hang> p_arrNhan_Hang;
        DxDataGrid<CDX_Trip> _Grid;
        //---------------------------------------------------------------------------------------------------------
        CDX_Trip EditContext = new CDX_Trip();
        public bool IsNewRow { get; set; }
        public string Error { get; set; }
        //---------------------------------------------------------------------------------------------------------
        protected override async Task OnInitializedAsync()
        {
            p_arrTai_Xe = await _db_Tai_Xe.List_DX_Tai_Xe();
            p_arrXe = await _db_Xe.List_DX_Xe();
            p_arrTrip = await _db_Trip.List_DX_Trip();
            p_arrDO = await _db_DO.List_DX_DO_Trang_Thai_ID(1);
            p_arrGiao_Hang = await _db_Giao_Hang.List_DX_Giao_Hang();
            p_arrNhan_Hang = await _db_Nhan_Hang.List_DX_Nhan_Hang();
        }
        async void LoadData()
        {
            await OnInitializedAsync();
            await InvokeAsync(StateHasChanged);
        }
        void OnRowStarting(CDX_Trip p_obj)
        {
            if (p_obj == null)
            {
                EditContext = new CDX_Trip();
                IsNewRow = true;
            }
            else
            {
                EditContext = p_obj;
                CDX_DO v_obj_DO = _db_DO.Get_DX_DO_By_ID(EditContext.DO_ID);
                v_obj_DO.Trip_ID = 0;
                v_obj_DO.Trang_Thai_ID = 1;
                _db_DO.Update_DX_DO(v_obj_DO);
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
                CDX_Trip v_obj_Trip = EditContext;
                CDX_DO v_obj_DO = _db_DO.Get_DX_DO_By_ID(v_obj_Trip.DO_ID);
                v_obj_Trip.Nhan_Hang_ID = v_obj_DO.Nhan_Hang_ID;
                v_obj_Trip.Giao_Hang_ID = v_obj_DO.Giao_Hang_ID;
                if (IsNewRow == true)
                {
                    v_obj_Trip.Last_Updated_By = "admin";
                    int v_Auto_ID_Trip = _db_Trip.Insert_DX_Trip(v_obj_Trip);
                    v_obj_DO.Trip_ID = v_Auto_ID_Trip;
                    v_obj_DO.Trang_Thai_ID = 2;
                    _db_DO.Update_DX_DO(v_obj_DO);
                }
                else
                {
                    v_obj_Trip.Last_Updated_By = "Long";
                    v_obj_DO.Trip_ID = v_obj_Trip.Auto_ID;
                    v_obj_DO.Trang_Thai_ID = 2;
                    _db_DO.Update_DX_DO(v_obj_DO);
                    _db_Trip.Update_DX_Trip(v_obj_Trip);
                }
                _Grid.CancelRowEdit();
                LoadData();
                Error = "";
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }
        }
    }
}
