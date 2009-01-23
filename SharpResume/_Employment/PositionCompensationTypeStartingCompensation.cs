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
  public class PositionCompensationTypeStartingCompensation
  {
    [XmlAttribute]
    public string currency;

    [XmlAttribute]
    public string intervalType;

    [XmlAttribute]
    public string validFrom;

    [XmlAttribute]
    public string validTo;

    [XmlText]
    public string Value;
  }
}