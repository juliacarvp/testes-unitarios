﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data) 
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listahistorico.Insert(0, "Res: " + res + " - Data: " + data);

            return res;

            // return val1 + val2
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listahistorico.Insert(0, "Res: " + res + " - Data: " + data);

            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listahistorico.Insert(0, "Res: " + res + " - Data: " + data);

            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listahistorico.Insert(0, "Res: " + res + " - Data: " + data);

            return res;
        }

        public List<string> historico() 
        {
            // Remove o excesso da lista e deixa apenas os 3 primeiros 
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
