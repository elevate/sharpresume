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
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  [XmlRoot("CompetencyId", Namespace = XmlNamespaces.HRXmlNamespace25, IsNullable = false)]
  public class EntityIdType : SharpResumeObject<EntityIdType>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityIdType"/> class.
    /// </summary>
    public EntityIdType()
    {
      this.IdValue = new List<EntityIdTypeIdValue>();
    }

    /// <summary>
    /// Gets or sets the id value.
    /// </summary>
    /// <value>The id value.</value>
    [XmlElement(ElementName = "IdValue")]
    public List<EntityIdTypeIdValue> IdValue { get; set; }

    /// <summary>
    /// Gets or sets the valid from.
    /// </summary>
    /// <value>The valid from.</value>
    [XmlAttribute(AttributeName = "validFrom")]
    public string ValidFrom { get; set; }

    /// <summary>
    /// Gets or sets the valid to.
    /// </summary>
    /// <value>The valid to.</value>
    [XmlAttribute(AttributeName = "validTo")]
    public string ValidTo { get; set; }

    /// <summary>
    /// Gets or sets the id owner.
    /// </summary>
    /// <value>The id owner.</value>
    [XmlAttribute(AttributeName = "idOwner")]
    public string IdOwner { get; set; }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// true if the current object is equal to the other parameter; otherwise, false.
    /// </returns>
    public override bool Equals(EntityIdType other)
    {
      //HACK: bad equality evaluation.
      //TODO: implement correct validation comparison
      if (other == null)
      {
        return false;
      }
      return true;
    }
  }
}