using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Data_CRM.Models.Data;
using API_Data_CRM.Models.Entity;

namespace API_Data_CRM.Services
{
    public class ClienteServices
    {
        private readonly DataContext _contexto;

        public ClienteServices(DataContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<ResponseModel<Cliente>> GetClientesAsync()
        {
            try
            {
                var clientes = await _contexto.Clientes.ToListAsync();

                if (clientes == null || clientes.Count == 0)
                {
                    return new ResponseModel<Cliente>
                    {
                        Data = null,
                        Error = new ErrorlModel
                        {
                            CodigoError = 404,
                            MensajeError = "No se encontraron clientes."
                        }
                    };
                }

                return new ResponseModel<Cliente>
                {
                    Data = clientes,
                    Error = new ErrorlModel
                    {
                        CodigoError = 0,
                        MensajeError = string.Empty
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<Cliente>
                {
                    Data = null,
                    Error = new ErrorlModel
                    {
                        CodigoError = 500,
                        MensajeError = ex.Message
                    }
                };
            }
        }

        public async Task<Cliente> GetClienteByIdAsync(string id)
        {
            return await _contexto.Clientes.FindAsync(id);
        }
    }
}
