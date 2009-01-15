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
  public class Language
  {
    public string Comments;

    [XmlElement(DataType = "language")]
    public string LanguageCode;

    public bool Read;

    [XmlIgnore]
    public bool ReadSpecified;

    public bool Speak;

    [XmlIgnore]
    public bool SpeakSpecified;

    public bool Write;

    [XmlIgnore]
    public bool WriteSpecified;
  }
}