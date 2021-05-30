using DataLayer;
using Entity.DX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DX
{
	public class CDX_DO_Controller
	{
		private void MapDX_DO(DataRow p_row, CDX_DO p_objDes)
		{
			DataTable p_dt = p_row.Table;

			if (p_dt.Columns.Contains("Auto_ID"))
				p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

			if (p_dt.Columns.Contains("Nhan_Hang_ID"))
				p_objDes.Nhan_Hang_ID = CUtility.Convert_To_Int32(p_row["Nhan_Hang_ID"]);

			if (p_dt.Columns.Contains("Giao_Hang_ID"))
				p_objDes.Giao_Hang_ID = CUtility.Convert_To_Int32(p_row["Giao_Hang_ID"]);

			if (p_dt.Columns.Contains("Ngay_Giao_Hang"))
				p_objDes.Ngay_Giao_Hang = CUtility.Convert_To_DateTime(p_row["Ngay_Giao_Hang"]);

			if (p_dt.Columns.Contains("Trip_ID"))
				p_objDes.Trip_ID = CUtility.Convert_To_Int32(p_row["Trip_ID"]);

			if (p_dt.Columns.Contains("Trang_Thai_ID"))
				p_objDes.Trang_Thai_ID = CUtility.Convert_To_Int32(p_row["Trang_Thai_ID"]);

			if (p_dt.Columns.Contains("So_Phieu_Giao"))
				p_objDes.So_Phieu_Giao = CUtility.Convert_To_String(p_row["So_Phieu_Giao"]);

			if (p_dt.Columns.Contains("So_Phieu_Nhan"))
				p_objDes.So_Phieu_Nhan = CUtility.Convert_To_String(p_row["So_Phieu_Nhan"]);

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

		public async Task<List<CDX_DO>> List_DX_DO()
		{
			List<CDX_DO> v_arrRes = new List<CDX_DO>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_DX_DO");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CDX_DO v_objRes = new CDX_DO();
					MapDX_DO(v_row, v_objRes);
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
		public async Task<List<CDX_DO>> List_DX_DO_Trang_Thai_ID(int p_intTrang_Thai_ID)
		{
			List<CDX_DO> v_arrRes = new List<CDX_DO>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "F5001_sp_sel_List_DX_DO_Trang_Thai_ID"
					,p_intTrang_Thai_ID);

				foreach (DataRow v_row in v_dt.Rows)
				{
					CDX_DO v_objRes = new CDX_DO();
					MapDX_DO(v_row, v_objRes);
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

		public CDX_DO Get_DX_DO_By_ID(int p_iID)
		{
			CDX_DO v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_DX_DO_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = new CDX_DO();
					MapDX_DO(v_dt.Rows[0], v_objRes);
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

		public int Insert_DX_DO(CDX_DO p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DX_DO",
					p_objData.Nhan_Hang_ID, p_objData.Giao_Hang_ID, p_objData.Ngay_Giao_Hang, p_objData.Trip_ID, p_objData.Trang_Thai_ID, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}
		public int Insert_DX_DO(SqlConnection p_con,SqlTransaction p_tran, CDX_DO p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(p_con, p_tran, CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DX_DO",
					p_objData.Nhan_Hang_ID, p_objData.Giao_Hang_ID, p_objData.Ngay_Giao_Hang, p_objData.Trip_ID, p_objData.Trang_Thai_ID, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_DX_DO(CDX_DO p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_DX_DO", p_objData.Auto_ID,
					p_objData.Nhan_Hang_ID, p_objData.Giao_Hang_ID, p_objData.Ngay_Giao_Hang, p_objData.Trip_ID, p_objData.Trang_Thai_ID, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_DX_DO(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_DX_DO", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void F5001_Delete_XNK_Nhap_Kho(int p_intAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F5001_sp_del_DX_DO",
					p_intAuto_ID, p_strLast_Updated_By);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
