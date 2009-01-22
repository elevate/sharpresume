// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  public abstract class BaseSharpResumeDocumentObject<T> : BaseSharpResumeObject<T> where T : ISharpResumeObject

  {
    [NonSerialized]
    private XmlSerializerNamespaces _serializerNamespaces;

    /// <summary>
    /// If you overwrite the XmlLanguage and the application won't validate, then you have nobody to blame but yourself.  For some reason it won't write the attribute if it's a property or read-only.
    /// </summary>
    [XmlAttribute("xml:lang")]
    public string XmlLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToUpperInvariant();

    /// <summary>
    /// If you overwrite the XsiSchemaLocation and the application won't validate, then you have nobody to blame but yourself.  For some reason it won't write the attribute if it's a property or read-only.
    /// </summary>
    [XmlAttribute(AttributeName = "schemaLocation", Namespace = XmlNamespaces.XmlSchemaInstance)]
    public string XsiSchemLocation = XmlNamespaces.HRXmlResumeSchemaLocation25;

    /// <summary>
    /// Gets the serializer namespaces.
    /// 
    /// Provides the xmlns and xmlns:xsi attribute values.
    /// </summary>
    /// <value>The serializer namespaces.</value>
    [XmlNamespaceDeclarations]
    public XmlSerializerNamespaces SerializerNamespaces
    {
      get
      {
        if (this._serializerNamespaces == null)
        {
          this._serializerNamespaces = new XmlSerializerNamespaces();
          this._serializerNamespaces.Add("xsi", XmlSchema.InstanceNamespace);
          //unfortunately, we can't add the xsi:schemaLocation here, it has to be done in a with an attribute and field, unless someone knows a better way.
        }
        return this._serializerNamespaces;
      }
    }
  }
}