#region

using System;
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
  public class FlexibleDatesType
  {
    [XmlAttribute]
    public string dateDescription;

    //[XmlElement("AnyDate", typeof (string))]
    //[XmlElement("MonthDay", typeof (string), DataType = "gMonthDay")]
    //[XmlElement("StringDate", typeof (string))]
    //[XmlElement("Year", typeof (string), DataType = "gYear")]
    //[XmlElement("YearMonth", typeof (string), DataType = "gYearMonth")]
    //[XmlChoiceIdentifier("ItemElementName")]
    [XmlIgnore]
    public string Item;

    [XmlIgnore]
    public ItemChoiceType ItemElementName;
  }
}