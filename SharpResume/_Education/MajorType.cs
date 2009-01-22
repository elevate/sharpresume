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
  public class MajorType
  {
    [XmlElement("DegreeConcentration")]
    public List<string> DegreeConcentration;

    [XmlElement("Name")]
    public List<string> Name;

    [XmlElement("Option")]
    public List<string> Option;

    [XmlElement("ProgramId")]
    public List<EntityIdType> ProgramId;
  }
}