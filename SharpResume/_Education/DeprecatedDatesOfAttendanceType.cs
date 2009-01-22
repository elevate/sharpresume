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
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class DeprecatedDatesOfAttendanceType
  {
    [XmlAttribute]
    public bool currentlyEnrolled;

    [XmlIgnore]
    public bool currentlyEnrolledSpecified;

    [XmlElement("EndDate")]
    public List<FlexibleDatesType> EndDate;

    [XmlAttribute]
    public string enrollmentStatus;

    [XmlElement("StartDate")]
    public List<FlexibleDatesType> StartDate;

    [XmlAttribute]
    public bool studentInGoodStanding;

    [XmlIgnore]
    public bool studentInGoodStandingSpecified;
  }
}