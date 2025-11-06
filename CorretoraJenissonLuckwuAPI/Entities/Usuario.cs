using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorretoraJenissonLuckwuAPI.Entities
{
    public class Usuario
    {
        #region Key
        [Key]
        public int Id { get; set; }
        #endregion


        #region Properties
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public string Stream_user_id { get; set; }

        [Phone]
        public string Telefone { get; set; }
        #endregion

        #region Generete Data
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_at { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_at { get; set; }
        #endregion
    }
}
