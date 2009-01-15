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
  [XmlType(AnonymousType = true)]
  public class EduDegreeTypeDegreeName
  {
    [XmlAttribute]
    public string academicHonors;

    [XmlAttribute]
    public string honorsProgram;

    [XmlText]
    public string Value;
  }
}