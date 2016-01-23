using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MLPJ_SaveEditor
{
    public sealed class SaveFile
    {
        #region Fields
        // I have no interest in going further
        private const int m_dataUsed = 0x1c0;
        private const int m_characterDataLength = 0x44;
        private const int m_maxCoinValue = 0x0f423f;

        private byte[] m_saveData;

        private Dictionary<string, DataOffset> m_dataOffsets = new Dictionary<string, DataOffset>()
        {
            { "CHARACTERS", new DataOffset(0x00000000, 0x000000cc) },
            { "COINS", new DataOffset(0x000000cc, 4) },
            { "INVENTORY", new DataOffset(0x000000d4, 0x000000ec) }
        };

        private string[] m_characterNames = new string[]
        {
            "Mario",
            "Luigi",
            "Paper Mario"
        };

        private Dictionary<string, Character> m_characters = new Dictionary<string, Character>();
        private Inventory m_inventory;
        #endregion

        #region Properties
        public Dictionary<string, Character> Characters
        {
            get { return m_characters; }
        }
        public Inventory Inventory
        {
            get { return m_inventory; }
        }
        #endregion

        #region Constructors
        public SaveFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(string.Format("{0} does not exist.", path));
            }

            Initialize(path);
        }
        #endregion

        #region Helper Methods
        private void Initialize(string path)
        {
            FileStream fs = File.OpenRead(path);
                        
            m_saveData = new byte[m_dataUsed];
            fs.Read(m_saveData, 0, m_dataUsed);

            fs.Close();            

            GetCharacters();
            GetInventory();
        }

        private byte[] GetData(DataOffset offset)
        {
            byte[] temp = new byte[offset.Length];
            Array.Copy(m_saveData, offset.Offset, temp, 0, offset.Length);
            return temp;
        }

        private void GetCharacters()
        {
            int dataOffset = m_dataOffsets["CHARACTERS"].Offset;
            byte[] tempData;

            for (int i = 0; i < m_characterNames.Length; ++i)
            {
                string key = m_characterNames[i];
                tempData = new byte[m_characterDataLength];

                Array.Copy(m_saveData, dataOffset, tempData, 0, m_characterDataLength);
                m_characters[key] = new Character(key, tempData);
                dataOffset += m_characterDataLength;
            }
        }

        private void GetInventory()
        {
            m_inventory = new Inventory(GetData(m_dataOffsets["INVENTORY"]));
        }
        #endregion

        #region Methods
        public void Save(string path)
        {
            int dataOffset = m_dataOffsets["CHARACTERS"].Offset;
            
            for (int i = 0; i < m_characterNames.Length; ++i)
            {
                string key = m_characterNames[i];
                Array.Copy(m_characters[key].Data, 0, m_saveData, dataOffset, m_characterDataLength);
                dataOffset += m_characterDataLength;
            }

            Array.Copy(m_inventory.Data, 0, m_saveData, m_dataOffsets["INVENTORY"].Offset, m_dataOffsets["INVENTORY"].Length);

            BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            bw.BaseStream.Position = 0;
            bw.Write(m_saveData, 0, m_saveData.Length);
            bw.Close();
        }
        public void MaxCoins()
        {
            Array.Copy(BitConverter.GetBytes(m_maxCoinValue), 0, m_saveData, m_dataOffsets["COINS"].Offset, 4);
        }
        #endregion
    }
}
