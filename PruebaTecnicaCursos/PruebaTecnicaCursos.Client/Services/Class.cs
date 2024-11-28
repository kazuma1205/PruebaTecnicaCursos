using PruebaTecnicaCursosModels.Shared.Models;
using System.Net.Http.Json;

namespace PruebaTecnicaCursos.Client.Services
{
    public class Class
    {
        private readonly HttpClient _httpClient;

        public Class(HttpClient httpClient)
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
