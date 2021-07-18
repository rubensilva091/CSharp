//-----------------------------------------------------------------------
// <copyright file="Equipamentos.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "a3_DadosClasses" que manipula os dados relativos à classe equipamentos
// </desc>
//-----------------------------------------------------------------------

using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace a3_DadosClasses
{
    [Serializable]
    public class Equipamentos
    {
        #region ATRIBUTOS
        private static List<EquipamentoCompleto> equ;
        private static List<EquipamentoAux> equAux;
        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por defeito
        /// </summary>
        static Equipamentos()
        {
            equ = new List<EquipamentoCompleto>();
            equAux = new List<EquipamentoAux>();
        }

        #endregion

        #region FUNCOES

        /// <summary>
        /// Regista um equipamento
        /// </summary>
        /// <param name="e">Equipamento Completo</param>
        /// <returns> e.Codigo se o equipamento for inserido
        /// 0 se não for inserido o equipamento</returns>
        public static int RegistaEquipamento(Equipamento e)
        {
            try
            {
                EquipamentoCompleto ec = new EquipamentoCompleto(e);
                ec.e.Codigo = (equ.Count) + 1;
                if (ExisteEquipamento(e.Codigo) == true) return 0;
                equ.Add(ec);
                return ec.e.Codigo;
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
        /// Verifica se existe Equipamento através do código
        /// </summary>
        /// <param name="cod">Codigo de equipamento </param>
        /// <returns> True se existir
        /// False se não existir</returns>
        public static bool ExisteEquipamento(int cod)
        {
            return equ.Exists(e => e.e.Codigo == cod);
        }

        /// <summary>
        /// Edita as informações de um equipamento
        /// </summary>
        /// <param name="cod">Código do equipamento a editar</param>
        /// <param name="marca">Nova marca do equipamento</param>
        /// <param name="modelo">Novo modelo do equipamento</param>
        /// <param name="tipo">Novo tipo do equipamento</param>
        /// <param name="dataAquisicao">Nova data de aquisição do Equipamento</param>
        /// <returns> True se as informações forem editadas corretamente
        /// False se as informações não forem editadas corretamente </returns>
        public static bool EditaEquipamento(int cod, string marca, string modelo, string tipo, DateTime dataAquisicao)
        {
            try
            {
                if (ExisteEquipamento(cod) == false) return false;
                for (int i = 0; i < equ.Count; i++)
                    if (equ[i].e.Codigo == cod)
                    {
                        equ[i].e.DataAquisicao = dataAquisicao;
                        equ[i].e.Marca = marca;
                        equ[i].e.Modelo = modelo;
                        equ[i].e.Tipo = tipo;
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
        /// Adiciona uma nova vulnerabilidade a um equipamento
        /// </summary>
        /// <param name="cod">Codigo de equipamento </param>
        /// <param name="codv">Codigo da Vulnerabilidade a adicionar </param>
        /// <returns> True se for adicionada
        /// False se não for adicionada</returns>
        public static bool AdicionaVulnerabilidadeEquipamento(int cod, int codv)
        {
            try
            {
                foreach (EquipamentoCompleto ec in equ)
                    if (cod == ec.e.Codigo)
                    {
                        ec.codVulns.Add(codv);
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
        /// Apresenta informação dos equipamentos
        /// </summary>
        /// <param name="e">Equipamento Completo </param>
        public static List<EquipamentoAux> MostraEquipamentos()
        {
            foreach (EquipamentoCompleto ec in equ)
            {
                EquipamentoAux eAux = new EquipamentoAux(ec.e.Codigo, ec.e.Tipo, ec.e.Marca, ec.e.Modelo, ec.e.DataAquisicao);
                equAux.Add(eAux);
            }
            return equAux;
        }

        /// <summary>
        /// Obtém equipamento completo através do código recebido
        /// </summary>
        /// <param name="cod"></param>
        /// <returns>Devolve equipamento completo</returns>
        public static EquipamentoAux ObterEquipamento(int cod)
        {
            foreach (EquipamentoCompleto ec in equ)
                if (ec.e.Codigo == cod)
                {
                    EquipamentoAux eAux = new EquipamentoAux(ec.e.Codigo, ec.e.Tipo, ec.e.Marca, ec.e.Modelo, ec.e.DataAquisicao);
                    return eAux;
                }
            return null;
        }

        /// <summary>
        /// Obtém quantidade de vulnerabilidades num equipamento
        /// </summary>
        /// <param name="cod">Código de equipamento</param>
        /// <returns>Quantidade de vulnerabilidades do equipamento</returns>
        public static int ObterQuantidadeVulnerabilidadesEquipamento(int cod)
        {
            foreach (EquipamentoCompleto ec in equ)
                if (ec.e.Codigo == cod)
                    return ec.codVulns.Count;
            return 0;
        }

        /// <summary>
        /// Obtém código da vulnerabilidade
        /// </summary>
        /// <param name="cod">Codigo Equipamento</param>
        /// <param name="pos">Posição do código da vulnerabilidade</param>
        /// <returns>Código da vulnerabilidade</returns>
        public static int ObterCodigoVulnerabilidade(int cod, int pos)
        {
            foreach (EquipamentoCompleto ec in equ)
                if (ec.e.Codigo == cod)
                    return ec.codVulns[pos];
            return 0;
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Equipamento
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarEquipamentos(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, equ);
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
        /// Carrega o ficheiro binário com a informação relativa à classe Equipamento
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarEquipamentos(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    equ = (List<EquipamentoCompleto>)bin.Deserialize(stream);
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
    /// Classe que compõe a classe Equipamento
    /// </summary>
    class EquipamentoCompleto
    {
        #region ATRIBUTOS
        public Equipamento e;
        public List<int> codVulns;
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor sem adicionar código de vulnerabilidade
        /// </summary>
        /// <param name="e"> Equipamento sem lista de Códigos</param>
        public EquipamentoCompleto(Equipamento e)
        {
            this.e = e;
            codVulns = new List<int>();
        }

        /// <summary>
        /// Construtor com adição de código de vulnerabilidade
        /// </summary>
        /// <param name="e"> Equipamento sem lista de Códigos</param>
        /// <param name="codV"> Código de Vulnerabilidade</param>
        public EquipamentoCompleto(Equipamento e, int codV)
        {
            this.e = e;
            codVulns = new List<int>();
            codVulns.Add(codV);
        }
        #endregion
    }
}

