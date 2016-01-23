using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPJ_SaveEditor
{
    public class DataOffset
    {
        #region Fields
        private int m_offset;
        private int m_length;
        #endregion

        #region Properties;
        public int Offset
        {
            get { return m_offset; }
        }
        public int Length
        {
            get { return m_length; }
        }
        #endregion

        #region Constructors
        public DataOffset(int offset, int length)
        {
            m_offset = offset;
            m_length = length;
        }
        #endregion

    }
}
