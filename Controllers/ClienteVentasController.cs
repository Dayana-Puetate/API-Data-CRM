using Microsoft.AspNetCore.Mvc;
using API_Data_CRM.Models.Data;
using API_Data_CRM.Models.Entity;
using API_Data_CRM.Services;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace API_Data_CRM.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ClienteVentasController : ControllerBase
    {
        private readonly ClienteServices _clienteServices;

        public ClienteVentasController(ClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var respuestaDTO = await _clienteServices.GetClientesAsync();
            return Ok(respuestaDTO);
        }

        [HttpGet]
        [Route("clienteId")]
        public async Task<IActionResult> ClienteId(string id)
        {
            var cliente = await _clienteServices.GetClienteByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
    }
}
