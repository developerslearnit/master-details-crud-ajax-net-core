namespace MasterDetailsCrudAjax.Entities;

public partial class Agent
{
    public int AgentId { get; set; }
    public string AgentCode { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
}
