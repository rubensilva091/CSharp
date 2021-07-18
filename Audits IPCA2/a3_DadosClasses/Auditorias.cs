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
//      Ficheiro da Biblioteca "a3_DadosClasses" que manipula os dados relativos à classe auditorias
// </desc>
//-----------------------------------------------------------------------

using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace a3_DadosClasses
{
    [Serializable]
    public class Auditorias
    {
        #region ATRIBUTOS
        private static List<AuditoriaCompleta> aud;
        private static List<AuditoriaAux> audAux;
        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Auditorias()
        {
            aud = new List<AuditoriaCompleta>();
            audAux = new List<AuditoriaAux>();
        }

        #endregion

        #region FUNCOES

        /// <summary>
        /// Regista uma auditoria
        /// </summary>
        /// <param name="a">Auditoria Completa </param>
        /// <returns> a.Codigo se a auditoria for inserida
        /// 0 se não for inserida a auditoria</returns>
        public static int RegistaAuditoria(Auditoria a)
        {
            try
            {
                AuditoriaCompleta ac = new AuditoriaCompleta(a);
                ac.a.Codigo = aud.Count + 1;
                if (aud.Contains(ac) == true) return 0;
                aud.Add(ac);
                return ac.a.Codigo;
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException(x.Message);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        /// <summary>
        /// Verifica se existe determinada auditoria
        /// </summary>
        /// <param name="cod">Codigo de auditoria </param>
        /// <returns> True se existir
        /// False se não existir</returns>
        public static bool ExisteAuditoria(int cod)
        {
            return aud.Exists(a => a.a.Codigo == cod);
        }

        /// <summary>
        /// Obtém a quantidade de auditorias
        /// </summary>
        /// <returns>Devolve a quantidade de auditorias</returns>
        public static int QuantidadeAuditorias()
        {
            return aud.Count;
        }

        /// <summary>
        /// Adiciona uma nova vulnerabilidade a uma auditoria
        /// </summary>
        /// <param name="cod">Codigo de auditoria </param>
        /// <param name="codv">Codigo da Vulnerabilidade a adicionar </param>
        /// <returns> True se for adicionada
        /// False se não for adicionada</returns>
        public static bool AdicionaVulnerabilidade(int cod, int codv)
        {
            try
            {
                foreach (AuditoriaCompleta ac in aud)
                    if (cod == ac.a.Codigo)
                    {
                        ac.codVulns.Add(codv);
                        return true;
                    }
                return false;
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException(x.Message);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
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
                if (ExisteAuditoria(cod) == false) return false;
                for (int i = 0; i < aud.Count; i++)
                    if (aud[i].a.Codigo == cod)
                    {
                        aud[i].a.DataRegisto = dataRegisto;
                        aud[i].a.Duracao = duracao;
                    }
                return true;
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException(x.Message);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        /// <summary>
        /// Apresenta informação de auditoria detalhada
        /// </summary>
        /// <param name="a">Auditoria Completa </param>
        public static List<AuditoriaAux> MostraAuditorias()
        {
            foreach (AuditoriaCompleta ac in aud)
            {
                AuditoriaAux aAux = new AuditoriaAux(ac.a.Codigo, ac.a.Duracao, ac.a.DataRegisto, ac.a.CodColab, ac.a.CodEqui);
                audAux.Add(aAux);
            }
            return audAux;
        }

        /// <summary>
        /// Apresenta detalhes sobre as auditorias de um colaborador
        /// </summary>
        /// <param name="codc">Codigo da Vulnerabilidade a adicionar </param>
        /// <returns> True se forem apresentadas auditorias
        /// False se não forem apresentadas auditorias</returns>
        public static List<AuditoriaAux> ApresentaAuditoriasColaborador(int codc)
        {
            var audc = aud.Where(aud => aud.a.CodColab == codc);
            foreach (AuditoriaCompleta ac in audc)
            {
                AuditoriaAux aAux = new AuditoriaAux(ac.a.Codigo, ac.a.Duracao, ac.a.DataRegisto, ac.a.CodColab, ac.a.CodEqui);
                audAux.Add(aAux);
            }
            if (audc.Count() == 0)
                return null;
            return audAux;
        }

        /// <summary>
        /// Apresenta detalhes sobre as auditorias por ordem decrescente de vulnerabilidades
        /// </summary>
        public static List<AuditoriaAux> ApresentaAuditoriasOrdenadasVuln()
        {
            var auditoriasOrdenadas = from a in aud
                                      orderby a.codVulns.Count descending
                                      select a;
            foreach (AuditoriaCompleta ac in auditoriasOrdenadas)
            {
                AuditoriaAux aAux = new AuditoriaAux(ac.a.Codigo, ac.a.Duracao, ac.a.DataRegisto, ac.a.CodColab, ac.a.CodEqui);
                audAux.Add(aAux);
            }
            if (auditoriasOrdenadas.Count() == 0)
                return null;
            return audAux;
        }

        /// <summary>
        /// Obtém auditoria completa através do código recebido
        /// </summary>
        /// <param name="cod">Código da auditoria</param>
        /// <returns>Devolve auditoria completa</returns>
        public static AuditoriaAux ObterAuditoria(int cod)
        {
            AuditoriaAux aAux = new AuditoriaAux();
            foreach (AuditoriaCompleta ac in aud)
                if (ac.a.Codigo == cod)
                {
                    aAux = new AuditoriaAux(ac.a.Codigo, ac.a.Duracao, ac.a.DataRegisto, ac.a.CodColab, ac.a.CodEqui);
                    return aAux;
                }
            return null;
        }

        /// <summary>
        /// Obtém quantidade de vulnerabilidades em uma auditoria
        /// </summary>
        /// <param name="cod">Código de auditoria</param>
        /// <returns>Quantidade de vulnerabilidades da auditoria</returns>
        public static int ObterQuantidadeVulnerabilidadesAuditoria(int cod)
        {
            foreach (AuditoriaCompleta ac in aud)
                if (ac.a.Codigo == cod)
                    return ac.codVulns.Count;
            return 0;
        }

        /// <summary>
        /// Obtem a auditoria que tem mais vulnerabilidades registadas
        /// </summary>
        /// <returns>Auditoria com mais vulnerabilidades</returns>
        public static AuditoriaAux ObterAuditoriaMaisVuln()
        {
            var auditoriasOrdenadas = from a in aud
                                      orderby a.codVulns.Count descending
                                      select a;
            AuditoriaAux aAux = new AuditoriaAux(auditoriasOrdenadas.First().a.Codigo, auditoriasOrdenadas.First().a.Duracao, auditoriasOrdenadas.First().a.DataRegisto, auditoriasOrdenadas.First().a.CodColab, auditoriasOrdenadas.First().a.CodEqui);
            return aAux;
        }

        /// <summary>
        /// Obtem a auditoria que tem menos vulnerabilidades registadas
        /// </summary>
        /// <returns>Auditoria com menos vulnerabilidades</returns>
        public static AuditoriaAux ObterAuditoriaMenosVuln()
        {
            var auditoriasOrdenadas = from a in aud
                                      orderby a.codVulns.Count ascending
                                      select a;
            AuditoriaAux aAux = new AuditoriaAux(auditoriasOrdenadas.First().a.Codigo, auditoriasOrdenadas.First().a.Duracao, auditoriasOrdenadas.First().a.DataRegisto, auditoriasOrdenadas.First().a.CodColab, auditoriasOrdenadas.First().a.CodEqui);
            return aAux;
        }

        /// <summary>
        /// Obtem a média de vulnerabilidades registadas nas auditorias
        /// </summary>
        /// <returns>Media de vulnerabilidades registadas</returns>
        public static double ObtemMediaVulns()
        {
            double media = (from a in aud select a.codVulns.Count).Average();
            return media;
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Auditoria
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarAuditorias(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, aud);
                stream.Close();
                return true;
            }
            catch (IOException x)
            {
                throw new IOException(x.Message);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        /// <summary>
        /// Carrega o ficheiro binário com a informação relativa à classe Auditoria
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarAuditorias(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    aud = (List<AuditoriaCompleta>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException x)
                {
                    throw new IOException(x.Message);
                }
                catch (Exception x)
                {
                    throw new Exception(x.Message);
                }
            }
            return false;
        }

        #endregion

        #endregion
    }

    [Serializable]
    /// <summary>
    /// Classe que compõe a classe Auditoria
    /// </summary>
    class AuditoriaCompleta
    {
        #region ATRIBUTOS
        public Auditoria a;
        public List<int> codVulns;
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtores
        /// </summary>
        /// <param name="a">Auditoria</param>
        public AuditoriaCompleta(Auditoria a)
        {
            this.a = a;
            codVulns = new List<int>();
        }

        public AuditoriaCompleta(Auditoria a, int codV)
        {
            this.a = a;
            codVulns = new List<int>();
            codVulns.Add(codV);
        }
        #endregion
    }
}
