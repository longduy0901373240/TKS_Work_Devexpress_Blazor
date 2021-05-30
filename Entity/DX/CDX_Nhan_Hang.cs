using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.DX
{
	public class CDX_Nhan_Hang
	{
		private int m_intAuto_ID;
		private string m_strSo_Phieu_Nhan;
		private string m_strDia_Chi;
		private string m_strLat;
		private string m_strLong;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CDX_Nhan_Hang()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_strSo_Phieu_Nhan = CConst.STR_VALUE_NULL;
			m_strDia_Chi = CConst.STR_VALUE_NULL;
			m_strLat = CConst.STR_VALUE_NULL;
			m_strLong = CConst.STR_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
		}

		public int Auto_ID
		{
			get
			{
				return m_intAuto_ID;
			}
			set
			{
				m_intAuto_ID = value;
			}
		}

		public string So_Phieu_Nhan
		{
			get
			{
				return m_strSo_Phieu_Nhan;
			}
			set
			{
				m_strSo_Phieu_Nhan = value.Trim();
			}
		}

		public string Dia_Chi
		{
			get
			{
				return m_strDia_Chi;
			}
			set
			{
				m_strDia_Chi = value.Trim();
			}
		}

		public string Lat
		{
			get
			{
				return m_strLat;
			}
			set
			{
				m_strLat = value.Trim();
			}
		}

		public string Long
		{
			get
			{
				return m_strLong;
			}
			set
			{
				m_strLong = value.Trim();
			}
		}

		public int deleted
		{
			get
			{
				return m_intdeleted;
			}
			set
			{
				m_intdeleted = value;
			}
		}

		public DateTime Created
		{
			get
			{
				return m_dtmCreated;
			}
			set
			{
				m_dtmCreated = value;
			}
		}

		public string Created_By
		{
			get
			{
				return m_strCreated_By;
			}
			set
			{
				m_strCreated_By = value.Trim();
			}
		}

		public DateTime Last_Updated
		{
			get
			{
				return m_dtmLast_Updated;
			}
			set
			{
				m_dtmLast_Updated = value;
			}
		}

		public string Last_Updated_By
		{
			get
			{
				return m_strLast_Updated_By;
			}
			set
			{
				m_strLast_Updated_By = value.Trim();
			}
		}
	}
}
