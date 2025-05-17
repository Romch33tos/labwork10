using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Matrix
{
  [TestClass]
  public class MatrixDeterminantTests
  {
    [DataTestMethod]
    [DataRow(1, new int[] { 5 })]
    [DataRow(-2, new int[] { 1, 2, 3, 4 })]
    [DataRow(0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void CalculateDeterminant_ReturnsCorrectValue(int expected, int[] elements)
    {
      var matrix = new SquareMatrix(elements);
      Assert.AreEqual(expected, matrix.CalculateDeterminant());
    }

    [TestMethod]
    [ExpectedException(typeof(MatrixSizeException))]
    public void CalculateDeterminant_TooLargeMatrix_ThrowsException()
    {
      var matrix = new SquareMatrix(
        1, 0, 0, 0,
        0, 1, 0, 0,
        0, 0, 1, 0,
        0, 0, 0, 1
      );
      matrix.CalculateDeterminant();
    }
  }
}