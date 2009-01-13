using System;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25, IncludeInSchema = false)]
  public enum ItemChoiceType
  {
    AnyDate,

    MonthDay,

    StringDate,

    Year,

    YearMonth
  }
}