
using ControlePonto.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace ControlePonto.Data
{
    internal class ControlePontoDbContext : DbContext
    {
        public ControlePontoDbContext(DbContextOptions<ControlePontoDbContext> options) : base(options)
        {

        }

        public DbSet<Cargo> Cargos { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Importa o nosso arquivo de configuração JSON
            var builder = new ConfigurationBuilder()
                            .AddJsonFile("appconfig.json", false, true);
            
            // Compila as configurações
            IConfigurationRoot configuracao = builder.Build();

            // Pega a string de conexão da configuracao
            var stringDeConexao = configuracao.GetConnectionString("ConexaoPadrao");

            // Adiciona a string a configuração do DbContext
            optionsBuilder.UseMySql(stringDeConexao, ServerVersion.AutoDetect(stringDeConexao));
        }
    }
}
