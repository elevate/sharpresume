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
  [XmlType(AnonymousType = true)]
  public class CompetencyTypeCompetencyId
  {
    [XmlAttribute]
    public string description;

    [XmlAttribute]
    public string id;

    [XmlAttribute]
    public string IdOwner;
  }
}