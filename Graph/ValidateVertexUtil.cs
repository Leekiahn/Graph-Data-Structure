namespace Graph;

public class ValidateVertexUtil
{
    // 두 인덱스 유효성 검사 메서드
    public static void Validate(int size, int from, int to)
    {
        if (from < 0 || from >= size || to < 0 || to >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }
    }
    
    // 단일 인덱스 유효성 검사 메서드
    public static void Validate(int size, int vertex)
    {
        if (vertex < 0 || vertex >= size)
        {
            throw new ArgumentOutOfRangeException("노드가 범위를 벗어났습니다.");
        }
    }
}