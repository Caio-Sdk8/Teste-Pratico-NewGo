using System.ComponentModel.DataAnnotations;

class senha
{
    [Required]
    public string conteudo { get; set; }

    public int validadorSenha(string senha){
        int pontuacaoSenha =  75;
        int contadorGeral = 0;
        
        if (senha.Length >= 14)
        {
            pontuacaoSenha++;
            if (senha.Length >= 18)
            {
                pontuacaoSenha++;
                if (senha.Length >= 22)
                {
                    pontuacaoSenha++;
                    if (senha.Length >= 26)
                    {
                        pontuacaoSenha++;
                        if (senha.Length >= 30)
                        {
                            pontuacaoSenha++;
                        }
                    }
                }
            }
        }
        
        foreach (char item in senha)
        {

            foreach (var itemRep in senha)
            {
            
            }
        }
        return pontuacaoSenha;
    }
}