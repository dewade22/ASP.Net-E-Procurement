using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class BankAccount
    {
        public int BankAccountId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string SearchName { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string PhoneNo { get; set; }
        public string TelexNo { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountName { get; set; }
        public string TransitNo { get; set; }
        public string TerritoryCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string ChainName { get; set; }
        public decimal? MinBalance { get; set; }
        public string BankAccPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public string LanguageCode { get; set; }
        public int? StatisticsGroup { get; set; }
        public string OurContactCode { get; set; }
        public string Country { get; set; }
        public decimal? Amount { get; set; }
        public byte? Blocked { get; set; }
        public string LastStatementNo { get; set; }
        public string FaxNo { get; set; }
        public string TelexAnswerBack { get; set; }
        public string FilePictureName { get; set; }
        public string PostCode { get; set; }
        public string LastCheckNo { get; set; }
        public decimal? BalanceLastStatement { get; set; }
        public string BankBranchNo { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string NoSeries { get; set; }
        public int? CheckReportId { get; set; }
        public string Iban { get; set; }
        public string Swiftcode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
