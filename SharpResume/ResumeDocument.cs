#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(AnonymousType = true)]
  [XmlRoot(ElementName = "Resume", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class ResumeDocument : SharpResumeDocumentObject<ResumeDocument>
  {
    /// <summary>
    /// Gets or sets the resume id.
    /// </summary>
    /// <value>The resume id.</value>
    [XmlElement(ElementName = "ResumeId")]
    public EntityIdType ResumeId { get; set; }

    /// <summary>
    /// Gets or sets the distribution guidelines.
    /// </summary>
    /// <value>The distribution guidelines.</value>
    [XmlElement(ElementName = "DistributionGuidelines")]
    public List<DistributionGuidelinesNode> DistributionGuidelines { get; set; }

    /// <summary>
    /// Gets or sets the structured XML resume.
    /// </summary>
    /// <value>The structured XML resume.</value>
    [XmlElement(ElementName = "StructuredXMLResume")]
    public List<StructuredXmlResumeType> StructuredXmlResume { get; set; }

    /// <summary>
    /// Gets or sets the non XML resume.
    /// </summary>
    /// <value>The non XML resume.</value>
    [XmlElement(ElementName = "NonXMLResume")]
    public NonXmlResumeType NonXmlResume { get; set; }

    /// <summary>
    /// Gets or sets the user area.
    /// </summary>
    /// <value>The user area.</value>
    [XmlElement(ElementName = "UserArea")]
    public UserAreaType UserArea { get; set; }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// true if the current object is equal to the other parameter; otherwise, false.
    /// </returns>
    public override bool Equals(ResumeDocument other)
    {
      //Debugger.Break();
      //log.Trace(other);
      //HACK: ugly, not good equality comparison. bad.
      if (other == null)
      {
        return false;
      }
      if (this.ResumeId == null && other.ResumeId == null)
      {
        return true;
      }
      if (this.ResumeId == null && other.ResumeId != null)
      {
        return false;
      }
      if (this.ResumeId != null && other.ResumeId == null)
      {
        return false;
      }
      if (this.ResumeId != null && other.ResumeId != null)
      {
        if (this.ResumeId.IdValue == null && other.ResumeId.IdValue == null)
        {
          return true;
        }
        if (this.ResumeId.IdValue == null && other.ResumeId.IdValue != null)
        {
          return false;
        }
        if (this.ResumeId.IdValue != null && other.ResumeId.IdValue == null)
        {
          return false;
        }
        if (this.ResumeId.IdValue != null && other.ResumeId.IdValue != null)
        {
          if (this.ResumeId.IdValue.Count != other.ResumeId.IdValue.Count)
          {
            return false;
          }
          for (var i = 0; i < this.ResumeId.IdValue.Count; ++i)
          {
            if (0 ==
                string.Compare(this.ResumeId.IdValue[i].Value, other.ResumeId.IdValue[i].Value, false,
                               CultureInfo.CurrentCulture))
            {
              return false;
            }
          }
        }
      }
      return true;
    }
  }

  ///// <summary>
  ///// Represents a HR-Xml 2.5 compliant Resume document.
  ///// </summary>
  //[Serializable]
  //[DebuggerStepThrough]
  //[DesignerCategory( StringHelper.SharpResumeCorrectSpelling )]
  //[XmlRoot( ElementName="Resume", Namespace = HRXmlNamespaces25.XmlNamespace, IsNullable=false )]
  //public class ResumeDocument : SharpResumeObject< ResumeDocument >
  //{
  //    private EntityIdType _resumeId = null;
  //    private StructuredXmlResumeType _structuredXmlResume = null;

  //    /// <summary>
  //    /// Initializes a new instance of the <see cref="ResumeDocument"/> class.
  //    /// </summary>
  //    public ResumeDocument() : this( null )
  //    {
  //    }

  //    /// <summary>
  //    /// Initializes a new instance of the <see cref="ResumeDocument"/> class.
  //    /// </summary>
  //    /// <param name="parent">The parent.</param>
  //    public ResumeDocument( ISharpResumeObject parent ) : base( parent )
  //    {
  //        _resumeId = new EntityIdType( this );
  //        _structuredXmlResume = new StructuredXmlResumeType();
  //    }

  //    /// <summary>
  //    /// Gets or sets the resume id.
  //    /// </summary>
  //    /// <value>The resume id.</value>
  //    [XmlElement( ElementName="ResumeId", Type=typeof ( EntityIdType ) )]
  //    public EntityIdType ResumeId
  //    {
  //        get { return _resumeId; }
  //        set
  //        {
  //            if ( _resumeId == null )
  //            {
  //                _resumeId = value;
  //            }
  //        }
  //    }

  //    /// <summary>
  //    /// Gets the xsi schema location.
  //    /// </summary>
  //    /// <value>The xsi schema location.</value>
  //    public override string XsiSchemaLocation
  //    {
  //        get { return HRXmlNamespaces25.ResumeSchemaLocation; }
  //    }

  //    /// <summary>
  //    /// Gets or sets the structured XML resume.
  //    /// </summary>
  //    /// <value>The structured XML resume.</value>
  //    [XmlElement( ElementName = "StructuredXmlResume", Type = typeof ( StructuredXmlResumeType ) )]
  //    public StructuredXmlResumeType StructuredXmlResume
  //    {
  //        get { return _structuredXmlResume; }
  //        set
  //        {
  //            if ( _structuredXmlResume == null )
  //            {
  //                _structuredXmlResume = value;
  //            }
  //        }
  //    }

  //    /// <summary>
  //    /// Indicates whether the current object is equal to another object of the same type.
  //    /// </summary>
  //    /// <param name="other">An object to compare with this object.</param>
  //    /// <returns>
  //    /// true if the current object is equal to the other parameter; otherwise, false.
  //    /// </returns>
  //    public override bool Equals( ResumeDocument other )
  //    {
  //        if ( other == null )
  //        {
  //            return false;
  //        }
  //        return true;
  //    }

  //    /// <summary>
  //    /// Serves as a hash function for a particular type.
  //    /// </summary>
  //    /// <returns>
  //    /// A hash code for the current <see cref="T:System.Object"/>.
  //    /// </returns>
  //    /// <filterPriority>2</filterPriority>
  //    public override int GetHashCode()
  //    {
  //        return base.GetHashCode() ^ ResumeId.GetHashCode();
  //    }
  //}
}