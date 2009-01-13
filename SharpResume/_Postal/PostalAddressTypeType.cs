using System;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [XmlType(AnonymousType = true)]
  public enum PostalAddressTypeType
  {
    postOfficeBoxAddress,

    streetAddress,

    militaryAddress,

    undefined
  }
}