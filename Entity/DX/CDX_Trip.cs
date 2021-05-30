using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.DX
{
	public class CDX_Trip
	{
		private int m_intAuto_ID;
		private int m_intDO_ID;
		private int m_intTai_Xe_ID;
		private int m_intXe_ID;
		private int m_intNhan_Hang_ID;
		private int m_intGiao_Hang_ID;
		private string m_strSo_Phieu_Giao;
		private string m_strSo_Phieu_Nhan;
		private int m_intdeleted;
		private DateTime m_dtmCreated;
		private string m_strCreated_By;
		private DateTime m_dtmLast_Updated;
		private string m_strLast_Updated_By;

		public CDX_Trip()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_intAuto_ID = CConst.INT_VALUE_NULL;
			m_intDO_ID = CConst.INT_VALUE_NULL;
			m_intTai_Xe_ID = CConst.INT_VALUE_NULL;
			m_intXe_ID = CConst.INT_VALUE_NULL;
			m_intNhan_Hang_ID = CConst.INT_VALUE_NULL;
			m_intGiao_Hang_ID = CConst.INT_VALUE_NULL;
			m_strSo_Phieu_Giao = CConst.STR_VALUE_NULL;
			m_strSo_Phieu_Nhan = CConst.STR_VALUE_NULL;
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

		public int Tai_Xe_ID
		{
			get
			{
				return m_intTai_Xe_ID;
			}
			set
			{
				m_intTai_Xe_ID = value;
			}
		}

		public int Xe_ID
		{
			get
			{
				return m_intXe_ID;
			}
			set
			{
				m_intXe_ID = value;
			}
		}

		public int Nhan_Hang_ID
		{
			get
			{
				return m_intNhan_Hang_ID;
			}
			set
			{
				m_intNhan_Hang_ID = value;
			}
		}

		public int Giao_Hang_ID
		{
			get
			{
				return m_intGiao_Hang_ID;
			}
			set
			{
				m_intGiao_Hang_ID = value;
			}
		}
		public string So_Phieu_Giao
		{
			get
			{
				return m_strSo_Phieu_Giao;
			}
			set
			{
				m_strSo_Phieu_Giao = value;
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
				m_strSo_Phieu_Nhan = value;
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
