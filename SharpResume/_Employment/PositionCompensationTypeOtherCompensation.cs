// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
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
  public class PositionCompensationTypeOtherCompensation
  {
    [XmlAttribute]
    public string type;

    [XmlAttribute]
    public string validFrom;

    [XmlAttribute]
    public string validTo;

    [XmlText]
    public string Value;
  }
}