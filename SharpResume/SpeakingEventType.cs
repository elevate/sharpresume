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
  [XmlRoot("SpeakingEvent", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class SpeakingEventType
  {
    [XmlElement("AffiliatedOrganization")]
    public List<string> AffiliatedOrganization;

    public string Description;
    public FlexibleDatesType EndDate;

    public string EventName;

    public string EventType;

    public string Link;
    public string Location;
    public string Role;

    public FlexibleDatesType StartDate;
    public string Title;

    [XmlAttribute]
    public string type;
  }
}