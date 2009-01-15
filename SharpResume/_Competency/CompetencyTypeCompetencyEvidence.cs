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
  [XmlType(AnonymousType = true)]
  public class CompetencyTypeCompetencyEvidence
  {
    [XmlAttribute]
    public string dateOfIncident;

    public CompetencyTypeCompetencyEvidenceEvidenceId EvidenceId;

    [XmlAttribute]
    public string expirationDate;

    [XmlElement("NumericValue", typeof (NumericValueType))]
    [XmlElement("StringValue", typeof (StringValue))]
    public object Item;

    [XmlAttribute]
    public string lastUsed;

    [XmlAttribute]
    public string name;

    [XmlAttribute]
    public bool required;

    [XmlIgnore]
    public bool requiredSpecified;

    [XmlElement("SupportingInformation")]
    public List<string> SupportingInformation;

    [XmlAttribute]
    public string typeDescription;

    [XmlAttribute]
    public string typeId;
  }
}