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
  [XmlRoot("Competency", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class CompetencyType
  {
    [XmlElement("Competency")]
    public List<CompetencyType> Competency;

    [XmlElement("CompetencyEvidence")]
    public List<CompetencyTypeCompetencyEvidence> CompetencyEvidence;

    public CompetencyTypeCompetencyId CompetencyId;

    [XmlElement("CompetencyWeight")]
    public List<CompetencyTypeCompetencyWeight> CompetencyWeight;

    [XmlAttribute]
    public string description;

    [XmlAttribute]
    public string name;

    [XmlAttribute]
    public bool required;

    [XmlIgnore]
    public bool requiredSpecified;

    [XmlElement("TaxonomyId")]
    public List<CompetencyTypeTaxonomyId> TaxonomyId;

    public UserAreaType UserArea;
  }
}