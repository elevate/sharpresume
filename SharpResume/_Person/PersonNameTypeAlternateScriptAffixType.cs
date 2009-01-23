#region

using System;
using System.Xml.Serialization;

#endregion

namespace Just3Ws.SharpResume
{
  [Serializable]
  [XmlType(AnonymousType = true)]
  public enum PersonNameTypeAlternateScriptAffixType
  {
    aristocraticTitle,

    formOfAddress,

    generation,

    qualification
  }
}