using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot("Reference", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class ReferenceType
  {
    public string Comments;

    [XmlElement("ContactMethod")]
    public List<ContactMethodType> ContactMethod;

    public PersonNameType PersonName;

    public string PositionTitle;

    [XmlAttribute]
    public string type;
  }
}