using System;
using System.Runtime.Serialization;
using NLog;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// Base exception for #Resume.
  /// </summary>
  [Serializable]
  public class SharpResumeException : Exception
  {
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Just3Ws.SharpResume.SharpResumeException"/> class.
    /// </summary>
    public SharpResumeException()
    {
      logger.Error("Invoked SharpResume()");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Just3Ws.SharpResume.SharpResumeException"/> class.
    /// </summary>
    /// <param name="message">The message.</param>
    public SharpResumeException(string message) : base(message)
    {
      logger.Error("Invoked SharpResume(\"{0}\")", message);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Just3Ws.SharpResume.SharpResumeException"/> class.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="innerException">The inner exception.</param>
    public SharpResumeException(string message, Exception innerException) : base(message, innerException)
    {
      if (innerException != null)
      {
        logger.Error("Invoked SharpResume(\"{0}\", {1})", message, innerException.GetType().Name);
      }
      else
      {
        logger.Error("Invoked SharpResume(\"{0}\", null)", message);
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Just3Ws.SharpResume.SharpResumeException"/> class.
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"></see> is zero (0). </exception>
    /// <exception cref="T:System.ArgumentNullException">The info parameter is null. </exception>
    protected SharpResumeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
      logger.Error("Invoked SharpResume(SerializationInfo, StreamingContext)");
    }
  }
}