namespace MasterDetailsCrudAjax.Entities;

public partial class AgentGuarantor
{
    public int AgentGuarantorId { get; set; }
    public int AgentId { get; set; }
    public int RelationshipId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    //Navigation properties
    public Agent Agent { get; set; }
    public Relationship Relationship { get; set;}

}
