namespace DapperExample;

public class Cargo
{
    public int Sequencia_car { get; set; }
    public string Descri_car { get; set; } = string.Empty;
    public DateTime DtaInc_car { get; set; }
    public string CpfUsu_car { get; set; } = string.Empty;
    public string Inativo_car { get; set; } = string.Empty;
    public int Versao_car { get; set; }

    public override string ToString()
    {
        return $"{Sequencia_car} - {Descri_car} - {DtaInc_car} - {Inativo_car} - {Versao_car}";
    }
}
