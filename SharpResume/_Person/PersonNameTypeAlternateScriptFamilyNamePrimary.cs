#region

using System;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [XmlType(AnonymousType = true)]
  public enum PersonNameTypeAlternateScriptFamilyNamePrimary
  {
    @true,

    @false,

    undefined
  }
}