# DateTimeIssueDemo

The code to show the demo in .NET 5 DateTimeKind is not correctly binding.

When UTC Timestring is supplied the .NET 5 binder correctly identifies it as UTC Type.
While when supplied non UTC Timestring with timezone offset it wrongly identifies as UTC Type instead of UTC.

This is modified version of code from discussion of
https://stackoverflow.com/questions/66391183/net-core-3-1-to-net-core-5-upgrade-gives-wrong-conversion-for-datetime-values
and original code of 
https://github.com/ShehulCS/Dotnet5DateTimeIssue

To see the issue,

1) Download this solution
2) Run the solution, you will be taken to URL of https://localhost:44308/?date1=2021-04-20T00:00:00Z&date2=2021-04-20T00:00:00-04:00
3) The output shows the DateTimeKind of 2 Dates parameter. The Kind for parameter named Date2 should be Local not UTC.


