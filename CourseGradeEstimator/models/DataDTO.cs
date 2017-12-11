using Newtonsoft.Json;
using System;

namespace CourseGradeEstimator.models
{
    public class DataDTO<D, P, G>
        where D : CourseItem
        where P : CourseItem
        where G : GradeItem
    {

        public DataDTO() {
        }

        public D Data { get; set; }

        public P Parent { get; set; }

        public G Grade { get; set; }

    }
}
