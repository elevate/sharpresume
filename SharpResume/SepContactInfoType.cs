#region

using System;
using System.Collections.Generic;
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
  [XmlRoot(ElementName = "SEPContactInfoType")]
  public class SepContactInfoType
  {
    /// <summary>
    /// Gets or sets the name of the person.
    /// </summary>
    /// <value>The name of the person.</value>
    [XmlElement(ElementName = "PersonName", Order = 0)]
    public PersonNameType PersonName { get; set; }

    /// <summary>
    /// Gets or sets the contact method.
    /// </summary>
    /// <value>The contact method.</value>
    [XmlElement(ElementName = "ContactMethod", Order = 1)]
    public List<ContactMethodType> ContactMethod { get; set; }
  }
}