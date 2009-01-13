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
  [XmlRoot(ElementName = "Mobile", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class MobileTelcomNumberType : TelcomNumberType
  {
    [XmlAttribute]
    public bool smsEnabled;

    [XmlIgnore]
    public bool smsEnabledSpecified;
  }
}