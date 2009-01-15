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
  [XmlRoot("NonXMLResume", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class NonXmlResumeType
  {
    public string Comments;
    public string LinkToResume;

    public string RevisionDate;

    [XmlElement("SupportingMaterials")]
    public List<StaffingSupportingMaterialsType> SupportingMaterials;

    public string TextResume;
  }
}