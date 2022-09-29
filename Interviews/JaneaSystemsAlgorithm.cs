namespace Interviews;

public class JaneaSystemsAlgorithm : IChallenge
{
//     
//     n choose k
//
//         a BridgerPay.b c d, n=4
//     k=2
//
//     ab
//         ac
//     ad
//         bc
//     bd
//         cd
//
//     ab=ba
//
//         k=3
//
//     abc
//         abd
//     acd
//         bcd
//
//
//     BridgerPay.a b c d e
//         abc
//     abd
//         abe
//     acd
//         ace
//     ade
//         bcd
//     bce
//         cde
//     k=3
//
//     for(var i = 0; i <= elems.Length - k; i++)
//     for 
//
//     base = ab
//     for i = k; i < length; i++
//     output = base + elems[i];
//
//     static string PCHelper(char [] elems, int k, string output, int start)
//     {
//         // break condition
//         if(output.Length == k)
//         {
//             Console.WriteLine(output);
//             return;
//         }
//   
//         for (int i = start; i < elems.Length; i++)
//         {
//             PCHelper(elems, k, output + elems[i], i + 1);
//         }
//
//     }
//
//     static void PrintCombinations(char [] elems, int k = 2)
//     {
//         PCHelper(elems, k, "", 0);
//     }
//
//
//     k=2
//
//     ab
//         ac
//     ad
//         bc
//     bd
//         cd
//
//     ab
//         ba
//
//     recursion

    public void Execute()
    {
        throw new NotImplementedException();
    }
}