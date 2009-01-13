using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class VerificationType
  {
    public RatingType AttendanceRating;
    public VerificationTypeContactInfo ContactInfo;

    public bool EligibleForRehire;

    [XmlIgnore]
    public bool EligibleForRehireSpecified;

    public RatingType OverallPerformanceRating;
    public bool PermissionToContact;

    [XmlIgnore]
    public bool PermissionToContactSpecified;

    [XmlElement("QuestionAnswerPair")]
    public List<EmploymentQuestionAnswerPairType> QuestionAnswerPair;

    public string ReasonForLeaving;
    public bool VerifyEmployment;

    [XmlIgnore]
    public bool VerifyEmploymentSpecified;
  }
}