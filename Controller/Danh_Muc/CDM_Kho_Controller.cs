using DataLayer;
using Entity.Danh_Muc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.Danh_Muc
{
    public class CDM_Kho_Controller
    {
        #region MapDM_Kho và MapPhan_Quyen_Kho_User
        private void MapDM_Kho(DataRow p_row, CDM_Kho p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Ten_Kho"))
                p_objDes.Ten_Kho = CUtility.Convert_To_String(p_row["Ten_Kho"]);

            if (p_dt.Columns.Contains("deleted"))
                p_objDes.deleted = CUtility.Convert_To_Int32(p_row["deleted"]);

            if (p_dt.Columns.Contains("Created"))
                p_objDes.Created = CUtility.Convert_To_DateTime(p_row["Created"]);

            if (p_dt.Columns.Contains("Created_By"))
                p_objDes.Created_By = CUtility.Convert_To_String(p_row["Created_By"]);

            if (p_dt.Columns.Contains("Last_Updated"))
                p_objDes.Last_Updated = CUtility.Convert_To_DateTime(p_row["Last_Updated"]);

            if (p_dt.Columns.Contains("Last_Updated_By"))
                p_objDes.Last_Updated_By = CUtility.Convert_To_String(p_row["Last_Updated_By"]);
        }

        private void MapPhan_Quyen_Kho_User(DataRow p_row, CDM_Phan_Quyen_Kho_User p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Kho_ID"))
                p_objDes.Kho_ID = CUtility.Convert_To_Int32(p_row["Kho_ID"]);

            if (p_dt.Columns.Contains("Ma_Dang_Nhap"))
                p_objDes.Ma_Dang_Nhap = CUtility.Convert_To_String(p_row["Ma_Dang_Nhap"]);

            if (p_dt.Columns.Contains("deleted"))
                p_objDes.deleted = CUtility.Convert_To_Int32(p_row["deleted"]);

            if (p_dt.Columns.Contains("Created"))
                p_objDes.Created = CUtility.Convert_To_DateTime(p_row["Created"]);

            if (p_dt.Columns.Contains("Created_By"))
                p_objDes.Created_By = CUtility.Convert_To_String(p_row["Created_By"]);

            if (p_dt.Columns.Contains("Last_Updated"))
                p_objDes.Last_Updated = CUtility.Convert_To_DateTime(p_row["Last_Updated"]);

            if (p_dt.Columns.Contains("Last_Updated_By"))
                p_objDes.Last_Updated_By = CUtility.Convert_To_String(p_row["Last_Updated_By"]);
        }
        #endregion

        #region DM_Phan_Quyen_Kho_User
        public IList<CDM_Phan_Quyen_Kho_User> List_Phan_Quyen_Kho_User()
        {
            IList<CDM_Phan_Quyen_Kho_User> v_arrRes = new List<CDM_Phan_Quyen_Kho_User>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_DM_Phan_Quyen_Kho_User");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Phan_Quyen_Kho_User v_objRes = new CDM_Phan_Quyen_Kho_User();
                    MapPhan_Quyen_Kho_User(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public IList<CDM_Phan_Quyen_Kho_User> F3006_List_Phan_Quyen_Kho_User_By_Kho_ID(int p_iKho_ID)
        {
            IList<CDM_Phan_Quyen_Kho_User> v_arrRes = new List<CDM_Phan_Quyen_Kho_User>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "F3006_sp_sel_List_Phan_Quyen_Kho_User_By_Kho_ID",
                    p_iKho_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Phan_Quyen_Kho_User v_objRes = new CDM_Phan_Quyen_Kho_User();
                    MapPhan_Quyen_Kho_User(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_arrRes;
        }

        public CDM_Phan_Quyen_Kho_User Get_Phan_Quyen_Kho_User_By_ID(int p_iID)
        {
            CDM_Phan_Quyen_Kho_User v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_DM_Phan_Quyen_Kho_User_By_ID",
                    p_iID);

                if (v_dt.Rows.Count > 1)
                {
                    v_objRes = new CDM_Phan_Quyen_Kho_User();
                    MapPhan_Quyen_Kho_User(v_dt.Rows[0], v_objRes);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_objRes;
        }

        public int Insert_Phan_Quyen_Kho_User(CDM_Phan_Quyen_Kho_User p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DM_Phan_Quyen_Kho_User",
                    p_objData.Kho_ID, p_objData.Ma_Dang_Nhap, p_objData.Last_Updated_By));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return v_iRes;
        }

        public void Update_Phan_Quyen_Kho_User(CDM_Phan_Quyen_Kho_User p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_DM_Phan_Quyen_Kho_User",
                    p_objData.Auto_ID, p_objData.Kho_ID, p_objData.Ma_Dang_Nhap, p_objData.Last_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete_Phan_Quyen_Kho(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_DM_Phan_Quyen_Kho_User",
                    p_iAuto_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region DM_Kho

        public async Task<List<CDM_Kho>> List_DM_Kho()
        {
            List<CDM_Kho> v_arrRes = new List<CDM_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_DM_Kho");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CDM_Kho v_objRes = new CDM_Kho();
                    MapDM_Kho(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                v_dt.Dispose();
            }

            return await Task.FromResult(v_arrRes);
        }

        public CDM_Kho Get_DM_Kho_By_ID(int p_iID)
        {
            CDM_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_DM_Kho_By_ID",
                    p_iID);
                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CDM_Kho();
                    MapDM_Kho(v_dt.Rows[0], v_objRes);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                v_dt.Dispose();
            }
            return v_objRes;
        }

        public int Insert_DM_Kho(CDM_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DM_Kho",
                    p_objData.Ten_Kho, p_objData.Last_Updated_By));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return v_iRes;
        }

        public int F3005_Insert_DM_Kho(CDM_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F3005_sp_ins_Kho",
                    p_objData.Ten_Kho, p_objData.Last_Updated_By));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return v_iRes;
        }

        public void Update_DM_Kho(CDM_Kho p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_DM_Kho",
                    p_objData.Auto_ID, p_objData.Ten_Kho, p_objData.Last_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void F3005_Update_DM_Kho(CDM_Kho p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F3005_sp_upd_Kho",
                    p_objData.Auto_ID, p_objData.Ten_Kho, p_objData.Last_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete_DM_Kho(int p_iAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_DM_Kho",
                    p_iAuto_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
