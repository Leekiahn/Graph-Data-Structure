namespace Graph;

class Program
{
    static void Main(string[] args)
    {
        // 무방향 그래프 인접 행렬
        AdjacencyMatrix undirectedGraph = new AdjacencyMatrix(5, false);
        undirectedGraph.AddEdge(0, 1);
        undirectedGraph.AddEdge(0, 2);
        undirectedGraph.AddEdge(1, 2);
        undirectedGraph.AddEdge(2, 3);
        undirectedGraph.AddEdge(3, 4);
        undirectedGraph.PrintMatrix();
        undirectedGraph.RemoveEdge(3, 4);   // 간선 제거
        Console.WriteLine(undirectedGraph.HasEdge(2, 3)); // true
        Console.WriteLine(undirectedGraph.HasEdge(3, 2)); // 무방향 그래프이므로 true
        Console.WriteLine(undirectedGraph.HasEdge(3, 4)); // 제거된 간선이므로 false
        
        // 방향 그래프 인접 행렬
        AdjacencyMatrix directedGraph = new AdjacencyMatrix(5, true);
        directedGraph.AddEdge(0, 1);
        directedGraph.AddEdge(1, 2);
        directedGraph.AddEdge(2, 3);
        directedGraph.AddEdge(3, 4);
        directedGraph.AddEdge(4, 0);
        directedGraph.PrintMatrix();
        directedGraph.RemoveEdge(3, 4); // 간선 제거
        Console.WriteLine(directedGraph.HasEdge(2, 3)); // true
        Console.WriteLine(directedGraph.HasEdge(3, 2)); // 방향 그래프이므로 false
        Console.WriteLine(directedGraph.HasEdge(3, 4)); // 제거된 간선이므로 false
        
        // 무방향 그래프 인접 리스트
        AdjacencyList undirectedList = new AdjacencyList(5, false);
        undirectedList.AddEdge(0, 1);
        undirectedList.AddEdge(0, 2);
        undirectedList.AddEdge(1, 2);
        undirectedList.AddEdge(2, 3);
        undirectedList.AddEdge(3, 4);
        undirectedList.PrintList();
        undirectedList.RemoveEdge(3, 4); // 간선 제거
        Console.WriteLine(undirectedList.HasEdge(2, 3)); // true
        Console.WriteLine(undirectedList.HasEdge(3, 2)); // 무방향 그래프이므로 true
        Console.WriteLine(undirectedList.HasEdge(3, 4)); // 제거된 간선이므로 false
        
        // 방향 그래프 인접 리스트
        AdjacencyList directedList = new AdjacencyList(5, true);
        directedList.AddEdge(0, 1);
        directedList.AddEdge(1, 2);
        directedList.AddEdge(2, 3);
        directedList.AddEdge(3, 4);
        directedList.AddEdge(4, 0);
        directedList.PrintList();
        directedList.RemoveEdge(3, 4); // 간선 제거
        Console.WriteLine(directedList.HasEdge(2, 3)); // true
        Console.WriteLine(directedList.HasEdge(3, 2)); // 방향 그래프이므로 false
        Console.WriteLine(directedList.HasEdge(3, 4)); // 제거된 간선이므로 false
        
        // 무방향 가중치 그래프
        WeightedGraph undirectedWeightedGraph = new WeightedGraph(5, false);
        undirectedWeightedGraph.AddEdge(0, 1, 10);
        undirectedWeightedGraph.AddEdge(0, 2, 5);
        undirectedWeightedGraph.AddEdge(1, 2, 2);
        undirectedWeightedGraph.AddEdge(2, 3, 1);
        undirectedWeightedGraph.AddEdge(3, 4, 7);
        undirectedWeightedGraph.PrintList();
        undirectedWeightedGraph.RemoveEdge(3, 4); // 간선 제거
        Console.WriteLine(undirectedWeightedGraph.HasEdge(2, 3)); // true
        Console.WriteLine(undirectedWeightedGraph.HasEdge(3, 2)); // 무방향 그래프이므로 true
        Console.WriteLine(undirectedWeightedGraph.HasEdge(3, 4)); // 제거된 간선이므로 false
        
        // 방향 가중치 그래프
        WeightedGraph directedWeightedGraph = new WeightedGraph(5, true);
        directedWeightedGraph.AddEdge(0, 1, 10);
        directedWeightedGraph.AddEdge(1, 2, 2);
        directedWeightedGraph.AddEdge(2, 3, 1);
        directedWeightedGraph.AddEdge(3, 4, 7);
        directedWeightedGraph.AddEdge(4, 0, 3);
        directedWeightedGraph.PrintList();
        directedWeightedGraph.RemoveEdge(3, 4); // 간선 제거
        Console.WriteLine(directedWeightedGraph.HasEdge(2, 3)); // true
        Console.WriteLine(directedWeightedGraph.HasEdge(3, 2)); // 방향 그래프이므로 false
        Console.WriteLine(directedWeightedGraph.HasEdge(3, 4)); // 제거된 간선이므로 false
    }
}