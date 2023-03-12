using System;
namespace Atividade
{
    class Program 
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("Informar Nome: ");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar endereço: ");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Pessoa Júrifica (j) ?: ");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                // --- Pessoa Física --
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine ("Informar CPF: ");
                pf.cpf = Console.ReadLine();

                Console.WriteLine ("Informar RG: ");
                pf.rg = Console.ReadLine();

                Console.WriteLine ("Informar Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto (val_pag);

                Console.WriteLine (" --------- Pessoa Física ----------");
                Console.WriteLine (" Nome..............: " + pf.nome);
                Console.WriteLine (" Endereço..........: " + pf.endereco);
                Console.WriteLine (" Cpf...............: " + pf.cpf);
                Console.WriteLine (" Valor de compra...: " + pf.valor.ToString("C"));
                Console.WriteLine (" Imposto...........: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine (" Total a pagar.....: " + pf.total.ToString("C"));

            }
            if(var_tipo == "j")
            {
                //Pessoa Júridica
                Pessoa_Juridica pj = new Pessoa_Juridica ();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informe EI: ");
                pj.ei = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine (" --------- Pessoa Física ----------");
                Console.WriteLine (" Nome..............: " + pj.nome);
                Console.WriteLine (" Endereço..........: " + pj.endereco);
                Console.WriteLine (" CNPJ..............: " + pj.cnpj);
                Console.WriteLine (" EI................: " + pj.ei);
                Console.WriteLine (" Valor de compra...: " + pj.valor.ToString("C"));
                Console.WriteLine (" Imposto...........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine (" Total a pagar.....: " + pj.total.ToString("C"));


            }
        }
    }
}