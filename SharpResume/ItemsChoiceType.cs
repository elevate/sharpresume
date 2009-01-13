using System;
using System.Xml.Serialization;

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