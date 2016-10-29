using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Links_Filterer_and_Separator
{
    public sealed class OutputFilesEnum
    {
        private readonly OutputFiles value;
        private readonly string file;

        public static Dictionary<OutputFiles, OutputFilesEnum> AllConstants = new Dictionary<OutputFiles, OutputFilesEnum>();


        static OutputFilesEnum()
        {
            AllConstants.Add(OutputFiles.LinksDonetperls, LinksDonetperls);
            AllConstants.Add(OutputFiles.LinksExtratorrent, LinksExtratorrent);
            AllConstants.Add(OutputFiles.LinksFacebook, LinksFacebook);
            AllConstants.Add(OutputFiles.LinksGetintopc, LinksGetintopc);
            AllConstants.Add(OutputFiles.LinksGoogle, LinksGoogle);
            AllConstants.Add(OutputFiles.LinksInstagram, LinksInstagram);
            AllConstants.Add(OutputFiles.LinksMicrosoft, LinksMicrosoft);
            AllConstants.Add(OutputFiles.LinksOceanofgames, LinksOceanofgames);
            AllConstants.Add(OutputFiles.LinksPinterest, LinksPinterest);
            AllConstants.Add(OutputFiles.LinksPorn, LinksPorn);
            AllConstants.Add(OutputFiles.LinksStackoverflow, LinksStackoverflow);
            AllConstants.Add(OutputFiles.LinksTumblr, LinksTumblr);
            AllConstants.Add(OutputFiles.LinksTwitter, LinksTwitter);
            AllConstants.Add(OutputFiles.LinksYoutube, LinksYoutube);

            AllConstants.Add(OutputFiles.NamesDramas, NamesDramas);
            AllConstants.Add(OutputFiles.NamesPornstars, NamesPornstars);
            AllConstants.Add(OutputFiles.NamesMovies, NamesMovies);

            AllConstants.Add(OutputFiles.SearchGoogle, SearchGoogle);
            AllConstants.Add(OutputFiles.SearchPorn, SearchPorn);

            AllConstants.Add(OutputFiles.Download, Download);
            AllConstants.Add(OutputFiles.Tasks, Tasks);
            AllConstants.Add(OutputFiles.ScriptsHints, ScriptsHints);
            AllConstants.Add(OutputFiles.MixOthers, MixOthers);
        }
        
        public OutputFilesEnum(OutputFiles value, string file)
        {
            this.value = value;
            this.file = file;
        }
        
        
        public enum OutputFiles
        {
            LinksDonetperls = 1,
            LinksExtratorrent = 2,
            LinksFacebook = 3,
            LinksGetintopc = 4,
            LinksGoogle = 5,
            LinksInstagram = 6,
            LinksMicrosoft = 7,
            LinksOceanofgames = 8,
            LinksPinterest = 9,
            LinksPorn = 10,
            LinksStackoverflow = 11,
            LinksTumblr = 12,
            LinksTwitter = 13,
            LinksYoutube = 14,

            NamesDramas = 41,
            NamesPornstars = 42,
            NamesMovies = 43,

            SearchGoogle = 61,
            SearchPorn = 62,

            Download = 81,
            Tasks = 82,
            ScriptsHints = 83,
            MixOthers = 84,
        }

        private static readonly OutputFilesEnum LinksDonetperls = new OutputFilesEnum(OutputFiles.LinksDonetperls, "Links.Donetperls");
        private static readonly OutputFilesEnum LinksExtratorrent = new OutputFilesEnum(OutputFiles.LinksExtratorrent, "LinksExtratorrent");
        private static readonly OutputFilesEnum LinksFacebook = new OutputFilesEnum(OutputFiles.LinksFacebook, "LinksFacebook");
        private static readonly OutputFilesEnum LinksGetintopc = new OutputFilesEnum(OutputFiles.LinksGetintopc, "LinksGetintopc");
        private static readonly OutputFilesEnum LinksGoogle = new OutputFilesEnum(OutputFiles.LinksGoogle, "LinksGoogle");
        private static readonly OutputFilesEnum LinksInstagram = new OutputFilesEnum(OutputFiles.LinksInstagram, "LinksInstagram");
        private static readonly OutputFilesEnum LinksMicrosoft = new OutputFilesEnum(OutputFiles.LinksMicrosoft, "LinksMicrosoft");
        private static readonly OutputFilesEnum LinksOceanofgames = new OutputFilesEnum(OutputFiles.LinksOceanofgames, "LinksOceanofgames");
        private static readonly OutputFilesEnum LinksPinterest = new OutputFilesEnum(OutputFiles.LinksPinterest, "LinksPinterest");
        private static readonly OutputFilesEnum LinksPorn = new OutputFilesEnum(OutputFiles.LinksPorn, "LinksPorn");
        private static readonly OutputFilesEnum LinksStackoverflow = new OutputFilesEnum(OutputFiles.LinksStackoverflow, "LinksStackoverflow");
        private static readonly OutputFilesEnum LinksTumblr = new OutputFilesEnum(OutputFiles.LinksTumblr, "LinksTumblr");
        private static readonly OutputFilesEnum LinksTwitter = new OutputFilesEnum(OutputFiles.LinksTwitter, "LinksTwitter");
        private static readonly OutputFilesEnum LinksYoutube = new OutputFilesEnum(OutputFiles.LinksYoutube, "LinksYoutube");

        private static readonly OutputFilesEnum NamesDramas = new OutputFilesEnum(OutputFiles.NamesDramas, "NamesDramas");
        private static readonly OutputFilesEnum NamesPornstars = new OutputFilesEnum(OutputFiles.NamesPornstars, "NamesPornstars");
        private static readonly OutputFilesEnum NamesMovies = new OutputFilesEnum(OutputFiles.NamesMovies, "NamesMovies");

        private static readonly OutputFilesEnum SearchGoogle = new OutputFilesEnum(OutputFiles.SearchGoogle, "SearchGoogle");
        private static readonly OutputFilesEnum SearchPorn = new OutputFilesEnum(OutputFiles.SearchPorn, "SearchPorn");

        private static readonly OutputFilesEnum Download = new OutputFilesEnum(OutputFiles.Download, "Download");
        private static readonly OutputFilesEnum Tasks = new OutputFilesEnum(OutputFiles.Tasks, "Tasks");
        private static readonly OutputFilesEnum ScriptsHints = new OutputFilesEnum(OutputFiles.ScriptsHints, "ScriptsHints");
        private static readonly OutputFilesEnum MixOthers = new OutputFilesEnum(OutputFiles.MixOthers, "MixOthers");

        
        
        

        
        public static string GetFileName(OutputFiles value)
        {
            
            foreach (var item in AllConstants)
            {
                if (value == item.Key)
                    return item.Value.file;
            }

            return string.Empty;
        }

    }
}
