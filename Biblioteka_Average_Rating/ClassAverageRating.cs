using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteka_Average_Rating
{
    public class ClassAverageRating
    {
        public static List<People> people = BD_Student_Discipline.Peoples();
        public static List<Discipline> disciplines =  BD_Student_Discipline.Disciplines();
        public static  double MethodRating(int idStud, DateTime DateStart, DateTime DateEnd, int idDiscipline)
        {
            if ((idStud > 0 && idDiscipline > 0)==false)
            {
                return -1;
            }
            if (DateStart<DateEnd==false)
            {
                return -1;
            }
            if(people.Any(x=>x.id==idStud && disciplines.Any(x=>x.id==idDiscipline && x.IdStud == idStud))==false)
            {
                return -1;
            }
            int Summ_Ozenok = 0;
            int col_Ozenok = 0;
            foreach (var item in disciplines)
            {
                if (item.id == idDiscipline && item.IdStud == idStud)
                {
                    if(item.date < DateEnd && DateStart <= item.date)
                    {
                        Summ_Ozenok = Summ_Ozenok + item.Ozenka;
                        col_Ozenok = col_Ozenok + 1;
                    } 
                }
            }
            if(Summ_Ozenok==0)
            {
                return -1; 
            }
            double otvet = Summ_Ozenok / col_Ozenok;
            return  otvet;
        }
    }
}
