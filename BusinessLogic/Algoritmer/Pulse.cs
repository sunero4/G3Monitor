﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        private double _lastPulse;
        public int TimeDifferences(List<double> data)
        {
            var times = Times(data);

            var differences = new List<double>();

            //var oldDifference = 0;
            for (int i = 1; i < times.Count; i++)
            {
                var diff = times[i] - times[i - 1];
                differences.Add(diff);
            }
            double averageDifference;

            if (differences.Count == 0)
            {
                averageDifference = _lastPulse;
            }
            else
            {
                averageDifference = differences.Average();
            }

            _lastPulse = averageDifference;

            return Convert.ToInt32(averageDifference);
        }


        public List<int> Times(List<double> values)
        {
            var peaks = new List<int>();
            var count = 0;
            var threshold = values.Max() * 0.8;

            for (int i = 20; i < values.Count - 20; i += 20)
            {
                if (values[i] > threshold && i >= 20)
                {
                    if (values[i] > values[i - 20] && values[i] > values[i + 20])
                    {
                        peaks.Add(i);
                    }
                }
            }

            return peaks;
            //var rangeOfPeaks = 20;

            //List<int> peaks = new List<int>();
            //double current;
            //List<double> range;
            //var beforeCount = 0;
            //var afterCount = 0;


            //int checksOnEachSide = rangeOfPeaks / 2;
            //for (int i = 0; i < values.Count; i++)
            //{
            //    current = values[i];
            //    range = values;

            //    if (i > checksOnEachSide)
            //    {
            //        range = range.Skip(i - checksOnEachSide).ToList();
            //        for (int j = 10; j < 0; j--)
            //        {
            //            if (range[i - j] < range[i])
            //            {
            //                beforeCount++;
            //            }
            //        }
            //    }

            //    range = range.Take(rangeOfPeaks).ToList();
            //    if ((range.Count() > 0) && (current == range.Max()))
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            if (range[i] > range[checksOnEachSide + j])
            //            {
            //                afterCount++;
            //            }
            //        }
            //    }

            //    if (beforeCount == 10 && afterCount == 10)
            //    {
            //        peaks.Add(i);
            //    }
            //}

            //return peaks;
            ////var tempList = new List<MaxValue>();
            ////var superMegaList = new List<List<MaxValue>>();

            //var tempList = new List<double>();
            //var superMegaList = new List<List<double>>();

            //var threshold = btList.Max() * 0.8;

            //for (int i = 0, n = btList.Count; i < n; i++)
            //{
            //    if (btList[i] > threshold)
            //    {
            //        //var value = new MaxValue()
            //        //{
            //        //    Index = i,
            //        //    Value = btList[i]
            //        //};
            //        tempList.Add(btList[i]);
            //    }
            //    if (btList[i] < threshold)
            //    {
            //        if (tempList.Count > 0)
            //        {
            //            List<double> temp = CopyList(tempList);
            //            superMegaList.Add(temp);
            //            tempList.Clear();
            //        }
            //    }
            //}


            //double sum = 0;
            //int indexsum = 0;

            //double max = 0;



            //var times = superMegaList.Select(x => x.IndexOf(x.Max())).ToList();

            //foreach (var list in superMegaList)
            //{
            //    var tempmax = list.Max();

            //    var index = btList.IndexOf(tempmax);
            //    times.Add(index);
            //    //  var test = list.Select(x => list.IndexOf(x.Value == ))
            //}

            //return times;
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

        private List<double> CopyList(List<double> list)
        {
            List<double> newList = new List<double>();
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
