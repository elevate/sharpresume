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
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot("ResumeAdditionalItem", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class AdditionalItemType
  {
    [XmlElement("Description")]
    public List<string> Description;

    public AdditionalItemTypeEffectiveDate EffectiveDate;

    [XmlAttribute]
    public string type;
  }
}