// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
using System.Collections.Generic;
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
  public class EmployerOrganizationDataType
  {
    // [XmlRoot( ElementName = "EmployerOrgDataType" )]

    /// <summary>
    /// Gets or sets the name of the employer organization.
    /// </summary>
    /// <value>The name of the employer organization.</value>
    [XmlElement(ElementName = "EmployerOrgName")]
    public string EmployerOrganizationName { get; set; }

    /// <summary>
    /// Gets or sets the employer contact info.
    /// </summary>
    /// <value>The employer contact info.</value>
    [XmlElement(ElementName = "EmployerContactInfo")]
    public EmpContactInfoType EmployerContactInformation { get; set; }

    /// <summary>
    /// Gets or sets the position history.
    /// </summary>
    /// <value>The position history.</value>
    [XmlElement("PositionHistory")]
    public List<EmployerOrgDataTypePositionHistory> PositionHistory { get; set; }

    /// <summary>
    /// Gets or sets the user area.
    /// </summary>
    /// <value>The user area.</value>
    [XmlElement(ElementName = "UserArea")]
    public UserAreaType UserArea { get; set; }

    /// <summary>
    /// Gets or sets the type of the employer organization.
    /// </summary>
    /// <value>The type of the employer organization.</value>
    [XmlAttribute(AttributeName = "EmployerOrgType")]
    public string EmployerOrganizationType { get; set; }
  }
}