using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class EducationalMeasureType
  {
    public AcademicCreditCodeType AcademicCreditCode;

    [XmlIgnore]
    public bool AcademicCreditCodeSpecified;

    public decimal AcademicCreditHoursAttempted;

    [XmlIgnore]
    public bool AcademicCreditHoursAttemptedSpecified;

    public decimal AcademicCreditHoursEarned;

    [XmlIgnore]
    public bool AcademicCreditHoursEarnedSpecified;

    public decimal AcademicCreditHoursIncluded;

    [XmlIgnore]
    public bool AcademicCreditHoursIncludedSpecified;

    public EducationalMeasureTypeClassRank ClassRank;
    public CourseLevelCodeType CourseLevelCode;

    [XmlIgnore]
    public bool CourseLevelCodeSpecified;

    public bool CumulativeSummaryIndicator;

    [XmlIgnore]
    public bool CumulativeSummaryIndicatorSpecified;

    public EducationMeasureType EducationalMeasure;

    [XmlAttribute]
    public string measureType;
  }
}