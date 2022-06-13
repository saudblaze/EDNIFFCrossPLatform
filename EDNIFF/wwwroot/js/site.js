// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



var _objToBeSaved = {

    IsTestCompleted: false,
    _listOfTest: [],
    Grade: '',

}

var _listOfTest;
var _currentTest;

function testmethod() {
    alert('Display Report');
}


$("#AllSelect").change(function () {
    if (this.checked) {
        $("#chkCMOS").prop('checked', true);
        $("#chkSound").prop('checked', true);
        $("#chkUSB").prop('checked', true);
        $("#chkLanPort").prop('checked', true);
        $("#chkOptical").prop('checked', true);
        $("#chkLCD").prop('checked', true);
        $("#chkKeyboard").prop('checked', true);
        $("#chkTouchpad").prop('checked', true);
        $("#chkWifi").prop('checked', true);
        $("#chkBattery").prop('checked', true);
        $("#chkCamera").prop('checked', true);
        $("#chkTouchScreen").prop('checked', true);
        $("#chkMicrophone").prop('checked', true);
        $("#chkSDCard").prop('checked', true);
        $("#chkBiometric").prop('checked', true);
        $("#chkSmartCard").prop('checked', true);
        $("#chkDisplay").prop('checked', true);
        $("#chkPortTest").prop('checked', true);
    } else {
        $("#chkCMOS").prop('checked', false);
        $("#chkSound").prop('checked', false);
        $("#chkUSB").prop('checked', false);
        $("#chkLanPort").prop('checked', false);
        $("#chkOptical").prop('checked', false);
        $("#chkLCD").prop('checked', false);
        $("#chkKeyboard").prop('checked', false);
        $("#chkTouchpad").prop('checked', false);
        $("#chkWifi").prop('checked', false);
        $("#chkBattery").prop('checked', false);
        $("#chkCamera").prop('checked', false);
        $("#chkTouchScreen").prop('checked', false);
        $("#chkMicrophone").prop('checked', false);
        $("#chkSDCard").prop('checked', false);
        $("#chkBiometric").prop('checked', false);
        $("#chkSmartCard").prop('checked', false);
        $("#chkDisplay").prop('checked', false);
        $("#chkPortTest").prop('checked', false);
    }
});

$(".singleselect").change(function () {
    if (!this.checked) {
        $("#AllSelect").prop('checked', false);
    } else {
        var allCheckbox = false;
        $('.singleselect').each(function (index, obj) {
            if (this.checked === false) {
                allCheckbox = true;
            }
        });
        if (!allCheckbox) {
            $("#AllSelect").prop('checked', true);
        }
    }
});


function NextClick() {
    //check if current test is marked as complete than only check for next test
    if (_currentTest && _currentTest.testDone == true) {

        var NextTest = false;
        $.each(_listOfTest, function (index, item) {
            if (item.testSelected == true && item.testDone == false) {
                //bind this test in div
                _currentTest = item;
                NextTest = true;
                return false;
            }
        });
        if (!NextTest) {
            _objToBeSaved._listOfTest = _listOfTest;
            _objToBeSaved.IsTestCompleted = true;
            //here need to update MacInfo.IsTestCompleted
            var mobject = {
                IsTestCompleted: _objToBeSaved.IsTestCompleted,
                TestList: _objToBeSaved._listOfTest,
            }
            $.ajax({
                type: 'POST',
                url: '/Tests/SetTestDone',
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                data: mobject,
                //async:false,
                success: function (result) {
                    if (result.isSuccess == 1) {
                        
                    } else {
                        alert('Failed to receive the Data');
                    }
                },
                error: function () {
                    alert('Failed to receive the Data');
                    console.log('Failed ');
                }
            })
            alert("test completed");
        } else {
            GetTestHtml();
            $("#lbl" + _currentTest.testName).text("Running");
            $("#lblResult" + _currentTest.testName).text("Not Tested");
        }


    } else {
        alert("Please complete " + _currentTest.testLable);
    }


}


