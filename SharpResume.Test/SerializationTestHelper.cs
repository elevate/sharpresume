#region

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;

#endregion

namespace Just3Ws.SharpResume.Test
{
  public class SerializationTestHelper<T> where T : ISharpResumeObject
  {
    public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// <summary>
    /// Serializes the resume document.
    /// </summary>
    /// <param name="xmlObject">The resume document.</param>
    /// <returns></returns>
    public string SerializeXmlObject(T xmlObject)
    {
      //Debugger.Break();
      logger.Info(string.Empty);
      try
      {
        var serializer = new XmlSerializer(typeof (T));
        var outputStream = new MemoryStream();
        serializer.Serialize(outputStream, xmlObject); //, xmlObject.SerializerNamespaces );
        outputStream.Flush();
        outputStream.Position = 0;

        return (new StreamReader(outputStream, true)).ReadToEnd();
      }
      catch (InvalidOperationException ioe)
      {
        logger.Error("There was an error attempting to serialize the object.", ioe);
        //Debugger.Break();
        throw;
      }
    }

    /// <summary>
    /// Deserializes the resume document.
    /// </summary>
    /// <param name="serializedXmlObject">The serialized resume document.</param>
    /// <returns></returns>
    public T DeserializeXmlObject(string serializedXmlObject)
    {
        logger.Info(string.Empty);
      var inputStream = new MemoryStream();
      var inputStreamWriter = new StreamWriter(inputStream);
      inputStreamWriter.Write(serializedXmlObject);
      inputStreamWriter.Flush();
      inputStream.Position = 0;
      var inputReader = XmlReader.Create(inputStream, null);
      return DeserializeXmlObject(inputReader);
    }

    /// <summary>
    /// Deserializes the XML object.
    /// </summary>
    /// <param name="inputReader">The input reader.</param>
    /// <returns></returns>
    public T DeserializeXmlObject(XmlReader inputReader)
    {
        logger.Info(string.Empty);
      var serializer = new XmlSerializer(typeof (ResumeDocument));
      Assert.IsTrue(serializer.CanDeserialize(inputReader));
      var events = new XmlDeserializationEvents();
      events.OnUnknownAttribute = this.Serializer_OnUnknownAttribute;
      events.OnUnknownElement = this.Serializer_OnUnknownElement;
      events.OnUnknownNode = this.Serializer_OnUnknownNode;
      events.OnUnreferencedObject = this.Serializer_OnUnreferencedObject;
      var deserialized = serializer.Deserialize(inputReader, events);
      Assert.IsNotNull(deserialized);
      return (T) deserialized;
    }

    /// <summary>
    /// Handles the OnUnknownAttribute event of the Serializer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="args">The <see cref="System.Xml.Serialization.XmlAttributeEventArgs"/> instance containing the event data.</param>
    public void Serializer_OnUnknownAttribute(object sender, XmlAttributeEventArgs args)
    {
        logger.Info(string.Empty);
      //Debugger.Break();
      logger.Info("OnUnknownAttribute");
      logger.Info(args.Attr.Name);
      Assert.Fail("Failed because of unknown attribute.");
    }

    /// <summary>
    /// Handles the OnUnknownElement event of the Serializer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="args">The <see cref="System.Xml.Serialization.XmlElementEventArgs"/> instance containing the event data.</param>
    public void Serializer_OnUnknownElement(object sender, XmlElementEventArgs args)
    {
      logger.Info(string.Empty);
      //Debugger.Break();
      logger.Info("OnUnknownElement");
      logger.Info(args.Element.Name);
      Assert.Fail("Failed because of unknown element.");
    }

    /// <summary>
    /// Handles the OnUnknownNode event of the Serializer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="args">The <see cref="System.Xml.Serialization.XmlNodeEventArgs"/> instance containing the event data.</param>
    public void Serializer_OnUnknownNode(object sender, XmlNodeEventArgs args)
    {
      logger.Info(string.Empty);
      //Debugger.Break();
      logger.Info("OnUnknownNode");
      logger.Info(args.Name);
      Assert.Fail("Failed because of unknown node.");
    }

    /// <summary>
    /// Handles the OnUnreferencedObject event of the Serializer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="args">The <see cref="System.Xml.Serialization.UnreferencedObjectEventArgs"/> instance containing the event data.</param>
    public void Serializer_OnUnreferencedObject(object sender, UnreferencedObjectEventArgs args)
    {
      logger.Info(string.Empty);
      //Debugger.Break();
      logger.Info("OnUnreferencedObject");
      Assert.Fail("Failed because of unreferenced object.");
    }

    /// <summary>
    /// Tests the basic resume document.
    /// </summary>
    [Test]
    public void TestBasicResumeDocument()
    {
      logger.Info(string.Empty);
      var document = new ResumeDocument();
      Assert.IsNotNull(document);
      Assert.IsNull(((ISharpResumeObject) document).Parent);
    }
  }
}