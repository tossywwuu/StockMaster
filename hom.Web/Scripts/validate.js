function myvalidator() {
    var valfuncs =
        {
            "isnull": function (value) {
                if (value === "")
                {
                    alert(1);
                }
            }
        }
    var reg = function (name,func) { valfuncs[name]=func }
     validator=function(flag,value) {
        if (valfuncs[flag])
        {
            valfuncs[flag]();
        }
    }
     return validator;
}
var valid = myvalidator();
valid("isnull","");
