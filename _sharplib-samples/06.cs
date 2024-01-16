using System;
// https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA0AXEBLANgHwAEAmARgFgAoKwgZgAIT6BZATwCEYA7MACwFsAhlADWVAN5V6jBti4Z6AUShRoAYQgATGAGcAklwCCAJQgB3ACq6MACgCUU+pMrTpAN2H0YK9Vpj0AXnobZVUoDW19I1MzOwARQQwYC2x+GAA6AFUMMAA5c3SAZRhILk0AbkdpHTNsHN5g7zCImAcXV2dXVzBBHX9Q30iDEwKBqFIQKq7GAHZ6Ukr2rp6+pR9wvyiRs3Sx4kml6cI54kXp+hX+9ZatmN31lAPz6WP6FDPpy7XmzeG7sYArE9nq8AR9lr0rj8htFRuskMDzq8kODXNoAGaCACuuCwUy6rwAnITUQBfRzk6jtOj0OQKMY3XIAeQsf3MVh0tja0k60w8UC81z8gWCDM2zNZsNiCSSKTSWRy+R2xVKFXx9BqdT4Niag1a6t5zwukO+ep0ErZOzGE3VRtepAADA7UecvmLIhapfcwvtbSCTk6XZ8Te7dJ7tt7oI8/Ui5ihAzHjatQ+aWZbI1AgYmCXMAQnDq6Q0KPWmvWMEdnXMj80bpBjsbjEbWXnNiUHKdJKZSaAxuFj+KaNjDthJHNaRaRSGgx+tiBPiNP2mMUBP0DOwgCJwDF9JyxOkIvu5QaX2BynwzFR0v1qQJ06d4O50FiPf11GRfGHQ/ASK81+31ASAikgr6UJSQA=

public class MyBenchmark
{
  public int ErrorCodesInARowTest()
  {
    var errorCode = (ErrorCodesInARow)DateTime.UtcNow.Second;
    switch (errorCode)
    {
      case ErrorCodesInARow.Error1:
        return 1;
      case ErrorCodesInARow.Error2:
        return 2;
      case ErrorCodesInARow.Error4:
        return 4;
      case ErrorCodesInARow.Error5:
        return 5;
      case ErrorCodesInARow.Error6:
        return 6;
      default:
        return 99;
    }
  }

  public int ErrorCodesNOTInARowTest()
  {
      var errorCode = (ErrorCodesNOTInARow)DateTime.UtcNow.Second;
      switch(errorCode)
      {
          case ErrorCodesNOTInARow.Error1:
              return 100;
          case ErrorCodesNOTInARow.Error2:
              return 200;
          case ErrorCodesNOTInARow.Error4:
              return 400;
          case ErrorCodesNOTInARow.Error5:
              return 500;
          case ErrorCodesNOTInARow.Error6:
              return 600;
          default:
              return 99;
      }
  }
}

public enum ErrorCodesInARow
{
  Error1 = 11,
  Error2 = 12,
  Error4 = 14,
  Error5 = 15,
  Error6 = 16,
}

public enum ErrorCodesNOTInARow
{
  Error1 = 100,
  Error2 = 200,
  Error4 = 400,
  Error5 = 500,
  Error6 = 600,
}
