//-----------------------------------------------------------------------
// <copyright file="Vulnerabilidades.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "a2_RegrasNeogico" que aplica regras aos métodos executados na classe Vulnerabilidades
// </desc>
//-----------------------------------------------------------------------

using a3_DadosClasses;
using c1_ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace a2_RegrasNegocio
{
    public class VulRegras
    {

        /// <summary>
        /// Regista uma vulnerabilidade
        /// </summary>
        /// <param name="v">Vulnerabilidade Completa </param>
        /// <returns> false se já existir essa vulnerabilidade
        /// 1 se for inserida a vulnerabilidade</returns>
        public static int RegistaVulnerabilidade(Vulnerabilidade v)
        {
            try
            {
                return Vulnerabilidades.RegistaVulnerabilidade(v);
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
        /// Edita as informações de uma vulnerabilidade
        /// </summary>
        /// <param name="cod">Código da vulnerabilidade a editar</param>
        /// <param name="descricao">Nova descrição da vulnerabilidade</param>
        /// <param name="impacto">Novo Nivel de impacto da vulnerabilidade</param>
        /// <param name="estado">Novo estado da vulnerabilidade</param>
        /// <returns> True se as informações forem editadas corretamente
        /// False se as informações não forem editadas corretamente </returns>
        public static bool EditaVulnerabilidade(int cod, string descricao, NivelImpacto impacto, Estado estado)
        {
            try
            {
                return Vulnerabilidades.EditaVulnerabilidade(cod, descricao, impacto, estado);
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
        /// Lista vuilnerabilidades relativas a auditoria agrupadas por nivel de impacto
        /// </summary>
        /// <param name="lst">Lista de codigos de vulnerabilidades</param>
        public static List<VulnerabilidadeAux> ListarVulnerabilidadesImpacto(List<int> lst)
        {
            return Vulnerabilidades.ListarVulnerabilidadesImpacto(lst);
        }

        /// <summary>
        /// Lista vuilnerabilidades relativas a equipamento
        /// </summary>
        /// <param name="cod"> Código da vulnerabilidade a listar </param>
        public static VulnerabilidadeAux ObterVulnerabilidadeEquipamento(int cod)
        {
            return Vulnerabilidades.ObterVulnerabilidadeEquipamento(cod);
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Vulnerabilidade
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarVulnerabilidades(string fileName)
        {
            try
            {
                return Vulnerabilidades.GuardarVulnerabilidades(fileName);
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
        /// Carrega o ficheiro binário com a informação relativa à classe Vulnerabilidade
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarVulnerabilidades(string fileName)
        {
            try
            {
                return Vulnerabilidades.CarregarVulnerabilidades(fileName);
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
    }
}
