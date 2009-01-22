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
  public class CompetencyTypeCompetencyWeight
  {
    [XmlElement("NumericValue", typeof (NumericValueType))]
    [XmlElement("StringValue", typeof (StringValue))]
    public object Item;

    [XmlElement("SupportingInformation")]
    public List<string> SupportingInformation;

    [XmlAttribute]
    public string type;
  }
}