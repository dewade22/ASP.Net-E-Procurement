using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string No { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string BloodType { get; set; }
        public string PhoneNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public string Email { get; set; }
        public string ReligionCode { get; set; }
        public string JamsostekNo { get; set; }
        public string BpjskesehatanNo { get; set; }
        public string FilePicture { get; set; }
        public DateTime? BirthDate { get; set; }
        public string SocialSecurityNo { get; set; }
        public string TaxCode { get; set; }
        public string PlaceofBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string TaxStatusCode { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountName { get; set; }
        public int? Gender { get; set; }
        public string Country { get; set; }
        public string ManagerNo { get; set; }
        public string EmplymtContractCode { get; set; }
        public string StatisticsGroupCode { get; set; }
        public string EmployeePostingGroup { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public int? Status { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string CauseofInactivityCode { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string GroundsforTermCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string ResourceNo { get; set; }
        public string FaxNo { get; set; }
        public string CompanyEmail { get; set; }
        public string Title { get; set; }
        public string SalespersPurchCode { get; set; }
        public string NoSeries { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
