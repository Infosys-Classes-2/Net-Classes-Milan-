//using hrm.applicatoncore.models;
//using hrm.web.viewmodels;

//namespace hrm.web.mapper
//{
//    public static class designationmapper
//    {
//        // 1 ta designatinon ko lagi matra ho
//        // model lai viewmodel ma bind gareko
//        public static designationviewmodel toviewmodel(this designation designation)
//        {
//            // designation viewmodel ko naya instance banaune

//            designationviewmodel designationviewmodel = new()
//            {

//                id = designation.id,
//                title = designation.title,
//                description=designation.description,
//                category = designation.category,
//            };

//            // return chai naya object lai garne
//            return  designationviewmodel;
//        }


//       // view model bata aauune data lai model ma bind gareko
//        public static designation tomodel(designationviewmodel designationviewmodel)
//        {
//            designation desiganiton = new()
//            {
//                id= designationviewmodel.id,
//                title = designationviewmodel.title,
//                description = designationviewmodel.description,
//                category = designationviewmodel.category
               
//            };
//            return desiganiton;
//        }

//        // model to viewmodel
//        public static list<designationviewmodel> toviewmodel(this list<designation> designations)
//        {
//            // var employeeviewmodels = employees.select(x => toviewmodel(x)).tolist();
//            var designationviewmodels = designations.select(x => toviewmodel(x)).tolist();
//            return designationviewmodels;
//        }

//        // view model to model
//        public static list<designation> tomodel(this list<designationviewmodel> desinationviewmodel)
//        {
//            var designation = desinationviewmodel.select(x => tomodel(x)).tolist();
//            return designation;
//        }

//    }

//}
