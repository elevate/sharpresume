#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot(ElementName = "PublicationHistory", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class PublicationHistoryType
  {
    [XmlElement("Article")]
    public List<ArticleType> Article;

    [XmlElement("Book")]
    public List<BookType> Book;

    [XmlElement("ConferencePaper")]
    public List<ConferencePaperType> ConferencePaper;

    [XmlElement("FormattedPublicationDescription")]
    public List<PublicationHistoryTypeFormattedPublicationDescription> FormattedPublicationDescription;

    [XmlElement("OtherPublication")]
    public List<OtherPublicationType> OtherPublication;
  }
}