using System.ComponentModel.DataAnnotations;

public class masterDesigner_User {
    [Key]
    public int masterDesigner_UserId { get; set; }

    [Required]
    public string masterDesigner_UserLogin { get; set; }

    [Required]
    public string masterDesigner_UserPassword { get; set; }
}
