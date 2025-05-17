using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Matrix
{
  [TestClass]
  public class MatrixComparisonTests
  {
    [TestMethod]
    public void CompareTo_EqualMatrices_ReturnsZero()
    {
      var matrix1 = new SquareMatrix(1, 2, 3, 4);
      var matrix2 = new SquareMatrix(1, 2, 3, 4);
      
      Assert.AreEqual(0, matrix1.CompareTo(matrix2));
    }

    [TestMethod]
    public void GreaterThanOperator_ReturnsCorrectResult()
    {
      var matrix1 = new SquareMatrix(5, 5, 5, 5);
      var matrix2 = new SquareMatrix(1, 1, 1, 1);
      
      Assert.IsTrue(matrix1 > matrix2);
    }

    [TestMethod]
    public void EqualityOperator_ReturnsCorrectResult()
    {
      var matrix1 = new SquareMatrix(1, 2, 3, 4);
      var matrix2 = new SquareMatrix(4, 3, 2, 1);
      
      Assert.IsTrue(matrix1 == matrix2);
    }
  }
}