function StartTest(obj, isAllSelected) {
    _listOfTest = obj.testList;
    _objToBeSaved.Grade = obj.grade; // 
    _objToBeSaved.IsTestCompleted

    var isAnyTest = false;
    if (isAllSelected) {
        //get cmos test
        var temp = _listOfTest.filter(obj => {
            return obj.testName === "CMOS"
        });
        if (temp && temp[0]) {
            _currentTest = temp[0];
        }
        isAnyTest = true;

    } else {
        //check for first selected test and TestDone = false 

        $.each(_listOfTest, function (index, item) {
            if (item.testSelected == true && item.testDone == false && isAnyTest == false) {
                //call ajax and bind this test in div                 
                _currentTest = item;
                isAnyTest = true;
            }
        });
    }

    if (_currentTest) {

        //set MACKINFO TestList
        var mdata = {
            obj: _listOfTest
        }
        $.ajax({
            type: 'POST',
            url: '/Tests/SetIsSelectedTestList',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
            data: mdata,
            //async:false,
            success: function (result) {
                if (result.isSuccess == 1) {
                    ////alert('Successfully received Data ');
                    //var strHtml = result.data;
                    //$("#divTest").html(strHtml)
                } else {
                    alert('Failed to receive the Data');
                }
            },
            error: function () {
                alert('Failed to receive the Data');
                console.log('Failed ');
            }
        });

    }


    if (isAnyTest) {
        GetTestHtml();
        $("#btnStart").prop("disabled", true);
        $("#lbl" + _currentTest.testName).text("Running");
        $("#lblResult" + _currentTest.testName).text("Not Tested");
    } else {
        alert("Please select atleast one task .");
    }
}

