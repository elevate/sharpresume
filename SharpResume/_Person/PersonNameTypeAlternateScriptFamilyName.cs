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
  public class PersonNameTypeAlternateScriptFamilyName
  {
    [XmlAttribute]
    public string prefix;

    [XmlAttribute]
    public PersonNameTypeAlternateScriptFamilyNamePrimary primary;

    [XmlIgnore]
    public bool primarySpecified;

    [XmlText]
    public string Value;
  }
}