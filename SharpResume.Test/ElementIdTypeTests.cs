#region

using NLog;
using NUnit.Framework;

#endregion

namespace Just3Ws.SharpResume.Test
{
  [TestFixture]
  public class ElementIdTypeTests : SerializationTestHelper<EntityIdType>
  {
    public static readonly Logger log = LogManager.GetCurrentClassLogger();

    /// <summary>
    /// Tests the basic element id type constructor initialized.
    /// </summary>
    [Test]
    public void TestBasicElementIdTypeConstructorInitialized()
    {
      log.Trace(string.Empty);
      const string actual = "hello";
      //EntityIdType entityIdType = new EntityIdType( actual );
      var entityIdType = new EntityIdType();
      Assert.IsNotNull(entityIdType, "The object is null.");
      Assert.IsNull(entityIdType.IdValue, "The object is not null.");
      //entityIdType.IdValue = new EntityIdTypeIdValue[1];
      entityIdType.IdValue.Add(new EntityIdTypeIdValue());
      entityIdType.IdValue[0] = new EntityIdTypeIdValue {Value = actual};
      Assert.IsTrue(0 == string.Compare(entityIdType.IdValue[0].Value, actual, false));
      Assert.IsNull(((ISharpResumeObject) entityIdType).Parent, "The object is not null.");
    }

    /// <summary>
    /// Tests the basic element id type default.
    /// </summary>
    [Test]
    public void TestBasicElementIdTypeDefault()
    {
      log.Trace(string.Empty);
      var entityIdType = new EntityIdType();
      Assert.IsNotNull(entityIdType, "The object is null.");
      Assert.IsNull(entityIdType.IdValue, "The object is not null.");
      Assert.IsNull(((ISharpResumeObject) entityIdType).Parent, "The object is not null.");
    }
  }
}