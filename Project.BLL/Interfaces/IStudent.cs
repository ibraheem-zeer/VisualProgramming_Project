using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    internal interface IStudent
    {
        void Login(string Email, string Password);
        void Enroll(int id);
        void DoExam(int id);
        int SeeResult(int id);
    }
}
