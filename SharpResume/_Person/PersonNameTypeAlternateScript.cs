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
  [XmlType(AnonymousType = true)]
  public class PersonNameTypeAlternateScript
  {
    [XmlElement("Affix")]
    public List<PersonNameTypeAlternateScriptAffix> Affix;

    [XmlElement("FamilyName")]
    public List<PersonNameTypeAlternateScriptFamilyName> FamilyName;

    public string FormattedName;

    [XmlElement("GivenName")]
    public List<string> GivenName;

    public string LegalName;

    public string MiddleName;
    public string PreferredGivenName;

    [XmlAttribute]
    public string script;
  }
}