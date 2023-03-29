namespace RotateImage;
public class Class1
{
    public void Rotate(int[][] matrix)
    {
        var rotation = new List<List<int>>();
        for (int i = 0; i < matrix.Length; i++)
        {
            int counter = 0;
            int otherCounter = matrix.Length - 1;
            var list = new List<int>();
            while (counter < matrix[i].Length)
            {
                list.Add(matrix[otherCounter][i]);
                counter++;
                otherCounter--;
            }
            rotation.Add(list);
        }
        for (int i = 0; i < rotation.Count; i++)
        {
            for (int j = 0; j < rotation[i].Count; j++)
            {
                matrix[i][j] = rotation[i][j];
            }
        }
    }
}
