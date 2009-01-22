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
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class Association : AssociationType
  {
    [XmlAttribute]
    public string type;
  }
}