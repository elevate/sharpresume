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
  [XmlType(AnonymousType = true)]
  public class RatingTypeNumericValue
  {
    [XmlAttribute]
    public string description;

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