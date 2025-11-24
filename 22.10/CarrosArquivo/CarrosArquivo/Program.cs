using CarrosArquivo;

string CarregarPrograma()
{

    string diretorio = "C:\\Files\\Locadora\\";
    string arquivo = "carros";
    

    if (!Directory.Exists(diretorio))
    {
        Directory.CreateDirectory(diretorio);
    }

    if (!File.Exists(Path.Combine(diretorio, arquivo)))
    {
        File.Create(Path.Combine(diretorio, arquivo));
    }

    return Path.Combine(diretorio, arquivo);
}

List<Carro> LerArquivo()
{
    var caminhoDoArquivo = CarregarPrograma();

    StreamReader sr = new StreamReader(caminhoDoArquivo);

    using (sr)
    {
        if (sr.ReadToEnd().Length == 0)
        {
            return new List<Carro>();
        }

            List<Carro> carros = new List<Carro>();
            while (sr.ReadToEnd() is not null)
            {
            string linha = sr.ReadLine();
            var valores = linha.Split(";");
            var carro = new Carro(int.Parse(valores[0]), valores[1], valores[2], int.Parse(valores[3]), valores[4], valores[5]);
            carros.Add(carro);
            }

            sr.Close();
            return carros;


        }
    
}

void GravarArquivo(List<Carro> carros)
{
    var caminho = CarregarPrograma();
    StreamWriter sw = new StreamWriter(caminho);

    using (sw)
    {
        foreach(Carro c in carros)
        {
            sw.WriteLine(c);
            sw.Close();
        }
    }
}

var locadora = new Locadora(LerArquivo());

locadora.CadastrarCarro();
locadora.CadastrarCarro();
locadora.CadastrarCarro();
locadora.CadastrarCarro();

locadora.ListarTodosCarros();
locadora.AtualizarCarro();
locadora.RemoverCarro();
locadora.ListarTodosCarros();

GravarArquivo(locadora.carros);
