using System;
using System.Collections.Generic;
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
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class SchoolDataType
  {
    [XmlElement("InternetDomainName")]
    public List<InternetDomainNameType> InternetDomainName;

    [XmlElement("SchoolId")]
    public List<EntityIdType> SchoolId;

    public string SchoolName;

    [XmlAttribute]
    public SchoolTypeType type;

    [XmlIgnore]
    public bool typeSpecified;
  }
}