using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace Bank.Domain.Entities
{
    //Модель документа
    public class Document
    {
        public uint Id { get; set; }
        public string DocumentName { get; set; }
        public DocumentType Type { get; set; }
        public string FilePath { get; set; }
        public DateTime? UploadDate { get; set; }
        public bool IsVerified { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? VerificationDate { get; set; }
        public uint ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
