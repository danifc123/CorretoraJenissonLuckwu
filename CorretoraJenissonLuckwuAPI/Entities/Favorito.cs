using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorretoraJenissonLuckwuAPI.Entities
{
    public class Favorito
    {
        #region
        [Key]
        public int Id { get; set; }
        #endregion

        #region Properties
        [ForeignKey("Usuario")]
        int Usuario_Id { get; set; }

        [ForeignKey("Imovel")]
        public int Imovel_Id { get; set; }
        #endregion
    }
}
