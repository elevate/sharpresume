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
  public class PatentDescriptionType
  {
    public string Description;

    [XmlArrayItem("InventorName", IsNullable = false)]
    public List<string> Inventors;

    public string Link;

    [XmlElement("PatentDetail")]
    public List<PatentDescriptionTypePatentDetail> PatentDetail;

    public string PatentTitle;
  }
}