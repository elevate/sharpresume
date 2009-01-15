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
  public class StaffingSupportingMaterialsTypeAttachmentReference
  {
    [XmlAttribute]
    public string context;

    [XmlAttribute]
    public string mimeType;

    [XmlText]
    public string Value;
  }
}