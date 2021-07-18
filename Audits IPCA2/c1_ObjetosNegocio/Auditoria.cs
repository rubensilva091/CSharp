//-----------------------------------------------------------------------
// <copyright file="Auditoria.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "c1_ObjetosNegocio" que cria a classse singular Auditoria que serve como Objeto de Negócio
// </desc>
//-----------------------------------------------------------------------

using System;

namespace c1_ObjetosNegocio
{
    [Serializable]
    public class Auditoria : IAuditoria
    {

        #region ESTADO
        private int codigo;
        private int duracao;
        private int codColab;
        private int codEqui;
        private DateTime dataRegisto;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public Auditoria()
        {
            this.codigo = 0;
            this.duracao = 0;
            this.dataRegisto = DateTime.Today;
            this.codColab = 0;
            this.codEqui = 0;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Codigo da Auditoria </param>
        /// <param name="duracao">Duracao da Auditoria</param>
        /// <param name="dataRegisto">Data de Registo da Auditoria</param>
        /// <param name="codColab">Código do Colaborador associado</param>
        /// <param name="codEqui">Código do Equipamento associado</param>
        public Auditoria(int codigo, int duracao, DateTime dataRegisto, int codColab, int codEqui)
        {
            this.codigo = codigo;
            this.duracao = duracao;
            this.dataRegisto = dataRegisto;
            this.codColab = codColab;
            this.codEqui = codEqui;
        }

        #endregion

        #region PROPRIEDADES
        // Manipular os atributos do Estado

        /// <summary>
        /// Manipula o atributo "codigo"
        /// int codigo;
        /// </summary>
        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        /// <summary>
        /// Manipula o atributo "duracao"
        /// int duracao;
        /// </summary>
        public int Duracao
        {
            get => duracao;
            set => duracao = value;
        }

        /// <summary>
        /// Manipula o atributo "dataRegisto"
        /// DateTime dataRegisto;
        /// </summary>
        public DateTime DataRegisto
        {
            get { return dataRegisto; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataRegisto = value;
                }
            }
        }

        /// <summary>
        /// Manipula o atributo "codigo Colaborador"
        /// int codColab;
        /// </summary>
        public int CodColab
        {
            get => codColab;
            set => codColab = value;
        }

        /// <summary>
        /// Manipula o atributo "codigo Equipamento"
        /// int codEqui;
        /// </summary>
        public int CodEqui
        {
            get => codEqui;
            set => codEqui = value;
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Interface para Auditoria
    /// </summary>
    interface IAuditoria
    {
        #region PROPRIEDADES
        int Codigo
        {
            get;
            set;
        }

        int Duracao
        {
            get;
            set;
        }

        DateTime DataRegisto
        {
            get;
            set;
        }

        int CodColab
        {
            get;
            set;
        }

        int CodEqui
        {
            get;
            set;
        }
        #endregion
    }

    public class AuditoriaAux
    {

        #region ESTADO
        private int codigo;
        private int duracao;
        private int codColab;
        private int codEqui;
        private DateTime dataRegisto;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public AuditoriaAux()
        {
            this.codigo = 0;
            this.duracao = 0;
            this.dataRegisto = DateTime.Today;
            this.codColab = 0;
            this.codEqui = 0;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Codigo da Auditoria </param>
        /// <param name="duracao">Duracao da Auditoria</param>
        /// <param name="dataRegisto">Data de Registo da Auditoria</param>
        /// <param name="codColab">Código do Colaborador associado</param>
        /// <param name="codEqui">Código do Equipamento associado</param>
        public AuditoriaAux(int codigo, int duracao, DateTime dataRegisto, int codColab, int codEqui)
        {
            this.codigo = codigo;
            this.duracao = duracao;
            this.dataRegisto = dataRegisto;
            this.codColab = codColab;
            this.codEqui = codEqui;
        }

        #endregion

        #region PROPRIEDADES
        // Manipular os atributos do Estado

        /// <summary>
        /// Manipula o atributo "codigo"
        /// int codigo;
        /// </summary>
        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        /// <summary>
        /// Manipula o atributo "dataRegisto"
        /// DateTime dataRegisto;
        /// </summary>
        public DateTime DataRegisto
        {
            get { return dataRegisto; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataRegisto = value;
                }
            }
        }

        /// <summary>
        /// Manipula o atributo "codigo Colaborador"
        /// int codColab;
        /// </summary>
        public int CodColab
        {
            get => codColab;
            set => codColab = value;
        }

        /// <summary>
        /// Manipula o atributo "codigo Equipamento"
        /// int codEqui;
        /// </summary>
        public int CodEqui
        {
            get => codEqui;
            set => codEqui = value;
        }

        /// <summary>
        /// Manipula o atributo "duracao"
        /// int duracao;
        /// </summary>
        public int Duracao
        {
            get => duracao;
            set => duracao = value;
        }

        #endregion

        #endregion
    }

}
