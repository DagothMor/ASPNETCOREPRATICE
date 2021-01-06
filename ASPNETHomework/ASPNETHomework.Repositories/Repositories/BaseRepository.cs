﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces.CRUD;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASPNETHomework.Repositories.Repositories
{
    /// <summary>
    /// Base class of repository for work with CRUD.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel>
        where TDto : BaseDto
        where TModel : BaseEntity
    {
        private readonly IMapper _mapper;
        protected DbSet<TModel> _dbSet => Context.Set<TModel>();
        public AspNetHomeworkContext Context { get; }

        /// <summary>
        /// Initialize an instance <see cref="BaseRepository{TDto, TModel}"/>.
        /// </summary>
        /// <param name="context">Data context.</param>
        /// <param name="mapper">Mapper.</param>
        protected BaseRepository(AspNetHomeworkContext context, IMapper mapper)
        {
	        Context = context;
	        _mapper = mapper;
        }

        /// <inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await _dbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return await GetAsync(entity.Id);
        }

        /// <inheritdoc cref="IDeletable{TDto}.DeleteAsync(int[])"/>
        public async Task DeleteAsync(params int[] ids)
        {
            var entities = await _dbSet
                                .Where(x => ids.Contains(x.Id))
                                .ToListAsync();

            Context.RemoveRange(entities);
            await Context.SaveChangesAsync();
        }

        /// <inheritdoc cref="IGettableById{TDto, TModel}.GetAsync(int)"/>
        public async Task<TDto> GetAsync(int id)
        {
	        var entity = await DefaultIncludeProperties(_dbSet)
                .AsNoTracking()
		        .FirstOrDefaultAsync(x => x.Id == id);
            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        /// <inheritdoc cref="IUpdatable{TDto, TModel}.UpdateAsync(TDto, CancellationToken)"/>
        public async Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default)
        {
            var entity = _mapper.Map<TModel>(dto);
            Context.Update(entity);
            await Context.SaveChangesAsync(token);
            var newEntity = await GetAsync(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        /// <inheritdoc cref="IGettable{TDto, TModel}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default)
        {
            var entities = await _dbSet.AsNoTracking().ToListAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }

        /// <summary>
        /// Added to selection related parameter's.
        /// </summary>
        /// <param name="dbSet">DbSet collection of repository.</param>
        protected virtual IQueryable<TModel> DefaultIncludeProperties(DbSet<TModel> dbSet) => dbSet;
    }
}
