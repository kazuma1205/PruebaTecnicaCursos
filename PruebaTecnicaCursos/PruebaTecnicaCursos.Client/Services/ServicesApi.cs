using PruebaTecnicaCursosModels.Shared.Models;
using System.Net.Http.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnicaCursos.Client.Services
{
    public class ServicesApi
    {
        private readonly HttpClient _httpClient;

        public ServicesApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Usuarios>> GetCursos()
        {
            try
            {
                // solicitud GET a la API del servidor
                var response = await _httpClient.GetFromJsonAsync<List<Usuarios>>("api/cursos");
                if (response == null)
                {
                    return new List<Usuarios>
                    {
                        
                    };
                }
              
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Usuarios>(); 
            }
        }
    }
}
