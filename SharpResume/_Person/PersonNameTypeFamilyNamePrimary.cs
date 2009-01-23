#region

using System;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(AnonymousType = true)]
  public enum PersonNameTypeFamilyNamePrimary
  {
    @true,

    @false,

    undefined
  }
}