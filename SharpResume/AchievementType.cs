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
  [XmlRoot("Achievement", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class AchievementType
  {
    public FlexibleDatesType Date;

    public string Description;

    public string IssuingAuthority;
  }
}