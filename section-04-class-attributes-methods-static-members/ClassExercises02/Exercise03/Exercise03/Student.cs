using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise03
{
    internal class Student
    {
        public string Name;
        public double GradeOne, GradeTwo, GradeThree;

        public double FinalGrade()
        {
            return GradeOne + GradeTwo + GradeThree;
        }

        public string IsApproved()
        {
            double finalGrade = FinalGrade();

            if (finalGrade < 60)
                return "REPROVADO\nFALTARAM "
                    + (60.0 - finalGrade).ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            else
                return "APROVADO";
        }

        public override string ToString()
        {
            return "NOTA FINAL = "
                + FinalGrade().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + IsApproved();
        }
    }
}
