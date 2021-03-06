#region

using NUnit.Framework;

#endregion

namespace Just3Ws.SharpResume.Test
{
  [TestFixture]
  public class ElementIdTypeTests : SerializationTestHelper<EntityIdType>
  {
      private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// <summary>
    /// Tests the basic element id type constructor initialized.
    /// </summary>
    [Test]
    public void TestBasicElementIdTypeConstructorInitialized()
    {
      logger.Info(string.Empty);
      const string actual = "hello";
      //EntityIdType entityIdType = new EntityIdType( actual );
      var entityIdType = new EntityIdType();
      Assert.IsNotNull(entityIdType, "The object is null.");
      Assert.IsEmpty(entityIdType.IdValue, "The object is not null.");
      //entityIdType.IdValue = new EntityIdTypeIdValue[1];
      entityIdType.IdValue.Add(new EntityIdTypeIdValue());
      entityIdType.IdValue[0] = new EntityIdTypeIdValue {Value = actual};
      Assert.IsTrue(0 == string.Compare(entityIdType.IdValue[0].Value, actual, false));
      var parent = ((ISharpResumeObject) entityIdType).Parent;
      Assert.IsNull(parent, "The object is not null.");
    }

    /// <summary>
    /// Tests the basic element id type default.
    /// </summary>
    [Test]
    public void TestBasicElementIdTypeDefault()
    {
      logger.Info(string.Empty);
      var entityIdType = new EntityIdType();
      Assert.IsNotNull(entityIdType, "The object is null.");
      Assert.IsEmpty(entityIdType.IdValue, "The object is not null.");
      Assert.IsNull(((ISharpResumeObject) entityIdType).Parent, "The object is not null.");
    }
  }
}