using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Just3Ws.SharpResume
{
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
  [XmlType(Namespace = XmlNamespaces.HRXmlNamespace25)]
  public class OccupationalCategoryType
  {
    public string CategoryCode;

    public string CategoryDescription;

    public string Comments;

    public OccupationalCategoryType JobCategory;
    public OccupationalCategoryTypeTaxonomyName TaxonomyName;
  }
}