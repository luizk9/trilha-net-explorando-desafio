namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

    public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //  Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
          
            if (Suite.Capacidade >= hospedes.Count )
            {
                Hospedes = hospedes;
            }
            else
            { 
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                
                throw new Exception("Capaciadade da Suite menor que o n de Hospides");
            }
        }


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        
         public int ObterQuantidadeHospedes( )
        {    
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
        
            int quantidade =  Hospedes.Count;

            return quantidade;
        }
            
         public decimal CalcularValorDiaria(  )
        {
            decimal valor = 0;
            valor =  DiasReservados * Suite.ValorDiaria;
          
            if (DiasReservados >=10)
            {
                decimal desconto = valor * 10/100;
                valor = valor - desconto;
            }

            return valor;
        }
        
    }
}
