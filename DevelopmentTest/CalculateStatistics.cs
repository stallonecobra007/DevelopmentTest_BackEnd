using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentTest
{
    public class CalculateStatistics : ICalculateStatistics
    {
        public double Mean(string values)
        {
            var updatedValues = convertStringToList(values);

            return updatedValues.Average();
        }

        public double Median(string values)
        {
            var updatedValues = convertStringToList(values);
            var count = updatedValues.Count();
            var orderedNum = updatedValues.OrderBy(x => x);
            var midPoint = updatedValues.Count() / 2;

            //Determine if it is even or not
            if (count % 2 == 0)
            {
                return (orderedNum.ElementAt(midPoint) + orderedNum.ElementAt(midPoint - 1)) / 2;
            }
            else
            {
                return orderedNum.ElementAt(midPoint);
            }
        }

        public string Mode(string values)
        {
            var updatedValues = convertStringToList(values);

            var modeDict = new Dictionary<double, int>();
            var modalValues = new List<int>();
            string updatedModalList;
            foreach (var num in updatedValues)
            {
                var count = updatedValues.ToList().Where(x => x == num).Count();
                if (!modeDict.ContainsKey(num))
                    modeDict.Add(num, count);
            }

            var highestValInDictionary = modeDict.Values.Max();

            if (highestValInDictionary > 1)
            {
                foreach (var x in modeDict)
                {
                    if (x.Value == highestValInDictionary)
                    {
                        modalValues.Add((int)x.Key);
                    }
                }
                updatedModalList = string.Join(",", modalValues);
                return updatedModalList;
            }
            else
                return "There is no mode for this list";
        }

        private List<double> convertStringToList(string culprit)
        {
            var updatedValues = new List<double>();

            int val = 0;
            var stringList = culprit.Split(',')
                                .Where(m => int.TryParse(m, out val))
                                .Select(m => int.Parse(m))
                                .ToList();
               
            stringList.ForEach(str => updatedValues.Add(str));
            return updatedValues;

        }
    }
}
