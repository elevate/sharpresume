//using System;
//using System.Xml;
//using System.Xml.Schema;
//using System.Xml.XPath;
//using Just3Ws.SharpResume.HRXml;

//namespace Just3Ws.SharpResume.Validation
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class XmlHelper
//    {
//        private static XmlSchemaSet _resumeSchemaSet = null;

//        /// <summary>
//        /// Gets the resume schema set.
//        /// </summary>
//        /// <value>The resume schema set.</value>
//        public static XmlSchemaSet ResumeSchemaSet
//        {
//            get
//            {
//                if ( _resumeSchemaSet != null )
//                {
//                    return _resumeSchemaSet;
//                }
//                _resumeSchemaSet = new XmlSchemaSet();
//                _resumeSchemaSet.Add( "xmlns", XmlNamespaces.HRXmlNamespace25 );
//                _resumeSchemaSet.Add( "xsi", XmlNamespaces.XmlSchemaInstance );
//                _resumeSchemaSet.Add( "schemaLocation", XmlNamespaces.HRXmlResumeSchemaLocation25 );
//                return _resumeSchemaSet;
//            }
//        }

//        #region Event Handlers

//        /// <summary>
//        /// Validations the event handler.
//        /// </summary>
//        /// <param name="sender">The sender.</param>
//        /// <param name="e">The <see cref="System.Xml.Schema.ValidationEventArgs"/> instance containing the event data.</param>
//        private static void ValidationEventHandler( object sender, ValidationEventArgs e )
//        {
//            throw new Exception( "The method or operation is not implemented." );
//        }

//        #endregion

//        /// <summary>
//        /// Validates the specified reader.
//        /// </summary>
//        /// <param name="reader">The reader.</param>
//        /// <returns></returns>
//        public static IXPathNavigable Validate( XmlReader reader )
//        {
//            XmlReaderSettings settings = new XmlReaderSettings();

//            //settings.ValidationEventHandler += new ValidationEventHandler(OnValidation);
//            settings.ValidationEventHandler += ValidationEventHandler;

//            XmlReader validatingReader = XmlReader.Create( reader, settings );

//            IXPathNavigable doc = new XPathDocument( validatingReader );
//            XPathNavigator nav = doc.CreateNavigator();

//            return doc;
//        }

//        /// <summary>
//        /// Creates the namespace manager.
//        /// </summary>
//        /// <param name="doc">The doc.</param>
//        /// <param name="defaultNamespaceName">Name of the default namespace.</param>
//        /// <returns></returns>
//        public static XmlNamespaceManager CreateNamespaceManager( XmlDocument doc, string defaultNamespaceName )
//        {
//            XmlNamespaceManager namespaceManager = new XmlNamespaceManager( doc.NameTable );
//            foreach ( XmlAttribute attribute in doc.SelectSingleNode( "/*" ).Attributes )
//            {
//                if ( 0 == string.Compare( attribute.Prefix, "xmlns", true ) )
//                {
//                    namespaceManager.AddNamespace( attribute.LocalName, attribute.Value );
//                }
//                else if ( 0 == string.Compare( attribute.Name, "xmlns" ) )
//                {
//                    namespaceManager.AddNamespace( defaultNamespaceName, attribute.Value );
//                }
//            }
//            return namespaceManager;
//        }
//    }
//}
