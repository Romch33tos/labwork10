using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace MatrixTests
{
  [TestClass]
  public class MatrixOperationsTests
  {
    [TestMethod]
    public void Addition_ValidMatrices_ReturnsCorrectResult()
    {
      var matrix1 = new SquareMatrix(1, 2, 3, 4);
      var matrix2 = new SquareMatrix(5, 6, 7, 8);
      var result = matrix1 + matrix2;
      
      Assert.AreEqual(6, result.MatrixElements[0, 0]);
      Assert.AreEqual(8, result.MatrixElements[0, 1]);
      Assert.AreEqual(10, result.MatrixElements[1, 0]);
      Assert.AreEqual(12, result.MatrixElements[1, 1]);
    }

    [TestMethod]
    [ExpectedException(typeof(MatrixOperationException))]
    public void Addition_DifferentSizes_ThrowsException()
    {
      var matrix1 = new SquareMatrix(1, 2, 3, 4);
      var matrix2 = new SquareMatrix(1, 2, 3, 4, 5, 6, 7, 8, 9);
      
      var result = matrix1 + matrix2;
    }

    [TestMethod]
    public void Multiplication_ValidMatrices_ReturnsCorrectResult()
    {
      var matrix1 = new SquareMatrix(1, 2, 3, 4);
      var matrix2 = new SquareMatrix(2, 0, 1, 2);
      var result = matrix1 * matrix2;
      
      Assert.AreEqual(4, result.MatrixElements[0, 0]);
      Assert.AreEqual(4, result.MatrixElements[0, 1]);
      Assert.AreEqual(10, result.MatrixElements[1, 0]);
      Assert.AreEqual(8, result.MatrixElements[1, 1]);
    }
  }
}