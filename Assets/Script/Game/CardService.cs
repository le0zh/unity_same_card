using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CardService
{
    // 目前共有5种卡片，就使用 0 - 4标识

    /// <summary>
    /// 随机生成卡片id的列表
    /// </summary>
    /// <param name="size">列表大小，最小是5</param>
    /// <returns></returns>
    public static List<int> GetQuestions(int size)
    {
        if (size < 5)
        {
            throw new ArgumentException("size should be greater than 5");
        }

        var result = new int[size];

        Random r = new Random(DateTime.Now.Millisecond);
        for (var i = 0; i < size; i++)
        {
            // The Next(Int32, Int32) overload returns random integers that range from minValue to maxValue – 1.
            result[i] = (r.Next(0, 5));
        }

        // 再次打乱
        result = fishShuffle(result);

        return result.ToList();
    }

    private static int[] fishShuffle(int[] inputs)
    {
        var shuffed = inputs;
        Random r = new Random(DateTime.Now.Millisecond);

        for (var i = inputs.Length - 1; i >= 0; i--)
        {
            var j = r.Next(0, i);

            var tmp = shuffed[i];
            shuffed[i] = shuffed[j];
            shuffed[j] = tmp;
        }

        return shuffed;
    }
}