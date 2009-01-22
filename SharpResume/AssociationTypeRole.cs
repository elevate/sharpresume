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