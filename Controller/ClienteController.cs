using GerenciadorDeCambio.Dao;
using GerenciadorDeCambio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Controller
{
    class ClienteController
    {
        public static string salvar(ClientModel cli)
        {
            string resposta = "";
            string[] nomes = cli.Nome.Split(' ');
            cli.Nome = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Trim() != "")
                {
                    nomes[i] = char.ToUpper(nomes[i][0]) + nomes[i].Substring(1);///Coloca a primeira letra em maisculu
                    cli.Nome += nomes[i] + " ";
                }
            }

            if (cli.Nome != "")
            {
                if (cli.Cpf!="")
                {
                    if (cli.Data != "")
                    {
                        ClienteDao.insert(cli);//insere um novo client
                    }
                    else
                    {
                        resposta = "Data em branco";
                    }
                }
                else
                {
                    resposta = "Cpf invaido";
                }
            }
            else
            {
                resposta = "Nome em branco";
            }
            return resposta;
        }

        public static string[] select()
        {

            DataTable dt = new DataTable();
            dt = ClienteDao.ListaClientes();
            string[] cliente = new string[(dt.Rows.Count)+1];
            cliente[0] = "Selecione";
            int i = 1;
            foreach (DataRow linha in dt.Rows)
            {
                cliente[i] = linha["id"].ToString() + " - " + linha["nome"].ToString();

                i++;
            }


            return cliente;
        }



        /// vaidar cpf
        public static bool IsValidCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito = "";
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }

            else
            {
                resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
            }
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
                digito = digito + resto.ToString();
            }
            return cpf.EndsWith(digito);
        }
    }
}
