namespace Algorithms;

public static class Graphs
{
    public static bool BFS(Dictionary<string, string[]> dict, string start)
    {
        var queue = new Queue<string>();
        var selected = new HashSet<string>();
        dict[start].ToList().ForEach(x => queue.Enqueue(x));

        while (queue.TryDequeue(out var key))
        {
            if (key.EndsWith("m"))
                return true;
            
            if(!selected.Add(key))
                continue;

            dict[key].ToList().ForEach(x => queue.Enqueue(x));
        }

        return false;
    }
    
    public static bool DFS(Dictionary<string, string[]> dict, string start)
    {
        var stack = new Stack<string>();
        var selected = new HashSet<string>();
        dict[start].ToList().ForEach(x => stack.Push(x));

        while (stack.TryPop(out var key))
        {
            if (key.EndsWith("m"))
                return true;
            
            if(!selected.Add(key))
                continue;
            
            dict[key].ToList().ForEach(x => stack.Push(x));
        }
        
        return false;
    }
    
    public static bool DFS_Recursive(Dictionary<string, string[]> dict, string start)
    {
        var selected = new HashSet<string>();

        return Internal(start);
        
        bool Internal(string key)
        {
            if (key.EndsWith("m"))
                return true;

            var result = false;
            foreach (var item in dict[key])
            {
                if(!selected.Add(item))
                    continue;
                
                result |= Internal(item);
            }

            return result;
        }
    }
}