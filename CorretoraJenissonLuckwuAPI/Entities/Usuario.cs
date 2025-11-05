using System.ComponentModel.DataAnnotations;

namespace CorretoraJenissonLuckwuAPI.Entities
{
    public class Usuario
    {
        #region Key
        public int Id { get; set; }
        #endregion

        #region
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
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
    }
}
