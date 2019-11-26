using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSubject
{
     abstract class Abstract
    {
        private bool isDone = false;

        protected abstract void Init();
        protected abstract void Do();
        protected abstract void Finish();

        protected void SetDone()
        {
            isDone = true;
        }
        protected void ResetDone()
        {
            isDone = false;
        }
        protected bool GetDoneState()
        {
            return isDone;
        }
        public void Run()
        {
            Init();
            while (!GetDoneState())
                Do();
            Finish();
        }
    }
}
