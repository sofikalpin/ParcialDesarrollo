using SistemaPedidos.DAL.Repositorios.Contrato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaPedidos.DAL.DBContext;
using Microsoft.Extensions.Logging;



namespace SistemaPedidos.DAL.Repositorios.Contrato
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly OrdenesUsuarioContext _dbContext;
        private readonly ILogger<GenericRepository<TModel>> _logger;

        public GenericRepository(OrdenesUsuarioContext dbContext, ILogger<GenericRepository<TModel>> logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<TModel> Obtener(Expression<Func<TModel, bool>> filtro)
        {
            try
            {
                return await _dbContext.Set<TModel>().FirstOrDefaultAsync(filtro);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el modelo con el filtro especificado.");
                throw new Exception("Ocurrió un error al obtener el modelo.", ex);
            }
        }

        public async Task<TModel> Crear(TModel modelo)
        {
            if (modelo == null)
                throw new ArgumentNullException(nameof(modelo));

            try
            {
                await _dbContext.Set<TModel>().AddAsync(modelo);
                await _dbContext.SaveChangesAsync();
                return modelo;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear un nuevo modelo.");
                throw new Exception("Ocurrió un error al crear el modelo.", ex);
            }
        }

        public async Task<bool> Editar(TModel modelo)
        {
            if (modelo == null)
                throw new ArgumentNullException(nameof(modelo));

            try
            {
                _dbContext.Set<TModel>().Update(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al editar el modelo.");
                throw new Exception("Ocurrió un error al editar el modelo.", ex);
            }
        }

        public async Task<bool> Eliminar(TModel modelo)
        {
            if (modelo == null)
                throw new ArgumentNullException(nameof(modelo));

            try
            {
                _dbContext.Set<TModel>().Remove(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar el modelo.");
                throw new Exception("Ocurrió un error al eliminar el modelo.", ex);
            }
        }

        public async Task<IQueryable<TModel>> Consultar(Expression<Func<TModel, bool>>? filtro = null)
        {
            try
            {
                return filtro == null
                    ? _dbContext.Set<TModel>()
                    : _dbContext.Set<TModel>().Where(filtro);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al consultar modelos.");
                throw new Exception("Ocurrió un error al consultar los modelos.", ex);
            }
        }
    }
}
