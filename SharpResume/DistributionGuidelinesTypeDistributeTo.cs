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
  public class DistributionGuidelinesTypeDistributeTo : DistributionType
  {
    [XmlElement("ContactMethod")]
    public List<ContactMethodType> ContactMethod;
  }
}