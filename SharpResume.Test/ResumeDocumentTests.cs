using System;
using System.IO;
using System.Xml;
using NLog;
using NUnit.Framework;

namespace Just3Ws.SharpResume.Test
{
  [TestFixture]
  public class ResumeDocumentTests : SerializationTestHelper<ResumeDocument>
  {
    public static readonly Logger logger = LogManager.GetCurrentClassLogger();

    [Test]
    public void TestLoadResumeExample()
    {
      logger.Trace(string.Empty);
      try
      {
        string serializedFileName = string.Format("SerializedResumeExample {0}.xml",
                                                  DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));
          //dateformat 2007-May-21-123059
        logger.Trace("Using temporary serialized object in file \"{0}\".", serializedFileName);
        Assert.IsTrue(File.Exists("ResumeExample.xml"));
        ResumeDocument resumeDocument1 = DeserializeXmlObject(XmlReader.Create("ResumeExample.xml"));
        Assert.IsNotNull(resumeDocument1, "The deserialized object is null.");
        string serializedResume1 = SerializeXmlObject(resumeDocument1);
        if (File.Exists(serializedFileName))
        {
          File.Delete(serializedFileName);
        }
        StreamWriter newFile = File.CreateText(serializedFileName);
        newFile.AutoFlush = true;
        newFile.Write(serializedResume1);
        newFile.Close();
      }
      catch (Exception ex)
      {
        logger.TraceException("Exception in TestLoadResumeExample test.", ex);
        throw;
      }
    }

    /// <summary>
    /// Tests the resume document XML serializer.
    /// </summary>
    [Test]
    public void TestResumeDocumentXmlSerializer()
    {
      logger.Trace(string.Empty);
      //deflate
      var resumeDocument1 = new ResumeDocument();
      Assert.IsNotNull(resumeDocument1, "The ResumeDocument is null.");
      Assert.IsNull(((ISharpResumeObject) resumeDocument1).Parent, "The ResumeDocument.Parent is not null.");
      resumeDocument1.ResumeId = new EntityIdType();
      //resumeDocument1.ResumeId.IdValue = new EntityIdTypeIdValue[1];
      resumeDocument1.ResumeId.IdValue.Add(new EntityIdTypeIdValue());
      resumeDocument1.ResumeId.IdValue[0] = new EntityIdTypeIdValue();
      resumeDocument1.ResumeId.IdValue[0].Value = "123";
      //resumeDocument1.StructuredXmlResume.Objective = "To rule the world.";
      string serializedResume1 = SerializeXmlObject(resumeDocument1);
      Assert.IsNotEmpty(serializedResume1, "The serialized ResumeDocument is empty.");
      Console.Out.WriteLine(serializedResume1);

      //inflate
      ResumeDocument resumeDocument2 = DeserializeXmlObject(serializedResume1);
      Assert.IsNotNull(resumeDocument2, "The ResumeDocument is null.");
      Assert.IsNull(((ISharpResumeObject) resumeDocument2).Parent, "The ResumeDocument.Parent is not null.");
      resumeDocument2.ResumeId = new EntityIdType();
      //resumeDocument2.ResumeId.IdValue = new EntityIdTypeIdValue[1];
      resumeDocument2.ResumeId.IdValue.Add(new EntityIdTypeIdValue());
      resumeDocument2.ResumeId.IdValue[0] = new EntityIdTypeIdValue();
      resumeDocument2.ResumeId.IdValue[0].Value = "123";

      //deflate
      string serializedResume2 = SerializeXmlObject(resumeDocument2);

      Assert.IsNotEmpty(serializedResume2, "The serialized resume is empty.");
      Console.Out.WriteLine(serializedResume2);

      Assert.IsTrue(0 == string.Compare(serializedResume1, serializedResume2, false),
                    "The serialized-deserialized-serialized results varied.");
      Assert.AreEqual(resumeDocument1, resumeDocument2, "The serialized-deserialized object comparison results varied.");
    }
  }
}