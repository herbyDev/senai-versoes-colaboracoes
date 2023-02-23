using System;
namespace Atividade
{
    class Program
    {
        static void Main (String[]args)
        {
            
            float val_pag;
            Console.WriteLine ("Informar nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine ("Informe seu endereço:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine ("Pessoa Física (f) ou Pessoa Jurídica (j)");
            string var_tipo = Console.ReadLine();
           
                if(var_tipo== "f" || var_tipo== "F")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine ("Informe seu CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine ("Informe seu RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine ("Informe o valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.pagar_imposto(val_pag);

                Console.WriteLine ("********** Pesso Física********** ");
                Console.WriteLine ("Nome..........:"+ pf.nome);
                Console.WriteLine ("Endereço...........:"+pf.endereco);
                Console.WriteLine ("CPF............:"+pf.cpf);
                Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pf.total.ToString("C"));
            }
            if(var_tipo== "j" || var_tipo== "J")
            {
               Pessoa_juridica pj = new Pessoa_juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine ("Informe seu CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine ("Informe seu IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine ("Informe o valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.pagar_imposto(val_pag);

                Console.WriteLine ("********** Pesso Jurídica********** ");
                Console.WriteLine ("Nome..........:"+ pj.nome);
                Console.WriteLine ("Endereço...........:"+pj.endereco);
                Console.WriteLine ("CNPJ............:"+pj.cnpj);
                Console.WriteLine ("IE............:"+pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pj.total.ToString("C")); 
            }
        }
    }
}