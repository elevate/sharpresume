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
  [XmlRoot("StructuredXMLResume", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class StructuredXmlResumeType
  {
    [XmlArrayItem("Achievement", IsNullable = false)]
    public List<AchievementType> Achievements;

    [XmlArrayItem("Association", IsNullable = false)]
    public List<Association> Associations;

    public string Comments;
    public SepContactInfoType ContactInfo;

    [XmlArrayItem("SchoolOrInstitution", IsNullable = false)]
    public List<EducationHistoryTypeSchoolOrInstitution> EducationHistory;

    [XmlArrayItem("EmployerOrg", IsNullable = false)]
    public List<EmployerOrganizationDataType> EmploymentHistory;

    public string ExecutiveSummary;

    [XmlArrayItem("Language", IsNullable = false)]
    public List<Language> Languages;

    [XmlArrayItem("LicenseOrCertification", IsNullable = false)]
    public List<CredentialType> LicensesAndCertifications;

    public MilitaryHistoryType MilitaryHistory;
    public string Objective;

    [XmlArrayItem("Patent", IsNullable = false)]
    public List<PatentDescriptionType> PatentHistory;

    [XmlArrayItem("Association", IsNullable = false)]
    public List<string> ProfessionalAssociations;

    public PublicationHistoryType PublicationHistory;

    public StructuredXmlResumeTypeQualifications Qualifications;

    [XmlArrayItem("Reference", IsNullable = false)]
    public List<ReferenceType> References;

    [XmlArrayItem("ResumeAdditionalItem", IsNullable = false)]
    public List<AdditionalItemType> ResumeAdditionalItems;

    public DateTime RevisionDate;

    [XmlArrayItem("SecurityCredential", IsNullable = false)]
    public List<CredentialType> SecurityCredentials;

    [XmlArrayItem("SpeakingEvent", IsNullable = false)]
    public List<SpeakingEventType> SpeakingEventsHistory;

    [XmlElement("SupportingMaterials")]
    public List<StaffingSupportingMaterialsType> SupportingMaterials;
  }
}