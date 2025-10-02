namespace Graph;

// 그래프 인접 행렬 구현
public class AdjacencyMatrix
{
    private readonly bool[,] matrix; // 인접 행렬
    private readonly int size;  // 노드 수
    private readonly bool isDirected; // 방향 그래프 여부

    public AdjacencyMatrix(int size, bool isDirected)
    {
        this.size = size;
        this.isDirected = isDirected;
        matrix = new bool[size, size];
    }

    // 간선 추가
    public void AddEdge(int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }

        matrix[from, to] = true;
        if (!isDirected)
            matrix[to, from] = true;
    }

    // 간선 제거
    public void RemoveEdge(int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }

        matrix[from, to] = false;
        if (!isDirected)
            matrix[to, from] = false;
    }

    // 간선 존재 여부 확인
    public bool HasEdge(int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }

        return matrix[from, to];
    }

    // 행렬 출력
    public void PrintMatrix()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] ? "1 " : "0 ");
            }

            Console.WriteLine();
        }
    }
}