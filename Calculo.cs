namespace Aula12
{
    public class Calculo
    {
        public string Calcular(){
            return "Não houve nenhum calculo a ser aplicado";
        }

        public string Calcular(int municao){
            return "A quantidade de municoes que o  jogador está é " +municao;

        }
        public string Calcular(int arma, int municao){
            return "A quantidade de municoes do jogador com armas é" +(arma+municao);

        }
        public string Calcular(string nome, string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }
    }
}