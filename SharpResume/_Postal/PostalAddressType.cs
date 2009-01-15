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
  [XmlRoot(ElementName = "PostalAddress", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class PostalAddressType
  {
    public string CountryCode;

    public PostalAddressTypeDeliveryAddress DeliveryAddress;
    public string Municipality;
    public string PostalCode;

    [XmlElement("Recipient")]
    public List<PostalAddressTypeRecipient> Recipient;

    [XmlElement("Region")]
    public List<string> Region;

    [XmlAttribute]
    public PostalAddressTypeType type;

    [XmlIgnore]
    public bool typeSpecified;
  }
}