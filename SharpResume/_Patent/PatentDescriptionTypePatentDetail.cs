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
  [XmlType(AnonymousType = true)]
  public class PatentDescriptionTypePatentDetail
  {
    public PatentDescriptionTypePatentDetailIssuingAuthority IssuingAuthority;

    [XmlElement("PatentMilestone")]
    public List<PatentDescriptionTypePatentDetailPatentMilestone> PatentMilestone;
  }
}