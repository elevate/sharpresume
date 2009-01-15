#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [XmlInclude(typeof (OtherPublicationType))]
  [XmlInclude(typeof (ConferencePaperType))]
  [XmlInclude(typeof (BookType))]
  [XmlInclude(typeof (ArticleType))]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class BasicBibliographicRecordType
  {
    public string Abstract;

    public string Comments;
    public CopyrightType Copyright;

    [XmlElement("Link")]
    public List<string> Link;

    [XmlElement("Name")]
    public List<BasicBibliographicRecordTypeName> Name;

    public FlexibleDatesType PublicationDate;
    public string Title;
  }
}