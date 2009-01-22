// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// International Standard Classification of Education (ISCED) classification codes.
  /// </summary>
  /// <seealso cref="http://www.uis.unesco.org/TEMPLATE/pdf/isced/ISCED_A.pdf"/>
  [Serializable]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public enum InternationalStandardClassificationOfEducationClassificationType
  {
    /// <summary>Pre-primary education.</summary>
    [XmlEnum("0")]
    Item0,
    /// <summary>Primary education or first stage of basic education.</summary>
    [XmlEnum("1")]
    Item1,
    /// <summary>Lower secondary or second stage of basic education.</summary>
    [XmlEnum("2")]
    Item2,
    /// <summary>(Upper) secondary education.</summary>
    [XmlEnum("3")]
    Item3,
    /// <summary>Post-secondary non-tertiary education.</summary>
    [XmlEnum("4")]
    Item4,
    /// <summary>First stage of tertiary education.</summary>
    [XmlEnum("5")]
    Item5,
    /// <summary>Second stage of tertiary education</summary>
    [XmlEnum("6")]
    Item6
  }
}