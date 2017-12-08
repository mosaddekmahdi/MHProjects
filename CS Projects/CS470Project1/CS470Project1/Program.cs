using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS470Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = 0;

            var allWeights = new List<int>();
            var allValues = new List<int>();
            var allUpperBounds = new List<int>();
            var allTypes = new List<int>();

            var intWeights = new List<int>();
            var intValues = new List<int>();
            var intUpperBounds = new List<int>();
            var index = 0;

            var inputItem = ProcessInputFile(args[0]);
            allWeights = inputItem.Weights;
            allValues = inputItem.Values;
            allUpperBounds = inputItem.UpperBounds;
            allTypes = inputItem.IsFractional;
            capacity = inputItem.Capacity;

            foreach (var item in allWeights)
            {
                if (allTypes[index] == 0)
                {
                    intWeights.Add(item);
                    intValues.Add(allValues[index]);
                    intUpperBounds.Add(allUpperBounds[index]);
                }
                index++;
            }

            var processedItems = PreprocessItems(intWeights.ToArray(), intValues.ToArray(), intUpperBounds.ToArray(), capacity);

            var weights = new List<int>();
            var values = new List<int>();
            foreach (var item in processedItems)
            {
                weights.Add(item.Weight);
                values.Add(item.Value);
            }

            var cost = IntegerKnapsack(capacity, weights.ToArray(), values.ToArray(), values.Count);

            var resultItems = new List<ResultItem>();

            index = 0;
            foreach (var item in allWeights)
            {
                resultItems.Add(new ResultItem() { 
                    AmountTaken = 0.0, 
                    ItemId = index, 
                    Value = allValues[index], 
                    Weight = allWeights[index], 
                    IsContinuous = (allTypes[index] == 1 ? true: false),
                    UpperBound = allUpperBounds[index]
                });
                index++;
            }

            CombineSolutions(cost, capacity, resultItems, processedItems.Length - 1, processedItems, args[1]);
        }

        public static void CombineSolutions(int[,] cost, int M, List<ResultItem> items, int intCount, Item[] processedInts, string outputPath)
        {
            var intWeights = new List<int>();
            var intValues = new List<int>();
            var intUpperbounds = new List<int>();
            var fracWeights = new List<int>();
            var fracValues = new List<int>();
            var fracUpperbounds = new List<int>();
            var allWeights = new List<int>();
            var allValues = new List<int>();
            var allUpperbounds = new List<int>();
            foreach (var item in items)
            {
                if (item.IsContinuous)
                {
                    fracWeights.Add((int)item.Weight);
                    fracValues.Add((int)item.Value);
                    fracUpperbounds.Add(item.UpperBound);
                }
                else
                {
                    intWeights.Add((int)item.Weight);
                    intValues.Add((int)item.Value);
                    intUpperbounds.Add((int)item.UpperBound);
                }
                allWeights.Add((int)item.Weight);
                allValues.Add((int)item.Value);
                allUpperbounds.Add(item.UpperBound);
            }
            if (cost.Length > 0)
            {
                var pWeights = new List<int>();
                var pValues = new List<int>();
                foreach (var item in processedInts)
                {
                    pWeights.Add(item.Weight);
                    pValues.Add(item.Value);
                }

                double maxSol = -1;
                var results = new List<ResultItem>();
                for (var i = 0; i <= M; ++i)
                {
                    var usedItems = FindItemsUsed(pWeights.ToArray(), cost, i);
                    items = UpdateAmountsOfItemsUsed(usedItems, pWeights.ToArray(), pValues.ToArray(), items);

                    double totalWeight = 0;
                    var index = 0;
                    foreach (var item in items)
                    {
                        if (!item.IsContinuous && item.AmountTaken > 0)
                        {
                            totalWeight += allWeights[item.ItemId] * item.AmountTaken;
                        }
                        index++;
                    }
                    var temp = 0.0;

                    if (M - totalWeight > 0)
                    {
                        var fracResult = FractionalKnapsack2(M - totalWeight, fracWeights.ToArray(), fracValues.ToArray(), fracUpperbounds.ToArray());
                        items = FindFracItemsUsed(fracResult, allWeights.ToArray(), fracWeights.ToArray(), allValues.ToArray(), fracValues.ToArray(), items);
                        for (var j = 0; j < fracResult.Length; ++j)
                        {
                            temp += fracValues[j] * fracResult[j];
                        }
                    }
                    if ((temp + cost[intCount, i]) > maxSol)
                    {
                        maxSol = temp + cost[intCount, i];
                        results = new List<ResultItem>();
                        foreach (var item in items) 
                            results.Add(new ResultItem() 
                            { 
                                AmountTaken = item.AmountTaken, 
                                IsContinuous = item.IsContinuous, 
                                ItemId = item.ItemId, 
                                UpperBound = item.UpperBound, 
                                Value = item.Value, 
                                Weight = item.Weight 
                            });
                    }
                }
                var amountsTaken = new List<double>();
                foreach (var item in results) amountsTaken.Add(item.AmountTaken);
                WriteOutputFile(outputPath, amountsTaken.ToArray(), maxSol);
            }
            else
            {
                var fracResult = FractionalKnapsack2(M, fracWeights.ToArray(), fracValues.ToArray(), fracUpperbounds.ToArray());
                double maxSol = 0;
                for (var i = 0; i < fracResult.Length; ++i)
                {
                    maxSol += fracValues[i] * fracResult[i];
                }
                WriteOutputFile(outputPath, fracResult, maxSol);
            }
        }

        public static List<ResultItem> FindFracItemsUsed(double[] FracResult, int[] allWeights, int[] fracWeights, int[] allValues, int[] fracValues, List<ResultItem> items)
        {
            foreach (var item in items) if (item.IsContinuous) item.AmountTaken = 0;
            var index = 0;
            foreach (var item in FracResult)
            {
                if (item != 0)
                {
                    for (int i = 0; i < allWeights.Length; ++i)
                    {
                        if (allWeights[i] == fracWeights[index] && allValues[i] == fracValues[index])
                        {
                            items[i].AmountTaken = item;
                        }
                    }
                }
                index++;
            }
            return items;
        }

        public static InputItem ProcessInputFile(string inputPath)
        {
            var result = new InputItem();
            var inputArray = System.IO.File.ReadAllLines(inputPath);
            var isFirst = true;
            foreach(var item in inputArray)
            {
                var lineArray = item.Split(new Char[2] { '\t', ' '});
                if (isFirst)
                {
                    result.Capacity = Convert.ToInt32(lineArray[1]);
                    isFirst = false;
                    continue;
                }
                result.Weights.Add(Convert.ToInt32(lineArray[1]));
                result.Values.Add(Convert.ToInt32(lineArray[0]));
                result.UpperBounds.Add(Convert.ToInt32(lineArray[2]));
                if (lineArray[3] == "C") result.IsFractional.Add(1);
                else result.IsFractional.Add(0);
            }
            
            return result;
        }

        public static void WriteOutputFile(string outputPath, double[] results, double totalValue)
        {
            var sb = new StringBuilder();
            sb.AppendLine(totalValue.ToString());
            foreach (var item in results)
            {
                sb.AppendLine(item.ToString());
            }
            System.IO.File.WriteAllText(outputPath, sb.ToString());
        }

        public static Item[] PreprocessItems(int[] weights, int[] values, int[] upperBounds, int capacity)
        {
            var itemsList = new List<Item>();
            var index = 0;
            foreach (var u in upperBounds)
            {
                if (u == -1)
                {
                    var actualUpperBound = (capacity / weights[index]) + 1;
                    for (var i = 0; i < actualUpperBound; ++i)
                    {
                        itemsList.Add(new Item(weights[index], values[index]));
                    }
                }
                else
                {
                    for (var i = 0; i < u; ++i)
                    {
                        itemsList.Add(new Item(weights[index], values[index]));
                    }
                }
                index++;
            }
            return itemsList.ToArray();
        }

        public static int[,] IntegerKnapsack(int M, int[] w, int[] v, int n)
        {
            int[,] cost = new int[v.Length, M + 1];
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j <= M; ++j)
                {
                    if (i == 0 && w[i] <= j)
                    {
                        cost[i, j] = v[i];
                    }
                    else if (i > 0 && w[i] > j)
                    {
                        cost[i, j] = cost[i - 1, j];                        
                    }
                    else if (i > 0 && w[i] <= j)
                    {
                        var a = cost[i - 1, j];
                        var b = v[i] + cost[i - 1, j - w[i]];
                        cost[i, j] = Math.Max(a, b);
                    }
                }
            }
            return cost;
        }

        public static int[] FindItemsUsed(int[] w, int[,] cost, int M)
        {
            var i = w.Length - 1;
            var capacity = M;
            var itmesUsed = new int[i + 1];
            while (i >= 0 && capacity >= 0)
            {
                if (cost[i, capacity] != 0)
                {
                    if (i == 0 && cost[i, capacity] > 0 || cost[i, capacity] != cost[i - 1, capacity])
                    {
                        itmesUsed[i] = 1;
                        capacity -= w[i];
                    }
                }
		        i--;
            }
            return itmesUsed;
        }

        public static List<ResultItem> UpdateAmountsOfItemsUsed(int[] usedI, int[] intWeights, int[] intValues, List<ResultItem> items)
        {
            foreach (var item in items) if (!item.IsContinuous) item.AmountTaken = 0;

            var index = 0;
            foreach (var item in usedI)
            {
                if (item == 1)
                {
                    var weight = intWeights[index];
                    var value = intValues[index];
                    for (var i = 0; i < items.Count; ++i)
                    {
                        if (items[i].Weight == weight && items[i].Value == value)
                        {
                            items[i].AmountTaken++;
                        }
                    }
                }
                //items.First(w => w.Weight == intWeights[index]);
                index++;
            }
            return items;
        }

        public static double[] FractionalKnapsack2(double M, int[] weights, int[] values, int[] upperbounds)
        {
            var results = new double[weights.Length];
            if (weights.Length > 0)
            {
                var ratios = new RatioItem[weights.Length];
                for (var i = 0; i < weights.Length; ++i)
                {
                    ratios[i] = new RatioItem() { Ratio = (values[i] / (double)weights[i]), Index = i, Value = values[i], Weight = weights[i] };
                }

                ratios = ratios.OrderByDescending(r => r.Ratio).ToArray();

                int index = 0;
                while (M > 0 && index < ratios.Count())
                {
                    int uB = upperbounds[ratios[index].Index];
                    //We should never get into this if condition because we have
                    //run the integer knapsack on everything prior to this step.
                    if (M >= ratios[index].Weight)
                    {
                        if (uB == -1)
                        {
                            results[ratios[index].Index] = M / Convert.ToDouble(ratios[index].Weight);
                            break;
                        }
                        else
                        {
                            while (uB != 0 && M > 0)
                            {
                                if (M >= ratios[index].Weight)
                                {
                                    M = Convert.ToInt32(M - (1 * ratios[index].Weight));
                                    results[ratios[index].Index] += 1;
                                    uB--;
                                }
                                else
                                {
                                    results[ratios[index].Index] += M / Convert.ToDouble(ratios[index].Weight);
                                    M = Convert.ToInt32(M - (results[ratios[index].Index] * ratios[index].Weight));
                                    break;
                                }
                            }
                        }
                        //results[ratios[index].Index] = 1;
                        //M = (int)(M - (1 * ratios[index].Weight));
                    }
                    else if (uB > 0 || uB == -1)
                    {
                        results[ratios[index].Index] = M / Convert.ToDouble(ratios[index].Weight);
                        M = Convert.ToInt32(M - (results[ratios[index].Index] * ratios[index].Weight));
                    }
                    index++;
                }
                //I am returning a list that lets me know what Items I used and how much I used of them. 
            }
            return results;
        }
    }
}
