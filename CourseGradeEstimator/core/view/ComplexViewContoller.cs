using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.interfaces;
using CourseGradeEstimator.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view
{

    abstract public class ComplexViewController<V>: ViewController<V>
    {
        protected ComplexViewController(Router r) : base(r)
        {

        }
        protected static void sPopulateView<H, C, B>(Complex<H, C, B> view, CourseItem item, List<CourseItem> childItems)
        {

            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            if (childItems != null && childItems.Count > 0)
            {
                string[][] data;

                data = childItems.Select(assignment => {
                    return new string[] { assignment.Title, assignment.Description, assignment.Code };
                }).ToArray();

                view.SetChildItems(data);
            }
        }

    }
}
