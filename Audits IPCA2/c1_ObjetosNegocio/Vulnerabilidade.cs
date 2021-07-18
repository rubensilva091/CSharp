//-----------------------------------------------------------------------
// <copyright file="Vulnerabilidade.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "c1_ObjetosNegocio" que cria a classse singular Vulnerabilidade que serve como Objeto de Negócio
// </desc>
//-----------------------------------------------------------------------

using System;

namespace c1_ObjetosNegocio
{
    #region ENUMS
    public enum NivelImpacto
    {
        BAIXO,
        MODERADO,
        ELEVADO
    }

    public enum Estado
    {
        RESOLVIDA,
        NAORESOLVIDA
    }
    #endregion

    [Serializable]
    public class Vulnerabilidade : IVulnerabilidade
    {
        #region ESTADO
        private int codigo;
        private string descricao;
        private NivelImpacto impacto;
        private Estado estado;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public Vulnerabilidade()
        {
            this.codigo = 0;
            this.descricao = "";
            this.impacto = 0;
            this.estado = 0;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Código da Vulnerabilidade</param>
        /// <param name="descricao">Descrição da Vulnerabilidade</param>
        /// <param name="impacto">Nivel de Imapcto da Vulnerabilidade</param>
        /// <param name="estado">Estado da Vulnerabilidade</param>
        public Vulnerabilidade(int codigo, string descricao, NivelImpacto impacto, Estado estado)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.impacto = impacto;
            this.estado = estado;
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
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Manipula o atributo "impacto"
        /// NivelImpacto impacto;
        /// </summary>
        public NivelImpacto Impacto
        {
            get => impacto;
            set => impacto = value;
        }

        /// <summary>
        /// Manipula o atributo "estado"
        /// NivelImpacto impacto;
        /// </summary>
        public Estado Estado
        {
            get => estado;
            set => estado = value;
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Interface para Vulnerabilidade
    /// </summary>
    interface IVulnerabilidade
    {
        #region PROPRIEDADES
        int Codigo
        {
            get;
            set;
        }

        string Descricao
        {
            get;
            set;
        }

        NivelImpacto Impacto
        {
            get;
            set;
        }

        Estado Estado
        {
            get;
            set;
        }
        #endregion
    }

    public class VulnerabilidadeAux
    {
        #region ESTADO
        private int codigo;
        private string descricao;
        private NivelImpacto impacto;
        private Estado estado;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public VulnerabilidadeAux()
        {
            this.codigo = 0;
            this.descricao = "";
            this.impacto = 0;
            this.estado = 0;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Código da Vulnerabilidade</param>
        /// <param name="descricao">Descrição da Vulnerabilidade</param>
        /// <param name="impacto">Nivel de Imapcto da Vulnerabilidade</param>
        /// <param name="estado">Estado da Vulnerabilidade</param>
        public VulnerabilidadeAux(int codigo, string descricao, NivelImpacto impacto, Estado estado)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.impacto = impacto;
            this.estado = estado;
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
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Manipula o atributo "impacto"
        /// NivelImpacto impacto;
        /// </summary>
        public NivelImpacto Impacto
        {
            get => impacto;
            set => impacto = value;
        }

        /// <summary>
        /// Manipula o atributo "estado"
        /// NivelImpacto impacto;
        /// </summary>
        public Estado Estado
        {
            get => estado;
            set => estado = value;
        }

        #endregion

        #endregion
    }
}
