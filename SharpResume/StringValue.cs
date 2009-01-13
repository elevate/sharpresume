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
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class StringValue
  {
    [XmlAttribute]
    public string description;

    [XmlAttribute]
    public string maxValue;

    [XmlAttribute]
    public string minValue;

    [XmlText]
    public string Value;
  }
}