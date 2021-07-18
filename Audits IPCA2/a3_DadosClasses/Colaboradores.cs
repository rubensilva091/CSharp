//-----------------------------------------------------------------------
// <copyright file="Colaboradores.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "a3_DadosClasses" que manipula os dados relativos à classe colaboradores
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
    public class Colaboradores : Pessoa
    {
        #region ATRIBUTOS
        private static List<Colaborador> col;
        private static List<ColaboradorAux> colAux;
        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        static Colaboradores()
        {
            col = new List<Colaborador>();
            colAux = new List<ColaboradorAux>();
        }

        #endregion

        #region FUNCOES

        /// <summary>
        /// Regista um Colaborador
        /// </summary>
        /// <param name="c">Colaborador Completo </param>
        /// <returns> false se já existir esse colaborador
        /// true se for inserido o colaborador</returns>
        public static bool RegistaColaborador(Colaborador c)
        {
            try
            {
                if (PesquisaColaborador(c.Nif) != 0) return false;
                c.Codigo = (col.Count) + 1;
                col.Add(c);
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
        /// Edita as informações de um colaborador
        /// </summary>
        /// <param name="cod">Código do colaborador a editar</param>
        /// <param name="nome">Novo nome do colaborador</param>
        /// <param name="idade">Nova idade do colaborador</param>
        /// <param name="genero">Novo género do colaborador</param>
        /// <param name="nif">Novo nif do colaborador</param>
        /// <returns> True se as informações forem editadas corretamente
        /// False se as informações não forem editadas corretamente </returns>
        public static bool EditaColaborador(int cod, string nome, int idade, Genero genero, int nif)
        {
            try
            {
                if (ExisteColaborador(cod) == false) return false;
                for (int i = 0; i < col.Count; i++)
                    if (col[i].Codigo == cod)
                    {
                        col[i].Nome = nome;
                        col[i].Idade = idade;
                        col[i].Genero = genero;
                        col[i].Nif = nif;
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
        /// Verifica se existe colaborador através do seu código
        /// </summary>
        /// <param name="cod">Codigo do colaborador.</param>
        /// <returns>True se existir colaborador
        /// False se não existir</returns>
        public static bool ExisteColaborador(int cod)
        {
            return col.Exists(c => c.Codigo == cod);
        }

        /// <summary>
        /// Procura um colaborador pelo Nif e devolve o seu código
        /// </summary>
        /// <param name="nif">Nif do colaborador.</param>
        /// <returns>c.Codigo se for encontrado o colaborador
        /// 0 se não for encontrado o colaborador</returns>
        public static int PesquisaColaborador(int nif)
        {
            foreach (Colaborador c in col)
                if (c.Nif == nif) return c.Codigo;
            return 0;
        }

        /// <summary>
        /// Incrementa a quantidade de auditorias de um colaborador
        /// </summary>
        /// <param name="cod">Código do colaborador.</param>
        /// <returns>true se for incrementado corretamente
        /// false se não for encontrado o colaborador</returns>
        public static bool AdicionaAuditoriaColaborador(int cod)
        {
            try
            {
                if (ExisteColaborador(cod) == false) return false;
                for (int i = 0; i < col.Count; i++)
                    if (col[i].Codigo == cod)
                        col[i].QuantAuds++;
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
        /// Torna um colaborador Inativo
        /// </summary>
        /// <param name="cod">Codigo do colaborador.</param>
        /// <returns>True se tornar um colaborador inativo
        /// False se não tornar um colaborador inativo</returns>
        public static bool TornarColaboradorInativo(int cod)
        {
            try
            {
                foreach (Colaborador c in col)
                    if (c.Codigo == cod && c.Atividade == Atividade.ATIVO)
                    {
                        c.Atividade = Atividade.INATIVO;
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
        /// Verifica o estado de atividade de um colaborador
        /// </summary>
        /// <param name="cod"> Codigo do colaborador em questão </param>
        /// <returns>True se estiver Ativo
        /// False se estiver Inativo </returns>
        public static bool VerificaAtividade(int cod)
        {
            foreach (Colaborador c in col)
                if (c.Codigo == cod)
                    if (c.Atividade == Atividade.ATIVO) return true;
            return false;
        }

        /// <summary>
        /// Apresenta informação dos colaboradores
        /// </summary>
        public static List<ColaboradorAux> MostraColaboradores()
        {
            foreach (Colaborador c in col)
            {
                ColaboradorAux cAux = new ColaboradorAux(c.Codigo, c.Atividade, c.Nome, c.Genero, c.Idade, c.Nif);
                colAux.Add(cAux);
            }
            return colAux;
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Colaborador
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarColaboradores(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, col);
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
        /// Carrega o ficheiro binário com a informação relativa à classe Colaborador
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarColaboradores(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    col = (List<Colaborador>)bin.Deserialize(stream);
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
}
