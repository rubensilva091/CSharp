//-----------------------------------------------------------------------
// <copyright file="Equipamento.cs" company="IPCA">
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
//      Ficheiro da Biblioteca "c1_ObjetosNegocio" que cria a classse singular Equipamento que serve como Objeto de Negócio
// </desc>
//-----------------------------------------------------------------------

using System;

namespace c1_ObjetosNegocio
{
    [Serializable]
    public class Equipamento : IEquipamento
    {
        #region ESTADO
        private int codigo;
        private string tipo;
        private string marca;
        private string modelo;
        private DateTime dataAquisicao;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public Equipamento()
        {
            this.codigo = 0;
            this.tipo = "";
            this.marca = "";
            this.modelo = "";
            this.dataAquisicao = DateTime.Today;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Codigo do Equipamento </param>
        /// <param name="tipo">Tipo do Equipamento</param>
        /// <param name="marca">Marca do Equipamento</param>
        /// <param name="modelo">Modelo do Equipamento</param>
        /// <param name="dataAquisicao">Data de aquisição do Equipamento</param>
        public Equipamento(int codigo, string tipo, string marca, string modelo, DateTime dataAquisicao)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.dataAquisicao = dataAquisicao;
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
        /// Manipula o atributo "tipo"
        /// string tipo;
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Manipula o atributo "marca"
        /// string marca;
        /// </summary>
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        /// <summary>
        /// Manipula o atributo "modelo"
        /// string modelo;
        /// </summary>
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Manipula o atributo "dataAquisicao"
        /// DateTime dataAquisicao;
        /// </summary>
        public DateTime DataAquisicao
        {
            get { return dataAquisicao; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataAquisicao = value;
                }
            }
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Interface para Equipamento
    /// </summary>
    interface IEquipamento
    {
        #region PROPRIEDADES
        int Codigo
        {
            get;
            set;
        }

        string Tipo
        {
            get;
            set;
        }

        string Marca
        {
            get;
            set;
        }

        string Modelo
        {
            get;
            set;
        }

        DateTime DataAquisicao
        {
            get;
            set;
        }
        #endregion
    }

    public class EquipamentoAux
    {
        #region ESTADO
        private int codigo;
        private string tipo;
        private string marca;
        private string modelo;
        private DateTime dataAquisicao;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Criação de novos objetos

        /// <summary>
        /// Construtor com valores por defeito
        /// </summary>
        public EquipamentoAux()
        {
            this.codigo = 0;
            this.tipo = "";
            this.marca = "";
            this.modelo = "";
            this.dataAquisicao = DateTime.Today;
        }

        /// <summary>
        /// Construtor com valores vindos do exterior
        /// </summary>
        /// <param name="codigo">Codigo do Equipamento </param>
        /// <param name="tipo">Tipo do Equipamento</param>
        /// <param name="marca">Marca do Equipamento</param>
        /// <param name="modelo">Modelo do Equipamento</param>
        /// <param name="dataAquisicao">Data de aquisição do Equipamento</param>
        public EquipamentoAux(int codigo, string tipo, string marca, string modelo, DateTime dataAquisicao)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.dataAquisicao = dataAquisicao;
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
        /// Manipula o atributo "tipo"
        /// string tipo;
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Manipula o atributo "marca"
        /// string marca;
        /// </summary>
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        /// <summary>
        /// Manipula o atributo "modelo"
        /// string modelo;
        /// </summary>
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Manipula o atributo "dataAquisicao"
        /// DateTime dataAquisicao;
        /// </summary>
        public DateTime DataAquisicao
        {
            get { return dataAquisicao; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataAquisicao = value;
                }
            }
        }

        #endregion

        #endregion
    }
}
