namespace SRP;

public class FileSaver
{
    public void SaveToFile(string directoryPath, string fileName, WorkReportFollowingSrp report)
    {
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
    }
}

public class WorkReportFollowingSrp
{
    private readonly List<WorkReportEntry> _entries;

    public WorkReportFollowingSrp()
    {
        _entries = new List<WorkReportEntry>();
    }

    public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

    public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

    public override string ToString() =>
        string.Join(Environment.NewLine,
            _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
}