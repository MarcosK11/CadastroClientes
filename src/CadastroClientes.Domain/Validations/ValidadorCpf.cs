namespace CadastroClientes.Domain.Validations;

public static class ValidadorCpf
{
    public static bool EhValido(string cpf)
    {
        // Remover caracteres não numéricos (pontos, traços)
        string apenasDigitos = new string(cpf.Where(c => char.IsDigit(c)).ToArray());

        // Verificar se tem 11 dígitos
        if (apenasDigitos.Length != 11)
        {
            return false;
        }

        // Verificar se todos os dígitos são iguais
        int quantidadeDigitos = apenasDigitos.Distinct().Count();
        if (quantidadeDigitos == 1)
        {
            return false;
        }

        // 4. Calcular o 1º dígito verificador
        int primeiroDigitoVerificador = CalcularDigitoVerificador(apenasDigitos, 10);

        // 5. Calcular o 2º dígito verificador
        int segundoDigitoVerificador = CalcularDigitoVerificador(apenasDigitos, 11);

        // 6. Comparar os dígitos calculados com os 2 últimos dígitos do CPF informado

        return primeiroDigitoVerificador == apenasDigitos[9] - '0' && segundoDigitoVerificador == apenasDigitos[10] - '0';
    }

    private static int CalcularDigitoVerificador(string digitos, int pesoInicial)
    {
        int soma = 0;
        int multiplicador = pesoInicial;
        for (int i = 0; i < pesoInicial - 1; i++)
        {
            int digito = digitos[i] - '0';

            soma += digito * multiplicador;

            multiplicador--;
        }

        int resto = soma % 11;

        if (resto < 2)
        {
            return 0;
        }
        return 11 - resto;
    }
}