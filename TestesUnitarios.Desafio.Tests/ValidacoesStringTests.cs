using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {

        var texto = "Matrix";
        var resultadoEsperado = 6;

       
        var resultadoAtual = _validacoes.RetornarQuantidadeCaracteres(texto);

        
        Assert.Equal(resultadoEsperado, resultadoAtual);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
    
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

       
        var resultadoEsperado = _validacoes.ContemCaractere(texto, textoProcurado);

        
        Assert.True(resultadoEsperado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        var resultadoEsperado = _validacoes.ContemCaractere(texto, textoProcurado);

        
        Assert.False(resultadoEsperado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
     

     
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        var resultadoEsperado = _validacoes.TextoTerminaCom(texto, textoProcurado);

       
        Assert.True(resultadoEsperado);
    }
}
