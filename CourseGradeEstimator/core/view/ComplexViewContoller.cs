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
    public delegate bool ItemFinder<D>(D item);
    public delegate string[] ItemToStringArray<D>(D item);

    abstract public class ComplexViewController<V>: ViewController<V>
    {
        protected ComplexViewController(Router r) : base(r)
        {

        }

        protected static D findItemByCode<D>(List<D> items, string code)
        {
            Predicate<D> moduleFinder = (D item) => { return (item as CourseItem).Code == code; };

            return items.Find(moduleFinder);
        }

        protected static string[][] getChildItemViewData<D>(List<D> items, ItemToStringArray<D> translator)
        {

            string[][] data = null;

            if (items != null && items.Count > 0)
                {
                    data = items.Select(item => translator(item)).ToArray();
                }

            return data;
        }

        protected static bool confirmDelete()
        {
            string title = String.Format(Properties.Resources.StringsConfrimAction, Properties.Resources.StringsDelete);
            DialogResult deleteAnswer = MessageBox.Show(Properties.Resources.StringsDeleteMessage, title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            return deleteAnswer == DialogResult.Yes;
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
