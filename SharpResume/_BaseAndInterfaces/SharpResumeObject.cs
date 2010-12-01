#region

using System;
using System.Collections;
using System.Diagnostics;

#endregion

namespace Just3Ws.SharpResume
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  [Serializable]
  [DebuggerStepThrough]
  public abstract class SharpResumeObject<T> : IComparable<T>, IEquatable<T>, ISharpResumeObject, IComparable, IComparer
    where T : ISharpResumeObject
  {
    /// <summary>
    /// The base NLog log instance.
    /// </summary>
    private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    private readonly ISharpResumeObject parent;

    /// <summary>
    /// Initializes a new instance of the <see cref="SharpResumeObject{T}"/> class.
    /// </summary>
    protected SharpResumeObject() : this(null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SharpResumeObject{T}"/> class.
    /// </summary>
    /// <param name="parent">The parent.</param>
    protected SharpResumeObject(ISharpResumeObject parent)
    {
      this.parent = parent;
    }

    #region IComparable Members

    /// <summary>
    /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="other">An object to compare with this instance.</param>
    /// <returns>
    /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has these meanings:
    /// Value
    /// Meaning
    /// Less than zero
    /// This instance is less than <paramref name="other"/>.
    /// Zero
    /// This instance is equal to <paramref name="other"/>.
    /// Greater than zero
    /// This instance is greater than <paramref name="other"/>.
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    /// 	<paramref name="other"/> is not the same type as this instance.
    /// </exception>
    public int CompareTo(object other)
    {
      //Debugger.Break();
      return this.Equals(other) ? 0 : 1;
    }

    #endregion

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
      //Debugger.Break();
      return this.Equals(other) ? 0 : 1;
    }

    #endregion

    #region IComparer Members

    /// <summary>
    /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
    /// </summary>
    /// <param name="x">The first object to compare.</param>
    /// <param name="y">The second object to compare.</param>
    /// <returns>
    /// Value
    /// Condition
    /// Less than zero
    /// <paramref name="x"/> is less than <paramref name="y"/>.
    /// Zero
    /// <paramref name="x"/> equals <paramref name="y"/>.
    /// Greater than zero
    /// <paramref name="x"/> is greater than <paramref name="y"/>.
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    /// Neither <paramref name="x"/> nor <paramref name="y"/> implements the <see cref="T:System.IComparable"/> interface.
    /// -or-
    /// <paramref name="x"/> and <paramref name="y"/> are of different types and neither one can handle comparisons with the other.
    /// </exception>
    public int Compare(object x, object y)
    {
      //Debugger.Break();
      return x.Equals(y) ? 0 : 1;
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
    public bool HasParent { get { return this.parent == null; } }

    /// <summary>
    /// Gets the parent.
    /// </summary>
    /// <value>The parent.</value>
    public ISharpResumeObject Parent { get { return this.parent; } }

    #endregion

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(SharpResumeObject<T> left, SharpResumeObject<T> right)
    {
      //Debugger.Break();
      // If both are null, or both are same instance, return true.
      if (ReferenceEquals(left, right))
      {
        return true;
      }

      // If one is null, but not both, return false.
      return ((object) left != null) && ((object) right != null);
    }

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(SharpResumeObject<T> left, SharpResumeObject<T> right)
    {
      //Debugger.Break();
      return !(left == right);
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <param name="other">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
    /// <returns>
    /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
    /// </returns>
    /// <filterPriority>2</filterPriority>
    public override bool Equals(object other)
    {
      //Debugger.Break();
      if (other == null || !(other is T))
      {
        return false;
      }
      return this.Equals((T) other);
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