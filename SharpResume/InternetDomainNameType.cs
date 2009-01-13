using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot(ElementName = "InternetDomainName", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class InternetDomainNameType
  {
    [XmlAttribute]
    public bool primaryIndicator;

    [XmlIgnore]
    public bool primaryIndicatorSpecified;

    [XmlText]
    public string Value;
  }
}