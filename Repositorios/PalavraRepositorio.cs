﻿using ControleAdornos.Entidades;
using ControleAdornos.Interface;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using Repositorios.Queries;

namespace ControleAdornos.Repositorios
{
    public class PalavraRepositorio : RepositorioBase, IRepos
    {
        public PalavraRepositorio()
        {
            VerificaBanco();
        }

        public void VerificaBanco()
        {
            using (var connection = new SqliteConnection(CriaConexao().ConnectionString))
            {
                connection.Open();

                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = Palavra_Queries.CriarTabelaPalavra;
                tableCmd.ExecuteNonQuery();
            }
        }

        public List<Palavra> Obter()
        {
            var lstPalavras = new List<Palavra>();

            using (var connection = new SqliteConnection(CriaConexao().ConnectionString))
            {
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = Palavra_Queries.ObterPalavras;

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstPalavras.Add(new Palavra()
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            Cor = new Cor()
                            {
                                Id = reader.GetInt32(2),
                                Descricao = reader.GetString(3),
                                ValorARBG = reader.GetInt32(4)
                            }
                        });
                    }
                }
            }

            return lstPalavras;
        }

        public void Remover(Palavra palavra)
        {
            using (var connection = new SqliteConnection(CriaConexao().ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var deleteCmd = connection.CreateCommand();
                    deleteCmd.Parameters.AddWithValue("@id", palavra.Id);
                    deleteCmd.CommandText = Palavra_Queries.ApagarPalavra;
                    deleteCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }

        public void Inserir(Palavra palavra)
        {
            using (var connection = new SqliteConnection(CriaConexao().ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var insertCmd = connection.CreateCommand();
                    insertCmd.Parameters.Add(new SqliteParameter("@descricao", palavra.Descricao));
                    insertCmd.Parameters.Add(new SqliteParameter("@material_id", palavra.Material_Id));
                    insertCmd.Parameters.Add(new SqliteParameter("@cor_id", palavra.Cor.Id));
                    insertCmd.CommandText = Palavra_Queries.InserirPalavra;
                    insertCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }

        public void Alterar(Palavra palavra)
        {
            using (var connection = new SqliteConnection(CriaConexao().ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var updateCmd = connection.CreateCommand();
                    updateCmd.Parameters.AddWithValue("@id", palavra.Id);
                    updateCmd.Parameters.AddWithValue("@descricao", palavra.Descricao);
                    updateCmd.Parameters.AddWithValue("@material_id", palavra.Material_Id);
                    updateCmd.Parameters.AddWithValue("@cor_id", palavra.Cor.Id);
                    updateCmd.CommandText = Palavra_Queries.AlterarPalavra;
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }

    }
}
