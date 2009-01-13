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
  public class AssociationType
  {
    public string Comments;
    public FlexibleDatesType EndDate;
    public EntityIdType Id;

    public string Link;
    public string Name;

    [XmlElement("Role")]
    public List<AssociationTypeRole> Role;

    public FlexibleDatesType StartDate;
  }
}