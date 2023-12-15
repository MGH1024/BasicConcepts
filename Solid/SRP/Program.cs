using SRP;

//work with following srp classes 
var report = new WorkReportFollowingSrp();
report.AddEntry(new WorkReportEntry("123Ds", "Project1", 5));
report.AddEntry(new WorkReportEntry("987Fc", "Project2", 3));

Console.WriteLine(report.ToString());

var saver = new FileSaver();
saver.SaveToFile(@"Reports", "WorkReport.txt", report);