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
  public class BookType : BasicBibliographicRecordType
  {
    public string Chapter;
    public string Edition;

    public string ISBN;
    public string ISSN;

    [XmlElement(DataType = "positiveInteger")]
    public string NumberOfPages;

    public string PublisherLocation;
    public string PublisherName;
  }
}