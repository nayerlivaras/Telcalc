using static System.Console;

static void Main(string[]args)
{
    double num1,num2;
    WriteLine(ingrese numero 1:"");
    num1=double.parse(readLine());

    WriteLine(ingrese numero 2:"");
    num2=double.Parse(ReadLine());
    Calculadora c1 = new Calculadora(num1,num2,"*");
    c1.imprimir();
    calculadora c2=new calculadora(num1,num2,"+");
    c2.imprimir();
    calculadora c3 = new calculadora(num1,num2."/");
    c4.imprimir();
    ReadLine();
}
public class calculadora 

{
    public calculadora(double a,double b,string operacion)
    {
        this.Numero1 = a;
        this.Numero2 = b;
        this.Operacion = operacion;
        this.Resultado = this.Operacion switch
        {
            "+"=>this.Numero1 + this.Numero2,
            "-"=>this,Numero1 - this.Numero2,
            "/"=>this.Numero1 / this.Numero2,
            "*"=>this.Numero1 * this.Numero2,
            _=> -1
        };

        }
    }
    public double Numero1 {get;set;}
    public double Numero2{get;set;}
    public string Operacion{get;set;}
    public double Resultado {get;set;}

    public void imprimir()
    {

        WhiteLine($"{this.Numero1}{this.Operacion}{this.Numero2}={this.Resultado}");
    }
}