using System;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [XmlType(AnonymousType = true)]
  public enum SchoolOrInstitutionTypeOrganizationUnitAttendanceStatus
  {
    current,

    prior,

    unknown
  }
}