using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Exam
    {
        public string Theme { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam(string theme, int days)
        {
            Theme = theme;
            ExamDate = DateTime.Now.AddDays(days);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public string GetTheme()
        {
            return this.Theme;
        }

        public string ToString()
        {
            return "Theme";
        }
    }
}
