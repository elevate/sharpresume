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
  public class EducationalMeasureTypeClassRank
  {
    [XmlAttribute(DataType = "integer")]
    public string numberOfStudents;

    [XmlText(DataType = "integer")]
    public string Value;
  }
}