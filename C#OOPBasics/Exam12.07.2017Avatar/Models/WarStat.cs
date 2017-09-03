using System.Text;

public class WarStat
{
    private int warsCounter;
    private StringBuilder statBuilder;

    public WarStat()
    {
        this.warsCounter = 0;
        this.statBuilder = new StringBuilder();
    }

    public void AddNewWar(string warIssuedByElement)
    {
        this.warsCounter++;
        this.statBuilder.AppendLine($"War {this.warsCounter} issued by {warIssuedByElement}");
    }

    public override string ToString()
    {
        return this.statBuilder.ToString();
    }
}

