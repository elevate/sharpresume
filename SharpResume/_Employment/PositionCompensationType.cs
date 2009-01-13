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
  public class PositionCompensationType
  {
    public string Comments;
    public PositionCompensationTypeEndingCompensation EndingCompensation;

    [XmlElement("OtherCompensation")]
    public List<PositionCompensationTypeOtherCompensation> OtherCompensation;

    public PositionCompensationTypeStartingCompensation StartingCompensation;
  }
}