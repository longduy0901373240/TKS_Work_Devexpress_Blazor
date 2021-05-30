using DataLayer;
using Entity.DX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Controller.DX
{
	public class CDX_Trip_Controller
	{
		private void MapDX_Trip(DataRow p_row, CDX_Trip p_objDes)
		{
			DataTable p_dt = p_row.Table;

			if (p_dt.Columns.Contains("Auto_ID"))
				p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

			if (p_dt.Columns.Contains("DO_ID"))
				p_objDes.DO_ID = CUtility.Convert_To_Int32(p_row["DO_ID"]);

			if (p_dt.Columns.Contains("Tai_Xe_ID"))
				p_objDes.Tai_Xe_ID = CUtility.Convert_To_Int32(p_row["Tai_Xe_ID"]);

			if (p_dt.Columns.Contains("Xe_ID"))
				p_objDes.Xe_ID = CUtility.Convert_To_Int32(p_row["Xe_ID"]);

			if (p_dt.Columns.Contains("Nhan_Hang_ID"))
				p_objDes.Nhan_Hang_ID = CUtility.Convert_To_Int32(p_row["Nhan_Hang_ID"]);

			if (p_dt.Columns.Contains("Giao_Hang_ID"))
				p_objDes.Giao_Hang_ID = CUtility.Convert_To_Int32(p_row["Giao_Hang_ID"]);

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

		public async Task<List<CDX_Trip>> List_DX_Trip()
		{
			List<CDX_Trip> v_arrRes = new List<CDX_Trip>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_DX_Trip");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CDX_Trip v_objRes = new CDX_Trip();
					MapDX_Trip(v_row, v_objRes);
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

		public CDX_Trip Get_DX_Trip_By_ID(int p_iID)
		{
			CDX_Trip v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_DX_Trip_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = new CDX_Trip();
					MapDX_Trip(v_dt.Rows[0], v_objRes);
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

		public int Insert_DX_Trip(CDX_Trip p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DX_Trip",
					p_objData.DO_ID, p_objData.Tai_Xe_ID, p_objData.Xe_ID, p_objData.Nhan_Hang_ID, p_objData.Giao_Hang_ID, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_DX_Trip(CDX_Trip p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_DX_Trip", p_objData.Auto_ID,
					p_objData.DO_ID, p_objData.Tai_Xe_ID, p_objData.Xe_ID, p_objData.Nhan_Hang_ID, p_objData.Giao_Hang_ID, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_DX_Trip(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_DX_Trip", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
