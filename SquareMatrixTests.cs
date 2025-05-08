using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Matrix
{
  [TestClass]
  public class SquareMatrixTests
  {
    [TestMethod]
    public void Constructor_With2DArray_CreatesCorrectMatrix()
    {
      int[,] elements = { { 1, 2 }, { 3, 4 } };
      var matrix = new SquareMatrix(elements);
      
      Assert.AreEqual(2, matrix.MatrixSize);
      Assert.AreEqual(1, matrix.MatrixElements[0, 0]);
      Assert.AreEqual(4, matrix.MatrixElements[1, 1]);
    }

    [TestMethod]
    public void Constructor_With1DArray_CreatesCorrectMatrix()
    {
      int[] elements = { 1, 2, 3, 4 };
      var matrix = new SquareMatrix(elements);
      
      Assert.AreEqual(2, matrix.MatrixSize);
      Assert.AreEqual(1, matrix.MatrixElements[0, 0]);
      Assert.AreEqual(4, matrix.MatrixElements[1, 1]);
    }

    [TestMethod]
    public void SumOfElements_ReturnsCorrectSum()
    {
      int[,] elements = { { 1, 2 }, { 3, 4 } };
      var matrix = new SquareMatrix(elements);
      
      Assert.AreEqual(10, matrix.SumOfElements());
    }

    [TestMethod]
    public void Clone_CreatesIndependentCopy()
    {
      int[,] elements = { { 1, 2 }, { 3, 4 } };
      var matrix = new SquareMatrix(elements);
      var clone = matrix.Clone();
      
      clone.MatrixElements[0, 0] = 5;
      
      Assert.AreEqual(1, matrix.MatrixElements[0, 0]);
      Assert.AreEqual(5, clone.MatrixElements[0, 0]);
    }
  }
}