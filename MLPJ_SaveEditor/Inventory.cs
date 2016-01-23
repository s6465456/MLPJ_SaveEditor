using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPJ_SaveEditor
{
    public class Inventory
    {
        #region Fields
        private byte[] m_inventoryData;

        private const byte m_maxItems = 0x63;
        
        private Dictionary<string, DataOffset> m_dataOffsets = new Dictionary<string, DataOffset>()
        {
            { "ITEMS", new DataOffset(0x00000000, 0x00000021)},
            { "GEAR", new DataOffset(0x0000032, 0x000000ba) },
        };
        #endregion

        #region Properties
        internal byte[] Data
        {
            get { return m_inventoryData; }
        }
        #endregion

        #region Constructors
        public Inventory(byte[] data)
        {
            m_inventoryData = data;
        }
        #endregion

        #region Helper Methods
        #endregion

        #region Methods
        public void MaxInventory()
        {
            DataOffset offset = m_dataOffsets["ITEMS"];
            for (int i = offset.Offset; i < (offset.Offset + offset.Length); ++i)
            {
                m_inventoryData[i] = m_maxItems;
            }

            offset = m_dataOffsets["GEAR"];
            for (int i = offset.Offset; i < (offset.Offset + offset.Length); ++i)
            {
                m_inventoryData[i] = m_maxItems;
            }
        }
        #endregion
    }
}
