using DapperExample;

using Dapper;

using MySql.Data.MySqlClient;

using (var conn = new MySqlConnection("Server=localhost;database=erp_teste;user=root;pwd=root;"))
{
    var dados = conn.Query<DadosPessoa, Endereco, DadosPessoa>
        ("select * from dadospessoa d, endereco e where d.SeqEnd_dpe = e.Sequen_end",
        map: (dado, endereco) =>
        {
            dado.Endereco = endereco;
            return dado;
        },
        splitOn: "Sequencia_dpe,Sequen_end");

    foreach (var dado in dados)
    {
        Console.WriteLine($"{dado.RazaoSocial_dpe} --- {dado.Endereco?.Lograd_end}");
    }
}

Console.ReadKey();