#region

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class OtherPublicationType : BasicBibliographicRecordType
  {
    public string ISBN;
    public string ISSN;

    [XmlElement(DataType = "positiveInteger")]
    public string NumberOfPages;

    public string PublisherLocation;
    public string PublisherName;

    [XmlAttribute]
    public string type;
  }
}