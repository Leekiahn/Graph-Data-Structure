using System;
using System.Collections.Generic;

namespace Graph;

public class WeightedGraph
{
    private readonly List<(int to, int weight)>[] adjList; // 인접 리스트 (가중치 포함)
    private readonly int size;  // 노드 수
    private readonly bool isDirected; // 방향 그래프 여부

    public WeightedGraph(int size, bool isDirected)
    {
        this.size = size;
        this.isDirected = isDirected;
        adjList = new List<(int, int)>[size];
        for (int i = 0; i < size; i++)
        {
            adjList[i] = new List<(int, int)>();
        }
    }

    // 간선 추가
    public void AddEdge(int from, int to, int weight)
    {
        ValidateVertexUtil.Validate(size, from, to);
        adjList[from].Add((to, weight));
        if (!isDirected)
        {
            adjList[to].Add((from, weight));
        }
    }

    // 간선 제거
    public void RemoveEdge(int from, int to)
    {
        ValidateVertexUtil.Validate(size, from, to);
        adjList[from].RemoveAll(edge => edge.to == to);
        if (!isDirected)
        {
            adjList[to].RemoveAll(edge => edge.to == from);
        }
    }

    // 간선 존재 여부 확인
    public bool HasEdge(int from, int to)
    {
        ValidateVertexUtil.Validate(size, from, to);
        return adjList[from].Exists(edge => edge.to == to);
    }

    // 특정 정점의 이웃 리스트 (가중치 포함)
    public List<(int to, int weight)> GetNeighbors(int vertex)
    {
        ValidateVertexUtil.Validate(size, vertex);
        return adjList[vertex];
    }

    // 리스트 출력
    public void PrintList()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i}: ");
            var neighbors = adjList[i];
            var neighborStr = string.Join(", ", neighbors.ConvertAll(e => $"({e.to}, {e.weight})"));
            Console.WriteLine(neighborStr);
        }
    }
}