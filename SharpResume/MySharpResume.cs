//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Xml;
//using System.Xml.Serialization;

//namespace Just3Ws.SharpResume
//{
//  /// <summary>
//  /// 
//  /// </summary>
//  [Serializable]
//  [DebuggerStepThrough]
//  [DesignerCategory(StringHelper.SharpResumeCorrectSpelling)]
//  public class MySharpResume
//  {
//    private readonly ResumeDocument _resume;

//    /// <summary>
//    /// Initializes a new instance of the <see cref="MySharpResume"/> class.
//    /// </summary>
//    public MySharpResume()
//    {
//      _resume = new ResumeDocument();
//    }

//    /// <summary>
//    /// Gets or sets the name.
//    /// </summary>
//    /// <value>The name.</value>
//    public string Name { get { return _resume.StructuredXmlResume.ContactInfo.PersonName.FormattedName; } set { _resume.StructuredXmlResume.ContactInfo.PersonName.FormattedName = value; } }

//    /// <summary>
//    /// Gets the employment history.
//    /// </summary>
//    /// <value>The employment history.</value>
//    public List<EmployerOrganizationDataType> EmploymentHistory { get { return _resume.StructuredXmlResume.EmploymentHistory; } }

//    /// <summary>
//    /// Gets or sets the objective.
//    /// </summary>
//    /// <value>The objective.</value>
//    public string Objective { get { return _resume.StructuredXmlResume.Objective; } set { _resume.StructuredXmlResume.Objective = value; } }

//    /// <summary>
//    /// Saves the specified output file name.
//    /// </summary>
//    /// <param name="outputFileName">Name of the output file.</param>
//    public void Save(string outputFileName)
//    {
//      var serializer = new XmlSerializer(typeof (ResumeDocument));
//      XmlWriter writer = XmlWriter.Create(outputFileName);
//      serializer.Serialize(writer, _resume);
//      writer.Flush();
//      writer.Close();
//    }
//  }
//}