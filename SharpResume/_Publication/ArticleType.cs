using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class ArticleType : BasicBibliographicRecordType
  {
    public string ISSN;

    public string Issue;
    public string JournalOrSerialName;

    public string PageNumber;

    [XmlElement(DataType = "language")]
    public string PublicationLanguage;

    public string Volume;
  }
}