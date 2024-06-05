using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAME
{
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class LibraryDocumentList
    {
        public string id { get; set; }
        public string name { get; set; }
        public string creatorEmail { get; set; }
        public string ownerEmail { get; set; }
        public string ownerName { get; set; }
        public DateTime modifiedDate { geta set; }
        public List<string> templateTypes { get; set; }
        public string sharingMode { get; set; }
        public string status { get; set; }
        public bool hidden { get; set; }
    }

    public class Page
    {
    }

    public class Root
    {
        public List<LibraryDocumentList> libraryDocumentList { get; set; }
        public Page page { get; set; }
    }


}
