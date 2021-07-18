//-----------------------------------------------------------------------
// <copyright file="Auditorias.cs" company="IPCA">
//     Copyright. All rights reserved.
// </copyright>
// <date> 05/09/2020 </date>
// <time> 00:45 </time>
// <author> 
//      Carlos Santos (19432)
//      Rúben Silva (19433) 
// </author>
// <email>
//      a19432@alunos.ipca.pt
//      a19433@alunos.ipca.pt
// </email>
// <desc>
//      Ficheiro da Biblioteca "a2_RegrasNeogico" que aplica regras aos métodos executados na classe Auditorias
// </desc>
//-----------------------------------------------------------------------


using a3_DadosClasses;
using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace a2_RegrasNegocio
{
    public class AudRegras
    {
        #region METODOS

        /// <summary>
        /// Regista uma auditoria verificando todas as regras e excecoes
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int RegistaAuditoria(Auditoria a)
        {
            try
            {
                return Auditorias.RegistaAuditoria(a);
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException("ERRO: " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO: " + x.Message);
            }
        }

        /// <summary>
        /// Verifica se existe auditoria
        /// </summary>
        /// <param name="cod"></param>
        /// <returns> True se existir
        /// False se não existir</returns>
        public static bool ExisteAuditoria(int cod)
        {
            return Auditorias.ExisteAuditoria(cod);
        }

        /// <summary>
        /// Obtém a quantidade de auditorias
        /// </summary>
        /// <returns>Devolve a quantidade de auditorias</returns>
        public static int QuantidadeAuditorias()
        {
            return Auditorias.QuantidadeAuditorias();
        }

        /// <summary>
        /// Adiciona uma nova vulnerabilidade a uma auditoria
        /// </summary>
        /// <param name="cod">Codigo de auditoria </param>
        /// <param name="codv">Codigo da Vulnerabilidade a adicionar </param>
        /// <returns> True se for adicionada
        /// False se não for adicionada</returns>
        public static bool AdicionaVulnerabilidadeAuditoria(int cod, int codv)
        {
            try
            {
                return Auditorias.AdicionaVulnerabilidade(cod, codv);
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException("ERRO: " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO: " + x.Message);
            }
        }

        /// <summary>
        /// Edita as informações de uma auditoria
        /// </summary>
        /// <param name="cod">Código da auditoria a editar</param>
        /// <param name="dataRegisto">Nova data de Registo</param>
        /// <param name="duracao">Nova duração</param>
        /// <returns> True se as informações forem editadas corretamente
        /// False se as informações não forem editadas corretamente </returns>
        public static bool EditaAuditoria(int cod, DateTime dataRegisto, int duracao)
        {
            try
            {
                return Auditorias.EditaAuditoria(cod, dataRegisto, duracao);
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException("ERRO: " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO: " + x.Message);
            }
        }

        /// <summary>
        /// Apresenta informação de auditoria detalhada
        /// </summary>
        /// <param name="a">Auditoria Completa </param>
        public static List<AuditoriaAux> MostraAuditorias()
        {
            return Auditorias.MostraAuditorias();
        }

        /// <summary>
        /// Apresenta detalhes sobre as auditorias de um colaborador
        /// </summary>
        /// <param name="codc">Codigo da Vulnerabilidade a adicionar </param>
        /// <returns> True se forem apresentadas auditorias
        /// False se não forem apresentadas auditorias</returns>
        public static List<AuditoriaAux> ApresentaAuditoriasColaborador(int codc)
        {
            return Auditorias.ApresentaAuditoriasColaborador(codc);
        }

        /// <summary>
        /// Apresenta detalhes sobre as auditorias por ordem decrescente de vulnerabilidades
        /// </summary>
        public static List<AuditoriaAux> ApresentaAuditoriasOrdenadasVuln()
        {
            return Auditorias.ApresentaAuditoriasOrdenadasVuln();
        }

        /// <summary>
        /// Obtém auditoria completa através do código recebido
        /// </summary>
        /// <param name="cod">Código da auditoria</param>
        /// <returns>Devolve auditoria completa</returns>
        public static AuditoriaAux ObterAuditoria(int cod)
        {
            return Auditorias.ObterAuditoria(cod);
        }

        /// <summary>
        /// Obtém quantidade de vulnerabilidades em uma auditoria
        /// </summary>
        /// <param name="cod">Código de auditoria</param>
        /// <returns>Quantidade de vulnerabilidades da auditoria</returns>
        public static int ObterQuantidadeVulnerabilidadesAuditoria(int cod)
        {
            return Auditorias.ObterQuantidadeVulnerabilidadesAuditoria(cod);
        }

        /// <summary>
        /// Obtem a auditoria que tem mais vulnerabilidades registadas
        /// </summary>
        /// <returns>Auditoria com mais vulnerabilidades</returns>
        public static AuditoriaAux ObterAuditoriaMaisVuln()
        {
            return Auditorias.ObterAuditoriaMaisVuln();
        }

        /// <summary>
        /// Obtem a auditoria que tem menos vulnerabilidades registadas
        /// </summary>
        /// <returns>Auditoria com menos vulnerabilidades</returns>
        public static AuditoriaAux ObterAuditoriaMenosVuln()
        {
            return Auditorias.ObterAuditoriaMenosVuln();
        }

        /// <summary>
        /// Obtem a média de vulnerabilidades registadas nas auditorias
        /// </summary>
        /// <returns>Media de vulnerabilidades registadas</returns>
        public static double ObtemMediaVulns()
        {
            return Auditorias.ObtemMediaVulns();
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Auditoria
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarAuditorias(string fileName)
        {
            try
            {
                return Auditorias.GuardarAuditorias(fileName);
            }
            catch (IOException x)
            {
                throw new IOException("ERRO: " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO: " + x.Message);
            }
        }

        /// <summary>
        /// Carrega o ficheiro binário com a informação relativa à classe Auditoria
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarAuditorias(string fileName)
        {
            try
            {
                return Auditorias.CarregarAuditorias(fileName);
            }
            catch (IOException x)
            {
                throw new IOException("ERRO: " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO: " + x.Message);
            }
        }


        #endregion
    }
}
