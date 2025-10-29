using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;

namespace SGDN.CustomerMcp.Functions;

public class SearchCustomersFunction
{
    [Function("SearchCustomer")]
    public async Task<IActionResult> Run(
        [McpToolTrigger("search_customers", "Search for customers in the SGDN Customer database using various search criteria. The query parameter is mandatory")] ToolInvocationContext context,
        [McpToolProperty("query", "string", "Mandatory! Search query string to find customers by name, organization number, or other fields.", true)] string query)
    {
        return new OkObjectResult(new
        {
            Navn = "Drammen Autoco Eiendom AS",
            Adresse = "Grønland 87, 3045 Drammen",
            Telefonnummer = "32 89 22 10",
            Organisasjonsnummer = "938311986",
            Kredittgrense = "20 000 NOK",
            Registreringsdato = "7. mai 1999",
            SistEndret = "20. oktober 2020",
            Status = "Inaktiv"
        });
    }
}
