using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.DX
{
	public class CDX_Xe
	{
		private int m_intAuto_ID;
		private string m_strTen_Xe;
		private string m_strBien_So;
		private string m_strTai_Trong;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CDX_Xe()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_strTen_Xe = CConst.STR_VALUE_NULL;
			m_strBien_So = CConst.STR_VALUE_NULL;
			m_strTai_Trong = CConst.STR_VALUE_NULL;
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

		public string Ten_Xe
		{
			get
			{
				return m_strTen_Xe;
			}
			set
			{
				m_strTen_Xe = value.Trim();
			}
		}

		public string Bien_So
		{
			get
			{
				return m_strBien_So;
			}
			set
			{
				m_strBien_So = value.Trim();
			}
		}

		public string Tai_Trong
		{
			get
			{
				return m_strTai_Trong;
			}
			set
			{
				m_strTai_Trong = value.Trim();
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
