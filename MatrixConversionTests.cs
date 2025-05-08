using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Matrix
{
  [TestClass]
  public class MatrixConversionTests
  {
    [TestMethod]
    public void ImplicitConversion_From1DArray_CreatesCorrectMatrix()
    {
      int[] elements = { 1, 2, 3, 4 };
      SquareMatrix matrix = elements;
      
      Assert.AreEqual(2, matrix.MatrixSize);
      Assert.AreEqual(1, matrix.MatrixElements[0, 0]);
      Assert.AreEqual(4, matrix.MatrixElements[1, 1]);
    }

    [TestMethod]
    public void ExplicitConversion_To2DArray_ReturnsCorrectArray()
    {
      var matrix = new SquareMatrix(1, 2, 3, 4);
      int[,] array = (int[,])matrix;
      
      Assert.AreEqual(1, array[0, 0]);
      Assert.AreEqual(4, array[1, 1]);
    }

    [TestMethod]
    public void ExplicitConversion_ToString_ReturnsCorrectString()
    {
      var matrix = new SquareMatrix(1, 2, 3, 4);
      string result = (string)matrix;
      
      StringAssert.Contains(result, "1");
      StringAssert.Contains(result, "4");
    }
  }
}