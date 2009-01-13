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
  public class PositionOrgNameType
  {
    public string OrganizationName;

    [XmlAttribute]
    public string organizationType;

    public PositionOrgNameType OrgName;
  }
}