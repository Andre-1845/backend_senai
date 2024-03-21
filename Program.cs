using System;

namespace Atividade;


 public class Program
    {
        public static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("informe nome");
            string var_nome = Console.ReadLine();       
            Console.WriteLine("informe endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica(f) ou Pessoa Juridica(j)?");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "j")
            {
                PessoaJuridica pj = new PessoaJuridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;


                Console.WriteLine("Informe CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_imposto(val_pag);
                
                Console.WriteLine("-----------Pessoa Juridica-----------");
                Console.WriteLine("Nome................: "+ pj.nome);
                Console.WriteLine("Endereço............: "+ pj.endereco);
                Console.WriteLine("IE..................: "+ pj.ie);
                Console.WriteLine("Valor de Compra.....: "+ pj.valor);
                Console.WriteLine("Imposto.............: "+ pj.valor_imposto);
                Console.WriteLine("Total a pagar.......: "+ pj.total);

            }
            if (var_tipo == "f")
            {
             // ----- PESSOA FISICA  ----  //
                PesFis pf = new PesFis();
                Console.WriteLine("Informe CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe RG: ");
                pf.rg = Console.ReadLine();
               
                Console.WriteLine("Informe Valor da Compra: ");
                float v = float.Parse(Console.ReadLine());
                val_pag = v;
                pf.Pagar_imposto(val_pag);
                
                
                pf.nome = var_nome;
                pf.endereco = var_endereco;        

                Console.WriteLine("-----------Pessoa Fisica-----------");
                Console.WriteLine("Nome................: "+ pf.nome);
                Console.WriteLine("Endereço............: "+ pf.endereco);
                Console.WriteLine("RG..................: "+ pf.rg);
                Console.WriteLine("Valor de Compra.....: "+ pf.valor.ToString);
                Console.WriteLine("Imposto.............: "+ pf.valor_imposto);
                Console.WriteLine("Total a pagar.......: "+ pf.total);

            }


            
        }
    }

   
