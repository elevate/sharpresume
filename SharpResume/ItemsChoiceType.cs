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
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25, IncludeInSchema = false)]
  public enum ItemsChoiceType
  {
    /// <summary>
    /// 
    /// </summary>
    AreaCityCode,

    /// <summary>
    /// 
    /// </summary>
    Extension,

    /// <summary>
    /// 
    /// </summary>
    FormattedNumber,

    /// <summary>
    /// 
    /// </summary>
    InternationalCountryCode,

    /// <summary>
    /// 
    /// </summary>
    NationalNumber,

    /// <summary>
    /// 
    /// </summary>
    SubscriberNumber
  }
}