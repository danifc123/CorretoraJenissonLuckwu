using CorretoraJenissonLuckwuAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CorretoraJenissonLuckwuAPI.Context
{
    public class CorretoraJenissonLuckwuDb: DbContext
    {
      #region Constructors
        public CorretoraJenissonLuckwuDb(DbContextOptions<CorretoraJenissonLuckwuDb> options) : base(options)
        {
        }
        #endregion
        #region Properties
        public Administrador administradores { get; set; }
        public Favorito favoritos { get; set; }
        public ImagemImovel imagemImoveis { get; set; }
        public Imovel imoveis { get; set; }
        public Usuario usuarios { get; set; }
        #endregion
        #region DbSets
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }
        public DbSet<ImagemImovel> ImagemImoveis { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion
    }
}
