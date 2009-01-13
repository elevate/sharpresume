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
  [XmlType(AnonymousType = true)]
  public class AssociationTypeRole
  {
    public string Comments;

    [XmlElement("Deliverable")]
    public List<string> Deliverable;

    public FlexibleDatesType EndDate;
    public string Name;
    public FlexibleDatesType StartDate;
  }
}