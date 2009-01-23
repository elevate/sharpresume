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
  [XmlInclude(typeof (MobileTelcomNumberType))]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot(ElementName = "Fax", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class TelcomNumberType
  {
    /// <summary>
    /// Gets or sets the name of the items element.
    /// </summary>
    /// <value>The name of the items element.</value>
    [XmlIgnore]
    [XmlElement(ElementName = "ItemsElementName")]
    public TelcomNumberItemChoiceType[] ItemsElementName { get; set; }

    /// <summary>
    /// Gets or sets the items.
    /// </summary>
    /// <value>The items.</value>
    [XmlChoiceIdentifier("ItemsElementName")]
    [XmlElement(ElementName = "AreaCityCode", Type = typeof (string))]
    [XmlElement(ElementName = "Extension", Type = typeof (string))]
    [XmlElement(ElementName = "FormattedNumber", Type = typeof (string))]
    [XmlElement(ElementName = "InternationalCountryCode", Type = typeof (string))]
    [XmlElement(ElementName = "NationalNumber", Type = typeof (string))]
    [XmlElement(ElementName = "SubscriberNumber", Type = typeof (string))]
    public string[] Items { get; set; }
  }
}