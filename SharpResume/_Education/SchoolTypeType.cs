using System;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public enum SchoolTypeType
  {
    current,

    prior,

    joint,

    degree
  }
}