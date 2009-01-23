#region

using System;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public enum AcademicCreditCodeType
  {
    A,

    C,

    G,

    N,

    Q,

    S,

    U,

    V,

    X
  }
}