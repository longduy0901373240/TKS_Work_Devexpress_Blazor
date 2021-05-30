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
	public class CDX_DO_Chi_Tiet_Controller
	{
		private void MapDX_DO_Chi_Tiet(DataRow p_row, CDX_DO_Chi_Tiet p_objDes)
		{
			DataTable p_dt = p_row.Table;

			if (p_dt.Columns.Contains("Auto_ID"))
				p_objDes.Auto_ID = CUtility.Convert_To_Int32(p_row["Auto_ID"]);

			if (p_dt.Columns.Contains("DO_ID"))
				p_objDes.DO_ID = CUtility.Convert_To_Int32(p_row["DO_ID"]);

			if (p_dt.Columns.Contains("San_Pham_ID"))
				p_objDes.San_Pham_ID = CUtility.Convert_To_Int32(p_row["San_Pham_ID"]);

			if (p_dt.Columns.Contains("So_Luong"))
				p_objDes.So_Luong = CUtility.Convert_To_Int32(p_row["So_Luong"]);

			if (p_dt.Columns.Contains("GW"))
				p_objDes.GW = CUtility.Convert_To_Int32(p_row["GW"]);

			if (p_dt.Columns.Contains("CBM"))
				p_objDes.CBM = CUtility.Convert_To_Int32(p_row["CBM"]);

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

		public IList<CDX_DO_Chi_Tiet> List_DX_DO_Chi_Tiet()
		{
			IList<CDX_DO_Chi_Tiet> v_arrRes = new List<CDX_DO_Chi_Tiet>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_List_DX_DO_Chi_Tiet");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CDX_DO_Chi_Tiet v_objRes = new CDX_DO_Chi_Tiet();
					MapDX_DO_Chi_Tiet(v_row, v_objRes);
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

		public async Task<List<CDX_DO_Chi_Tiet>> F50011_List_CDX_DO_Chi_Tiet_By_Nhap_Kho_ID(int p_intDO_ID)
		{
			List<CDX_DO_Chi_Tiet> v_arrRes = new List<CDX_DO_Chi_Tiet>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "F50011_sp_sel_List_DX_DO_Chi_Tiet_By_DO_ID",
					p_intDO_ID);

				foreach (DataRow v_row in v_dt.Rows)
				{
					CDX_DO_Chi_Tiet v_objRes = new CDX_DO_Chi_Tiet();
					MapDX_DO_Chi_Tiet(v_row, v_objRes);
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

		public CDX_DO_Chi_Tiet Get_DX_DO_Chi_Tiet_By_ID(int p_iID)
		{
			CDX_DO_Chi_Tiet v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, v_dt, "sp_sel_Get_DX_DO_Chi_Tiet_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = new CDX_DO_Chi_Tiet();
					MapDX_DO_Chi_Tiet(v_dt.Rows[0], v_objRes);
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

		public int Insert_DX_DO_Chi_Tiet(CDX_DO_Chi_Tiet p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DX_DO_Chi_Tiet",
					p_objData.DO_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.GW, p_objData.CBM, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}
		public int Insert_DX_DO_Chi_Tiet(SqlConnection p_con, SqlTransaction p_tran, CDX_DO_Chi_Tiet p_objData)
		{
			int v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt32(CSqlHelper.ExecuteScalar(p_con, p_tran, CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_ins_DX_DO_Chi_Tiet",
					p_objData.DO_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.GW, p_objData.CBM, p_objData.Last_Updated_By));
			}

			catch (Exception ex)
			{
				throw ex;
			}

			return v_iRes;
		}
		public void Update_DX_DO_Chi_Tiet(CDX_DO_Chi_Tiet p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_upd_DX_DO_Chi_Tiet", p_objData.Auto_ID,
					p_objData.DO_ID, p_objData.San_Pham_ID, p_objData.So_Luong, p_objData.GW, p_objData.CBM, p_objData.Last_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete_DX_DO_Chi_Tiet(int p_iAuto_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "sp_del_DX_DO_Chi_Tiet", p_iAuto_ID, p_strLast_Updated_By);
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void F50011_Delete_DX_DO_Chi_Tiet_By_DO_ID(int p_intDO_ID, string p_strLast_Updated_By)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String, "F50011_sp_del_DX_DO_Chi_Tiet_By_DO_ID",
					p_intDO_ID, p_strLast_Updated_By);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
