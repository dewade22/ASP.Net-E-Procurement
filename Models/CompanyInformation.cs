using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class CompanyInformation
    {
        public string CompanyCode { get; set; }
        public string ParentCompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyName2 { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyPhoneNo2 { get; set; }
        public string CompanyFaxNo { get; set; }
        public string GiroNo { get; set; }
        public string BankName { get; set; }
        public string BankBranchNo { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountName { get; set; }
        public string BankAddress { get; set; }
        public string PaymentRoutingNo { get; set; }
        public string CustomsPermitNo { get; set; }
        public DateTime? CustomsPermitDate { get; set; }
        public string VatregistrationNo { get; set; }
        public string RegistrationNo { get; set; }
        public string ShiptoName { get; set; }
        public string ShiptoName2 { get; set; }
        public string ShiptoAddress { get; set; }
        public string ShiptoAddress2 { get; set; }
        public string ShiptoCity { get; set; }
        public string ShiptoContact { get; set; }
        public string LocationCode { get; set; }
        public string ImageFolderName { get; set; }
        public string PostCode { get; set; }
        public string ShiptoPostCode { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string CountryRegionCode { get; set; }
        public string ShiptoCountryRegionCode { get; set; }
        public string Iban { get; set; }
        public string Swiftcode { get; set; }
        public string IndustrialClassification { get; set; }
        public string AbbreviatedName { get; set; }
        public byte? ShowAbbreviatedName { get; set; }
        public int? SystemIndicator { get; set; }
        public string CustomSystemIndicatorText { get; set; }
        public int? SystemIndicatorStyle { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string CheckAvailPeriodCalc { get; set; }
        public int? CheckAvailTimeBucket { get; set; }
        public string BaseCalendarCode { get; set; }
        public string CalConvergenceTimeFrame { get; set; }
        public string Abn { get; set; }
        public int? TaxPeriod { get; set; }
        public string AbndivisionPartNo { get; set; }
        public string Irdno { get; set; }
        public string Rdocode { get; set; }
        public DateTime? VatregistrationDate { get; set; }
        public string SignInvoiceName { get; set; }
        public string SignInvoiceDept { get; set; }
        public string InvoiceRemarks { get; set; }
        public string Appversion { get; set; }
        public string FileFolder { get; set; }
        public string LoginImageName { get; set; }
        public string LogoFileName { get; set; }
        public string WallFileName { get; set; }
        public string SecurityCheck { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
