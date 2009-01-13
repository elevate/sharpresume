using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(AnonymousType = true)]
  public class PersonNameTypeFamilyName
  {
    [XmlAttribute]
    public string prefix;

    [XmlAttribute]
    public PersonNameTypeFamilyNamePrimary primary;

    [XmlIgnore]
    public bool primarySpecified;

    [XmlText]
    public string Value;
  }
}