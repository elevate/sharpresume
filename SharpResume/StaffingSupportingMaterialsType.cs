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
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class StaffingSupportingMaterialsType
  {
    public string Description;

    [XmlElement("AttachmentReference", typeof (StaffingSupportingMaterialsTypeAttachmentReference))]
    [XmlElement("Link", typeof (string))]
    public object Item;
  }
}