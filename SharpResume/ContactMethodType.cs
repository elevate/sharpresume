// <license>
// © 2009, Business Decisions, Inc.
// All Rights Reserved.
// </license>

#region

using System;
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
  public class ContactMethodType
  {
    public TelcomNumberType Fax;

    public string InternetEmailAddress;

    public string InternetWebAddress;
    public string Location;
    public MobileTelcomNumberType Mobile;
    public TelcomNumberType Pager;

    public PostalAddressType PostalAddress;
    public TelcomNumberType Telephone;
    public TelcomNumberType TTYTDD;
    public string Use;
    public string WhenAvailable;
  }
}