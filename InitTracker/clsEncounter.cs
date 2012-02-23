
namespace InitTrackerBase
{
    class clsEncounter
    {
        public string strName
        {
            get
            {
                return m_strFilePath.Substring(m_strFilePath.LastIndexOf("\\")+1).Replace(".enc", "");
            }
        }

        private string m_strFilePath;
        public string strEncounterFilePath
        {
            get
            {
                return m_strFilePath;
            }
        }
        

        public clsEncounter(string strFilePath)
        {
            m_strFilePath = strFilePath;
        }

    }
}
