using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.DX
{
	public class CDX_DO_Chi_Tiet
	{
		private int m_intAuto_ID;
		private int m_intDO_ID;
		private int m_intSan_Pham_ID;
		private int m_intSo_Luong;
		private int m_intGW;
		private int m_intCBM;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CDX_DO_Chi_Tiet()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_intDO_ID = CConst.INT_VALUE_NULL;
			m_intSan_Pham_ID = CConst.INT_VALUE_NULL;
			m_intSo_Luong = CConst.INT_VALUE_NULL;
			m_intGW = CConst.INT_VALUE_NULL;
			m_intCBM = CConst.INT_VALUE_NULL;
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

		public int DO_ID
		{
			get
			{
				return m_intDO_ID;
			}
			set
			{
				m_intDO_ID = value;
			}
		}

		public int San_Pham_ID
		{
			get
			{
				return m_intSan_Pham_ID;
			}
			set
			{
				m_intSan_Pham_ID = value;
			}
		}

		public int So_Luong
		{
			get
			{
				return m_intSo_Luong;
			}
			set
			{
				m_intSo_Luong = value;
			}
		}

		public int GW
		{
			get
			{
				return m_intGW;
			}
			set
			{
				m_intGW = value;
			}
		}

		public int CBM
		{
			get
			{
				return m_intCBM;
			}
			set
			{
				m_intCBM = value;
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
