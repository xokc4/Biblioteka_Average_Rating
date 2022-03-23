using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Average_Rating
{
    class BD_Student_Discipline
    {
        public static List<Discipline> Disciplines()
        {
            List<Discipline> discipline = new List<Discipline>()
            {
                new Discipline(){IdStud=1, id=1, Name="Mathit", Ozenka=4, date= new DateTime(2021,01,01, 15,05,00) },
                new Discipline(){IdStud=1, id=2, Name="Histori", Ozenka=5, date= new DateTime(2021,01,01, 12,05,00) },
                new Discipline(){IdStud=1, id=3, Name="Russki", Ozenka=3, date= new DateTime(2021,03,02, 13,05,00) },
                new Discipline(){IdStud=1, id=1, Name="Mathit", Ozenka=2, date= new DateTime(2021,02,02, 13,05,00) },
                new Discipline(){IdStud=3, id=2, Name="Histori", Ozenka=3, date= new DateTime(2021,02,01, 10,05,00) },
                new Discipline(){IdStud=3, id=3, Name="Russki", Ozenka=5, date= new DateTime(2021,03,01, 14,05,00 ) },
                new Discipline(){IdStud=2, id=2, Name="Histori", Ozenka=2, date= new DateTime(2021,02,18, 12,05,00 ) },
                new Discipline(){IdStud=2, id=1, Name="Mathit", Ozenka=5, date= new DateTime(2021,03,04, 9,05,00 ) },
                new Discipline(){IdStud=3, id=1, Name="Mathit", Ozenka=5, date= new DateTime(2021,02,04, 7,05,00 ) },
                new Discipline(){IdStud=1, id=3, Name="Russki", Ozenka=4, date= new DateTime(2021,03,05, 7,05,00 ) },
                new Discipline(){IdStud=2, id=3, Name="Russki", Ozenka=3, date= new DateTime(2021,02,02, 9,05,00 ) },
                new Discipline(){IdStud=3, id=2, Name="Histori", Ozenka=2, date= new DateTime(2021,02,05, 10,05,00 ) },
                new Discipline(){IdStud=2, id=2, Name="Histori", Ozenka=3, date= new DateTime(2021,03,02, 13,05,00 ) },
                new Discipline(){IdStud=2, id=1, Name="Mathit", Ozenka=5, date= new DateTime(2021,03,03, 16,05,00 )  },
                new Discipline(){IdStud=3, id=1, Name="Mathit", Ozenka=4, date= new DateTime(2021,03,01, 11,05,00 ) },
                new Discipline(){IdStud=1, id=3, Name="Russki", Ozenka=3, date= new DateTime(2021,01,04, 9,05,00 ) },
                new Discipline(){IdStud=3, id=3, Name="Russki", Ozenka=5, date= new DateTime(2021,02,07, 8,05,00 ) },
                new Discipline(){IdStud=2, id=3, Name="Russki", Ozenka=4, date= new DateTime(2021,02,01, 8,05,00 ) },
            };
            return discipline;

        }
        public static List<People> Peoples()
        {
            List<People> people = new List<People>()
            {
                new People(){id=1, Name="1 студент" },
                new People(){id=2, Name="2 студент" },
                new People(){id=3, Name="3 студент" },
            };
            return people;
        }
    }
}
