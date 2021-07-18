//-----------------------------------------------------------------------
// <copyright file="Colaborador.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "c1_ObjetosNegocio" que cria a classse singular Colaborador que serve como Objeto de Negócio
// </desc>
//-----------------------------------------------------------------------

using System;

namespace c1_ObjetosNegocio
{
    #region ENUMS
    public enum Atividade
    {
        ATIVO,
        INATIVO
    }
    #endregion

    [Serializable]
    public class Colaborador : Pessoa, IColaborador
    {
        #region ESTADO
        private int codigo;
        private int quantAuds;
        private Atividade atividade;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public Colaborador() : base()
        {
            this.codigo = 0;
            this.atividade = 0;
            this.quantAuds = 0;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Codigo do Colaborador </param>
        /// <param name="atividade">Atividade do Colaborador </param>
        /// <param name="quantAuds">Quantidade de Auditorias do Colaborador</param>
        /// <param name="nome">Nome do Colaborador </param>
        /// <param name="genero">Género do Colaborador </param>
        /// <param name="idade">Idade do Colaborador </param>
        /// <param name="nif">Nif do Colaborador </param>
        public Colaborador(int codigo, Atividade atividade, int quantAuds, string nome, Genero genero, int idade, int nif) : base(nome, genero, idade, nif)
        {
            this.codigo = codigo;
            this.atividade = atividade;
            this.quantAuds = quantAuds;
            base.Nome = nome;
            base.Genero = genero;
            base.Idade = idade;
            base.Nif = nif;
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
        /// Manipula o atributo "estado"
        /// Estado estado;
        /// </summary>
        public Atividade Atividade
        {
            get => atividade;
            set => atividade = value;
        }

        /// <summary>
        /// Manipula o atributo "quantidade Auditorias"
        /// int quantAuds;
        /// </summary>
        public int QuantAuds
        {
            get => quantAuds;
            set => quantAuds = value;
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Interface para Colaborador
    /// </summary>
    interface IColaborador
    {
        #region PROPRIEDADES
        int Codigo
        {
            get;
            set;
        }

        int QuantAuds
        {
            get;
            set;
        }

        Atividade Atividade
        {
            get;
            set;
        }
        #endregion
    }

    public class ColaboradorAux : Pessoa
    {
        #region ESTADO
        private int codigo;
        private Atividade atividade;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public ColaboradorAux() : base()
        {
            this.codigo = 0;
            this.atividade = 0;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Codigo do Colaborador </param>
        /// <param name="atividade">Atividade do Colaborador </param>
        /// <param name="nome">Nome do Colaborador </param>
        /// <param name="genero">Género do Colaborador </param>
        /// <param name="idade">Idade do Colaborador </param>
        /// <param name="nif">Nif do Colaborador </param>
        public ColaboradorAux(int codigo, Atividade atividade, string nome, Genero genero, int idade, int nif) : base(nome, genero, idade, nif)
        {
            this.codigo = codigo;
            this.atividade = atividade;
            base.Nome = nome;
            base.Genero = genero;
            base.Idade = idade;
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
        /// Manipula o atributo "estado"
        /// Estado estado;
        /// </summary>
        public Atividade Atividade
        {
            get => atividade;
            set => atividade = value;
        }

        #endregion

        #endregion
    }
}
