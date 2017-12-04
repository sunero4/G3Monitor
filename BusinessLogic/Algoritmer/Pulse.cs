using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Accord.Math.Transforms;

namespace BusinessLogic
{
    public class Pulse:IPulse
    {
        public int TimeDifferences(List<double> data)
        {
            var times = Times(data);

            var differences = new List<double>();
            double oldDifference = 0;

            for (int i = 0; i < times.Count; i++)
            {
                var diff = times[i] - oldDifference;
                differences.Add(diff);
                oldDifference = times[i];
            }
            var averageDifference = differences.Average();

            return Convert.ToInt32(averageDifference);
        }


        public List<int> Times(List<double> btList)
        {
            var times = new List<int>();
            var tempList = new List<MaxValue>();
            var superMegaList = new List<List<MaxValue>>();
            var threshold = btList.Max() * 0.8;

            for (int i = 0, n = btList.Count; i < n; i++)
            {
                if (btList[i] > threshold)
                {
                    var value = new MaxValue()
                    {
                        Index = i,
                        Value = btList[i]
                    };
                    tempList.Add(value);
                }
                if (btList[i] < threshold)
                {
                    if (tempList.Count > 0)
                    {
                        List<MaxValue> temp = CopyList(tempList);
                        superMegaList.Add(temp);
                        tempList.Clear();
                    }
                }
            }


            double sum = 0;
            int indexsum = 0;

            for (int i = 0; i < superMegaList.Count; i++)
            {
                foreach (var value in superMegaList[i])
                {
                    sum += value.Value;
                    indexsum += value.Index;
                }

                var temp = new MaxValue()
                {
                    Value = sum / superMegaList[i].Count,
                    Index = indexsum / superMegaList[i].Count
                };

                times.Add(temp.Index);
            }

            return times;
        }

       

        //public List<int> Times(List<double> btList)
        //{
        //    var threshold = btList.Max() * 0.8;
        //    var temp = new MaxValue();
        //    var tempList = new List<MaxValue>();
        //    var superMegaList = new List<List<MaxValue>>();

        //    for (int i = 0, n = btList.Count; i < n; i++)
        //    {
        //        if (btList[i] > threshold)
        //        {
        //            temp = new MaxValue()
        //            {
        //                Index = i,
        //                Value = btList[i]
        //            };
        //            tempList.Add(temp);
        //        }
        //        if (btList[i] < threshold)
        //        {
        //            if (tempList.Count > 0)
        //            {
        //                superMegaList.Add(tempList);
        //                tempList.Clear();
        //            }
        //        }
        //    }

        //    var times = new List<int>();
        //    foreach (var list in superMegaList)
        //    {
        //        times.Add(list.IndexOf(list.Max()));
        //    }
        //    return times;
        //}


        //double max = 0;
            //var threshold = btList.Max() * 0.8;
            //List<int> times = new List<int>();

            //for (int i = 1; i < btList.Count - 1; i++)
            //{
            //    //if (btList[i] <= btList[i + 1])
            //    //{
            //    //    max = btList[i + 1];
            //    //}
            //    //if (max == btList[i] && max > btList[i + 1])
            //    //{
            //    //    times.Add(i);
            //    //}

            //    if (btList[i] > btList[i + 1] && btList[i] > threshold && btList[i] > btList[i - 1])
            //    {
            //        times.Add(i);
            //    }
            //}
            //return times;

        public double Calculate(List<double> btList)
        {
            double pulse = 0;
            var diff = TimeDifferences(btList);

            if (diff != 0)
            {
                pulse = 60000 / diff; // 60000 sample divideret med den gennemsnitlige tidsforskel mellem toppunkterne og derefter dividere vi med en faktor 1000, da der er 1000 sample pr. sekund. 
            }
            
            return pulse;

        }

        private List<MaxValue> CopyList(List<MaxValue> list)
        {
            List<MaxValue> newList = new List<MaxValue>();
            foreach (var x in list)
            {
                newList.Add(x);
            }
            return newList;
        }
    }

    

    public class MaxValue
    {
        public double Value { get; set; }
        public int Index { get; set; }
    }
}
