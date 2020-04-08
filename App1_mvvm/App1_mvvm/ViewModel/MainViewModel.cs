using App1_mvvm.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1_mvvm.ViewModel
{
    public class MainViewModel : BaseNotify
    {
        string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
                Notify();
            }
        }
        int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                _quantidade = value;
                Notify();
            }
        }

        string _messagem;
        public string Mensagem 
        {
            get => _messagem;
            set
            {
                _messagem = value;
                Notify();
            }
        }

        public IObservable<Produto> Produtos { get; set; }

        public Command SaveCommand { get; set; }
        public Command EraseCommad { get; set; }

        public MainViewModel()
        {
            SaveCommand = new Command(Save);
            EraseCommad = new Command(Erase);
        }
                                    
        public void Save()
        {
            Mensagem = Nome;
        }

        public void Erase()
        {
            Nome = string.Empty;
            Quantidade = 0;
        }
    }
}
