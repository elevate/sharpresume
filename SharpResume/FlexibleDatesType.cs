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
    /// <summary>
    /// Gets or sets the date description.
    /// </summary>
    /// <value>The date description.</value>
    [XmlAttribute(AttributeName = "dateDescription")]
    public string DateDescription { get; set; }

    /// <summary>
    /// Gets or sets the item.
    /// </summary>
    /// <value>The item.</value>
    [XmlChoiceIdentifier("ItemElementName")]
    [XmlElement("AnyDate", typeof (string))]
    [XmlElement("MonthDay", typeof (string), DataType = "gMonthDay")]
    [XmlElement("StringDate", typeof (string))]
    [XmlElement("Year", typeof (string), DataType = "gYear")]
    [XmlElement("YearMonth", typeof (string), DataType = "gYearMonth")]
    public string Item { get; set; }

    /// <summary>
    /// Gets or sets the name of the item element.
    /// </summary>
    /// <value>The name of the item element.</value>
    [XmlIgnore]
    public YearMonthItemChoiceType ItemElementName { get; set; }
  }
}