#region

using System;
using System.Collections.Generic;
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
  public class EduDegreeType
  {
    public string Comments;

    [XmlElement("DatesOfAttendance")]
    public List<DatesOfAttendanceType> DatesOfAttendance;

    [XmlElement("DegreeClassification")]
    public List<ClassificationType> DegreeClassification;

    public FlexibleDatesType DegreeDate;

    [XmlElement("DegreeMajor")]
    public List<MajorType> DegreeMajor;

    public EducationalMeasureType DegreeMeasure;

    [XmlElement("DegreeMinor")]
    public List<MinorType> DegreeMinor;

    public EduDegreeTypeDegreeName DegreeName;

    [XmlAttribute]
    public string degreeType;

    [XmlAttribute]
    public bool examPassed;

    [XmlIgnore]
    public bool examPassedSpecified;

    [XmlAttribute]
    public GraduatingDegreeType graduatingDegree;

    [XmlIgnore]
    public bool graduatingDegreeSpecified;

    [XmlElement("OtherHonors")]
    public List<EduDegreeTypeOtherHonors> OtherHonors;

    public UserAreaType UserArea;
  }
}