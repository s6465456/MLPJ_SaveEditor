using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPJ_SaveEditor
{
    public class Character
    {
        #region Fields
        private string m_name;
        private const int m_maxExperience = 0x7fffffff;
        private const int m_maxAddedStats = 0x7ffff;
        private const int m_maxLevel = 100;
        private const int m_maxRankBonus = 7;
        private const int m_maxRankValue = 0x16;

        private Dictionary<string, DataOffset> m_dataOffsets = new Dictionary<string,DataOffset>()
        {
            { "HP", new DataOffset(0x00000000, 2) },
            { "BP", new DataOffset(0x00000002, 2) },
            { "HP+", new DataOffset(0x00000004, 2) },
            { "BP+", new DataOffset(0x0000000a, 2) },
            { "POW+", new DataOffset(0x00000010, 2) },
            { "DEF+", new DataOffset(0x00000016, 2) },
            { "SPEED+", new DataOffset(0x0000001c, 2) },
            { "STACHE+", new DataOffset(0x00000022, 2) },
            { "EXP", new DataOffset(0x00000028, 4) },
            { "SHELLRANK", new DataOffset(0x00000036, 1) },
            { "BOOMERANGRANK", new DataOffset(0x00000038, 1) },
            { "FLOWERRANK", new DataOffset(0x0000003a, 1) },
            { "LEAFRANK", new DataOffset(0x0000003c, 1) },
            { "STARRANK", new DataOffset(0x0000003e, 1) },
            { "RAINBOWRANK", new DataOffset(0x00000040, 1) },
            { "EXTRARANK", new DataOffset(0x00000042, 1) },
        };

        private byte[] m_characterData;
        #endregion

        #region Properties
        internal byte[] Data
        {
            get { return m_characterData; }
        }
        public string Name
        {
            get { return m_name; }
        }
        #endregion

        #region Constructors
        public Character(string name, byte[] data)
        {
            m_name = name;
            m_characterData = data;
        }
        #endregion
        
        #region Helper Methods
        #endregion

        #region Methods
        public void MaxLevel()
        {
            byte[] enableRankBonus = BitConverter.GetBytes(0xe0);
            Array.Copy(BitConverter.GetBytes(m_maxExperience), 0, m_characterData, m_dataOffsets["EXP"].Offset, 4);
            for (int i = m_dataOffsets["SHELLRANK"].Offset + 1; i < m_dataOffsets["EXTRARANK"].Offset + 2; i += 2)
            {
                Array.Copy(enableRankBonus, 0, m_characterData, i, 1);
            }
        }
        public void MaxAddedStats()
        {
            DataOffset offset = m_dataOffsets["HP+"];
            Array.Copy(BitConverter.GetBytes(m_maxAddedStats), 0, m_characterData, offset.Offset, offset.Length);

            offset = m_dataOffsets["BP+"];
            Array.Copy(BitConverter.GetBytes(m_maxAddedStats), 0, m_characterData, offset.Offset, offset.Length);

            offset = m_dataOffsets["POW+"];
            Array.Copy(BitConverter.GetBytes(m_maxAddedStats), 0, m_characterData, offset.Offset, offset.Length);

            offset = m_dataOffsets["DEF+"];
            Array.Copy(BitConverter.GetBytes(m_maxAddedStats), 0, m_characterData, offset.Offset, offset.Length);

            offset = m_dataOffsets["SPEED+"];
            Array.Copy(BitConverter.GetBytes(m_maxAddedStats), 0, m_characterData, offset.Offset, offset.Length);

            offset = m_dataOffsets["STACHE+"];
            Array.Copy(BitConverter.GetBytes(m_maxAddedStats), 0, m_characterData, offset.Offset, offset.Length);
        }
        public bool SetRankBonus(string rank, int value)
        {
            if (!m_dataOffsets.ContainsKey(rank))
                return false;

            DataOffset offset = m_dataOffsets[rank];
            Array.Copy(BitConverter.GetBytes(value), 0, m_characterData, offset.Offset, offset.Length);
            return true;
        }
        #endregion
    }
}
