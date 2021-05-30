using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.DX
{
	public class CDX_Tai_Xe
	{
		private int m_intAuto_ID;
		private string m_strTen_Tai_Xe;
		private string m_strSDT;
		private int m_intSo_CMND;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CDX_Tai_Xe()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_strTen_Tai_Xe = CConst.STR_VALUE_NULL;
			m_strSDT = CConst.STR_VALUE_NULL;
			m_intSo_CMND = CConst.INT_VALUE_NULL;
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

		public string Ten_Tai_Xe
		{
			get
			{
				return m_strTen_Tai_Xe;
			}
			set
			{
				m_strTen_Tai_Xe = value.Trim();
			}
		}

		public string SDT
		{
			get
			{
				return m_strSDT;
			}
			set
			{
				m_strSDT = value.Trim();
			}
		}

		public int So_CMND
		{
			get
			{
				return m_intSo_CMND;
			}
			set
			{
				m_intSo_CMND = value;
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
