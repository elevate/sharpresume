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
  public class ConferencePaperType : BasicBibliographicRecordType
  {
    public FlexibleDatesType ConferenceDate;

    public string ConferenceLocation;
    public string EventName;
  }
}