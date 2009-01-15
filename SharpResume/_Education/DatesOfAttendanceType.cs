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
  public class DatesOfAttendanceType
  {
    [XmlAttribute]
    public bool currentlyEnrolled;

    [XmlIgnore]
    public bool currentlyEnrolledSpecified;

    public FlexibleDatesType EndDate;

    [XmlAttribute]
    public string enrollmentStatus;

    public FlexibleDatesType StartDate;

    [XmlAttribute]
    public bool studentInGoodStanding;

    [XmlIgnore]
    public bool studentInGoodStandingSpecified;
  }
}