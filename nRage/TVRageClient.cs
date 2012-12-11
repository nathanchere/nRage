﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using nRage.Contract.TVRage;

namespace nRage
{

    public class TVRageClient
    {
        private IRetriever Retriever { get; set; }


        public TVRageClient(IRetriever retriever) { this.Retriever = retriever; }

        protected string FormatURLParam(string param)
        {
            // TODO: any fancy formatting here (eg replace space with +, remove certain chars
            return param;
        }

        protected string GetSearchByTitleURL(string title) { return "http://services.tvrage.com/feeds/search.php?show=" + FormatURLParam(title); }

        public SearchResponse SearchByTitle(string title)
        {
            var result = new SearchResponse() { Results = new List<SearchResult>() };

            var response = XDocument.Load(Retriever.Get(GetSearchByTitleURL(title)));
            if (response.Root == null || response.Root.Value == "0") return result;

            result.Results = response.Descendants("show").Select(x=>new SearchResult{
                ShowID = (int) x.Element("showid"),
                Name = (string) x.Element("name"),
                Link = (string) x.Element("link"),
                Country = (string) x.Element("country"),
                Started = (string) x.Element("started"),
                Ended = (string) x.Element("ended"),
                Seasons = (string) x.Element("seasons"),
                Status = (string) x.Element("status"),
                Classification = (string) x.Element("classification"),
                Genres = x.Descendants("genre").Select(y=>y.Value).ToList(),
            }).ToList();

            return result;
        }
    }
}