#region

using System;
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
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class DistributionGuidelinesNode
  {
    [XmlElement("DistributeTo")]
    public DistributionGuidelinesTypeDistributeTo DistributeTo;

    [XmlElement("DoNotDistributeTo")]
    public DistributionNode DoNotDistributeTo;
  }
}