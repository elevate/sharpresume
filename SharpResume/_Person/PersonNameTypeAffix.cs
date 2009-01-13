using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(AnonymousType = true)]
  public class PersonNameTypeAffix
  {
    [XmlAttribute]
    public PersonNameTypeAffixType type;

    [XmlText]
    public string Value;
  }
}