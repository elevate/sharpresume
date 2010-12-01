#region

using System;
using System.IO;
using System.Xml;
using NUnit.Framework;

#endregion

namespace Just3Ws.SharpResume.Test
{
  [TestFixture]
  public class ResumeDocumentTests : SerializationTestHelper<ResumeDocument>
  {
    public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [Test]
    public void TestLoadResumeExample()
    {
      logger.Info(string.Empty);
      try
      {
        var serializedFileName = string.Format("SerializedResumeExample {0}.xml",
                                               DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"));
        //dateformat 2007-May-21-123059
        logger.InfoFormat("Using temporary serialized object in file \"{0}\".", serializedFileName);
        Assert.IsTrue(File.Exists("ResumeExample.xml"));
        var resumeDocument1 = this.DeserializeXmlObject(XmlReader.Create("ResumeExample.xml"));
        Assert.IsNotNull(resumeDocument1, "The deserialized object is null.");
        var serializedResume1 = this.SerializeXmlObject(resumeDocument1);
        if (File.Exists(serializedFileName))
        {
          File.Delete(serializedFileName);
        }
        var newFile = File.CreateText(serializedFileName);
        newFile.AutoFlush = true;
        newFile.Write(serializedResume1);
        newFile.Close();
      }
      catch (Exception ex)
      {
        logger.Error("Exception in TestLoadResumeExample test.", ex);
        if (null != ex.InnerException)
        {
            logger.Error("Inner exception in TestLoadResumeExample test.", ex.InnerException);
        }
        throw;
      }
    }

    /// <summary>
    /// Tests the resume document XML serializer.
    /// </summary>
    [Test]
    public void TestResumeDocumentXmlSerializer()
    {
        logger.Info(string.Empty);
      //deflate
      var resumeDocument1 = new ResumeDocument();
      Assert.IsNotNull(resumeDocument1, "The ResumeDocument is null.");
      Assert.IsNull(((ISharpResumeObject) resumeDocument1).Parent, "The ResumeDocument.Parent is not null.");
      resumeDocument1.ResumeId = new EntityIdType();
      resumeDocument1.ResumeId.IdValue.Add(new EntityIdTypeIdValue());
      resumeDocument1.ResumeId.IdValue[0] = new EntityIdTypeIdValue {Value = "123"};
      var serializedResume1 = this.SerializeXmlObject(resumeDocument1);
      Assert.IsNotEmpty(serializedResume1, "The serialized ResumeDocument is empty.");
      Console.Out.WriteLine(serializedResume1);

      //inflate
      var resumeDocument2 = DeserializeXmlObject(serializedResume1);
      Assert.IsNotNull(resumeDocument2, "The ResumeDocument is null.");
      Assert.IsNull(((ISharpResumeObject) resumeDocument2).Parent, "The ResumeDocument.Parent is not null.");
      resumeDocument2.ResumeId = new EntityIdType();
      resumeDocument2.ResumeId.IdValue.Add(new EntityIdTypeIdValue());
      resumeDocument2.ResumeId.IdValue[0] = new EntityIdTypeIdValue {Value = "123"};

      //deflate
      var serializedResume2 = this.SerializeXmlObject(resumeDocument2);

      Assert.IsNotEmpty(serializedResume2, "The serialized resume is empty.");
      Console.Out.WriteLine(serializedResume2);

      var x1 = serializedResume1;
      var x2 = serializedResume2;
      var c = string.Compare(x1, x2, false);
      Assert.IsTrue(0 == c,
                    "The serialized-deserialized-serialized results varied.");

      Console.Out.WriteLine(resumeDocument1.Equals(resumeDocument2));

      Console.Out.WriteLine(resumeDocument1.CompareTo(resumeDocument2));

      Assert.AreEqual(resumeDocument1, resumeDocument2, "The serialized-deserialized object comparison results varied.");
    }
  }
}