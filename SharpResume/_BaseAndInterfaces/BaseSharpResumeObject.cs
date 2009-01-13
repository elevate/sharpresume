using System;
using System.Diagnostics;
using NLog;

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  [Serializable]
  [DebuggerStepThrough]
  public abstract class BaseSharpResumeObject<T> : IComparable<T>, IEquatable<T>, ISharpResumeObject
    where T : ISharpResumeObject
  {
    /// <summary>
    /// The base NLog logger instance.
    /// </summary>
    protected static readonly Logger logger = LogManager.GetCurrentClassLogger();

    private readonly ISharpResumeObject _parent;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseSharpResumeObject{T}"/> class.
    /// </summary>
    protected BaseSharpResumeObject() : this(null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseSharpResumeObject{T}"/> class.
    /// </summary>
    /// <param name="parent">The parent.</param>
    protected BaseSharpResumeObject(ISharpResumeObject parent)
    {
      _parent = parent;
    }

    #region IComparable<T> Members

    /// <summary>
    /// Compares the current object with another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the other parameter.Zero This object is equal to other. Greater than zero This object is greater than other.
    /// </returns>
    public int CompareTo(T other)
    {
      return Equals(other) ? 0 : 1;
    }

    #endregion

    #region IEquatable<T> Members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// true if the current object is equal to the other parameter; otherwise, false.
    /// </returns>
    public abstract bool Equals(T other);

    #endregion

    #region ISharpResumeObject Members

    /// <summary>
    /// Gets a value indicating whether this instance has parent.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance has parent; otherwise, <c>false</c>.
    /// </value>
    public bool HasParent { get { return _parent == null; } }

    /// <summary>
    /// Gets the parent.
    /// </summary>
    /// <value>The parent.</value>
    public ISharpResumeObject Parent { get { return _parent; } }

    #endregion

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(BaseSharpResumeObject<T> left, BaseSharpResumeObject<T> right)
    {
      // If both are null, or both are same instance, return true.
      if (ReferenceEquals(left, right))
      {
        return true;
      }

      // If one is null, but not both, return false.
      if (((object) left == null) || ((object) right == null))
      {
        return false;
      }

      return true;
    }

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(BaseSharpResumeObject<T> left, BaseSharpResumeObject<T> right)
    {
      return !(left == right);
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
    /// <returns>
    /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
    /// </returns>
    /// <filterPriority>2</filterPriority>
    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is T))
      {
        return false;
      }
      return Equals((T) obj);
    }

    /// <summary>
    /// Serves as a hash function for a particular type.
    /// </summary>
    /// <returns>
    /// A hash code for the current <see cref="T:System.Object"/>.
    /// </returns>
    /// <filterPriority>2</filterPriority>
    public override int GetHashCode()
    {
      return 0;
    }
  }
}