using Fornecedores.Data;
using fornecedores.Models.MaisFornec;

namespace Fornecedores.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar as Tarefas
                if (!context.Fornecedores.Any())
                {
                    context.Fornecedores.AddRange(new List<Fornecedor>()
                    {
                        new Fornecedor()
                        {
                            RazaoSocial = "Desavisei Voce",
                            NomeFantasia = "As cronicas dos desavisados",
                            Email = "desavisados@gmail.com",
                            Telefone = "(16)99487-3501",
                            Logradouro = "Irineu voce nao sabe nem eu",
                            Bairro = "Nao sei",
                            CEP = "50792-000",
                            Cidade = "Nuncanenvi",
                            Numero = 58,
                            Nome = "Joaozinho Gamesplay",
                        },
                        new Fornecedor() {
                            RazaoSocial = "Poligrotas",
                            NomeFantasia = "AS grandes peripécias dos poligrotas",
                            Email = "Poligrotas@outlook.com",
                            Telefone = "(17)99647-1250",
                            Logradouro = "lugar nenhum",
                            Bairro = "courassa",
                            CEP = "98001-789",
                            Cidade = "João Paulista",
                            Numero = 87,
                            Nome = "Kratos Of War",
                        },
                        new Fornecedor()
                        {
                            RazaoSocial = "Goiabada de Banana",
                            NomeFantasia = "Marmelada de Banana",
                            Email = "GoiabaBanana@gmail.com",
                            Telefone = "(13)99014-6547",
                            Logradouro = "Sitio do Pica-pau amarelo",
                            Bairro = "Rosas",
                            CEP = "82475-980",
                            Cidade = "CucaSemNuca",
                            Numero = 01,
                            Nome = "Emília dos panos",
                        },
                        new Fornecedor()
                        {
                            RazaoSocial = "Pró-serve Global",
                            NomeFantasia = "Pró-serve",
                            Email = "proserve@gmail.com",
                            Telefone = "(18)99416-8273",
                            Logradouro = "Moura De Lima Carpintaria",
                            Bairro = "Oliveiras das orquideas",
                            CEP = "74100-248",
                            Cidade = "Queiroz",
                            Numero = 687,
                            Nome = "Henrique Negri",
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
