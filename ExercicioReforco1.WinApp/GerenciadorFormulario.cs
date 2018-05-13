using ExercicioReforco1.Dominio.Ultils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioReforco1.WinApp
{
    public abstract class GerenciadorFormulario
    {
        public abstract void Adicionar();
        public abstract void Atualizar();
        public abstract void Excluir();
        public abstract UserControl CarregarListagem();
       
    }
}
