using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces.CRUD;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASPNETHomework.Repositories
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
        protected readonly AspNetHomeworkContext _сontext;
        protected DbSet<TModel> DbSet => _сontext.Set<TModel>();

        /// <summary>
        /// Initialize an instance <see cref="BaseRepository{TDto, TModel}"/>.
        /// </summary>
        /// <param name="context">Data context.</param>
        /// <param name="mapper">Mapper.</param>
        protected BaseRepository(AspNetHomeworkContext context, IMapper mapper)
        {
            _сontext = context;
            _mapper = mapper;
        }

        /// <inheritdoc cref="ICreatable{TDto, TModel}.CreateAsync(TDto)"/>
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await DbSet.AddAsync(entity);
            await _сontext.SaveChangesAsync();
            return await GetAsync(entity.Id);
        }

        /// <inheritdoc cref="IDeletable{TDto, TModel}.DeleteAsync(int[])"/>
        public async Task DeleteAsync(params int[] ids)
        {
            var entities = await DbSet
                                .Where(x => ids.Contains(x.Id))
                                .ToListAsync();

            _сontext.RemoveRange(entities);
            await _сontext.SaveChangesAsync();
        }

        /// <inheritdoc cref="IGettableById{TDto, TModel}.GetAsync(int)"/>
        public async Task<TDto> GetAsync(int id)
        {
            var entity = await DbSet
                              .AsNoTracking()
                              .FirstOrDefaultAsync(x => x.Id == id);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        /// <inheritdoc cref="IUpdatable{TDto, TModel}.UpdateAsync(TDto, CancellationToken)"/>
        public async Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default)
        {
            var entity = _mapper.Map<TModel>(dto);
            _сontext.Update(entity);
            await _сontext.SaveChangesAsync(token);
            var newEntity = await GetAsync(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        /// <inheritdoc cref="IGettable{TDto, TModel}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default)
        {
            var entities = await DbSet.AsNoTracking().ToListAsync();

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
