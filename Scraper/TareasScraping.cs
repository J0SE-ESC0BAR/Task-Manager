using Microsoft.Playwright;
using OrganizadorJAEM.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace OrganizadorJAEM.Scraper
{
    internal class TareasScraping
    {
        public List<Tarea> TareasScrapeadas { get; private set; } = new List<Tarea>();

        private Prinsipal _prinsipal;

        public TareasScraping(Prinsipal prinsipal)
        {
            _prinsipal = prinsipal;
        }

        public async Task Scraping(string carnet, string contraseña)
        {
            try
            {
                var urlLogin = "https://utecvirtual.blackboard.com/?new_loc=%2Fultra%2Fdeadline";

                // Iniciar Playwright y el navegador
                var playwright = await Playwright.CreateAsync();
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    ExecutablePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
                });

                // Crear una nueva página
                var page = await browser.NewPageAsync();

                // Navegar a la página de inicio de sesión
                await page.GotoAsync(urlLogin);

                // Ingresar el nombre de usuario y la contraseña
                await page.FillAsync("#user_id", carnet);
                await page.FillAsync("#password", contraseña);

                // Hacer clic en el botón de inicio de sesión
                await page.ClickAsync("#entry-login");

                // Esperar a que la página cargue después del inicio de sesión
                await page.WaitForLoadStateAsync();

                // Esperar un tiempo adicional para asegurarse de que la página haya cargado completamente
                await page.WaitForTimeoutAsync(2000);  // Esperar 2 segundos

                // Obtener el contenido HTML de la página después de iniciar sesión
                var htmlContent = await page.ContentAsync();
                // Cargar el contenido en un documento de HtmlAgilityPack
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(htmlContent);
                // Raspar los datos deseados
                foreach (var element in doc.DocumentNode.SelectNodes("//div[@class='element-details']"))
                {

                    var titleNode = element.SelectSingleNode("div[@class='content']/a");
                    var title = titleNode?.InnerText.Trim();

                    var descriptionNode = element.SelectSingleNode("div[contains(@class, 'name')]/a");

                    var description = descriptionNode?.InnerText.Trim();

                    var dateTextNode = element.SelectSingleNode("div[@class='content']/span");
                    var dateText = dateTextNode?.InnerText.Trim();

                    //##########################################################
                    // Hacer clic en el botón de cada tarea (no funciona de momento)

                    //await page.ClickAsync(".name a");

                    //Verificar si es continuar intento o iniciar intento o ver intento

                    //var EstadoEnviadoNode = element.SelectSingleNode("div[@class='attempt-button-container']/a/span[@class='label-button-attempt']");

                    //var estadoEnviado = EstadoEnviadoNode?.InnerText.Trim();

                    //DateTime? entregado = (estadoEnviado == "Continuar intento") ? DateTime.Now : (DateTime?)null;
                    //#############################################################

                    if (!string.IsNullOrEmpty(dateText))
                    {
                        var parts = dateText.Split(new[] { ": " }, StringSplitOptions.None);
                        if (parts.Length > 1)
                        {
                            var date = parts[1].Trim();

                            if (!string.IsNullOrEmpty(title))
                            {
                                var titleShort = title.Split('-')[0].Trim();

                                TareasScrapeadas.Add(new Tarea
                                {
                                    Tema = titleShort,
                                    Descripcion = description,
                                    // Usando ParseExact con el formato "d/M/yy HH:mm" y la cultura española
                                    Vencimiento = DateTime.ParseExact(date, "d/M/yy HH:mm", new CultureInfo("es-ES"))
                                });
                            }
                        }
                    }

                }
                // Cerrar el navegador
                await page.CloseAsync();
                await browser.CloseAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el proceso de scrapeo: "+ex.Message);
            }
        }
    }
}