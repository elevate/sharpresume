// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class PositionOrgInfoType
  {
    /// <summary>
    /// Gets or sets the website.
    /// </summary>
    /// <value>The website.</value>
    [XmlElement(ElementName = "WebSite")]
    public string Website { get; set; }

    /// <summary>
    /// Gets or sets the position location.
    /// </summary>
    /// <value>The position location.</value>
    public PostalAddressType PositionLocation { get; set; }

    /// <summary>
    /// Gets or sets the location summary.
    /// </summary>
    /// <value>The location summary.</value>
    public EmploymentLocationSummaryType LocationSummary { get; set; }
  }
}