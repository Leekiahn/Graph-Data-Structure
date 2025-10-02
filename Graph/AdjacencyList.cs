namespace Graph;

public class AdjacencyList
{
    private readonly List<int>[] list; // 인접 리스트
    private readonly int size;  // 노드 수
    private readonly bool isDirected; // 방향 그래프 여부

    public AdjacencyList(int size, bool isDirected)
    {
        this.size = size;
        this.isDirected = isDirected;
        list = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            list[i] = new List<int>();
        }
    }
    
    // 간선 추가
    public void AddEdge(int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }
        
        list[from].Add(to);
        if (!isDirected)
        {
            list[to].Add(from);
        }
    }
    
    // 간선 제거
    public void RemoveEdge(int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }
        
        list[from].Remove(to);
        if (!isDirected)
        {
            list[to].Remove(from);
        }
    }
    
    // 간선 존재 여부 확인
    public bool HasEdge(int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }
        
        return list[from].Contains(to);
    }
    
    // 특정 정점의 이웃 리스트
    public List<int> GetNeighbors(int vertex)
    {
        if (vertex < 0 || vertex >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }
        
        return list[vertex];
    }
    
    // 리스트 출력
    public void PrintList()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i}: ");
            Console.WriteLine(string.Join(", ", list[i]));
        }
    }
}