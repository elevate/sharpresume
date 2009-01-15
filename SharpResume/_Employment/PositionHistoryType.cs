#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class PositionHistoryType
  {
    public string Comments;
    public PositionCompensationType Compensation;

    [XmlElement("Competency")]
    public List<CompetencyType> Competency;

    [XmlAttribute]
    public bool currentEmployer;

    [XmlIgnore]
    public bool currentEmployerSpecified;

    public string Description;
    public FlexibleDatesType EndDate;

    [XmlElement("JobCategory")]
    public List<OccupationalCategoryType> JobCategory;

    [XmlElement("JobLevelInfo")]
    public List<JobLevelInfoType> JobLevelInfo;

    [XmlElement("OrgIndustry")]
    public List<PositionOrgIndustryType> OrgIndustry;

    [XmlElement("OrgInfo")]
    public List<PositionOrgInfoType> OrgInfo;

    public PositionOrgNameType OrgName;
    public string OrgSize;

    [XmlAttribute]
    public string positionType;

    public FlexibleDatesType StartDate;
    public string Title;
    public UserAreaType UserArea;
    public VerificationType Verification;
  }
}