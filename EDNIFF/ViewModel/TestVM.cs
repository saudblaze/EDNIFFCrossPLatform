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
        public string Id { get; set; }
        public string LableId { get; set; }
        public string TestName { get; set; }
        public string TestLable { get; set; }
        public string TestResultLable { get; set; }
        public bool TestDone { get; set; }
        public bool TestSelected { get; set; }
        public int TestIndex { get; set; }
    }

    public class MainSaveMethodParam
    {
        public List<TestList> TestList { get; set; }
        public bool IsTestDone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
