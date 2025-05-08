using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Matrix
{
  [TestClass]
  public class MatrixInverseTests
  {
    [TestMethod]
    public void InverseMatrix_2x2Matrix_ReturnsCorrectInverse()
    {
      var matrix = new SquareMatrix(4, 7, 2, 6);
      var inverse = matrix.InverseMatrix();
      
      Assert.AreEqual(6, inverse.MatrixElements[0, 0]);
      Assert.AreEqual(-7, inverse.MatrixElements[0, 1]);
      Assert.AreEqual(-2, inverse.MatrixElements[1, 0]);
      Assert.AreEqual(4, inverse.MatrixElements[1, 1]);
    }

    [TestMethod]
    [ExpectedException(typeof(MatrixCalculationException))]
    public void InverseMatrix_ZeroDeterminant_ThrowsException()
    {
      var matrix = new SquareMatrix(1, 2, 2, 4);
      var inverse = matrix.InverseMatrix();
    }
  }
}