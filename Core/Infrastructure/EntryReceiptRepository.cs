using Application.Interfaces;
using Core.Entities;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using DataStore.Queries;
using Dapper;

namespace Infrastructure
{
    public class EntryReceiptRepository : IEntryReceiptRepository
    {
        private readonly IConfiguration _configuration;

        public EntryReceiptRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> AddAsync(EntryReceipt entity)
        {
            using (IDbConnection connection = new SqlConnection(_configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(EntryReceiptQueries.AddEntryReceipt, entity);
                return result.ToString();
            }
        }
    }
}
