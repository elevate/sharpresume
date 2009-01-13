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
  [XmlRoot(ElementName = "MilitaryHistory", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class MilitaryHistoryType
  {
    public string Comments;
    public string CountryServed;

    [XmlElement("ServiceDetail")]
    public List<MilitaryHistoryTypeServiceDetail> ServiceDetail;

    public EntityIdType ServiceNumber;

    public string ServiceStatus;

    public UserAreaType UserArea;
  }
}