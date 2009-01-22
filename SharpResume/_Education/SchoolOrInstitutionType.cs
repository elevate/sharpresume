// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

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
  public class SchoolOrInstitutionType
  {
    public string Comments;
    public DeprecatedDatesOfAttendanceType DatesOfAttendance;

    [XmlElement("Degree")]
    public List<SchoolOrInstitutionTypeDegree> Degree;

    [XmlIgnore]
    public bool ISCEDInstitutionClassificationSpecified;

    [XmlElement("LocalInstitutionClassification")]
    public List<ClassificationType> LocalInstitutionClassification;

    public SchoolOrInstitutionTypeLocationSummary LocationSummary;

    [XmlElement("Major")]
    public List<string> Major;

    public EduMeasureType Measure;

    [XmlElement("Minor")]
    public List<string> Minor;

    [XmlElement("OrganizationUnit")]
    public List<SchoolOrInstitutionTypeOrganizationUnit> OrganizationUnit;

    public PostalAddressType PostalAddress;

    [XmlElement("School")]
    public List<SchoolDataType> School;

    public string SchoolName;

    [XmlAttribute]
    public string schoolType;

    public UserAreaType UserArea;

    /// <summary>
    /// Gets or sets the isced institution classification.
    /// </summary>
    /// <value>The isced institution classification.</value>
    [XmlElement(ElementName = "ISCEDInstitutionClassification")]
    public InternationalStandardClassificationOfEducationClassificationType
      InternationalStandardClassificationOfEducationClassification { get; set; }
  }
}