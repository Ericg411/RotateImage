namespace RotateImage.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 2, 3 };
        matrix[1] = new int[] { 4, 5, 6 };
        matrix[2] = new int[] { 7, 8, 9 };  

        _test.Rotate(matrix);
        
        int[][] answer = new int[3][];
        answer[0] = new int[] { 7, 4, 1 };
        answer[1] = new int[] { 8, 5, 2 };
        answer[2] = new int[] { 9, 6, 3 };

        bool isTrue = true;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != answer[i][j])
                {
                    isTrue = false;
                }
            }
        }       

        Assert.IsTrue( isTrue );

    }   
    
    [TestMethod]
    public void TestMethod2()
    {
        int[][] matrix = new int[4][];
        matrix[0] = new int[] { 5, 1, 9, 11 };
        matrix[1] = new int[] { 2, 4, 8, 10 };
        matrix[2] = new int[] { 13, 3, 6, 7 };  
        matrix[3] = new int[] { 15, 14, 12, 16 };  

        _test.Rotate(matrix);
        
        int[][] answer = new int[4][];
        answer[0] = new int[] { 15, 13, 2, 5 };
        answer[1] = new int[] { 14, 3, 4, 1 };
        answer[2] = new int[] { 12, 6, 8, 9 };
        answer[3] = new int[] { 16, 7, 10, 11 };

        bool isTrue = true;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != answer[i][j])
                {
                    isTrue = false;
                }
            }
        }       

        Assert.IsTrue( isTrue );

    }
}