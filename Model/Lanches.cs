﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesApp.Model
{
    public class Lanches : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }


        private const decimal OVO = 1.50M;
        private const decimal BACON = 2.00M;
        private const decimal CATUPIRY = 2.50M;
        private const decimal CHEDDAR = 2.00M;
        private const decimal MAIONESE = 1.00M;

        public string TextoOvo
        {
            get { return string.Format("Ovo - R$ {0}", OVO); }
        }

        public string TextoBacon
        {
            get { return string.Format("Bacon - R$ {0}", BACON); }
        }

        public string TextoCatupiry
        {
            get { return string.Format("Catupiry - R$ {0}", CATUPIRY); }
        }

        public string TextoCheddar
        {
            get { return string.Format("Cheddar - R$ {0}", CHEDDAR); }
        }

        public string TextoMaionese
        {
            get { return string.Format("Maionese - R$ {0}", MAIONESE); }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", Preco
                    + (TemOvo ? OVO : 0) + (TemBacon ? BACON : 0)
                    + (TemMaionese ? MAIONESE : 0) + (TemCheddar ? CHEDDAR : 0) + (TemCatupiry ? CATUPIRY : 0));
            }
        }

        private bool temOvo;

        public bool TemOvo
        {
            get { return temOvo; }
            set
            {
                temOvo = value;
                RaisePropertyChanged(nameof(ValorTotal));

            }
        }
        //++++++++++++++++++++++++++++++++++++++++
        private bool temMaionese;

        public bool TemMaionese
        {
            get { return temMaionese; }
            set
            {
                temMaionese = value;
                RaisePropertyChanged(nameof(ValorTotal));

            }
        }
        //++++++++++++++++++++++++++++++++++++++++
        private bool temBacon;

        public bool TemBacon
        {
            get { return temBacon; }
            set
            {
                temBacon = value;
                RaisePropertyChanged(nameof(ValorTotal));

            }
        }
        //++++++++++++++++++++++++++++++++++++++++
        private bool temCheddar;

        public bool TemCheddar
        {
            get { return temCheddar; }
            set
            {
                temCheddar = value;
                RaisePropertyChanged(nameof(ValorTotal));

            }
        }
        //++++++++++++++++++++++++++++++++++++++++
        private bool temCatupiry;

        public bool TemCatupiry
        {
            get { return temCatupiry; }
            set
            {
                temCatupiry = value;
                RaisePropertyChanged(nameof(ValorTotal));

            }
        }







    }
}
