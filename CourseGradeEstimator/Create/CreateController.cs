﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.Create
{
    class CreateController : core.ViewController<CreateView>
    {
        public CreateController(Router r): base(r) {
            view = new CreateView();
        }
    }
}
