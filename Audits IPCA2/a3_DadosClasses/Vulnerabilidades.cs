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
//      Ficheiro da Biblioteca "a3_DadosClasses" que manipula os dados relativos à classe vulnerabilidades
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
    public class Vulnerabilidades
    {
        #region VARIAVEIS
        private static List<Vulnerabilidade> vul;
        private static List<VulnerabilidadeAux> vulAux;
        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Vulnerabilidades()
        {
            vul = new List<Vulnerabilidade>();
            vulAux = new List<VulnerabilidadeAux>();
        }

        #endregion

        #region FUNCOES

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
                v.Codigo = (vul.Count) + 1;
                if (ExisteVulnerabilidade(v.Codigo) == true) return 0;
                vul.Add(v);
                return v.Codigo;
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
        /// Verifica se existe vulnerabilidade
        /// </summary>
        /// <param name="cod">Codigo de vulnerabilidade </param>
        /// <returns> True se existir
        /// False se não existir</returns>
        private static bool ExisteVulnerabilidade(int cod)
        {
            return vul.Exists(v => v.Codigo == cod);
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
                if (ExisteVulnerabilidade(cod) == false) return false;
                for (int i = 0; i < vul.Count; i++)
                    if (vul[i].Codigo == cod)
                    {
                        vul[i].Descricao = descricao;
                        vul[i].Impacto = impacto;
                        vul[i].Estado = estado;
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
        /// Lista vuilnerabilidades de uma auditoria agrupadas por nivel de impacto
        /// </summary>
        /// <param name="lst">Lista de codigos de vulnerabilidades</param>
        public static List<VulnerabilidadeAux> ListarVulnerabilidadesImpacto(List<int> lst)
        {
            VulnerabilidadeAux vAux = new VulnerabilidadeAux();
            foreach (int i in lst)
                foreach (Vulnerabilidade v in vul)
                    if (i == v.Codigo)
                    {
                        vAux = new VulnerabilidadeAux(v.Codigo, v.Descricao, v.Impacto, v.Estado);
                        vulAux.Add(vAux);
                    }

            var vulnerabilidadesOrdenadas = from v in vulAux
                                            orderby v.Impacto ascending
                                            select v;

            return vulAux;
        }

        /// <summary>
        /// Obtem vuilnerabilidade relativa a equipamento
        /// </summary>
        /// <param name="cod">Codigo de Vulnerabilidade</param>
        public static VulnerabilidadeAux ObterVulnerabilidadeEquipamento(int cod)
        {
            VulnerabilidadeAux vAux = new VulnerabilidadeAux();
            if (ExisteVulnerabilidade(cod) == false) return null;
            foreach (Vulnerabilidade v in vul)
                if (v.Codigo == cod)
                    vAux = new VulnerabilidadeAux(v.Codigo, v.Descricao, v.Impacto, v.Estado);
            return vAux;
        }

        /// <summary>
        /// Guarda em ficheiro binário a informação relativa à classe Vulnerabilidade
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool GuardarVulnerabilidades(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, vul);
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
        /// Carrega o ficheiro binário com a informação relativa à classe Vulnerabilidade
        /// </summary>
        /// <param name="fileName">Diretório do ficheiro</param>
        public static bool CarregarVulnerabilidades(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    vul = (List<Vulnerabilidade>)bin.Deserialize(stream);
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
