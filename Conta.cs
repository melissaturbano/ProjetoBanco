public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }
    public Conta(int codigo)
    {
        Codigo = codigo; 
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if(valor>Saldo) {
            throw new ArgumentException("Você não tem saldo");
        } 
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
    }

    public double Transferir(double valor, Conta conta) 
    {
        if(Saldo<valor || 0<valor) {
            throw new ArgumentException("Você não pode transferir esse valor");
        }
        

        return Saldo;
    }


}