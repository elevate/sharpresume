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
  [XmlRoot(ElementName = "NumericValue", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class NumericValueType
  {
    [XmlAttribute]
    public string description;

    [XmlAttribute]
    public double interval;

    [XmlIgnore]
    public bool intervalSpecified;

    [XmlAttribute]
    public double maxValue;

    [XmlIgnore]
    public bool maxValueSpecified;

    [XmlAttribute]
    public double minValue;

    [XmlIgnore]
    public bool minValueSpecified;

    [XmlText]
    public double Value;
  }
}