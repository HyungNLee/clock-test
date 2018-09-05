using System;

namespace Clock
{
  public class ClockFace
  {
    private int hPos;
    private int mPos;

    public double CalculateAngle(int hour, int min)
    {
      hPos = hour;
      mPos = min;

      double angle = Math.Abs(((hPos * 30) + (mPos * .5)) - (mPos * 6));

      return (angle > 180) ? (360 - angle) : angle;

    }
  }
}
