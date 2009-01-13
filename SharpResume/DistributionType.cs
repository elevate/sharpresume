using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class DistributionType
  {
    public EntityIdType Id;

    public string Name;

    [XmlAttribute]
    public string validFrom;

    [XmlAttribute]
    public string validTo;
  }
}