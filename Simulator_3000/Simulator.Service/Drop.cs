using System;
using System.Collections.Generic;
using System.Linq;

namespace Simulator.Service
{
    public class Drop
    {
        List<TypeOfValue> _type;
        List<Data> _values;

        public string Type { get; set; }
        public string Value { get; set; }
        public string ValueID { get; set; }

        public Drop(List<TypeOfValue> type, List<Data> values, int chanceType, int chanceValue)
        {
            _type = type;
            _values = values;
            Type = GetTypeOfResource(chanceType);
            Value = GetValueOfResource(Type, chanceValue);
        }

        string GetTypeOfResource(int chanceType)
        {
            var rnd =chanceType;
            var sum = default(double);
            for (int i = 0; i < _type.Count; i++)
            {
                sum += Double.Parse(_type[i].Percent);
                if (rnd < sum)
                    return _type[i].Name;
            }
            return _type[_type.Count-1].Name;
        }

        string GetValueOfResource(string name, int chanceValue)
        {
            if (name != "Blueprints")
            {
                var values = _values
                    .Where(c => c.Name == name)
                    .Select(c => c)
                    ;
                var valueList = new List<Data>(values);
                var rnd = chanceValue;
                var sum = default(double);

                for (int i = 0; i < valueList.Count; i++)
                {
                    sum += Double.Parse(valueList[i].Percent)*100;
                    if (rnd < (int)sum)
                    {
                        ValueID = valueList[i].Value;
                        return valueList[i].Value;
                    }
                }
                ValueID = valueList[valueList.Count - 1].ID;
                return valueList[valueList.Count - 1].Value;
            }
            else
                return "1";
        }
    }
}
