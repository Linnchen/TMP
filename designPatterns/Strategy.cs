using System;
using System.Collections.Generic;
using System.Text;

namespace _15012020_design_patterns
{
    public interface IStrategy
    {
        string GetPath();
    
    }

    public class StrategyFirstFolder : IStrategy
    {
        public string GetPath()
        {
            return "first_folder\\1.txt";
        }
    }

    public class StrategySecondFolder : IStrategy
    {
        public string GetPath()
        {
            return "second_folder\\2.dat";
        }
    }

}
