#region

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class EducationMeasureType
  {
    public bool ExcessiveValueIndicator;

    [XmlIgnore]
    public bool ExcessiveValueIndicatorSpecified;

    public bool GoodStudentIndicator;

    [XmlIgnore]
    public bool GoodStudentIndicatorSpecified;

    public MeasureValueType HighestPossibleValue;
    public MeasureValueType LowestPossibleValue;
    public string MeasureSystem;

    public MeasureValueType MeasureValue;
  }
}