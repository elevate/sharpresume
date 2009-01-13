using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot("LicenseOrCertification", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class CredentialType
  {
    public string Description;

    public CredentialTypeEffectiveDate EffectiveDate;
    public string Id;

    public IssuingAuthorityType IssuingAuthority;
    public string Name;
  }
}