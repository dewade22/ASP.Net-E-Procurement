using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ReturnReceiptLine
    {
        public int ReturnReceiptLineId { get; set; }
        public int ReturnReceiptHeaderId { get; set; }
        public string DocumentNo { get; set; }
        public int SeqLineNo { get; set; }
        public string SelltoCustomerNo { get; set; }
        public int? RecordType { get; set; }
        public string RecordNo { get; set; }
        public string LocationCode { get; set; }
        public string PostingGroup { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitofMeasure { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitCostLcy { get; set; }
        public decimal? Vatpercent { get; set; }
        public decimal? LineDiscountPercent { get; set; }
        public byte? AllowInvoiceDisc { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? UnitsperParcel { get; set; }
        public decimal? UnitVolume { get; set; }
        public int? AppltoItemEntry { get; set; }
        public int? ItemRcptEntryNo { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string CustomerPriceGroup { get; set; }
        public string JobNo { get; set; }
        public string WorkTypeCode { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public string OrderNo { get; set; }
        public int? OrderLineNo { get; set; }
        public string BilltoCustomerNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int? VatcalculationType { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public int? AttachedtoLineNo { get; set; }
        public string ExitPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string TaxAreaCode { get; set; }
        public byte? TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatbusPostingGroup { get; set; }
        public string VatprodPostingGroup { get; set; }
        public string BlanketOrderNo { get; set; }
        public int? BlanketOrderLineNo { get; set; }
        public decimal? VatbaseAmount { get; set; }
        public decimal? UnitCost { get; set; }
        public DateTime? PostingDate { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal? QtyperUnitofMeasure { get; set; }
        public string UnitofMeasureCode { get; set; }
        public decimal? QuantityBase { get; set; }
        public decimal? QtyInvoicedBase { get; set; }
        public DateTime? FapostingDate { get; set; }
        public string DepreciationBookCode { get; set; }
        public byte? DepruntilFapostingDate { get; set; }
        public string DuplicateinDepreciationBook { get; set; }
        public byte? UseDuplicationList { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string CrossReferenceNo { get; set; }
        public string UnitofMeasureCrossRef { get; set; }
        public int? CrossReferenceType { get; set; }
        public string CrossReferenceTypeNo { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte? Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public decimal? ReturnQtyRcdNotInvd { get; set; }
        public int? ApplfromItemEntry { get; set; }
        public decimal? ItemChargeBaseAmount { get; set; }
        public byte? Correction { get; set; }
        public string ReturnOrderNo { get; set; }
        public int? ReturnOrderLineNo { get; set; }
        public string ReturnReasonCode { get; set; }
        public byte? AllowLineDisc { get; set; }
        public string CustomerDiscGroup { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
