namespace git_submodule_demo;

public record Entity
{
    public Guid Id {get; set;}
    public DateTimeOffset DateCreated {get; set;} = DateTimeOffset.Now;
    public DateTimeOffset? DateModified {get; set;}
    public string ModifiedBy {get; set;} = "Git Submodule";
} 
