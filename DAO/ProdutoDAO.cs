﻿using Aula05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula05.DAO
{
    public class ProdutoDAO
    {
        public void Adiciona(Produto produto)
        {
            using (var context = new EstoqueContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public IList<Produto> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Produtos.Include("Categoria").ToList();
            }
        }

        public Produto BuscaPorId(int id)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Produtos.Include("Categoria")
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public void Atualiza(Produto produto)
        {
            using (var contexto = new EstoqueContext())
            {
                contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}