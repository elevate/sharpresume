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
  [XmlType(AnonymousType = true)]
  public class MilitaryHistoryTypeServiceDetail
  {
    [XmlElement("AreaOfExpertise")]
    public List<string> AreaOfExpertise;

    [XmlAttribute]
    public string branch;

    [XmlElement("Campaign")]
    public List<string> Campaign;

    public DatesOfServiceType DatesOfService;

    public string DischargeStatus;

    [XmlElement("DisciplinaryAction")]
    public List<string> DisciplinaryAction;

    public RankAchievedType RankAchieved;

    [XmlElement("RecognitionAchieved")]
    public List<string> RecognitionAchieved;

    public string UnitOrDivision;

    public UserAreaType UserArea;
  }
}