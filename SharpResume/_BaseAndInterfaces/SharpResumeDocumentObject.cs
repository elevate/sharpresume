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
  public abstract class SharpResumeDocumentObject<T> : SharpResumeObject<T> where T : ISharpResumeObject

  {
    [NonSerialized]
    private XmlSerializerNamespaces serializerNamespaces;

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
        if (this.serializerNamespaces == null)
        {
          this.serializerNamespaces = new XmlSerializerNamespaces();
          this.serializerNamespaces.Add("xsi", XmlSchema.InstanceNamespace);
          //unfortunately, we can't add the xsi:schemaLocation here, it has to be done in a with an attribute and field, unless someone knows a better way.
        }
        return this.serializerNamespaces;
      }
    }
  }
}