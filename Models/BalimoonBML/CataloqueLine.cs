using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CataloqueLine
    {
        public int CataloqueLineId { get; set; }
        public int CataloqueHeaderId { get; set; }
        public string CataloqueHeaderNo { get; set; }
        public int SeqLineNo { get; set; }
        public string ItemNo { get; set; }
        public string Descriptions { get; set; }
        public string ItemStatus { get; set; }
        public string ItemOwn { get; set; }
        public string Ytddata { get; set; }
        public decimal? QuantitySoldYtd { get; set; }
        public decimal? QuantityOhytd { get; set; }
        public decimal? PercentSoldYtd { get; set; }
        public decimal? PercentStytd { get; set; }
        public string Mtddata { get; set; }
        public decimal? QuantitySoldMtd { get; set; }
        public decimal? QuantityOhmtd { get; set; }
        public decimal? PercentSoldMtd { get; set; }
        public decimal? PercentStmtd { get; set; }
        public decimal? CurrenctUnitPrice { get; set; }
        public string OpenCm { get; set; }
        public decimal? OpenPocm { get; set; }
        public string OpenNm { get; set; }
        public decimal? OpenPonm { get; set; }
        public string OpenN2m { get; set; }
        public decimal? OpenPon2m { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
