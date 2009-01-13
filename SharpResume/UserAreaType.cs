using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
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
  [XmlRoot(ElementName = "UserArea", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class UserAreaType
  {
    /// <summary>
    /// Gets or sets any.
    /// </summary>
    /// <value>Any.</value>
    [XmlAnyElement]
    public List<XmlElement> Any { get; set; }
  }
}