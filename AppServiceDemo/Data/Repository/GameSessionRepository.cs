﻿using AppServiceDemo.Data.Entities;
using AppServiceDemo.Data.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace AppServiceDemo.Data.Repository
{
    public interface IGameSessionRepository : IRepository<GameSession>
    {
        Task<GameSession> GetByOwnerIdAsync(Guid userId);
    }

    public class GameSessionRepository : CosmosRepository<GameSession, CosmosDbContext>, IGameSessionRepository
    {
        public GameSessionRepository(CosmosDbContext context) : base(context)
        { }

        public async Task<GameSession> GetByOwnerIdAsync(Guid userId)
        {
            return await _context.GameSessions.FirstOrDefaultAsync(x => x.OwnerUserId == userId);
        }
    }
}