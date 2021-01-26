using System;
using System.Collections.Generic;

namespace ProcessoÁgil.Models
{
    public static class Cadastro
    {
        private static List<Pessoa> listadepessoas = new List<Pessoa>();          
            
        public static void addPessoa(Pessoa p)
        {
            listadepessoas.Add(p);                   
        
            
        }
        public static List<Pessoa> Listar()
        {
            return listadepessoas;
        } 
    }
}