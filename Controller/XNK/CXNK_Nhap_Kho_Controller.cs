﻿using DataLayer;
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
    public class CXNK_Nhap_Kho_Controller
    {
        private void MapXNK_Nhap_Kho(DataRow p_row, CXNK_Nhap_Kho p_objDes)
        {
            DataTable p_dt = p_row.Table;

            if (p_dt.Columns.Contains("Auto_ID"))
                p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

            if (p_dt.Columns.Contains("So_Phieu_Nhap"))
                p_objDes.So_Phieu_Nhap = CUtility.Convert_To_String(p_row["So_Phieu_Nhap"]);

            if (p_dt.Columns.Contains("Ngay_Nhap_Kho"))
                p_objDes.Ngay_Nhap_Kho = CUtility.Convert_To_DateTime(p_row["Ngay_Nhap_Kho"]);

            if (p_dt.Columns.Contains("Nha_Cung_Cap_ID"))
                p_objDes.Nha_Cung_Cap_ID = CUtility.Convert_To_Int32(p_row["Nha_Cung_Cap_ID"]);

            if (p_dt.Columns.Contains("Kho_ID"))
                p_objDes.Kho_ID = CUtility.Convert_To_Int32(p_row["Kho_ID"]);

            if (p_dt.Columns.Contains("Ghi_Chu"))
                p_objDes.Ghi_Chu = CUtility.Convert_To_String(p_row["Ghi_Chu"]);

            if (p_dt.Columns.Contains("Tong_So_Luong"))
                p_objDes.Tong_So_Luong = CUtility.Convert_To_Double(p_row["Tong_So_Luong"]);

            if (p_dt.Columns.Contains("Tong_Tri_Gia"))
                p_objDes.Tong_Tri_Gia = CUtility.Convert_To_Double(p_row["Tong_Tri_Gia"]);

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

        public async Task<List<CXNK_Nhap_Kho>> List_XNK_Nhap_Kho()
        {
            List<CXNK_Nhap_Kho> v_arrRes = new List<CXNK_Nhap_Kho>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_XNK_Nhap_Kho");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CXNK_Nhap_Kho v_objRes = new CXNK_Nhap_Kho();
                    MapXNK_Nhap_Kho(v_row, v_objRes);
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

        public CXNK_Nhap_Kho Get_XNK_Nhap_Kho_By_ID(int p_iID)
        {
            CXNK_Nhap_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_XNK_Nhap_Kho_By_ID",
                    p_iID);
                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CXNK_Nhap_Kho();
                    MapXNK_Nhap_Kho(v_dt.Rows[0], v_objRes);
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

        public CXNK_Nhap_Kho F40011_Get_XNK_Nhap_Kho_By_So_Phieu_Nhap(string p_strSo_Phieu_Nhap)
        {
            CXNK_Nhap_Kho v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "F40011_sp_sel_Get_XNK_Nhap_Kho_By_So_Phieu_Nhap",
                    p_strSo_Phieu_Nhap);
                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = new CXNK_Nhap_Kho();
                    MapXNK_Nhap_Kho(v_dt.Rows[0], v_objRes);
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

        public int Insert_XNK_Nhap_Kho(SqlConnection p_con, SqlTransaction p_tran, CXNK_Nhap_Kho p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(p_con, p_tran, CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_XNK_Nhap_Kho",
                    p_objData.So_Phieu_Nhap, p_objData.Ngay_Nhap_Kho, p_objData.Nha_Cung_Cap_ID, p_objData.Kho_ID, p_objData.Ghi_Chu, p_objData.Tong_So_Luong, p_objData.Tong_Tri_Gia, p_objData.Last_Updated_By));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return v_iRes;
        }

        public void Update_XNK_Nhap_Kho(CXNK_Nhap_Kho p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_XNK_Nhap_Kho",
                    p_objData.Auto_ID, p_objData.So_Phieu_Nhap, p_objData.Ngay_Nhap_Kho, p_objData.Nha_Cung_Cap_ID, p_objData.Kho_ID, p_objData.Ghi_Chu, p_objData.Tong_So_Luong, p_objData.Tong_Tri_Gia, p_objData.Last_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete_XNK_Nhap_Kho(int p_intAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_XNK_Nhap_Kho",
                    p_intAuto_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void F4001_Delete_XNK_Nhap_Kho(int p_intAuto_ID, string p_strLast_Updated_By)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F4001_sp_del_XNK_Nhap_Kho",
                    p_intAuto_ID, p_strLast_Updated_By);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
