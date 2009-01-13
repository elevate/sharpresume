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
  [XmlType(AnonymousType = true)]
  public class PostalAddressTypeRecipient
  {
    [XmlElement("AdditionalText")]
    public List<string> AdditionalText;

    public string Organization;

    public string OrganizationName;
    public PersonNameType PersonName;
  }
}