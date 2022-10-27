using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA
{
    public class Atividade
    {
        String data;
        String titulo;
        String desc;
        public Atividade(string titulo, string desc, string data)
        {
            this.data = data;
            this.titulo = titulo;
            this.desc = desc;
        }
        public Atividade()
        {
            this.data = "";
            this.titulo = "";
            this.desc = "";
        }

        public void setData(string d)
        {
            data = d;
        }

        public void setTitulo(string t)
        {
            titulo = t;
        }

        public void setDesc(string d)
        {
            desc = d;
        }

        public string getData()
        {
            return data;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public string getDesc()
        {
            return desc;
        }

    }
}