function MarkItAsCompleted() {
    var mdata = _currentTest
    $.ajax({
        type: 'POST',
        url: '/Tests/MarkTestComplete',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
        data: mdata,
        //async:false,
        success: function (result) {
            if (result.isSuccess == 1) {
                ////alert('Successfully received Data ');
                //var strHtml = result.data;
                //$("#divTest").html(strHtml)
            } else {
                alert('Failed to receive the Data');
            }
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    })
}

function GetTestHtml() {
    var mdata = _currentTest
    $.ajax({
        type: 'POST',
        url: '/Tests/GetTestHtml',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
        data: _currentTest,
        //async: false,
        success: function (result) {
            if (result.isSuccess == 1) {
                var strHtml = result.data;
                $("#divTest").html(strHtml);
                if (_currentTest.testName == "CMOS") {
                    $("#rd" + _currentTest.testName + "Pass").prop("checked", true);

                }
            } else {
                alert('Failed to receive the Data');
            }
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    })
}

function MainSaveMethod() {
        debugger;
        //make ajax call to save data
        //var mdata = _objToBeSaved
        $.ajax({
            type: 'POST',
            url: '/Tests/MainSaveMethod',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
            data: null,
            //async:false,
            success: function (res) {
                debugger;
                if (res.isSuccess == 1) {

                    alert("Please select the grade .");
                    $("#btnMainSave").prop("disabled", true);
                }

                else if (re.isSuccess == 101)
                {
                    alert("Please select the grade .");
                }
                else if (re.isSuccess == 102) {
                    alert("Please do the testing first .");
                }
                else {
                    alert('Failed to receive the Data');
                }
            },
            error: function () {
                alert('Failed to receive the Data');
                console.log('Failed ');
            }
        })      
}


function MarkAsCompleted(objResultText) {
    if (_currentTest) {
        $.each(_listOfTest, function (index, item) {
            if (_currentTest.testName == item.testName) {
                //also make ajax call and marked static object with is testdone = true
                //MarkItAsCompleted();
                
                item.testDone = true;
                _currentTest.testDone = true;

                item.testResult = objResultText;
                _currentTest.testResult = objResultText;

                
                SetLable($("#lbl" + _currentTest.testName), objResultText);
                SetLable($("#lblResult" + _currentTest.testName), objResultText);


                if (objResultText == 'Pass') {
                    item.className = 'form-check-label PassText';
                    _currentTest.className = 'form-check-label PassText';
                }
                else if (objResultText == 'Fail') {
                    item.className = 'form-check-label FailText';
                    _currentTest.className = 'form-check-label FailText';
                }
                else if (objResultText == 'NoDevice') {
                    item.className = 'form-check-label NoDeviceText';
                    _currentTest.className = 'form-check-label NoDeviceText';
                }
                else if (objResultText == 'NotTested') {
                    item.className = 'form-check-label NotTestedText';
                    _currentTest.className = 'form-check-label NotTestedText';
                }

                setTimeout(MarkItAsCompleted(), 500);                
            }
        });
    }
}

function SetLable(InputId, objResult, _listOfTestItem) {
    if (InputId) {
        $(InputId).text(objResult);
        $(InputId).removeClass();
        if (objResult == 'Pass') {
            $(InputId).addClass('form-check-label PassText');            
        }
        else if (objResult == 'Fail') {
            $(InputId).addClass('form-check-label FailText');            
        }
        else if (objResult == 'NoDevice') {
            $(InputId).addClass('form-check-label NoDeviceText');            
        }
        else if (objResult == 'NotTested') {
            $(InputId).addClass('form-check-label NotTestedText');            
        }
    }
}


var Sound = {

    
    SpeakerChange() {
        debugger;
        //alert('RightSpeakerChange');
        Sound.MarkSoundTested();
    },
    SpeakerTest() {
        debugger;
        //var audio = new Audio("../Files/leftSpeaker.wav");
        //audio.play();

        var audio = new Audio('http://codeskulptor-demos.commondatastorage.googleapis.com/descent/gotitem.mp3');
        audio.play();

        $("#chkSpeakerPass").attr('checked', 'checked');
        
        Sound.MarkSoundTested();
    },    
    AudioPortChange() {
        alert('AudioPortChange');
    },
    MarkSoundTested() {
        debugger;
        var SpeakerPass = $("input:radio[name='chkSpeakerPass']:checked").val();
        var SpeakerFail = $("input:radio[name='chkSpeakerFail']:checked").val();
        if (SpeakerPass) {
            MarkAsCompleted('Pass');
        } else {
            MarkAsCompleted('Fail');
        }
    }
};

var USB = {
    RetestUSB() {
        alert('RetestUSB');
    },
    USBChange(mResult) {
        MarkAsCompleted(mResult);
    }
};

var LanPort = {

};

var Optical = {

};

var LCD = {

};

var keyboard = {
    StartTest() {
        alert('start keyboard test');
    },
    BacklightKeyboardChecked() {
        alert('BacklightKeyboard');
    },
    BacklightPassFail() {
        alert('BacklightPassFail');
    }
};

var Touchpad = {
    SetTouch() {
        alert('SetTouch');
    },
    ResetTouch() {
        alert('ResetTouch');
    },
    SetPointerTouch() {
        alert('SetPointerTouch');
    },
    ResetPointerTouch() {
        alert('ResetPointerTouch');
    },
    MarkAsPointerCompleted() {
        alert('MarkAsPointerCompleted');
    }
};

var WifiBluetooth = {

};

var Battery = {

};

var Camera = {

};

var Touchscreen = {

};

var Microphone = {

};

var SDCard = {

};

var Biometrics = {

};

var SmartCard = {

};

var Display = {

};

var Port = {

};

var Dashboard = {

    SetGrade() {
        //alert($("#ddlGrade").val());
        var SelectedGrade = $("#ddlGrade").val();
        if (SelectedGrade) {
            _objToBeSaved.Grade = SelectedGrade;
        }
        
        var mdata = {
            Grade : $("#ddlGrade").val()
        };
        $.ajax({
            type: 'POST',
            url: '/Tests/SetGradeMethod',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
            data: mdata,
            //async:false,
            success: function (result) {
                if (result.isSuccess == 1) {
                    
                } else {
                    alert('Failed to receive the Data');
                }
            },
            error: function () {
                alert('Failed to receive the Data');
                console.log('Failed ');
            }
        })
    },

};


