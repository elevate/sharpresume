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
  public class StructuredXmlResumeTypeQualifications
  {
    [XmlElement("Competency")]
    public List<CompetencyType> Competency;

    public string QualificationSummary;
  }
}