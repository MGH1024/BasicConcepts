namespace SRP;

public  class WorkReportEntry
{
    public WorkReportEntry(string projectCode, string projectName, int spentHours)
    {
        ProjectCode = projectCode;
        ProjectName = projectName;
        SpentHours = spentHours;
    }

    public string ProjectCode { get; set; }
    public string ProjectName { get; set; }
    public int SpentHours { get; set; }
}