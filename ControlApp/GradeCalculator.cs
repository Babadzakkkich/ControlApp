using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp
{
    public class GradeCalculator
    {
        public static (int totalScore, string grade) CalculateGrade(int module1Score, int module2Score, int module3Score)
        {
            if (module1Score < 0 || module1Score > 22 ||
                module2Score < 0 || module2Score > 38 ||
                module3Score < 0 || module3Score > 20)
            {
                throw new ArgumentOutOfRangeException("Баллы должны быть в пределах:\nМодуль 1: 0-22\nМодуль 2: 0-38\nМодуль 3: 0-20");
            }

            int totalScore = module1Score + module2Score + module3Score;

            string grade;
            if (totalScore >= 56 && totalScore <= 80)
                grade = "5 (отлично)";
            else if (totalScore >= 32 && totalScore <= 55)
                grade = "4 (хорошо)";
            else if (totalScore >= 16 && totalScore <= 31)
                grade = "3 (удовлетворительно)";
            else
                grade = "2 (неудовлетворительно)";

            return (totalScore, grade);
        }
    }
}
