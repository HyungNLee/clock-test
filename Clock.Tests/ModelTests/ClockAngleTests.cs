using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clock;

namespace Clock.Test
{
  [TestClass]
  public class ClockTest
  {
    [TestMethod]
    public void CalculateAngleTest_Angle()
    {
      ClockFace testClock = new ClockFace();
      Assert.AreEqual(157.5, testClock.CalculateAngle(3, 45));
    }
  }
}
