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
//      Ficheiro da Biblioteca "a2_RegrasNeogico" que aplica regras aos métodos executados na classe Equipamentos
// </desc>
//-----------------------------------------------------------------------

using a3_DadosClasses;
using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace a2_RegrasNegocio
{
    public class EquRegras
    {

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
                return Equipamentos.RegistaEquipamento(e);
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException("ERRO : " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO : " + x.Message);
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
            return Equipamentos.ExisteEquipamento(cod);
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
                return Equipamentos.EditaEquipamento(cod, marca, modelo, tipo, dataAquisicao);
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException("ERRO : " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO : " + x.Message);
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
                return Equipamentos.AdicionaVulnerabilidadeEquipamento(cod, codv);
            }
            catch (IndexOutOfRangeException x)
            {
                throw new FormatException("ERRO : " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO : " + x.Message);
            }
        }

        /// <summary>
        /// Apresenta informação dos equipamentos
        /// </summary>
        /// <param name="e">Equipamento Completo </param>
        public static List<EquipamentoAux> MostraEquipamentos()
        {
            return Equipamentos.MostraEquipamentos();
        }

        /// <summary>
        /// Obtém equipamento completo através do código recebido
        /// </summary>
        /// <param name="cod"></param>
        /// <returns>Devolve equipamento completo</returns>
        public static EquipamentoAux ObterEquipamento(int cod)
        {
            return Equipamentos.ObterEquipamento(cod);
        }

        /// <summary>
        /// Obtém quantidade de vulnerabilidades num equipamento
        /// </summary>
        /// <param name="cod">Código de equipamento</param>
        /// <returns>Quantidade de vulnerabilidades do equipamento</returns>
        public static int ObterQuantidadeVulnerabilidadesEquipamento(int cod)
        {
            return Equipamentos.ObterQuantidadeVulnerabilidadesEquipamento(cod);
        }

        /// <summary>
        /// Obtém código da vulnerabilidade
        /// </summary>
        /// <param name="cod">Codigo Equipamento</param>
        /// <param name="pos">Posição do código da vulnerabilidade</param>
        /// <returns>Código da vulnerabilidade</returns>
        public static int ObterCodigoVulnerabilidade(int cod, int pos)
        {
            return Equipamentos.ObterCodigoVulnerabilidade(cod, pos);
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Equipamento
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarEquipamentos(string fileName)
        {
            try
            {
                return Equipamentos.GuardarEquipamentos(fileName);
            }
            catch (IOException x)
            {
                throw new IOException("ERRO : " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO : " + x.Message);
            }
        }

        /// <summary>
        /// Carrega o ficheiro binário com a informação relativa à classe Equipamento
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarEquipamentos(string fileName)
        {
            try
            {
                return Equipamentos.CarregarEquipamentos(fileName);
            }
            catch (IOException x)
            {
                throw new IOException("ERRO : " + x.Message);
            }
            catch (Exception x)
            {
                throw new Exception("ERRO : " + x.Message);
            }
        }
    }
}
