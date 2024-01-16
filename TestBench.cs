using System;
using System.Text;
using BenchmarkDotNet.Attributes;

public class MyBenchmark
{
  [Benchmark]
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

  [Benchmark]
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
