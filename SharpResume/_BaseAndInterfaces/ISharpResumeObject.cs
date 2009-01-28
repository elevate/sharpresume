using System;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// Common interface that will be applied to all objects participating in the HR-Xml API.
  /// </summary>
  public interface ISharpResumeObject
  {
    /// <summary>
    /// Gets the parent.
    /// </summary>
    /// <value>The parent.</value>
    ISharpResumeObject Parent { get; }

    /// <summary>
    /// Gets a value indicating whether this instance has parent.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance has parent; otherwise, <c>false</c>.
    /// </value>
    bool HasParent { get; }

    ///// <summary>
    ///// Gets the serializer namespaces.
    ///// 
    ///// Provides the xmlns and xmlns:xsi attribute values.
    ///// </summary>
    ///// <value>The serializer namespaces.</value>
    //XmlSerializerNamespaces SerializerNamespaces { get; }
  }
}