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
	public class CDX_Nhan_Hang_Controller
	{
		private void MapDX_Nhan_Hang(DataRow p_row, CDX_Nhan_Hang p_objDes)
		{
			DataTable p_dt = p_row.Table;

			if (p_dt.Columns.Contains("Auto_ID"))
				p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

			if (p_dt.Columns.Contains("So_Phieu_Nhan"))
				p_objDes.So_Phieu_Nhan = CUtility.Convert_To_String(p_row["So_Phieu_Nhan"]);

			if (p_dt.Columns.Contains("Dia_Chi"))
				p_objDes.Dia_Chi = CUtility.Convert_To_String(p_row["Dia_Chi"]);

			if (p_dt.Columns.Contains("Lat"))
				p_objDes.Lat = CUtility.Convert_To_String(p_row["Lat"]);

			if (p_dt.Columns.Contains("Long"))
				p_objDes.Long = CUtility.Convert_To_String(p_row["Long"]);

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

		public async Task<List<CDX_Nhan_Hang>> List_DX_Nhan_Hang()
		{
			List<CDX_Nhan_Hang> v_arrRes = new List<CDX_Nhan_Hang>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_DX_Nhan_Hang");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CDX_Nhan_Hang v_objRes = new CDX_Nhan_Hang();
					MapDX_Nhan_Hang(v_row, v_objRes);
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

		public CDX_Nhan_Hang Get_DX_Nhan_Hang_By_ID(int p_iID)
		{
			CDX_Nhan_Hang v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_DX_Nhan_Hang_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = new CDX_Nhan_Hang();
					MapDX_Nhan_Hang(v_dt.Rows[0], v_objRes);
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

		public int Insert_DX_Nhan_Hang(CDX_Nhan_Hang p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DX_Nhan_Hang",
					p_objData.So_Phieu_Nhan, p_objData.Dia_Chi, p_objData.Lat, p_objData.Long, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}

		public void Update_DX_Nhan_Hang(CDX_Nhan_Hang p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_DX_Nhan_Hang", p_objData.Auto_ID,
					p_objData.So_Phieu_Nhan, p_objData.Dia_Chi, p_objData.Lat, p_objData.Long, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_DX_Nhan_Hang(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_DX_Nhan_Hang", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
