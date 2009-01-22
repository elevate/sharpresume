// <license>
// � 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

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
  public enum CourseLevelCodeType
  {
    [XmlEnum("1")]
    Item1,

    [XmlEnum("2")]
    Item2,

    [XmlEnum("3")]
    Item3,

    [XmlEnum("4")]
    Item4,

    [XmlEnum("5")]
    Item5,

    [XmlEnum("6")]
    Item6,

    [XmlEnum("7")]
    Item7,

    [XmlEnum("8")]
    Item8,

    [XmlEnum("9")]
    Item9,

    [XmlEnum("10")]
    Item10,

    [XmlEnum("11")]
    Item11,

    [XmlEnum("12")]
    Item12,

    [XmlEnum("13")]
    Item13,

    [XmlEnum("14")]
    Item14,

    [XmlEnum("15")]
    Item15,

    [XmlEnum("16")]
    Item16,

    [XmlEnum("17")]
    Item17,

    [XmlEnum("18")]
    Item18,

    [XmlEnum("19")]
    Item19,

    A,

    AR,

    B,

    D,

    DL,

    E,

    F,

    G,

    H,

    I,

    L,

    M,

    P,

    R,

    T,

    U,

    V
  }
}