using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TrialsProject.DTS;

namespace TrialsProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var addAnotherClass = default(char);
            do
            {
                if (GenerateCSClass())
                    Console.WriteLine("CS File generated successfully!");
                Console.WriteLine("Would you like to add another class? (y/n)");
                addAnotherClass = Console.ReadLine()[0];
            }
            while (addAnotherClass == 'y');
            Console.ReadLine();
        }

        public static void CopyDataToClient()
        {
            var sw = new Stopwatch();
            var sqlJob = new SqlJobs();
            var appDbContext = new AppDbContext();


            sw.Start();
            var ArticleParSites = sqlJob.GetAllArticleParSites();
            ArticleParSites.ForEach(art =>
            {
                appDbContext.ArticleParSites.Add(art);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(ArticleParSites.IndexOf(art) / (double)ArticleParSites.Count) * 100d}% of ArticleParSites finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {ArticleParSites.Count} ArticleParSite row(s).");
            sw.Reset();



            sw.Start();
            var Articles = sqlJob.GetAllArticles();
            Articles.ForEach(art =>
            {
                appDbContext.Articles.Add(art);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(Articles.IndexOf(art) / Articles.Count) * 100d}% of Articles finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {Articles.Count} Articles row(s).");
            sw.Reset();



            sw.Start();
            var CategorieSiteClients = sqlJob.GetAllCategorieSiteClients();
            CategorieSiteClients.ForEach(catclt =>
            {
                appDbContext.CategorieSiteClients.Add(catclt);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(CategorieSiteClients.IndexOf(catclt) / CategorieSiteClients.Count) * 100d}% of Articles finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {CategorieSiteClients.Count} CategorieSiteClients row(s).");
            sw.Reset();



            sw.Start();
            var Clients = sqlJob.GetAllClients();
            Clients.ForEach(clt =>
            {
                appDbContext.Clients.Add(clt);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(Clients.IndexOf(clt) / Clients.Count) * 100d}% of Clients finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {Clients.Count} Clients row(s).");
            sw.Reset();



            sw.Start();
            var ClientsMarchandiser = sqlJob.GetAllClientsMarchandiser();
            ClientsMarchandiser.ForEach(cltmrch =>
            {
                appDbContext.ClientsMarchandisers.Add(cltmrch);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(ClientsMarchandiser.IndexOf(cltmrch) / ClientsMarchandiser.Count) * 100d}% of ClientsMarchandiser finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {ClientsMarchandiser.Count} ClientsMarchandiser row(s).");
            sw.Reset();



            sw.Start();
            var ComputerDocument = sqlJob.GetAllComputerDocument();
            ComputerDocument.ForEach(cptdoc =>
            {
                appDbContext.ComputerDocuments.Add(cptdoc);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(ComputerDocument.IndexOf(cptdoc) / ComputerDocument.Count) * 100d}% of ComputerDocuments finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {ComputerDocument.Count} ComputerDocument row(s).");
            sw.Reset();



            sw.Start();
            var FamilleClients = sqlJob.GetAllFamilleClients();
            FamilleClients.ForEach(fmclt =>
            {
                appDbContext.FamilleClients.Add(fmclt);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(FamilleClients.IndexOf(fmclt) / FamilleClients.Count) * 100d}% of FamilleClients finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {FamilleClients.Count} FamilleClients row(s).");
            sw.Reset();



            sw.Start();
            var LigneRapportVisites = sqlJob.GetAllLigneRapportVisites();
            LigneRapportVisites.ForEach(lnrprvst =>
            {
                appDbContext.LigneRapportVisites.Add(lnrprvst);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(LigneRapportVisites.IndexOf(lnrprvst) / LigneRapportVisites.Count) * 100d}% of LigneRapportVisites finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {LigneRapportVisites.Count} LigneRapportVisites row(s).");
            sw.Reset();



            sw.Start();
            var Plans = sqlJob.GetAllPlans();
            Plans.ForEach(pln =>
            {
                appDbContext.Plans.Add(pln);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(Plans.IndexOf(pln) / Plans.Count) * 100d}% of Plans finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {Plans.Count} Plans row(s).");
            sw.Reset();



            sw.Start();
            var ReclamationD = sqlJob.GetAllReclamationD();
            ReclamationD.ForEach(recD =>
            {
                appDbContext.ReclamationDs.Add(recD);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(ReclamationD.IndexOf(recD) / ReclamationD.Count) * 100d}% of ReclamationD finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {ReclamationD.Count} ReclamationD row(s).");
            sw.Reset();



            sw.Start();
            var ReclamationH = sqlJob.GetAllReclamationH();
            ReclamationH.ForEach(recH =>
            {
                appDbContext.ReclamationHs.Add(recH);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(ReclamationH.IndexOf(recH) / ReclamationH.Count) * 100d}% of ReclamationH finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {ReclamationH.Count} ReclamationH row(s).");
            sw.Reset();



            sw.Start();
            var Sites = sqlJob.GetAllSites();
            Sites.ForEach(site =>
            {
                appDbContext.Sites.Add(site);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(Sites.IndexOf(site) / Sites.Count) * 100d}% of Sites finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {Sites.Count} Sites row(s).");
            sw.Reset();



            sw.Start();
            var SitesMarchandiser = sqlJob.GetAllSitesMarchandiser();
            SitesMarchandiser.ForEach(stemrch =>
            {
                appDbContext.SitesMarchandisers.Add(stemrch);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(SitesMarchandiser.IndexOf(stemrch) / SitesMarchandiser.Count) * 100d}% of SitesMarchandiser finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {SitesMarchandiser.Count} SitesMarchandiser row(s).");
            sw.Reset();



            sw.Start();
            var TraceGPS = sqlJob.GetAllTraceGPS();
            TraceGPS.ForEach(trcgps =>
            {
                appDbContext.TraceGPSs.Add(trcgps);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(TraceGPS.IndexOf(trcgps) / TraceGPS.Count) * 100d}% of TraceGPS finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {TraceGPS.Count} TraceGPS row(s).");
            sw.Reset();



            sw.Start();
            var TraceGPSSites = sqlJob.GetAllTraceGPSSites();
            TraceGPSSites.ForEach(trcgpsste =>
            {
                appDbContext.TraceGPSSites.Add(trcgpsste);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(TraceGPSSites.IndexOf(trcgpsste) / TraceGPSSites.Count) * 100d}% of TraceGPSSites finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {TraceGPSSites.Count} TraceGPSSites row(s).");
            sw.Reset();



            sw.Start();
            var TypeVisites = sqlJob.GetAllTypeVisites();
            TypeVisites.ForEach(typvst =>
            {
                appDbContext.TypeVisites.Add(typvst);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(TypeVisites.IndexOf(typvst) / TypeVisites.Count) * 100d}% of TypeVisites finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {TypeVisites.Count} TypeVisites row(s).");
            sw.Reset();



            sw.Start();
            var Utilisateurs = sqlJob.GetAllUtilisateurs();
            Utilisateurs.ForEach(usr =>
            {
                appDbContext.Utilisateurs.Add(usr);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(Utilisateurs.IndexOf(usr) / Utilisateurs.Count) * 100d}% of Utilisateurs finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {Utilisateurs.Count} Utilisateurs row(s).");
            sw.Reset();



            sw.Start();
            var Visites = sqlJob.GetAllVisites();
            Visites.ForEach(vst =>
            {
                appDbContext.Visites.Add(vst);
                appDbContext.SaveChanges();
                Console.WriteLine($"{(Visites.IndexOf(vst) / Visites.Count) * 100d}% of Visites finished.");
            });
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds} milliseconds to get and insert {Visites.Count} Visites row(s).");
            sw.Reset();
        }

        private static void ReplaceHTMLExtensionToCSHTML()
        {
            var filePath = Console.ReadLine();
            var files = Directory.GetFiles(filePath).Where(fn => fn.EndsWith(".html")).ToList();
            files.ForEach(file =>
            {
                var fileName = Path.GetFileName(file);
                var words = fileName.Split('-');
                var output = "";
                words.ToList().ForEach(word =>
                {
                    output += char.ToUpper(word[0]) + word.Substring(1);

                });
                File.Move(file, file.Replace(Path.GetFileName(file), output).Replace(".html", ".cshtml"));
            });
        }

        private static bool GenerateCSClass()
        {
            Console.WriteLine("Write the namespace value:");
            var spacename = Console.ReadLine();
            var script = "using System;\n\nnamespace " + spacename + " \n{\n\tpublic class ";
            Console.WriteLine("Type the absolute path of the output file:");
            var outputFilePath = Console.ReadLine();
            while (!outputFilePath.ToLower().EndsWith(".cs"))
            {
                Console.WriteLine("Type a valid CS file absolute path!");
                outputFilePath = Console.ReadLine();
            }
            var className = Path.GetFileNameWithoutExtension(outputFilePath);
            script += className + "\n\t{" + Environment.NewLine;
            var property = "";
            do
            {
                if (!property.Equals("finished!"))
                {
                    Console.WriteLine("Write property type and property name (example: int x)" + Environment.NewLine + "Write \"finished!\" to stop adding attributes.");
                    property = Console.ReadLine();
                    script += "\t\tpublic " + property + " { get; set; }" + Environment.NewLine;
                }
            } 
            while (!property.Equals("finished!"));

            script += "\t}"+Environment.NewLine+"}";
            File.Create(outputFilePath).Close();
            File.WriteAllText(outputFilePath, script);
            return true;
        }

        private static void GetJsAndCSsScriptLinesPerFile(String folderPath)
        {
            var files = Directory.GetFiles(folderPath).ToList();
            files.ForEach(file =>
            {
                Console.WriteLine("JS Files used in "+Path.GetFileName(file)+": ");
                var linesWithJsFileExtension = File.ReadAllLines(file).Where(line => line.Contains(".js\"")).Select(line => line.Replace("                ","")).ToList();
                linesWithJsFileExtension.ForEach(line => Console.WriteLine(line));

                Console.WriteLine("CSS Files used in " + Path.GetFileName(file) + ": ");
                var linesWithCSSFileExtension = File.ReadAllLines(file).Where(line => line.Contains(".css\"")).Select(line => line.Replace("                ", "")).ToList();
                linesWithCSSFileExtension.ForEach(line => Console.WriteLine(line));
            });
        }
    }
}