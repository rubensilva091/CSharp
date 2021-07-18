//-----------------------------------------------------------------------
// <copyright file="Pessoa.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "c1_ObjetosNegocio" que cria a classse singular Pessoa que serve como Objeto de Negócio
// </desc>
//-----------------------------------------------------------------------

using System;

namespace c1_ObjetosNegocio
{
    #region ENUMS
    public enum Genero
    {
        M,
        F
    }
    #endregion

    [Serializable]
    public class Pessoa : IPessoa
    {
        #region ESTADO

        private int idade;
        private int nif;
        private string nome;
        private Genero genero;

        #endregion

        #region PROPRIEDADES

        //Métodos usados para manipular atributos do Estado

        /// <summary>
        /// Manipula o atributo "genero"
        /// Genero genero;
        /// </summary>
        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Manipula o atributo "nif"
        /// int nif;
        /// </summary>
        public int Nif
        {
            set { nif = value; }
            get { return nif; }
        }

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        public int Idade
        {
            get => idade;
            set
            {
                if (value <= 0)
                {
                    idade = -1;
                }
                else
                {
                    idade = value;
                }
            }
        }
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Métodos usados na criação de novos objectos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public Pessoa()
        {
            this.nif = -1;
            this.idade = -1;
            this.nome = "";
            this.genero = 0;
        }

        /// <summary>
        /// Construtor com dados vindos do exterior
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="genero">Género da Pessoa</param>
        /// <param name="nif">Nif da Pessoa</param>
        /// <param name="idade">Idade da Pessoa</param>
        public Pessoa(string nome, Genero genero, int idade, int nif)
        {
            this.nome = nome;
            this.genero = genero;
            this.idade = idade;
            this.nif = nif;
        }

        #endregion

        #endregion

    }

    /// <summary>
    /// Interface para Pessoa
    /// </summary>
    interface IPessoa
    {
        #region PROPRIEDADES
        int Idade
        {
            get;
            set;
        }

        int Nif
        {
            get;
            set;
        }

        Genero Genero
        {
            get;
            set;
        }

        string Nome
        {
            get;
            set;
        }
        #endregion
    }
}
