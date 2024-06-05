using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Name
{
    public class AgreementModel
    {
        // Roots myDeserializedClass = JsonConvert.DeserializeObject<Roots>(myJsonResponse);
        public class DocumentCreationInfo
        {
            public List<FileInfo> fileInfos { get; set; }
            public string name { get; set; }
            public List<RecipientSetInfo> recipientSetInfos { get; set; }
            public string signatureType { get; set; }
            public string signatureFlow { get; set; }
            
        }

        public class FileInfo
        {
            public string libraryDocumentId { get; set; }
        }

        public class RecipientSetInfo
        {
            public List<RecipientSetMemberInfo> recipientSetMemberInfos { get; set; }
            public string recipientSetRole { get; set; }
        }

        public class RecipientSetMemberInfo
        {
            
            public string email { get; set; }
        }

        public class Roots
        {
            public DocumentCreationInfo documentCreationInfo { get; set; }
        }

    }
}

