/*-----------------------------------------------------------------------
* <copyright file="Program.cs" company="IPCA">
*     Copyright. All rights reserved.
* </copyright>
* <date> 05/09/2020 </date>
* <time> 00:45 </time>
* <author> 
*      Carlos Santos (19432)
*      Rúben Silva (19433) 
* </author>
* <email>
*      a19432@alunos.ipca.pt
*      a19433@alunos.ipca.pt
* </email>
* <desc>
*      Ficheiro principal que agrupa todas as classes vindas das bibliotecas e implementa os métodos.
* </desc>
-----------------------------------------------------------------------*/

using a2_RegrasNegocio;
using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;


namespace TrabalhoPrático1_19432_19433
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VARIAVEIS
            int quant, opcao = 0;

            AuditoriaAux amaior;
            AuditoriaAux amenor;
            Auditoria a = new Auditoria();
            Colaborador c = new Colaborador();
            Equipamento e = new Equipamento();
            Vulnerabilidade v = new Vulnerabilidade();
            EquipamentoAux e2;

            List<int> vulnsAux;
            List<ColaboradorAux> colAux;
            List<AuditoriaAux> audAux;
            List<EquipamentoAux> equAux;
            List<VulnerabilidadeAux> vulAux= new List<VulnerabilidadeAux>();
            #endregion

            #region CARREGAMENTOS
            try
            {
                EquRegras.CarregarEquipamentos(@"..\..\Ficheiros\Equipamentos");
            }
            catch (IOException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.CarregarVulnerabilidades(@"..\..\Ficheiros\Vulnerabilidades");
            }
            catch (IOException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                ColRegras.CarregarColaboradores(@"..\..\Ficheiros\Colaboradores");
            }
            catch (IOException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.CarregarAuditorias(@"..\..\Ficheiros\Auditorias");
            }
            catch (IOException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            #endregion

            #region ZONA DEMONSTRATIVA (TESTE)

            #region DADOS TESTE
            /*Criação de Objetos exemplares*/
            Colaborador col1 = new Colaborador(0, Atividade.ATIVO, 0, "Carlo", Genero.M, 20, 164015584);
            Colaborador col2 = new Colaborador(0, Atividade.ATIVO, 0, "Filipe", Genero.M, 23, 251312021);
            Equipamento equ1 = new Equipamento(0, "Portatil", "HP", "cs006np", DateTime.Parse("21/02/2020"));
            Equipamento equ2 = new Equipamento(0, "Monitor", "LG", "ex123", DateTime.Today);
            Vulnerabilidade vul1 = new Vulnerabilidade(0, "Falha no sistema", NivelImpacto.ELEVADO, Estado.NAORESOLVIDA);
            Vulnerabilidade vul2 = new Vulnerabilidade(0, "Erro", NivelImpacto.MODERADO, Estado.NAORESOLVIDA);
            Vulnerabilidade vul3 = new Vulnerabilidade(0, "Problema", NivelImpacto.BAIXO, Estado.RESOLVIDA);
            Vulnerabilidade vul4 = new Vulnerabilidade(0, "Erro de iniciação", NivelImpacto.ELEVADO, Estado.RESOLVIDA);
            Vulnerabilidade vul5 = new Vulnerabilidade(0, "Falha", NivelImpacto.BAIXO, Estado.NAORESOLVIDA);
            Vulnerabilidade vul6 = new Vulnerabilidade(0, "Perde Informação", NivelImpacto.MODERADO, Estado.RESOLVIDA);

            /*Registo de cada um dos objetos*/
            try
            {
                ColRegras.RegistaColaborador(col1);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                ColRegras.RegistaColaborador(col2);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.RegistaEquipamento(equ1);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.RegistaEquipamento(equ2);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.RegistaVulnerabilidade(vul1);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.RegistaVulnerabilidade(vul2);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.RegistaVulnerabilidade(vul3);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.RegistaVulnerabilidade(vul4);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.RegistaVulnerabilidade(vul5);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.RegistaVulnerabilidade(vul6);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            /*Criação de Objetos exemplares*/
            Auditoria aud1 = new Auditoria(0, 10, DateTime.Today, col1.Codigo, equ1.Codigo);
            Auditoria aud2 = new Auditoria(0, 54, DateTime.Today, col1.Codigo, equ2.Codigo);
            Auditoria aud3 = new Auditoria(0, 41, DateTime.Today, col2.Codigo, equ2.Codigo);

            /*Complementação das auditorias e equipamentos ao adicionar vulnerabilidades*/
            try
            {
                AudRegras.RegistaAuditoria(aud1);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.RegistaAuditoria(aud2);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.RegistaAuditoria(aud3);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                ColRegras.AdicionaAuditoriaColaborador(aud1.CodColab);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                ColRegras.AdicionaAuditoriaColaborador(aud2.CodColab);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                ColRegras.AdicionaAuditoriaColaborador(aud2.CodColab);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.AdicionaVulnerabilidadeAuditoria(aud1.Codigo, vul1.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.AdicionaVulnerabilidadeAuditoria(aud1.Codigo, vul2.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.AdicionaVulnerabilidadeAuditoria(aud2.Codigo, vul3.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.AdicionaVulnerabilidadeAuditoria(aud3.Codigo, vul4.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.AdicionaVulnerabilidadeAuditoria(aud3.Codigo, vul5.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                AudRegras.AdicionaVulnerabilidadeAuditoria(aud3.Codigo, vul6.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.AdicionaVulnerabilidadeEquipamento(equ1.Codigo, vul1.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.AdicionaVulnerabilidadeEquipamento(equ1.Codigo, vul2.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.AdicionaVulnerabilidadeEquipamento(equ2.Codigo, vul3.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.AdicionaVulnerabilidadeEquipamento(equ2.Codigo, vul4.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.AdicionaVulnerabilidadeEquipamento(equ2.Codigo, vul5.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.AdicionaVulnerabilidadeEquipamento(equ2.Codigo, vul6.Codigo);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            #endregion

            /*Apresentação do dashboard*/
            if (AudRegras.QuantidadeAuditorias() != 0)
            {
                amaior = AudRegras.ObterAuditoriaMaisVuln();
                amenor = AudRegras.ObterAuditoriaMenosVuln();
                Console.WriteLine("     -> Quantidade de Auditorias: {0}\n", AudRegras.QuantidadeAuditorias());
                Console.WriteLine("     -> Auditoria com mais Vulnerabilidades");
                Console.WriteLine("         Código: {0, -5}|  Data: {1, -10}  |  Quantidade de Vulnerabilidades: {2}\n", amaior.Codigo.ToString(), amaior.DataRegisto.ToShortDateString(), AudRegras.ObterQuantidadeVulnerabilidadesAuditoria(amaior.Codigo).ToString());
                Console.WriteLine("     -> Auditoria com menos Vulnerabilidades");
                Console.WriteLine("         Código: {0, -5}|  Data: {1, -10}  |  Quantidade de Vulnerabilidades: {2}\n", amenor.Codigo.ToString(), amenor.DataRegisto.ToShortDateString(), AudRegras.ObterQuantidadeVulnerabilidadesAuditoria(amenor.Codigo).ToString());
                Console.WriteLine("     -> Média de Vulnerabilidades por Auditoria: {0}\n\n", AudRegras.ObtemMediaVulns().ToString());
            }
            Console.ReadKey();
            Console.Clear();

            /*Mostrar Informações*/
            Console.WriteLine(":{0, -63}:\n:{1, -63}:", "-> Lista de Auditorias", " ");
            Console.WriteLine(": {0, -7}: {1, -12}: {2, -9}: {3, -13}: {4, -13}:", "Código", "Data", "Duracao", "Colaborador", "Equipamento");
            Console.WriteLine(": {0, -7}: {0, -12}: {0, -9}: {0, -13}: {0, -13}:", "");
            audAux = AudRegras.MostraAuditorias();
            foreach (AuditoriaAux aAux in audAux)
                Console.WriteLine(": {0, -7}: {1, -12}: {2, -5}min : {3, -13}: {4, -13}:", aAux.Codigo.ToString(), aAux.DataRegisto.ToShortDateString(), aAux.Duracao.ToString(), aAux.CodColab.ToString(), aAux.CodEqui.ToString());
            Console.WriteLine();
            audAux.Clear();

            Console.WriteLine(":{0, -66}:\n:{1, -66}:", "-> Lista de Colaboradores", " ");
            Console.WriteLine(": {0, -8}: {1, -23}: {2, -7}: {3, -7}: {4, -12}:", "Código", "Nome", "Idade", "Género", "Atividade");
            Console.WriteLine(": {0, -8}: {0, -23}: {0, -7}: {0, -7}: {0, -12}:", "");
            colAux = ColRegras.MostraColaboradores();
            foreach (ColaboradorAux cAux in colAux)
                Console.WriteLine(": {0, -8}: {1, -23}: {2, -7}: {3, -7}: {4, -12}:", cAux.Codigo.ToString(), cAux.Nome, cAux.Idade.ToString(), cAux.Genero.ToString(), cAux.Atividade.ToString());
            Console.WriteLine();
            colAux.Clear();

            Console.WriteLine(":{0, -71}:\n:{1, -71}:", "-> Lista de Equipamentos", " ");
            Console.WriteLine(": {0, -7}: {1, -12}: {2,-14}: {3, -14}: {4, -15}:", "Código", "Data", "Tipo", "Marca", "Modelo");
            Console.WriteLine(": {0, -7}: {0, -12}: {0,-14}: {0, -14}: {0, -15}:", "");
            equAux = EquRegras.MostraEquipamentos();
            foreach (EquipamentoAux eAux in equAux)
                Console.WriteLine(": {0, -7}: {1, -12}: {2,-14}: {3, -14}: {4, -15}:", eAux.Codigo.ToString(), eAux.DataAquisicao.ToShortDateString(), eAux.Tipo.ToString(), eAux.Marca.ToString(), eAux.Modelo.ToString());
            equAux.Clear();
            Console.ReadKey();
            Console.Clear();

            /*Editar Objetos*/
            try
            {
                AudRegras.EditaAuditoria(1, DateTime.Parse("22/02/2020"), 26);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                VulRegras.EditaVulnerabilidade(vul5.Codigo, "Falha no Sistema", NivelImpacto.BAIXO, Estado.RESOLVIDA);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                EquRegras.EditaEquipamento(2, "Monitor", "BenQ", "ex123", DateTime.Today);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            /*Editar Colaborador e tornar inativo*/
            try
            {
                ColRegras.EditaColaborador(1, "Carlos", 21, Genero.M, 164015584);
            }
            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            if (ColRegras.VerificaAtividade(1))
            {
                try
                {
                    ColRegras.TornarColaboradorInativo(1);
                }
                catch (IndexOutOfRangeException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }

            /*Apresentação de algumas informações*/
            Console.WriteLine(" Auditorias por Colaborador:");
            audAux = AudRegras.ApresentaAuditoriasColaborador(1);
            Console.WriteLine(" Código Colaborador: {0}", 1.ToString());
            Console.WriteLine(" Quantidade auditorias: {0}", audAux.Count.ToString());
            if (audAux == null)
                Console.WriteLine("- Este Colaborador não tem auditorias registadas.");
            foreach (AuditoriaAux aAux in audAux)
            {
                Console.WriteLine("\nCódigo da Auditoria: {0}", aAux.Codigo.ToString());
                Console.WriteLine("Data: {0}", aAux.DataRegisto.ToShortDateString());
                Console.WriteLine("Equipamento Associado: {0}", aAux.CodEqui.ToString());
                Console.WriteLine("Quantidade Vulnerabilidades: {0}", AudRegras.ObterQuantidadeVulnerabilidadesAuditoria(aAux.Codigo).ToString());
            }
            Console.WriteLine();
            audAux.Clear();

            Console.WriteLine(":{0, -71}:\n:{1, -71}:", "-> Lista de Auditorias por Ordem Decrescente de Vulnerabilidades", " ");
            Console.WriteLine(": {0, -7}: {1, -12}: {2, -13}: {3, -13}: {4, -17}:", "Código", "Data", "Colaborador", "Equipamento", "Vulnerabilidades");
            Console.WriteLine(": {0, -7}: {0, -12}: {0, -13}: {0, -13}: {0, -17}:", "");
            audAux = AudRegras.ApresentaAuditoriasOrdenadasVuln();

            foreach (AuditoriaAux aAux in audAux)
                Console.WriteLine(": {0, -7}: {1, -12}: {2, -13}: {3, -13}: {4, -17}:", aAux.Codigo.ToString(), aAux.DataRegisto.ToShortDateString(), aAux.CodColab.ToString(), aAux.CodEqui.ToString(), AudRegras.ObterQuantidadeVulnerabilidadesAuditoria(aAux.Codigo));
            audAux.Clear();
            Console.ReadKey();
            Console.Clear();

            e2 = EquRegras.ObterEquipamento(1);
            Console.WriteLine("- Detalhes de Equipamento\n");
            Console.WriteLine("Código: " + e2.Codigo.ToString());
            Console.WriteLine("Tipo: " + e2.Tipo);
            Console.WriteLine("Data de Aquisição: " + e2.DataAquisicao.ToShortDateString());
            quant = EquRegras.ObterQuantidadeVulnerabilidadesEquipamento(e2.Codigo);
            Console.WriteLine("Quantidade de Vulnerabilidades: " + quant.ToString());
            Console.WriteLine("\nVulnerabilidades do Equipamento:\n");
            if (quant > 0)
                for (int i = 0; i < quant; i++)
                    vulAux.Add(VulRegras.ObterVulnerabilidadeEquipamento(EquRegras.ObterCodigoVulnerabilidade(e2.Codigo, i)));
            else
                Console.WriteLine("- Este equipamento não tem vulnerabilidades registadas.");

            foreach (VulnerabilidadeAux vAux in vulAux)
                Console.WriteLine("Vulnerabilidade:\nCódigo: {0}\nEstado: {1}\nImpacto: {2}\n", vAux.Codigo.ToString(), vAux.Estado.ToString(), vAux.Impacto.ToString());

            vulnsAux = new List<int> { vul3.Codigo, vul4.Codigo, vul5.Codigo, vul6.Codigo };
            Console.WriteLine("\n- Vulnerabilidades do Equipamento 2 Agrupadas por Nivel de Impacto.");
            vulAux = VulRegras.ListarVulnerabilidadesImpacto(vulnsAux);

            Console.Write("\nBaixo:  ");
            foreach (VulnerabilidadeAux vAux in vulAux)
                if (vAux.Impacto == NivelImpacto.BAIXO)
                    Console.Write("{0} | ", vAux.Codigo);
            Console.Write("\nModerado:  ");
            foreach (VulnerabilidadeAux vAux in vulAux)
                if (vAux.Impacto == NivelImpacto.MODERADO)
                    Console.Write("{0} | ", vAux.Codigo);
            Console.Write("\nElevado:  ");
            foreach (VulnerabilidadeAux vAux in vulAux)
                if (vAux.Impacto == NivelImpacto.ELEVADO)
                    Console.WriteLine("{0} | ", vAux.Codigo);
            Console.WriteLine();
            vulAux.Clear();
            Console.ReadKey();
            Console.Clear();

            #endregion

            #region GUARDAR 
            Console.Write("Guardar?\n[1] Sim\n[x] Não\n > ");
            opcao = TryCatchInt();
            if (opcao == 1)
            {
                try
                {
                    EquRegras.GuardarEquipamentos(@"..\..\Ficheiros\Equipamentos");
                }
                catch (IOException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
                try
                {
                    VulRegras.GuardarVulnerabilidades(@"..\..\Ficheiros\Vulnerabilidades");
                }
                catch (IOException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
                try
                {
                    ColRegras.GuardarColaboradores(@"..\..\Ficheiros\Colaboradores");
                }
                catch (IOException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
                try
                {
                    AudRegras.GuardarAuditorias(@"..\..\Ficheiros\Auditorias");
                }
                catch (IOException x)
                {
                    Console.WriteLine(x.Message);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
            }
            #endregion
        }

        #region VALIDACOES LEITURA
        /// <summary>
        /// Verifica a validade de leitura de um numero inteiro
        /// </summary>
        /// <returns>Numero Inteiro válido</returns>
        public static int TryCatchInt()
        {
            int x = 0;
            bool verif = false;
            do
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Caracteres Inválidos.\nInsira Novamente > ");
                }
                catch (Exception e)
                {
                    Console.Write("ERRO: " + e.Message);
                    continue;
                }
                verif = true;
            } while (verif == false);

            return x;
        }

        /// <summary>
        /// Verifica a validade de leitura de uma data
        /// </summary>
        /// <returns>Data válida</returns>
        public static DateTime TryCatchDateTime()
        {
            DateTime x = DateTime.Today;
            bool verif = false;
            do
            {
                try
                {
                    x = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Caracteres Inválidos.\nInsira Novamente > ");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERRO: " + e.Message);
                    continue;
                }
                verif = true;
            } while (verif == false);

            return x;
        }
        #endregion
    }
}
