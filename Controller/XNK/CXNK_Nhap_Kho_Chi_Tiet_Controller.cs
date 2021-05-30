using DataLayer;
using Entity.XNK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.XNK
{
    public class CXNK_Nhap_Kho_Chi_Tiet_Controller
    {
        #region Map
        private void MapXNK_Nhap_Kho_Chi_Tiet(DataRow p_row, CXNK_Nhap_Kho_Chi_Tiet p_objDes)
        {
            DataTable p_dt = p_row.Table;
            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("Nhap_Kho_ID"))
                p_objDes.Nhap_Kho_ID = CUtility.Convert_To_Int32(p_row["Nhap_Kho_ID"]);

            if (p_dt.Columns.Contains("Session_ID"))
                p_objDes.Session_ID = CUtility.Convert_To_String(p_row["Session_ID"]);

            if (p_dt.Columns.Contains("San_Pham_ID"))
                p_objDes.San_Pham_ID = CUtility.Convert_To_Int32(p_row["San_Pham_ID"]);

            if (p_dt.Columns.Contains("So_Luong"))
                p_objDes.So_Luong = CUtility.Convert_To_Double(p_row["So_Luong"]);

            if (p_dt.Columns.Contains("Don_Gia"))
                p_objDes.Don_Gia = CUtility.Convert_To_Double(p_row["Don_Gia"]);

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

            if (p_dt.Columns.Contains("Ma_San_Pham"))
                p_objDes.Ma_San_Pham = CUtility.Convert_To_String(p_row["Ma_San_Pham"]);

            if (p_dt.Columns.Contains("Ten_San_Pham"))
                p_objDes.Ten_San_Pham = CUtility.Convert_To_String(p_row["Ten_San_Pham"]);

            if (p_dt.Columns.Contains("Thong_Tin_San_Pham"))
                p_objDes.Thong_Tin_San_Pham = CUtility.Convert_To_String(p_row["Thong_Tin_San_Pham"]);

            if (p_dt.Columns.Contains("Tri_Gia"))
                p_objDes.Tri_Gia = CUtility.Convert_To_Double(p_row["Tri_Gia"]);

        }

        #endregion

        #region Nhập Kho Chi Tiết
        public IList<CXNK_Nhap_Kho_Chi_Tiet> List_XNK_Nhap_Kho_Chi_Tiet()
        {
            IList<CXNK_Nhap_Kho_Chi_Tiet> v_arrRes = new List<CXNK_Nhap_Kho_Chi_Tiet>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_XNK_Nhap_Kho_Chi_Tiet");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Nhap_Kho_Chi_Tiet v_objRes = new CXNK_Nhap_Kho_Chi_Tiet();
                    MapXNK_Nhap_Kho_Chi_Tiet(v_row, v_objRes);
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

        public async Task<List<CXNK_Nhap_Kho_Chi_Tiet>> F40011_List_XNK_Nhap_Kho_Chi_Tiet_By_Nhap_Kho_ID(int p_intNhap_Kho_ID)
        {
            List<CXNK_Nhap_Kho_Chi_Tiet> v_arrRes = new List<CXNK_Nhap_Kho_Chi_Tiet>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "F40011_sp_sel_List_XNK_Nhap_Kho_Chi_Tiet_By_Nhap_Kho_ID",
                    p_intNhap_Kho_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Nhap_Kho_Chi_Tiet v_objRes = new CXNK_Nhap_Kho_Chi_Tiet();
                    MapXNK_Nhap_Kho_Chi_Tiet(v_row, v_objRes);
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

        public CXNK_Nhap_Kho_Chi_Tiet Get_XNK_Nhap_Kho_Chi_Tiet_By_ID(int p_iID)
        {
            CXNK_Nhap_Kho_Chi_Tiet v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_XNK_Nhap_Kho_Chi_Tiet_By_ID",
                    p_iID);
                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CXNK_Nhap_Kho_Chi_Tiet();
                    MapXNK_Nhap_Kho_Chi_Tiet(v_dt.Rows[0], v_objRes);
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

        public int Insert_XNK_Nhap_Kho_Chi_Tiet(SqlConnection p_con, SqlTransaction p_tran, CXNK_Nhap_Kho_Chi_Tiet p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(p_con, p_tran, CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_XNK_Nhap_Kho_Chi_Tiet",
                    p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.Don_Gia, p_objData.Last_Updated_By));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return v_iRes;
        }

        public void Update_XNK_Nhap_Kho_Chi_Tiet(CXNK_Nhap_Kho_Chi_Tiet p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_XNK_Nhap_Kho_Chi_Tiet",
                    p_objData.Auto_ID, p_objData.Nhap_Kho_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.Don_Gia, p_objData.Last_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete_XNK_Nhap_Kho_Chi_Tiet(int p_intAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_XNK_Nhap_Kho_Chi_Tiet",
                    p_intAuto_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void F40011_Delete_XNK_Nhap_Kho_Chi_Tiet_By_Nhap_Kho_ID(int p_intNhap_Kho_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F40011_sp_del_XNK_Nhap_Kho_Chi_Tiet_By_Nhap_Kho_ID",
                    p_intNhap_Kho_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Nhập Kho Chi Tiết Temp
        public IList<CXNK_Nhap_Kho_Chi_Tiet> List_XNK_Nhap_Kho_Chi_Tiet_Temp()
        {
            IList<CXNK_Nhap_Kho_Chi_Tiet> v_arrRes = new List<CXNK_Nhap_Kho_Chi_Tiet>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_XNK_Nhap_Kho_Chi_Tiet_Temp");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Nhap_Kho_Chi_Tiet v_objRes = new CXNK_Nhap_Kho_Chi_Tiet();
                    MapXNK_Nhap_Kho_Chi_Tiet(v_row, v_objRes);
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

        public async Task<List<CXNK_Nhap_Kho_Chi_Tiet>> F40011_List_XNK_Nhap_Kho_Chi_Tiet_Temp_By_Session_ID(string p_strSession_ID)
        {
            List<CXNK_Nhap_Kho_Chi_Tiet> v_arrRes = new List<CXNK_Nhap_Kho_Chi_Tiet>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "F40011_sp_sel_List_XNK_Nhap_Kho_Chi_Tiet_Temp_By_Session_ID",
                    p_strSession_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Nhap_Kho_Chi_Tiet v_objRes = new CXNK_Nhap_Kho_Chi_Tiet();
                    MapXNK_Nhap_Kho_Chi_Tiet(v_row, v_objRes);
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

        public CXNK_Nhap_Kho_Chi_Tiet Get_XNK_Nhap_Kho_Chi_Tiet_Temp_By_ID(int p_iID)
        {
            CXNK_Nhap_Kho_Chi_Tiet v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_XNK_Nhap_Kho_Chi_Tiet_Temp_By_ID",
                    p_iID);
                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CXNK_Nhap_Kho_Chi_Tiet();
                    MapXNK_Nhap_Kho_Chi_Tiet(v_dt.Rows[0], v_objRes);
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

        public int Insert_XNK_Nhap_Kho_Chi_Tiet_Temp(CXNK_Nhap_Kho_Chi_Tiet p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_XNK_Nhap_Kho_Chi_Tiet_Temp",
                    p_objData.Session_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.Don_Gia, p_objData.Last_Updated_By));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return v_iRes;
        }

        public void Update_XNK_Nhap_Kho_Chi_Tiet_Temp(CXNK_Nhap_Kho_Chi_Tiet p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_XNK_Nhap_Kho_Chi_Tiet_Temp",
                    p_objData.Auto_ID, p_objData.Session_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.Don_Gia, p_objData.Last_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete_XNK_Nhap_Kho_Chi_Tiet_Temp(int p_intAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_XNK_Nhap_Kho_Chi_Tiet_Temp",
                    p_intAuto_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void F40011_Delete_XNK_Nhap_Kho_Chi_Tiet_Temp_By_Session_ID(string p_strSession_ID)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F40011_sp_del_XNK_Nhap_Kho_Chi_Tiet_Temp_By_Session_ID",
                    p_strSession_ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion
    }
}
