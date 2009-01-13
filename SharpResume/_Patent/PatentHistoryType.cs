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
  [XmlRoot(ElementName = "PatentHistory", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class PatentHistoryType
  {
    [XmlElement("Patent")]
    public List<PatentDescriptionType> Patent;
  }
}