using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class DistributionGuidelinesType
  {
    [XmlElement("DistributeTo")]
    public List<DistributionGuidelinesTypeDistributeTo> DistributeTo;

    [XmlElement("DoNotDistributeTo")]
    public List<DistributionType> DoNotDistributeTo;
  }
}