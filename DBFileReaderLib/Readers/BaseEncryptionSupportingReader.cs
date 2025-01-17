using System.Collections.Generic;
using System.Linq;
using DBFileReaderLib.Common;

namespace DBFileReaderLib.Readers
{
    abstract class BaseEncryptionSupportingReader : BaseReader, IEncryptionSupportingReader
    {
        protected List<IEncryptableDatabaseSection> m_sections;
        protected Dictionary<int, int[]> m_encryptedIDs;

        List<IEncryptableDatabaseSection> IEncryptionSupportingReader.GetEncryptedSections()
        {
            return this.m_sections.Where(s => s.TactKeyLookup != 0).ToList();
        }

        Dictionary<int, int[]> IEncryptionSupportingReader.GetEncryptedIDs()
        {
            return this.m_encryptedIDs;
        }
    }
}