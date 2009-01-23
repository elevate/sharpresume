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
  [XmlRoot(ElementName = "PersonName", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class PersonNameType
  {
    [XmlAttribute]
    private string _script;

    [XmlElement("AlternateScript")]
    public List<PersonNameTypeAlternateScript> AlternateScript { get; set; }

    [XmlElement("Affix")]
    public List<PersonNameTypeAffix> Affix { get; set; }

    [XmlElement("FamilyName")]
    public List<PersonNameTypeFamilyName> FamilyName { get; set; }

    public string MiddleName { get; set; }

    public string Script { get { return this._script; } set { this._script = value; } }

    public string PreferredGivenName { get; set; }

    [XmlElement("GivenName")]
    public List<string> GivenName { get; set; }

    public string FormattedName { get; set; }

    public string LegalName { get; set; }
  }
}