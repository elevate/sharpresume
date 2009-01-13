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
  public class PostalAddressTypeDeliveryAddress
  {
    [XmlElement("AddressLine")]
    public List<string> AddressLine;

    public string BuildingNumber;

    public string PostOfficeBox;
    public string StreetName;
    public string Unit;
  }
}