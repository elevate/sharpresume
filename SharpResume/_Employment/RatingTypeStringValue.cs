using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(AnonymousType = true)]
  public class RatingTypeStringValue
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