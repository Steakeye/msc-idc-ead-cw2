using CourseGradeEstimator.core.view.Create;
using System;
using System.Collections;


namespace CourseGradeEstimator.routes.CreateAssignment
{
    class CreateAssignmentController : core.view.ViewController<CreateAssignment>
    {
        public CreateAssignmentController(Router r) : base(r) {
            view = new CreateAssignment();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));

            view.BindDelegates();
        }

    }
}
