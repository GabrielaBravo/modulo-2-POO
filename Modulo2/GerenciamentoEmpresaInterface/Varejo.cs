﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEmpresaInterface
{
    internal class Varejo : EmpresaBase, IEmpresa
    {
        public EnviarNotificacaoWhatsApp EnviarNotificacaoWhatsApp { get;private set; }   
        public Varejo(string nome, string endereco, int cnpj, EnviarNotificacaoWhatsApp notificacaoWhatsApp) : base(nome, endereco, cnpj)
        {
            EnviarNotificacaoWhatsApp = notificacaoWhatsApp;
        }
        
        public void RealizarVenda()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Nome} Está atualmente realizando venda de produtos!");

            Console.WriteLine(sb);
            EnviarNotificacaoWhatsApp.EnviarMensagemCliente();
            
        }
    }
}
