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
  public class EmpContactInfoType
  {
    [XmlElement("ContactMethod")]
    public List<ContactMethodType> ContactMethod;

    [XmlAttribute]
    public string contactType;

    [XmlElement("InternetDomainName")]
    public List<InternetDomainNameType> InternetDomainName;

    public EmploymentLocationSummaryType LocationSummary;
    public PersonNameType PersonName;
  }
}