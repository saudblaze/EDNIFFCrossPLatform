using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.ViewModel
{
    public class TestVM
    {
        public List<TestList> TestList { get; set; }        
    }
    public class TestList
    {
        //public string Id { get; set; }
        //public string LableId { get; set; }
        public string testName { get; set; }
        public string testLable { get; set; }
        public string testResultLable { get; set; }
        public bool testDone { get; set; }
        public bool testSelected { get; set; }
        public int testIndex { get; set; }
        public string testResult { get; set; }
        public string className { get; set; }

    }

    public class SetGrade
    {
        public string Grade { get; set; }
    }

    public class MainSaveMethodParam
    {
        public List<TestList> _listOfTest { get; set; }
        public bool IsTestDone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
