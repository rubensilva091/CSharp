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
//      Ficheiro da Biblioteca "a2_RegrasNeogico" que aplica regras aos métodos executados na classe Colaboradores
// </desc>
//-----------------------------------------------------------------------

using a3_DadosClasses;
using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace a2_RegrasNegocio
{
    public class ColRegras
    {
        #region METODOS

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
                return Colaboradores.RegistaColaborador(c);
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
                return Colaboradores.EditaColaborador(cod, nome, idade, genero, nif);
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
        /// Verifica se existe colaborador através do seu código
        /// </summary>
        /// <param name="cod">Codigo do colaborador.</param>
        /// <returns>True se existir colaborador
        /// False se não existir</returns>
        public static bool ExisteColaborador(int cod)
        {
            return Colaboradores.ExisteColaborador(cod);
        }

        /// <summary>
        /// Procura um colaborador pelo Nif e devolve o seu código
        /// </summary>
        /// <param name="nif">Nif do colaborador.</param>
        /// <returns>c.Codigo se for encontrado o colaborador
        /// 0 se não for encontrado o colaborador</returns>
        public static int PesquisaColaborador(int nif)
        {
            return Colaboradores.PesquisaColaborador(nif);
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
                return Colaboradores.AdicionaAuditoriaColaborador(cod);
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
        /// Torna um colaborador Inativo
        /// </summary>
        /// <param name="cod">Codigo do colaborador.</param>
        /// <returns>True se tornar um colaborador inativo
        /// False se não tornar um colaborador inativo</returns>
        public static bool TornarColaboradorInativo(int cod)
        {
            try
            {
                return Colaboradores.TornarColaboradorInativo(cod);
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
        /// Verifica o estado de atividade de um colaborador
        /// </summary>
        /// <param name="cod"> Codigo do colaborador em questão </param>
        /// <returns>True se estiver Ativo
        /// False se estiver Inativo </returns>
        public static bool VerificaAtividade(int cod)
        {
            return Colaboradores.VerificaAtividade(cod);
        }

        /// <summary>
        /// Apresenta informação dos colaboradores
        /// </summary>
        /// <param name="a">Auditoria Completa </param>
        public static List<ColaboradorAux> MostraColaboradores()
        {
            return Colaboradores.MostraColaboradores();
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Colaborador
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarColaboradores(string fileName)
        {
            try
            {
                return Colaboradores.GuardarColaboradores(fileName);
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
        /// Carrega o ficheiro binário com a informação relativa à classe Colaborador
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarColaboradores(string fileName)
        {
            try
            {
                return Colaboradores.CarregarColaboradores(fileName);
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
