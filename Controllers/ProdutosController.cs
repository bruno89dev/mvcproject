using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercado.Data;
using ProjetoMercado.DTO;
using ProjetoMercado.Models;

namespace ProjetoMercado.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext database;

        public ProdutosController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(ProdutoDTO produtoTemporario){
            if (ModelState.IsValid){
                Produto produto = new Produto();
                produto.Nome = produtoTemporario.Nome;
                produto.Categoria = database.Categorias.First(categoria => categoria.Id == produtoTemporario.CategoriaID);
                produto.Fornecedor = database.Fornecedores.First(fornecedor => fornecedor.Id == produtoTemporario.FornecedorID);
                produto.PrecoDeCusto = produtoTemporario.PrecoDeCusto;
                produto.PrecoDeVenda = produtoTemporario.PrecoDeVenda;
                produto.UnidadeDeMedicao = produtoTemporario.UnidadeDeMedicao;
                produto.Status = true;
                database.Produtos.Add(produto);
                database.SaveChanges();
                return RedirectToAction("Produtos","Gestao");
            } else {
                ViewBag.Categorias = database.Categorias.ToList();
                ViewBag.Fornecedores = database.Fornecedores.ToList();
                return View("../Gestao/NovoProduto");
            }
        }
    }
}