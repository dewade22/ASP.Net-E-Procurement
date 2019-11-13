using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Balimoon_E_Procurement.Models.BalimoonBMI
{
    public partial class BalimoonBMIContext : DbContext
    {
        public BalimoonBMIContext()
        {
        }

        public BalimoonBMIContext(DbContextOptions<BalimoonBMIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountingPeriod> AccountingPeriod { get; set; }
        public virtual DbSet<AnalysisColumn> AnalysisColumn { get; set; }
        public virtual DbSet<AnalysisLine> AnalysisLine { get; set; }
        public virtual DbSet<AnalysisReportName> AnalysisReportName { get; set; }
        public virtual DbSet<AnalysisType> AnalysisType { get; set; }
        public virtual DbSet<AnalysisView> AnalysisView { get; set; }
        public virtual DbSet<AnalysisViewBudgetEntry> AnalysisViewBudgetEntry { get; set; }
        public virtual DbSet<AnalysisViewEntry> AnalysisViewEntry { get; set; }
        public virtual DbSet<AnalysisViewGlaccount> AnalysisViewGlaccount { get; set; }
        public virtual DbSet<ApprovalEntry> ApprovalEntry { get; set; }
        public virtual DbSet<AttributeSetup> AttributeSetup { get; set; }
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<BankAccountLedgerEntry> BankAccountLedgerEntry { get; set; }
        public virtual DbSet<BankAccountPostingGroup> BankAccountPostingGroup { get; set; }
        public virtual DbSet<BaseCalendar> BaseCalendar { get; set; }
        public virtual DbSet<BaseCalendarChange> BaseCalendarChange { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<CampaignEntry> CampaignEntry { get; set; }
        public virtual DbSet<CampaignStatus> CampaignStatus { get; set; }
        public virtual DbSet<CampaignTargetGroup> CampaignTargetGroup { get; set; }
        public virtual DbSet<CauseofAbsence> CauseofAbsence { get; set; }
        public virtual DbSet<CauseofInactivity> CauseofInactivity { get; set; }
        public virtual DbSet<CheckLedgerEntry> CheckLedgerEntry { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRate { get; set; }
        public virtual DbSet<CustInvoiceDisc> CustInvoiceDisc { get; set; }
        public virtual DbSet<CustomerAmount> CustomerAmount { get; set; }
        public virtual DbSet<CustomerBankAccount> CustomerBankAccount { get; set; }
        public virtual DbSet<CustomerDiscountGroup> CustomerDiscountGroup { get; set; }
        public virtual DbSet<CustomerLedgerEntry> CustomerLedgerEntry { get; set; }
        public virtual DbSet<CustomerLedgerEntryB420180120> CustomerLedgerEntryB420180120 { get; set; }
        public virtual DbSet<CustomerLedgerEntryDetailed> CustomerLedgerEntryDetailed { get; set; }
        public virtual DbSet<CustomerPostingGroup> CustomerPostingGroup { get; set; }
        public virtual DbSet<CustomerPriceGroup> CustomerPriceGroup { get; set; }
        public virtual DbSet<CustomerShipToAddress> CustomerShipToAddress { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CvledgerEntryBuffer> CvledgerEntryBuffer { get; set; }
        public virtual DbSet<DetailedCvledgEntryBuffer> DetailedCvledgEntryBuffer { get; set; }
        public virtual DbSet<Dimension> Dimension { get; set; }
        public virtual DbSet<DimensionBuffer> DimensionBuffer { get; set; }
        public virtual DbSet<DimensionValue> DimensionValue { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeAbsence> EmployeeAbsence { get; set; }
        public virtual DbSet<EmployeeLedgerEntry> EmployeeLedgerEntry { get; set; }
        public virtual DbSet<EmployeePostingGroup> EmployeePostingGroup { get; set; }
        public virtual DbSet<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual DbSet<EmployeeRelative> EmployeeRelative { get; set; }
        public virtual DbSet<EmployeeRoles> EmployeeRoles { get; set; }
        public virtual DbSet<EmployeeSalaryRates> EmployeeSalaryRates { get; set; }
        public virtual DbSet<EmployeeStatisticsGroup> EmployeeStatisticsGroup { get; set; }
        public virtual DbSet<EmploymentContract> EmploymentContract { get; set; }
        public virtual DbSet<FixedAsset> FixedAsset { get; set; }
        public virtual DbSet<FixedAssetLedgerEntry> FixedAssetLedgerEntry { get; set; }
        public virtual DbSet<FixedAssetPostingGroup> FixedAssetPostingGroup { get; set; }
        public virtual DbSet<GenBusinessPostingGroup> GenBusinessPostingGroup { get; set; }
        public virtual DbSet<GenJournalBatch> GenJournalBatch { get; set; }
        public virtual DbSet<GenJournalHeader> GenJournalHeader { get; set; }
        public virtual DbSet<GenJournalLine> GenJournalLine { get; set; }
        public virtual DbSet<GenJournalTemplate> GenJournalTemplate { get; set; }
        public virtual DbSet<GenLedgerAccCategory> GenLedgerAccCategory { get; set; }
        public virtual DbSet<GenLedgerAccount> GenLedgerAccount { get; set; }
        public virtual DbSet<GenLedgerBudgetEntry> GenLedgerBudgetEntry { get; set; }
        public virtual DbSet<GenLedgerBudgetName> GenLedgerBudgetName { get; set; }
        public virtual DbSet<GenLedgerEntry> GenLedgerEntry { get; set; }
        public virtual DbSet<GenLedgerRegister> GenLedgerRegister { get; set; }
        public virtual DbSet<GenLedgerSetup> GenLedgerSetup { get; set; }
        public virtual DbSet<GenPostingSetup> GenPostingSetup { get; set; }
        public virtual DbSet<GenProductPostingGroup> GenProductPostingGroup { get; set; }
        public virtual DbSet<GlitemLedgerRelation> GlitemLedgerRelation { get; set; }
        public virtual DbSet<Glregister> Glregister { get; set; }
        public virtual DbSet<GroundsforTermination> GroundsforTermination { get; set; }
        public virtual DbSet<HumanResourceUnitofMeasure> HumanResourceUnitofMeasure { get; set; }
        public virtual DbSet<HumanResourcesSetup> HumanResourcesSetup { get; set; }
        public virtual DbSet<Icpartner> Icpartner { get; set; }
        public virtual DbSet<InventoryPostingBuffer> InventoryPostingBuffer { get; set; }
        public virtual DbSet<InventoryPostingGroup> InventoryPostingGroup { get; set; }
        public virtual DbSet<InventoryPostingSetup> InventoryPostingSetup { get; set; }
        public virtual DbSet<InventoryPosttoGltestBuffer> InventoryPosttoGltestBuffer { get; set; }
        public virtual DbSet<InventorySetup> InventorySetup { get; set; }
        public virtual DbSet<InvoicePostBuffer> InvoicePostBuffer { get; set; }
        public virtual DbSet<ItemBudgetEntry> ItemBudgetEntry { get; set; }
        public virtual DbSet<ItemBudgetName> ItemBudgetName { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<ItemCharge> ItemCharge { get; set; }
        public virtual DbSet<ItemChargeAssignmentPurch> ItemChargeAssignmentPurch { get; set; }
        public virtual DbSet<ItemChargeAssignmentSales> ItemChargeAssignmentSales { get; set; }
        public virtual DbSet<ItemDiscountGroup> ItemDiscountGroup { get; set; }
        public virtual DbSet<ItemEntryRelation> ItemEntryRelation { get; set; }
        public virtual DbSet<ItemFlavours> ItemFlavours { get; set; }
        public virtual DbSet<ItemJournalBatch> ItemJournalBatch { get; set; }
        public virtual DbSet<ItemJournalHeader> ItemJournalHeader { get; set; }
        public virtual DbSet<ItemJournalLine> ItemJournalLine { get; set; }
        public virtual DbSet<ItemJournalTemplate> ItemJournalTemplate { get; set; }
        public virtual DbSet<ItemLedgerEntry> ItemLedgerEntry { get; set; }
        public virtual DbSet<ItemPriceGroup> ItemPriceGroup { get; set; }
        public virtual DbSet<ItemRegister> ItemRegister { get; set; }
        public virtual DbSet<ItemSizes> ItemSizes { get; set; }
        public virtual DbSet<ItemUnitOfMeasures> ItemUnitOfMeasures { get; set; }
        public virtual DbSet<ItemVariants> ItemVariants { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<JournalLineDimension> JournalLineDimension { get; set; }
        public virtual DbSet<LedgerEntryDimension> LedgerEntryDimension { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<MachineCenter> MachineCenter { get; set; }
        public virtual DbSet<ManufacturingSetup> ManufacturingSetup { get; set; }
        public virtual DbSet<MarketingSetup> MarketingSetup { get; set; }
        public virtual DbSet<NoSeries> NoSeries { get; set; }
        public virtual DbSet<NoSeriesLine> NoSeriesLine { get; set; }
        public virtual DbSet<Opportunity> Opportunity { get; set; }
        public virtual DbSet<OpportunityEntry> OpportunityEntry { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PaymentTerms> PaymentTerms { get; set; }
        public virtual DbSet<PhysInventoryLedgerEntry> PhysInventoryLedgerEntry { get; set; }
        public virtual DbSet<PhysInvtCountingPeriod> PhysInvtCountingPeriod { get; set; }
        public virtual DbSet<PhysInvtItemSelection> PhysInvtItemSelection { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<ProductionBomheader> ProductionBomheader { get; set; }
        public virtual DbSet<ProductionBomline> ProductionBomline { get; set; }
        public virtual DbSet<ProductionOrderComponent> ProductionOrderComponent { get; set; }
        public virtual DbSet<ProductionOrderHeader> ProductionOrderHeader { get; set; }
        public virtual DbSet<ProductionOrderLine> ProductionOrderLine { get; set; }
        public virtual DbSet<PurchCommentLine> PurchCommentLine { get; set; }
        public virtual DbSet<PurchaseContractHeader> PurchaseContractHeader { get; set; }
        public virtual DbSet<PurchaseContractLines> PurchaseContractLines { get; set; }
        public virtual DbSet<PurchaseCrMemoHeader> PurchaseCrMemoHeader { get; set; }
        public virtual DbSet<PurchaseCrMemoLine> PurchaseCrMemoLine { get; set; }
        public virtual DbSet<PurchaseInvoiceHeader> PurchaseInvoiceHeader { get; set; }
        public virtual DbSet<PurchaseInvoiceLine> PurchaseInvoiceLine { get; set; }
        public virtual DbSet<PurchaseLineDiscount> PurchaseLineDiscount { get; set; }
        public virtual DbSet<PurchasePrepaymentPercent> PurchasePrepaymentPercent { get; set; }
        public virtual DbSet<PurchasePrice> PurchasePrice { get; set; }
        public virtual DbSet<PurchaseRcptHeader> PurchaseRcptHeader { get; set; }
        public virtual DbSet<PurchaseRcptLine> PurchaseRcptLine { get; set; }
        public virtual DbSet<PurchaseRequisitionHeader> PurchaseRequisitionHeader { get; set; }
        public virtual DbSet<PurchaseRequisitionLine> PurchaseRequisitionLine { get; set; }
        public virtual DbSet<PurchasesHeader> PurchasesHeader { get; set; }
        public virtual DbSet<PurchasesLine> PurchasesLine { get; set; }
        public virtual DbSet<PurchasesPayablesSetup> PurchasesPayablesSetup { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<ReasonCode> ReasonCode { get; set; }
        public virtual DbSet<ReasonCodeGroups> ReasonCodeGroups { get; set; }
        public virtual DbSet<Relative> Relative { get; set; }
        public virtual DbSet<ReportSelections> ReportSelections { get; set; }
        public virtual DbSet<ReservationEntry> ReservationEntry { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourcePrice> ResourcePrice { get; set; }
        public virtual DbSet<ReturnReason> ReturnReason { get; set; }
        public virtual DbSet<ReturnReceiptHeader> ReturnReceiptHeader { get; set; }
        public virtual DbSet<ReturnReceiptLine> ReturnReceiptLine { get; set; }
        public virtual DbSet<ReturnShipmentHeader> ReturnShipmentHeader { get; set; }
        public virtual DbSet<ReturnShipmentLine> ReturnShipmentLine { get; set; }
        public virtual DbSet<RoutingHeader> RoutingHeader { get; set; }
        public virtual DbSet<RoutingLine> RoutingLine { get; set; }
        public virtual DbSet<RoutingLink> RoutingLink { get; set; }
        public virtual DbSet<RoutingPersonnel> RoutingPersonnel { get; set; }
        public virtual DbSet<RoutingQualityMeasure> RoutingQualityMeasure { get; set; }
        public virtual DbSet<RoutingTool> RoutingTool { get; set; }
        public virtual DbSet<SalesCommentLine> SalesCommentLine { get; set; }
        public virtual DbSet<SalesCrMemoHeader> SalesCrMemoHeader { get; set; }
        public virtual DbSet<SalesCrMemoLine> SalesCrMemoLine { get; set; }
        public virtual DbSet<SalesHeader> SalesHeader { get; set; }
        public virtual DbSet<SalesInvoiceHeader> SalesInvoiceHeader { get; set; }
        public virtual DbSet<SalesInvoiceLine> SalesInvoiceLine { get; set; }
        public virtual DbSet<SalesLine> SalesLine { get; set; }
        public virtual DbSet<SalesLineDiscount> SalesLineDiscount { get; set; }
        public virtual DbSet<SalesPrepaymentPercent> SalesPrepaymentPercent { get; set; }
        public virtual DbSet<SalesPrice> SalesPrice { get; set; }
        public virtual DbSet<SalesReceivablesSetup> SalesReceivablesSetup { get; set; }
        public virtual DbSet<SalesShipmentHeader> SalesShipmentHeader { get; set; }
        public virtual DbSet<SalesShipmentLine> SalesShipmentLine { get; set; }
        public virtual DbSet<SalespersonPurchaser> SalespersonPurchaser { get; set; }
        public virtual DbSet<ShopCalendar> ShopCalendar { get; set; }
        public virtual DbSet<ShopCalendarHoliday> ShopCalendarHoliday { get; set; }
        public virtual DbSet<ShopCalendarWorkingDays> ShopCalendarWorkingDays { get; set; }
        public virtual DbSet<SourceCode> SourceCode { get; set; }
        public virtual DbSet<SourceCodeSetup> SourceCodeSetup { get; set; }
        public virtual DbSet<Statement> Statement { get; set; }
        public virtual DbSet<StatementLine> StatementLine { get; set; }
        public virtual DbSet<StatementSalesEntry> StatementSalesEntry { get; set; }
        public virtual DbSet<StockDeliveryHeader> StockDeliveryHeader { get; set; }
        public virtual DbSet<StockDeliveryLine> StockDeliveryLine { get; set; }
        public virtual DbSet<StockRequisitionHeader> StockRequisitionHeader { get; set; }
        public virtual DbSet<StockRequisitionLine> StockRequisitionLine { get; set; }
        public virtual DbSet<StockReturnReceiptHeader> StockReturnReceiptHeader { get; set; }
        public virtual DbSet<StockReturnReceiptLine> StockReturnReceiptLine { get; set; }
        public virtual DbSet<StockkeepingUnit> StockkeepingUnit { get; set; }
        public virtual DbSet<TenderType> TenderType { get; set; }
        public virtual DbSet<TrackingSpecification> TrackingSpecification { get; set; }
        public virtual DbSet<TransferHeader> TransferHeader { get; set; }
        public virtual DbSet<TransferLine> TransferLine { get; set; }
        public virtual DbSet<TransferReceiptHeader> TransferReceiptHeader { get; set; }
        public virtual DbSet<TransferReceiptLine> TransferReceiptLine { get; set; }
        public virtual DbSet<TransferRoute> TransferRoute { get; set; }
        public virtual DbSet<TransferShipmentHeader> TransferShipmentHeader { get; set; }
        public virtual DbSet<TransferShipmentLine> TransferShipmentLine { get; set; }
        public virtual DbSet<UnitOfMeasures> UnitOfMeasures { get; set; }
        public virtual DbSet<ValidationPeriod> ValidationPeriod { get; set; }
        public virtual DbSet<ValueEntry> ValueEntry { get; set; }
        public virtual DbSet<VatamountLine> VatamountLine { get; set; }
        public virtual DbSet<VatbusinessPostingGroup> VatbusinessPostingGroup { get; set; }
        public virtual DbSet<Vatentry> Vatentry { get; set; }
        public virtual DbSet<VatpostingSetup> VatpostingSetup { get; set; }
        public virtual DbSet<VatproductPostingGroup> VatproductPostingGroup { get; set; }
        public virtual DbSet<VendorLedgerEntry> VendorLedgerEntry { get; set; }
        public virtual DbSet<VendorLedgerEntryDetailed> VendorLedgerEntryDetailed { get; set; }
        public virtual DbSet<VendorPostingGroup> VendorPostingGroup { get; set; }
        public virtual DbSet<VendorSalesPrice> VendorSalesPrice { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<WarehouseEmployee> WarehouseEmployee { get; set; }
        public virtual DbSet<WarehouseEntry> WarehouseEntry { get; set; }
        public virtual DbSet<WarehouseJournalBatch> WarehouseJournalBatch { get; set; }
        public virtual DbSet<WarehouseJournalLine> WarehouseJournalLine { get; set; }
        public virtual DbSet<WarehouseJournalTemplate> WarehouseJournalTemplate { get; set; }
        public virtual DbSet<WarehouseReceiptHeader> WarehouseReceiptHeader { get; set; }
        public virtual DbSet<WarehouseReceiptLine> WarehouseReceiptLine { get; set; }
        public virtual DbSet<WarehouseReceiptPostedHeader> WarehouseReceiptPostedHeader { get; set; }
        public virtual DbSet<WarehouseReceiptPostedLine> WarehouseReceiptPostedLine { get; set; }
        public virtual DbSet<WarehouseRegister> WarehouseRegister { get; set; }
        public virtual DbSet<WarehouseRequest> WarehouseRequest { get; set; }
        public virtual DbSet<WarehouseSetup> WarehouseSetup { get; set; }
        public virtual DbSet<WarehouseShipmentHeader> WarehouseShipmentHeader { get; set; }
        public virtual DbSet<WarehouseShipmentLine> WarehouseShipmentLine { get; set; }
        public virtual DbSet<WarehouseShipmentPostedHeader> WarehouseShipmentPostedHeader { get; set; }
        public virtual DbSet<WarehouseShipmentPostedLine> WarehouseShipmentPostedLine { get; set; }
        public virtual DbSet<WorkCenter> WorkCenter { get; set; }
        public virtual DbSet<WorkCenterGroup> WorkCenterGroup { get; set; }

        // Unable to generate entity type for table 'dbo.alv_checkcr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.salesline4upload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.salesheader4upload'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=BalimoonBMI;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccountingPeriod>(entity =>
            {
                entity.HasKey(e => e.StartingDate)
                    .HasName("AccountingPeriod$0");

                entity.HasIndex(e => e.AccountingPeriodId)
                    .HasName("IX_AccountingPeriod")
                    .IsUnique();

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.AccountingPeriodId)
                    .HasColumnName("AccountingPeriodID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisColumn>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisArea, e.AnalysisColumnTemplate, e.LineNo })
                    .HasName("AnalysisColumn$0");

                entity.Property(e => e.AnalysisColumnTemplate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnalysisColumnId)
                    .HasColumnName("AnalysisColumnID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AnalysisTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnHeader)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComparisonDateFormula)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ComparisonPeriodFormula)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ItemLedgerEntryTypeFilter)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValueEntryTypeFilter)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisLine>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisArea, e.AnalysisLineTemplateName, e.LineNo })
                    .HasName("Analysis Line$0");

                entity.Property(e => e.AnalysisLineTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnalysisLineId)
                    .HasColumnName("AnalysisLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension1Totaling)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2Totaling)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension3Totaling)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDimensionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Range)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RowRefNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisReportName>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisArea, e.Name })
                    .HasName("AnalysisReportName$0");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnalysisColumnTemplateName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnalysisLineTemplateName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnalysisReportNameId)
                    .HasColumnName("AnalysisReportNameID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("AnalysisType$0");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisTypeId)
                    .HasColumnName("AnalysisTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemLedgerEntryTypeFilter)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValueEntryTypeFilter)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisView>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("AnalysisView$0");

                entity.HasIndex(e => e.AnalysisViewId)
                    .HasName("IX_AnalysisView")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnalysisViewId)
                    .HasColumnName("AnalysisViewID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusinessUnitFilter)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension3Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension4Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountFilter)
                    .HasColumnName("GLAccountFilter")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateUpdated).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AnalysisViewBudgetEntry>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisViewCode, e.BudgetName, e.GlaccountNo, e.Dimension1ValueCode, e.Dimension2ValueCode, e.Dimension3ValueCode, e.Dimension4ValueCode, e.BusinessUnitCode, e.PostingDate, e.EntryNo })
                    .HasName("AnalysisViewBudgetEntry$0");

                entity.Property(e => e.AnalysisViewCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .HasColumnName("GLAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension1ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension3ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension4ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AnalysisViewBudgetEntryId)
                    .HasColumnName("AnalysisViewBudgetEntryID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AnalysisViewEntry>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisViewCode, e.GlaccountNo, e.Dimension1ValueCode, e.Dimension2ValueCode, e.Dimension3ValueCode, e.Dimension4ValueCode, e.BusinessUnitCode, e.PostingDate, e.EntryNo })
                    .HasName("AnalysisViewEntry$0");

                entity.Property(e => e.AnalysisViewCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .HasColumnName("GLAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension1ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension3ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension4ValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.AddCurrAmount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AddCurrCreditAmount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AddCurrDebitAmount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AnalysisViewEntryId)
                    .HasColumnName("AnalysisViewEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<AnalysisViewGlaccount>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisViewCode, e.GlaccountNo })
                    .HasName("AnalysisViewGLAccount$0");

                entity.ToTable("AnalysisViewGLAccount");

                entity.HasIndex(e => e.AnalysisViewGlaccountId)
                    .HasName("IX_AnalysisViewGLAccount")
                    .IsUnique();

                entity.Property(e => e.AnalysisViewCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .HasColumnName("GLAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnalysisViewGlaccountId)
                    .HasColumnName("AnalysisViewGLAccountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApprovalEntry>(entity =>
            {
                entity.Property(e => e.ApprovalEntryId).HasColumnName("ApprovalEntryID");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApprovalCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableCreditLimitLcy)
                    .HasColumnName("AvailableCreditLimitLCY")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateTimeSentforApproval).HasColumnType("datetime");

                entity.Property(e => e.DelegationDateFormula)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.RecordIdtoApprove)
                    .IsRequired()
                    .HasColumnName("RecordIDtoApprove")
                    .HasMaxLength(448);

                entity.Property(e => e.SalespersPurchCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SenderBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowStepInstanceId).HasColumnName("WorkflowStepInstanceID");
            });

            modelBuilder.Entity<AttributeSetup>(entity =>
            {
                entity.HasKey(e => new { e.AttributeType, e.Code })
                    .HasName("AttributeSetup$0");

                entity.HasIndex(e => e.AttributeSetupId)
                    .HasName("IX_AttributeSetup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeSetupId)
                    .HasColumnName("AttributeSetupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Bank Account$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalanceLastStatement).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BankAccPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChainName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CheckReportId).HasColumnName("CheckReportID");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilePictureName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastCheckNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastStatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MinBalance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OurContactCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SearchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Swiftcode)
                    .HasColumnName("SWIFTCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexAnswerBack)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransitNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankAccountLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("BankAccountLedgerEntry$0");

                entity.HasIndex(e => e.BankAccountLedgerEntryId)
                    .HasName("IX_BankAccountLedgerEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasComputedColumnSql("([DebitAmount]-[CreditAmount])");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountLedgerEntryId)
                    .HasColumnName("BankAccountLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedatDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OurContactCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankAccountPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Bank Account Posting Group$0");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BankAccountPostingGroupId)
                    .HasColumnName("BankAccountPostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GlbankAccountNo)
                    .HasColumnName("GLBankAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BaseCalendar>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("BaseCalendar$0");

                entity.HasIndex(e => e.BaseCalendarId)
                    .HasName("IX_BaseCalendar")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCalendarId)
                    .HasColumnName("BaseCalendarID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaseCalendarChange>(entity =>
            {
                entity.HasKey(e => new { e.BaseCalendarCode, e.RecurringSystem, e.Date, e.Day })
                    .HasName("BaseCalendarChange$0");

                entity.HasIndex(e => e.BaseCalendarChangeId)
                    .HasName("IX_BaseCalendarChange")
                    .IsUnique();

                entity.Property(e => e.BaseCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.BaseCalendarChangeId)
                    .HasColumnName("BaseCalendarChangeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Campaign$0");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("IX_Campaign")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId)
                    .HasColumnName("CampaignID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SellinginEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellinginStartDate).HasColumnType("datetime");

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VisibleDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CampaignEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("Campaign Entry$0");

                entity.HasIndex(e => e.CampaignEntryId)
                    .HasName("IX_CampaignEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.CampaignEntryId)
                    .HasColumnName("CampaignEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CampaignStatus>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Campaign Status$0");

                entity.HasIndex(e => e.CampaignStatusId)
                    .HasName("IX_CampaignStatus")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignStatusId)
                    .HasColumnName("CampaignStatusID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CampaignTargetGroup>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.No, e.CampaignNo })
                    .HasName("Campaign Target Group$0");

                entity.HasIndex(e => e.CampaignTargetGroupId)
                    .HasName("IX_CampaignTargetGroup")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignTargetGroupId)
                    .HasColumnName("CampaignTargetGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CauseofAbsence>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("CauseofAbsence$0");

                entity.HasIndex(e => e.CauseofAbsenceId)
                    .HasName("IX_CauseofAbsence")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CauseofAbsenceId)
                    .HasColumnName("CauseofAbsenceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.UnitofMeasureCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CauseofInactivity>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("CauseofInactivity$0");

                entity.HasIndex(e => e.CauseofInactivityId)
                    .HasName("IX_CauseofInactivity")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CauseofInactivityId)
                    .HasColumnName("CauseofInactivityID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CheckLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("CheckLedgerEntry$0");

                entity.HasIndex(e => e.CheckLedgerEntryId)
                    .HasName("IX_CheckLedgerEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckLedgerEntryId)
                    .HasColumnName("CheckLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CheckNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.StatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryRegion>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("CountryRegion$0");

                entity.HasIndex(e => e.CountryRegionId)
                    .HasName("IX_CountryRegion")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressFormat).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactAddressFormat).HasDefaultValueSql("((0))");

                entity.Property(e => e.CountryRegionId)
                    .HasColumnName("CountryRegionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EucountryRegionCode)
                    .HasColumnName("EUCountryRegionCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntrastatCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Currency$0");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("IX_Currency")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AmountDecimalPlaces)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConvLcyrndgCreditAcc)
                    .HasColumnName("ConvLCYRndgCreditAcc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvLcyrndgDebitAcc)
                    .HasColumnName("ConvLCYRndgDebitAcc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Emucurrency).HasColumnName("EMUCurrency");

                entity.Property(e => e.LastDateAdjusted).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentToleranceAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaxVatdifferenceAllowed)
                    .HasColumnName("MaxVATDifferenceAllowed")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentTolerancePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RealizedGainsAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealizedGlgainsAccount)
                    .HasColumnName("RealizedGLGainsAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealizedGllossesAccount)
                    .HasColumnName("RealizedGLLossesAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealizedLossesAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResidualGainsAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResidualLossesAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAmountDecimalPlaces)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnrealizedGainsAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnrealizedLossesAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatroundingType).HasColumnName("VATRoundingType");
            });

            modelBuilder.Entity<CurrencyExchangeRate>(entity =>
            {
                entity.HasKey(e => new { e.CurrencyCode, e.StartingDate })
                    .HasName("CurrencyExchangeRate$0");

                entity.HasIndex(e => e.CurrencyExchangeRateId)
                    .HasName("IX_CurrencyExchangeRate_1")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.AdjustmentExchRateAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyExchangeRateId)
                    .HasColumnName("CurrencyExchangeRateID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExchangeRateAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.RelationalAdjmtExchRateAmt).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RelationalCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RelationalExchRateAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RelationalSettRateAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SettlementRateAmount).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<CustInvoiceDisc>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.CurrencyCode, e.MinimumAmount })
                    .HasName("Cust_ Invoice Disc_$0");

                entity.HasIndex(e => e.CustInvoiceDiscId)
                    .HasName("IX_CustInvoiceDisc")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustInvoiceDiscId)
                    .HasColumnName("CustInvoiceDiscID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCharge).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<CustomerAmount>(entity =>
            {
                entity.HasKey(e => new { e.CustomerNo, e.AmountLcy, e.Amount2Lcy })
                    .HasName("CustomerAmount$0");

                entity.HasIndex(e => e.CustomerAmountId)
                    .HasName("IX_CustomerAmount")
                    .IsUnique();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount2Lcy)
                    .HasColumnName("Amount2LCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAmountId)
                    .HasColumnName("CustomerAmountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerBankAccount>(entity =>
            {
                entity.HasKey(e => new { e.CustomerNo, e.Code })
                    .HasName("CustomerBankAccount$0");

                entity.HasIndex(e => e.CustomerBankAccountId)
                    .HasName("IX_CustomerBankAccount")
                    .IsUnique();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBankAccountId)
                    .HasColumnName("CustomerBankAccountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Swiftcode)
                    .HasColumnName("SWIFTCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexAnswerBack)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransitNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerDiscountGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("CustomerDiscountGroup$0");

                entity.HasIndex(e => e.CustomerDiscountGroupId)
                    .HasName("IX_CustomerDiscountGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerDiscountGroupId)
                    .HasColumnName("CustomerDiscountGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.HasIndex(e => e.CustomerLedgerEntryId)
                    .HasName("IX_CustomerLedgerEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AcceptedPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdjustedCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdjustmentAppliesto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmounttoApply).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Basadjustment).HasColumnName("BASAdjustment");

                entity.Property(e => e.ClosedatDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedbyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyAmountLcy)
                    .HasColumnName("ClosedbyAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLedgerEntryId)
                    .HasColumnName("CustomerLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("InvDiscountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalAmtLcy)
                    .HasColumnName("OriginalAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscGivenLcy)
                    .HasColumnName("PmtDiscGivenLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscToleranceDate).HasColumnType("datetime");

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PmtToleranceLcy)
                    .HasColumnName("PmtToleranceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PreAdjmtReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitLcy)
                    .HasColumnName("ProfitLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemAmt).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmtLcy)
                    .HasColumnName("RemainingAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReversedCustomerLedgerEntryId).HasColumnName("ReversedCustomerLedgerEntryID");

                entity.Property(e => e.ReversedbyCustomerLedgerEntryId).HasColumnName("ReversedbyCustomerLedgerEntryID");

                entity.Property(e => e.SalesLcy)
                    .HasColumnName("SalesLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerLedgerEntryB420180120>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("CustomerLedgerEntry_b4_20180120");

                entity.HasIndex(e => e.CustomerLedgerEntryId)
                    .HasName("IX_CustomerLedgerEntry_b4_20180120")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AcceptedPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdjustedCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdjustmentAppliesto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmounttoApply).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Basadjustment).HasColumnName("BASAdjustment");

                entity.Property(e => e.ClosedatDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedbyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyAmountLcy)
                    .HasColumnName("ClosedbyAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLedgerEntryId)
                    .HasColumnName("CustomerLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("InvDiscountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalAmtLcy)
                    .HasColumnName("OriginalAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscGivenLcy)
                    .HasColumnName("PmtDiscGivenLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscToleranceDate).HasColumnType("datetime");

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PmtToleranceLcy)
                    .HasColumnName("PmtToleranceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PreAdjmtReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitLcy)
                    .HasColumnName("ProfitLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemAmt).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmtLcy)
                    .HasColumnName("RemainingAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReversedCustomerLedgerEntryId).HasColumnName("ReversedCustomerLedgerEntryID");

                entity.Property(e => e.ReversedbyCustomerLedgerEntryId).HasColumnName("ReversedbyCustomerLedgerEntryID");

                entity.Property(e => e.SalesLcy)
                    .HasColumnName("SalesLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerLedgerEntryDetailed>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliedCustomerLedgerEntryId).HasColumnName("AppliedCustomerLedgerEntryID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLedgerEntryDetailedId)
                    .HasColumnName("CustomerLedgerEntryDetailedID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InitialEntryDueDate).HasColumnType("datetime");

                entity.Property(e => e.InitialEntryGlobalDim1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InitialEntryGlobalDim2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnappliedbyCustomerLedgerEntryDetailedId).HasColumnName("UnappliedbyCustomerLedgerEntryDetailedID");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.CustomerPostingGroupId)
                    .HasName("IX_CustomerPostingGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalFeeAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCurrApplnRndgAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreditRoundingAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroupId)
                    .HasColumnName("CustomerPostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DebitCurrApplnRndgAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebitRoundingAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRoundingAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentDiscCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentToleranceCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentToleranceDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivablesAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceChargeAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerPriceGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("CustomerPriceGroup$0");

                entity.HasIndex(e => e.CustomerPriceGroupId)
                    .HasName("IX_CustomerPriceGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerPriceGroupId)
                    .HasColumnName("CustomerPriceGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPriceChange).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PriceIncludesVat).HasColumnName("PriceIncludesVAT");

                entity.Property(e => e.StoreGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGrPrice)
                    .HasColumnName("VATBusPostingGrPrice")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerShipToAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerNo, e.Code })
                    .HasName("CustomerShipToAddress$0");

                entity.HasIndex(e => e.CustomerShipToAddressId)
                    .HasName("IX_CustomerShipToAddress")
                    .IsUnique();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerShipToAddressId)
                    .HasColumnName("CustomerShipToAddressID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofExport)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexAnswerBack)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerNo);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_Customers")
                    .IsUnique();

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AbndivisionPartNo)
                    .HasColumnName("ABNDivisionPartNo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AllowLineDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ApplicationMethod).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlockPaymentTolerance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Blocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.BudgetedAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChainName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CombineShipments).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComponentsonInvoices).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComponentsonSalesOrders).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComponentsonShipments).HasDefaultValueSql("((0))");

                entity.Property(e => e.CopySelltoAddrtoQteFrom).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditLimitLcy)
                    .HasColumnName("CreditLimitLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEmail)
                    .HasColumnName("CustomerEMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerHomePage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue01Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue02Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue03Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue04Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue05Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FilePicture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinChargeTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceCopies).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Irdno)
                    .HasColumnName("IRDNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastStatementNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Npwpaddress)
                    .HasColumnName("NPWPAddress")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Npwpaddress1)
                    .HasColumnName("NPWPAddress1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Npwpname)
                    .HasColumnName("NPWPName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npwpname1)
                    .HasColumnName("NPWPName1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npwpno)
                    .HasColumnName("NPWPNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OurAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofExport)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PricesIncludingVat)
                    .HasColumnName("PricesIncludingVAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimaryContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatements).HasDefaultValueSql("((0))");

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Registered).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReminderTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reserve).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Segment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAdvice).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticsGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.StexpiryDate)
                    .HasColumnName("STExpiryDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sttype)
                    .HasColumnName("STType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubSegment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDocumentType).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxLiable).HasDefaultValueSql("((0))");

                entity.Property(e => e.TelexAnswerBack)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tglpengukuhan)
                    .HasColumnName("TGLPengukuhan")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvledgerEntryBuffer>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("CVLedgerEntryBuffer$0");

                entity.ToTable("CVLedgerEntryBuffer");

                entity.HasIndex(e => e.CvledgerEntryBufferId)
                    .HasName("IX_CVLedgerEntryBuffer")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AcceptedPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdjustedCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmounttoApply).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPaytoCvno)
                    .HasColumnName("BilltoPaytoCVNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedatDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedbyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyAmountLcy)
                    .HasColumnName("ClosedbyAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CvledgerEntryBufferId)
                    .HasColumnName("CVLedgerEntryBufferID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cvno)
                    .HasColumnName("CVNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CvpostingGroup)
                    .HasColumnName("CVPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("InvDiscountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalAmtLcy)
                    .HasColumnName("OriginalAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscGivenLcy)
                    .HasColumnName("PmtDiscGivenLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscToleranceDate).HasColumnType("datetime");

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PmtToleranceLcy)
                    .HasColumnName("PmtToleranceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProfitLcy)
                    .HasColumnName("ProfitLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmtLcy)
                    .HasColumnName("RemainingAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoundingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoundingAmountLcy)
                    .HasColumnName("RoundingAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoundingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPurchaseLcy)
                    .HasColumnName("SalesPurchaseLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetailedCvledgEntryBuffer>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("DetailedCVLedgEntryBuffer$0");

                entity.ToTable("DetailedCVLedgEntryBuffer");

                entity.HasIndex(e => e.DetailedCvledgEntryBufferId)
                    .HasName("IX_DetailedCVLedgEntryBuffer")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AdditionalCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliedCvledgerEntryNo).HasColumnName("AppliedCVLedgerEntryNo");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DetailedCvledgEntryBufferId)
                    .HasColumnName("DetailedCVLedgEntryBufferID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InitialEntryDueDate).HasColumnType("datetime");

                entity.Property(e => e.InitialEntryGlobalDim1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InitialEntryGlobalDim2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatamountLcy)
                    .HasColumnName("VATAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dimension>(entity =>
            {
                entity.HasKey(e => e.DimensionCode);

                entity.HasIndex(e => e.DimensionId)
                    .HasName("IX_Dimension")
                    .IsUnique();

                entity.Property(e => e.DimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Blocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodeCaption)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DimensionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionId)
                    .HasColumnName("DimensionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DimensionName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilterCaption)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DimensionBuffer>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.EntryNo, e.DimensionCode })
                    .HasName("DimensionBuffer$0");

                entity.HasIndex(e => e.DimensionBufferId)
                    .HasName("IX_DimensionBuffer")
                    .IsUnique();

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DimensionBufferId)
                    .HasColumnName("DimensionBufferID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NewDimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionValue>(entity =>
            {
                entity.HasKey(e => new { e.DimensionCode, e.DimensionValueCode })
                    .HasName("DimensionValue$0");

                entity.HasIndex(e => e.DimensionValueId)
                    .HasName("IX_DimensionValue")
                    .IsUnique();

                entity.Property(e => e.DimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Blocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DimensionValueId)
                    .HasColumnName("DimensionValueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DimensionValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ParentDimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Employee$0");

                entity.HasIndex(e => new { e.Status, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Status, e.EmplymtContractCode, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BpjskesehatanNo)
                    .HasColumnName("BPJSKesehatanNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CauseofInactivityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmployeePostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentDate).HasColumnType("datetime");

                entity.Property(e => e.EmplymtContractCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilePicture)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroundsforTermCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveDate).HasColumnType("datetime");

                entity.Property(e => e.Initials)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JamsostekNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofBirth)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersPurchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticsGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStatusCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeAbsence>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("EmployeeAbsence$0");

                entity.HasIndex(e => e.EmployeeAbsenceId)
                    .HasName("IX_EmployeeAbsence")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.CauseofAbsenceCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeAbsenceId)
                    .HasColumnName("EmployeeAbsenceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UnitofMeasureCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("EmployeeLedgerEntry$0");

                entity.HasIndex(e => e.EmployeeLedgerEntryId)
                    .HasName("IX_EmployeeLedgerEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasComputedColumnSql("([DebitAmount]-[CreditAmount])");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasComputedColumnSql("([DebitAmountLCY]-[CreditAmountLCY])");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedatDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedbyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyAmountLcy)
                    .HasColumnName("ClosedbyAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLedgerEntryId)
                    .HasColumnName("EmployeeLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmountLcy)
                    .HasColumnName("RemainingAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeePostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("EmployeePostingGroup$0");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeePostingGroupId)
                    .HasColumnName("EmployeePostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GlaccountNo)
                    .HasColumnName("GLAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeQualification>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.SeqLineNo })
                    .HasName("EmployeeQualification$0");

                entity.HasIndex(e => e.EmployeeQualificationId)
                    .HasName("IX_EmployeeQualification")
                    .IsUnique();

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CourseGrade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeQualificationId)
                    .HasColumnName("EmployeeQualificationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.InstitutionCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.QualificationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeRelative>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.SeqLineNo })
                    .HasName("EmployeeRelative$0");

                entity.HasIndex(e => e.EmployeeRelativeId)
                    .HasName("IX_EmployeeRelative")
                    .IsUnique();

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeRelativeId)
                    .HasColumnName("EmployeeRelativeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RelativeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RelativesEmployeeNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeRoles>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.WorkRoleCode })
                    .HasName("EmployeeRoles$0");

                entity.HasIndex(e => e.EmployeeRolesId)
                    .HasName("IX_EmployeeRoles")
                    .IsUnique();

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkRoleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeRolesId)
                    .HasColumnName("EmployeeRolesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Qualifications)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkArrangementCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeSalaryRates>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.WorkRoleCode, e.WorkCode, e.DateFrom })
                    .HasName("EmployeeSalaryRates$0");

                entity.HasIndex(e => e.EmployeeSalaryRatesId)
                    .HasName("IX_EmployeeSalaryRates")
                    .IsUnique();

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkRoleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeSalaryRatesId)
                    .HasColumnName("EmployeeSalaryRatesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HourlyCostRate).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SalaryCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeStatisticsGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("EmployeeStatisticsGroup$0");

                entity.HasIndex(e => e.EmployeeStatisticsGroupId)
                    .HasName("IX_EmployeeStatisticsGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatisticsGroupId).HasColumnName("EmployeeStatisticsGroupID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmploymentContract>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("EmploymentContract$0");

                entity.HasIndex(e => e.EmploymentContractId)
                    .HasName("IX_EmploymentContract")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentContractId)
                    .HasColumnName("EmploymentContractID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FixedAsset>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.HasIndex(e => e.FixedAssetId)
                    .HasName("IX_FixedAsset")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ComponentofMainAsset)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaclassCode)
                    .HasColumnName("FAClassCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FalocationCode)
                    .HasColumnName("FALocationCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingGroup)
                    .HasColumnName("FAPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FasubclassCode)
                    .HasColumnName("FASubclassCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileNamePicture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FixedAssetId)
                    .HasColumnName("FixedAssetID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NextServiceDate).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibleEmployee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SearchDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FixedAssetLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("FixedAssetLedgerEntry$0");

                entity.HasIndex(e => new { e.GlentryNo, e.EntryNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.TransactionNo, e.EntryNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.PostingDate, e.EntryNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.EntryNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.CanceledfromFano, e.DepreciationBookCode, e.FapostingDate, e.EntryNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fano, e.DepreciationBookCode, e.FapostingDate, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fano, e.DepreciationBookCode, e.PartofBookValue, e.FapostingDate, e.EntryNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fano, e.DepreciationBookCode, e.PartofDepreciableBasis, e.FapostingDate, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fano, e.DepreciationBookCode, e.FapostingCategory, e.FapostingType, e.DocumentNo, e.EntryNo })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fano, e.DepreciationBookCode, e.FapostingCategory, e.FapostingType, e.PostingDate, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fano, e.DepreciationBookCode, e.FapostingCategory, e.FapostingType, e.FapostingDate, e.PartofBookValue, e.ReclassificationEntry, e.EntryNo })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AccumDeprPercentCustom1).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledfromFano)
                    .HasColumnName("CanceledfromFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DecliningBalancePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DeprEndingDateCustom1).HasColumnType("datetime");

                entity.Property(e => e.DeprPercentthisyearCustom1).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DeprStartingDateCustom1).HasColumnType("datetime");

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationEndingDate).HasColumnType("datetime");

                entity.Property(e => e.DepreciationStartingDate).HasColumnType("datetime");

                entity.Property(e => e.DepreciationTableCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaclassCode)
                    .HasColumnName("FAClassCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FaexchangeRate)
                    .HasColumnName("FAExchangeRate")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.FalocationCode)
                    .HasColumnName("FALocationCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fano)
                    .HasColumnName("FANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FanoBudgetedFano)
                    .HasColumnName("FANoBudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingCategory).HasColumnName("FAPostingCategory");

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingGroup)
                    .HasColumnName("FAPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingType).HasColumnName("FAPostingType");

                entity.Property(e => e.FasubclassCode)
                    .HasColumnName("FASubclassCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FixedAssetLedgerEntryId)
                    .HasColumnName("FixedAssetLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FixedDeprAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlentryNo).HasColumnName("GLEntryNo");

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoofDepreciationYears).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StraightLinePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseFaledgerCheck).HasColumnName("UseFALedgerCheck");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixedAssetPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("FixedAssetPostingGroup$0");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccumDeprAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccumDepreciationAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcqCostAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcquisitionCostAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcquisitionCostBalAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprecBalAcconDisp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppreciationAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppreciationAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppreciationBalAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BookValAcconDispGain)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BookValAcconDispLoss)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Custom1Account)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom1AccountonDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom1BalAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom1ExpenseAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom2Account)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom2AccountonDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom2BalAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom2ExpenseAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationExpenseAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FixedAssetPostingGroupId)
                    .HasColumnName("FixedAssetPostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GainsAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LossesAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceBalAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceExpenseAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAcconDispGain)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAcconDispLoss)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesBalAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WriteDownAcconDisposal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WriteDownAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WriteDownBalAcconDisp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WriteDownExpenseAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenBusinessPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("GenBusinessPostingGroup$0");

                entity.HasIndex(e => e.GenBusinessPostingGroupId)
                    .HasName("IX_GenBusinessPostingGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefVatbusPostingGroup)
                    .HasColumnName("DefVATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusinessPostingGroupId)
                    .HasColumnName("GenBusinessPostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenJournalBatch>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.Name })
                    .HasName("Gen_ Journal Batch$0");

                entity.HasIndex(e => e.GenJournalBatchId)
                    .HasName("IX_GenJournalBatch")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AllowVatdifference).HasColumnName("AllowVATDifference");

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CopyVatsetuptoJnlLines).HasColumnName("CopyVATSetuptoJnlLines");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenJournalBatchId)
                    .HasColumnName("GenJournalBatchID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenJournalHeader>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.JournalBatchName, e.DocumentNo });

                entity.HasIndex(e => e.GenJournalHeaderId)
                    .HasName("IX_GenJournalHeader")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.GenJournalHeaderId)
                    .HasColumnName("GenJournalHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenJournalLine>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.JournalBatchName, e.DocumentNo, e.SeqLineNo })
                    .HasName("PK_GenJournalLine_1");

                entity.HasIndex(e => e.GenJournalLineId)
                    .HasName("IX_GenJournalLine_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.GenJournalHeaderId, e.SeqLineNo })
                    .HasName("IX_GenJournalLine_2")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasComputedColumnSql("([DebitAmount]-[CreditAmount])");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalGenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalGenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalTaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalTaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalVatamount)
                    .HasColumnName("BalVATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalVatamountLcy)
                    .HasColumnName("BalVATAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalVatbaseAmount)
                    .HasColumnName("BalVATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalVatbaseAmountLcy)
                    .HasColumnName("BalVATBaseAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalVatbusPostingGroup)
                    .HasColumnName("BalVATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalVatcalculationType).HasColumnName("BalVATCalculationType");

                entity.Property(e => e.BalVatdifference)
                    .HasColumnName("BalVATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalVatpercent)
                    .HasColumnName("BalVATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BalVatprodPostingGroup)
                    .HasColumnName("BalVATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceLcy)
                    .HasColumnName("BalanceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPaytoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Eu3partyTrade).HasColumnName("EU3PartyTrade");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaaddCurrencyFactor)
                    .HasColumnName("FAAddCurrencyFactor")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.FaerrorEntryNo).HasColumnName("FAErrorEntryNo");

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingType).HasColumnName("FAPostingType");

                entity.Property(e => e.FareclassificationEntry).HasColumnName("FAReclassificationEntry");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenJournalHeaderId).HasColumnName("GenJournalHeaderID");

                entity.Property(e => e.GenJournalLineId)
                    .HasColumnName("GenJournalLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Icdirection).HasColumnName("ICDirection");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerGlaccNo)
                    .HasColumnName("ICPartnerGLAccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerTransactionNo).HasColumnName("ICPartnerTransactionNo");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("InvDiscountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineAmountLcy)
                    .HasColumnName("JobLineAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscAmountLcy)
                    .HasColumnName("JobLineDiscAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTotalCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTotalCostLcy)
                    .HasColumnName("JobTotalCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTotalPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTotalPriceLcy)
                    .HasColumnName("JobTotalPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitCostLcy)
                    .HasColumnName("JobUnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitOfMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobUnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitPriceLcy)
                    .HasColumnName("JobUnitPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitLcy)
                    .HasColumnName("ProfitLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecurringFrequency)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPurchLcy)
                    .HasColumnName("SalesPurchLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalespersPurchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalvageValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SelltoBuyfromNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoOrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCurrVatamount)
                    .HasColumnName("SourceCurrVATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCurrVatbaseAmount)
                    .HasColumnName("SourceCurrVATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatamountLcy)
                    .HasColumnName("VATAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbaseAmountLcy)
                    .HasColumnName("VATBaseAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatposting).HasColumnName("VATPosting");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenJournalTemplate>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("Gen_ Journal Template$0");

                entity.HasIndex(e => e.GenJournalTemplateId)
                    .HasName("IX_GenJournalTemplate")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowVatdifference).HasColumnName("AllowVATDifference");

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CopyVatsetuptoJnlLines).HasColumnName("CopyVATSetuptoJnlLines");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustReceiptReportId).HasColumnName("CustReceiptReportID");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.GenJournalTemplateId)
                    .HasColumnName("GenJournalTemplateID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingReportId).HasColumnName("PostingReportID");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestReportId).HasColumnName("TestReportID");

                entity.Property(e => e.VendorReceiptReportId).HasColumnName("VendorReceiptReportID");
            });

            modelBuilder.Entity<GenLedgerAccCategory>(entity =>
            {
                entity.Property(e => e.GenLedgerAccCategoryId)
                    .HasColumnName("GenLedgerAccCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenLedgerAccount>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("GenLedgerAccount$0");

                entity.HasIndex(e => e.GenLedgerAccountId)
                    .HasName("IX_GenLedgerAccount")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCategory).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountSubCategory).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsolCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsolDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsolidationtoId)
                    .HasColumnName("ConsolidationtoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultIcpartnerGenLedgerAccNo)
                    .HasColumnName("DefaultICPartnerGenLedgerAccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenLedgerAccountId)
                    .HasColumnName("GenLedgerAccountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.No2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SearchName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenLedgerBudgetEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("GenLedgerBudgetEntry$0");

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.BudgetDimension1Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension2Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension3Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension4Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnitCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenLedgerAccountNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenLedgerBudgetEntryId)
                    .HasColumnName("GenLedgerBudgetEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenLedgerBudgetName>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("GenLedgerBudgetName$0");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BudgetDimension1Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension2Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension3Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension4Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GenLedgerBudgetNameId)
                    .HasColumnName("GenLedgerBudgetNameID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("GenLedgerEntry$0");

                entity.HasIndex(e => e.GenLedgerEntryId)
                    .HasName("IX_GenLedgerEntry")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostingDate, e.DebitAmount, e.CreditAmount, e.GenLedgerAccountNo })
                    .HasName("GenLedgerEntry_COANO");

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AddCurrencyCreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AddCurrencyDebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdditionalCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasComputedColumnSql("([DebitAmount]-[CreditAmount])");

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CloseIncomeStatementDimId).HasColumnName("CloseIncomeStatementDimID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaentryNo).HasColumnName("FAEntryNo");

                entity.Property(e => e.FaentryType).HasColumnName("FAEntryType");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenLedgerAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenLedgerEntryId)
                    .HasColumnName("GenLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenLedgerRegister>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("GenLedgerRegister$0");

                entity.HasIndex(e => e.GenLedgerRegisterId)
                    .HasName("IX_GenLedgerRegister")
                    .IsUnique();

                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FromVatentryNo).HasColumnName("FromVATEntryNo");

                entity.Property(e => e.GenLedgerRegisterId)
                    .HasColumnName("GenLedgerRegisterID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToVatentryNo).HasColumnName("ToVATEntryNo");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenLedgerSetup>(entity =>
            {
                entity.Property(e => e.GenLedgerSetupId).HasColumnName("GenLedgerSetupID");

                entity.Property(e => e.AdditionalReportingCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AllowGlaccDeletionBefore)
                    .HasColumnName("AllowGLAccDeletionBefore")
                    .HasColumnType("datetime");

                entity.Property(e => e.AllowPostingFrom).HasColumnType("datetime");

                entity.Property(e => e.AllowPostingTo).HasColumnType("datetime");

                entity.Property(e => e.AmountDecimalPlaces)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AmountRoundingPrecision).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ApplnRoundingPrecision).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BankAccountNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BasgroupCompany).HasColumnName("BASGroupCompany");

                entity.Property(e => e.BasgstdivisionFactor)
                    .HasColumnName("BASGSTDivisionFactor")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BastobeLodgedasaGroup).HasColumnName("BAStobeLodgedasaGroup");

                entity.Property(e => e.BilltoSelltoVatcalc).HasColumnName("BilltoSelltoVATCalc");

                entity.Property(e => e.CheckGlaccountUsage).HasColumnName("CheckGLAccountUsage");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EnableIrdno).HasColumnName("EnableIRDNo");

                entity.Property(e => e.EnableVatregistrationNo).HasColumnName("EnableVATRegistrationNo");

                entity.Property(e => e.FullGstonPrepayment).HasColumnName("FullGSTonPrepayment");

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gstreport).HasColumnName("GSTReport");

                entity.Property(e => e.InterestCalExclVat).HasColumnName("InterestCalExclVAT");

                entity.Property(e => e.InvRoundingPrecisionLcy)
                    .HasColumnName("InvRoundingPrecisionLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvRoundingTypeLcy).HasColumnName("InvRoundingTypeLCY");

                entity.Property(e => e.LastIctransactionNo).HasColumnName("LastICTransactionNo");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Lcycode)
                    .HasColumnName("LCYCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaxPaymentToleranceAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaxVatdifferenceAllowed)
                    .HasColumnName("MaxVATDifferenceAllowed")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentDiscountGracePeriod)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTolerancePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscExclVat).HasColumnName("PmtDiscExclVAT");

                entity.Property(e => e.PostDatedJournalBatch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostDatedJournalTemplate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentUnrealizedVat).HasColumnName("PrepaymentUnrealizedVAT");

                entity.Property(e => e.PrintVatspecificationinLcy).HasColumnName("PrintVATspecificationinLCY");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension3Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension4Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension5Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension6Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension7Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension8Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SummarizeGlentries).HasColumnName("SummarizeGLEntries");

                entity.Property(e => e.UnitAmountDecimalPlaces)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAmountRoundingPrecision).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnrealizedVat).HasColumnName("UnrealizedVAT");

                entity.Property(e => e.VatexchangeRateAdjustment).HasColumnName("VATExchangeRateAdjustment");

                entity.Property(e => e.VatroundingType).HasColumnName("VATRoundingType");

                entity.Property(e => e.VattolerancePercent)
                    .HasColumnName("VATTolerancePercent")
                    .HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<GenPostingSetup>(entity =>
            {
                entity.HasKey(e => new { e.GenBusPostingGroup, e.GenProdPostingGroup })
                    .HasName("General Posting Setup$0");

                entity.HasIndex(e => e.GeneralPostingSetupId)
                    .HasName("IX_GeneralPostingSetup")
                    .IsUnique();

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cogsaccount)
                    .HasColumnName("COGSAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CogsaccountInterim)
                    .HasColumnName("COGSAccountInterim")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectCostAppliedAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Focaccount)
                    .HasColumnName("FOCAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GeneralPostingSetupId)
                    .HasColumnName("GeneralPostingSetupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InventoryAdjmtAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvtAccrualAccInterim)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCostAdjmtAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobSalesAdjmtAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OverheadAppliedAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PoscoupDiscAccount)
                    .HasColumnName("POSCoupDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PoscustDiscAccount)
                    .HasColumnName("POSCustDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PosinfoCodeDiscAccount)
                    .HasColumnName("POSInfoCodeDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PosinvDiscAccount)
                    .HasColumnName("POSInvDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PoslineDiscAccount)
                    .HasColumnName("POSLineDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PoslineDiscOfferAccount)
                    .HasColumnName("POSLineDiscOfferAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PosperiodicDiscAccount)
                    .HasColumnName("POSPeriodicDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostenderTypeDiscAccount)
                    .HasColumnName("POSTenderTypeDiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostotalDiscOfferAccount)
                    .HasColumnName("POSTotalDiscOfferAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchCreditMemoAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchFadiscAccount)
                    .HasColumnName("PurchFADiscAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchInvDiscAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchLineDiscAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchPmtDiscCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchPmtDiscDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchPmtTolCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchPmtTolDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchPrepaymentsAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseLandedCostAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PurchaseVarianceAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCreditMemoAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvDiscAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesLandedCostAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesLineDiscAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPmtDiscCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPmtDiscDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPmtTolCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPmtTolDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPrepaymentsAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenProductPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("GenProductPostingGroup$0");

                entity.HasIndex(e => e.GenProductPostingGroupId)
                    .HasName("IX_GenProductPostingGroup_1")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoInsertDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefVatprodPostingGroup)
                    .HasColumnName("DefVATProdPostingGroup")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenProductPostingGroupId)
                    .HasColumnName("GenProductPostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GlitemLedgerRelation>(entity =>
            {
                entity.HasKey(e => new { e.GlentryNo, e.ValueEntryNo })
                    .HasName("GLItemLedgerRelation$0");

                entity.ToTable("GLItemLedgerRelation");

                entity.HasIndex(e => e.GlitemLedgerRelationId)
                    .HasName("IX_GLItemLedgerRelation")
                    .IsUnique();

                entity.Property(e => e.GlentryNo).HasColumnName("GLEntryNo");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GlitemLedgerRelationId)
                    .HasColumnName("GLItemLedgerRelationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GlregisterNo).HasColumnName("GLRegisterNo");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Glregister>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("GLRegister$0");

                entity.ToTable("GLRegister");

                entity.HasIndex(e => e.GlregisterId)
                    .HasName("IX_GLRegister")
                    .IsUnique();

                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FromVatentryNo).HasColumnName("FromVATEntryNo");

                entity.Property(e => e.GlregisterId)
                    .HasColumnName("GLRegisterID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToVatentryNo).HasColumnName("ToVATEntryNo");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroundsforTermination>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("GroundsforTermination$0");

                entity.HasIndex(e => e.GroundsforTerminationId)
                    .HasName("IX_GroundsforTermination")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroundsforTerminationId).HasColumnName("GroundsforTerminationID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HumanResourceUnitofMeasure>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("HumanResourceUnitofMeasure$0");

                entity.HasIndex(e => e.HumanResourceUnitofMeasureId)
                    .HasName("IX_HumanResourceUnitofMeasure")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HumanResourceUnitofMeasureId)
                    .HasColumnName("HumanResourceUnitofMeasureID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<HumanResourcesSetup>(entity =>
            {
                entity.Property(e => e.HumanResourcesSetupId).HasColumnName("HumanResourcesSetupID");

                entity.Property(e => e.BaseUnitofMeasure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeNos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.RowStatus).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Icpartner>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("ICPartner$0");

                entity.ToTable("ICPartner");

                entity.HasIndex(e => e.IcpartnerId)
                    .HasName("IX_ICPartner")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CostDistributioninLcy).HasColumnName("CostDistributioninLCY");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerId)
                    .HasColumnName("ICPartnerID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InboxDetails)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundPurchItemNoType).HasColumnName("OutboundPurch_ItemNoType");

                entity.Property(e => e.PayablesAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivablesAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryPostingBuffer>(entity =>
            {
                entity.HasKey(e => new { e.PostingDate, e.AccountType, e.LocationCode, e.InventoryPostingGroup, e.GenBusPostingGroup, e.GenProdPostingGroup, e.DimensionEntryNo, e.Negative, e.BalAccountType, e.ReasonCode, e.InvAdjustGroup })
                    .HasName("InventoryPostingBuffer$0");

                entity.HasIndex(e => e.InventoryPostingBufferId)
                    .HasName("IX_InventoryPostingBuffer")
                    .IsUnique();

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvAdjustGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountAcy)
                    .HasColumnName("AmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingBufferId)
                    .HasColumnName("InventoryPostingBufferID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Inventory Posting Group$0");

                entity.HasIndex(e => e.InventoryPostingGroupId)
                    .HasName("IX_InventoryPostingGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForInventory).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForPurchase).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForSale).HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryPostingGroupId)
                    .HasColumnName("InventoryPostingGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventoryPostingSetup>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.InvtPostingGroupCode })
                    .HasName("Inventory Posting Setup$0");

                entity.HasIndex(e => e.InventoryPostingSetupId)
                    .HasName("IX_InventoryPostingSetup")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvtPostingGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapOverheadVarianceAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapacityVarianceAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InventoryAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryAccountInterim)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingSetupId)
                    .HasColumnName("InventoryPostingSetupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaterialVarianceAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MfgOverheadVarianceAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubcontractedVarianceAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Wipaccount)
                    .HasColumnName("WIPAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryPosttoGltestBuffer>(entity =>
            {
                entity.HasKey(e => e.SeqLineNo)
                    .HasName("InventotyPosttoGLTestBuffer$0");

                entity.ToTable("InventoryPosttoGLTestBuffer");

                entity.HasIndex(e => e.InventoryPosttoGltestBufferId)
                    .HasName("IX_InventotyPosttoGLTestBuffer")
                    .IsUnique();

                entity.Property(e => e.SeqLineNo).ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPosttoGltestBufferId)
                    .HasColumnName("InventoryPosttoGLTestBufferID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InvtPostingGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventorySetup>(entity =>
            {
                entity.Property(e => e.InventorySetupId).HasColumnName("InventorySetupID");

                entity.Property(e => e.AutomaticBuildKitBom).HasColumnName("AutomaticBuildKitBOM");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dimension01Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension02Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension03Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension04Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension05Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension06Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension07Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension08Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension09Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension10Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedCostPostingtoGl).HasColumnName("ExpectedCostPostingtoGL");

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPickNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPutawayNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemGroupDimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KitBomnos)
                    .HasColumnName("KitBOMNos")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NonstockItemNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PostedInvtPickNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedInvtPutawayNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedTransferRcptNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedTransferShptNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoicePostBuffer>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Glaccount, e.GenBusPostingGroup, e.GenProdPostingGroup, e.VatbusPostingGroup, e.VatprodPostingGroup, e.TaxAreaCode, e.TaxGroupCode, e.TaxLiable, e.UseTax, e.DimensionEntryNo, e.JobNo, e.FixedAssetLineNo })
                    .HasName("InvoicePostBuffer$0");

                entity.Property(e => e.Glaccount)
                    .HasColumnName("GLAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountAcy)
                    .HasColumnName("AmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingType).HasColumnName("FAPostingType");

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvDiscountAmountAcy)
                    .HasColumnName("InvDiscountAmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvoicePostBufferId)
                    .HasColumnName("InvoicePostBufferID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineDiscountAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountAmountAcy)
                    .HasColumnName("LineDiscountAmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalvageValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatamountAcy)
                    .HasColumnName("VATAmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbaseAmountAcy)
                    .HasColumnName("VATBaseAmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<ItemBudgetEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("ItemBudgetEntry$0");

                entity.HasIndex(e => e.ItemBudgetEntryId)
                    .HasName("IX_ItemBudgetEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.BudgetDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension3Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemBudgetEntryId)
                    .HasColumnName("ItemBudgetEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Liters)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemBudgetName>(entity =>
            {
                entity.HasKey(e => new { e.AnalysisArea, e.Name })
                    .HasName("ItemBudgetName$0");

                entity.HasIndex(e => e.ItemBudgetNameId)
                    .HasName("IX_ItemBudgetName")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetDimension3Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetYear).HasDefaultValueSql("((2017))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ItemBudgetNameId)
                    .HasColumnName("ItemBudgetNameID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_ItemCategory")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DefGenProdPostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefInventoryPostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefTaxGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefVatprodPostingGroup)
                    .HasColumnName("DefVATProdPostingGroup")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemCharge>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("ItemCharge$0");

                entity.HasIndex(e => e.ItemChargeId)
                    .HasName("IX_ItemCharge")
                    .IsUnique();

                entity.HasIndex(e => new { e.Description, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.GenProdPostingGroup, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.SearchDescription, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeId)
                    .HasColumnName("ItemChargeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SearchDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemChargeAssignmentPurch>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.SeqLineNo })
                    .HasName("ItemChargeAssignmentPurch$0");

                entity.HasIndex(e => new { e.AppliestoDocType, e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.SeqLineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.AppliestoDocType, e.AppliestoDocNo, e.AppliestoDocLineNo, e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.SeqLineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AmounttoAssign).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliestoDocLineAmount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliestoDocNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeAssignmentPurchId)
                    .HasColumnName("ItemChargeAssignmentPurchID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemChargeNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.QtyAssigned).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtytoAssign).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ItemChargeAssignmentSales>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.SeqLineNo })
                    .HasName("ItemChargeAssignmentSales$0");

                entity.HasIndex(e => new { e.AppliestoDocType, e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.SeqLineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.AppliestoDocType, e.AppliestoDocNo, e.AppliestoDocLineNo, e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.SeqLineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AmounttoAssign).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliestoDocLineAmount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliestoDocNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeAssignmentSalesId)
                    .HasColumnName("ItemChargeAssignmentSalesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemChargeNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.QtyAssigned).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtytoAssign).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ItemDiscountGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("ItemDiscountGroup$0");

                entity.HasIndex(e => e.ItemDiscountGroupId)
                    .HasName("IX_ItemDiscountGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDiscountGroupId)
                    .HasColumnName("ItemDiscountGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemEntryRelation>(entity =>
            {
                entity.HasKey(e => e.ItemEntryNo)
                    .HasName("ItemEntryRelation$0");

                entity.HasIndex(e => e.ItemEntryRelationId)
                    .HasName("IX_ItemEntryRelation")
                    .IsUnique();

                entity.Property(e => e.ItemEntryNo).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemEntryRelationId)
                    .HasColumnName("ItemEntryRelationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemFlavours>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Description })
                    .HasName("PK_dbo.ItemFlavours");

                entity.HasIndex(e => e.ItemFlavoursId)
                    .HasName("IX_ItemFlavours")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ItemFlavoursId)
                    .HasColumnName("ItemFlavoursID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemJournalBatch>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.Name })
                    .HasName("ItemJournalBatch$0");

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemJournalBatchId)
                    .HasColumnName("ItemJournalBatchID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemJournalHeader>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.JournalBatchName, e.DocumentNo })
                    .HasName("PK_ItemJournalHeader_1");

                entity.HasIndex(e => e.ItemJournalHeaderId)
                    .HasName("IX_ItemJournalHeader")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Item')");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.ItemJournalHeaderId)
                    .HasColumnName("ItemJournalHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("lastModifiedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProdOrderSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemJournalLine>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.JournalBatchName, e.DocumentNo, e.SeqLineNo })
                    .HasName("PK_ItemJournalLine_1");

                entity.HasIndex(e => e.ItemJournalLineId)
                    .HasName("IX_ItemJournalLine_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemJournalHeaderId, e.SeqLineNo })
                    .HasName("IX_ItemJournalLine_3")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountAcy)
                    .HasColumnName("AmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BodocNo)
                    .HasColumnName("BODocNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapUnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConcurrentCapacity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.EndingTime).HasColumnType("datetime");

                entity.Property(e => e.EntryExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IctsourceDocNo)
                    .HasColumnName("ICTSourceDocNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IctsourceDocType).HasColumnName("ICTSourceDocType");

                entity.Property(e => e.IctsourceSeqLineNo).HasColumnName("ICTSourceSeqLineNo");

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvAdjustGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryValueCalculated).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InventoryValueRevalued).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicedQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvoicedQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvoicetoSourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemJournalHeaderId)
                    .HasColumnName("ItemJournalHeaderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemJournalLineId)
                    .HasColumnName("ItemJournalLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewItemExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.NewLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewLotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewSerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OriginallyOrderedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginallyOrderedVarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OutputQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutputQuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyCalculated).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPhysInventory).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperCapUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecurringFrequency)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RolledupCapOverheadCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupCapacityCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupMaterialCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupMfgOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupSubcontractedCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RunTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RunTimeBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalespersPurchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ScrapQuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SetupTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SetupTimeBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SingleLevelCapOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelCapacityCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelMaterialCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelMfgOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelSubcontrdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourcePostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartingTime).HasColumnType("datetime");

                entity.Property(e => e.StopCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StopTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StopTimeBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TempUserId)
                    .HasColumnName("TempUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostAcy)
                    .HasColumnName("UnitCostACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostCalculated).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostRevalued).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");

                entity.Property(e => e.WorkCenterGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkShiftCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemJournalTemplate>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.HasIndex(e => e.ItemJournalTemplateId)
                    .HasName("IX_ItemJournalTemplate")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemJournalTemplateId)
                    .HasColumnName("ItemJournalTemplateID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhseRegisterReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("ItemLedgerEntry$0");

                entity.HasIndex(e => e.ItemLedgerEntryId)
                    .HasName("IX_ItemLedgerEntry")
                    .IsUnique();

                entity.HasIndex(e => e.ItemNo)
                    .HasName("IX_ItemLedgerEntry_1");

                entity.HasIndex(e => e.PostingDate)
                    .HasName("IX_ItemLedgerEntry_2");

                entity.HasIndex(e => new { e.PostingDate, e.ItemNo })
                    .HasName("IX_ItemLedgerEntry_3");

                entity.HasIndex(e => new { e.Quantity, e.ItemNo, e.PostingDate })
                    .HasName("ILE_IndexItemNOPostingDate");

                entity.HasIndex(e => new { e.EntryNo, e.ItemNo, e.Quantity, e.Positive, e.PostingDate })
                    .HasName("ItemLedgerEntry_PostingDate");

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue01Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue02Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue03Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DimensionValue04Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicedQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemLedgerEntryId)
                    .HasColumnName("ItemLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OriginallyOrderedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginallyOrderedVarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedQtyNotReturned).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemPriceGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("ItemPriceGroup$0");

                entity.HasIndex(e => e.ItemPriceGroupId)
                    .HasName("IX_ItemPriceGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPriceGroupId)
                    .HasColumnName("ItemPriceGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemRegister>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("ItemRegister$0");

                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemRegisterId)
                    .HasColumnName("ItemRegisterID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemSizes>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Description })
                    .HasName("PK_dbo.ItemSizes");

                entity.HasIndex(e => e.ItemSizesId)
                    .HasName("IX_ItemSizes")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ItemSizesId)
                    .HasColumnName("ItemSizesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemUnitOfMeasures>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.Uomcode })
                    .HasName("PK_dbo.ItemUnitOfMeasures");

                entity.HasIndex(e => e.ItemUnitOfMeasureId)
                    .HasName("IX_ItemUnitOfMeasures")
                    .IsUnique();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uomcode)
                    .HasColumnName("UOMCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Cubage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemUnitOfMeasureId)
                    .HasColumnName("ItemUnitOfMeasureID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ItemVariants>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.ItemVariantCode })
                    .HasName("PK_dbo.ItemVariants");

                entity.HasIndex(e => e.ItemVariantId)
                    .HasName("IX_ItemVariants")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemVariantCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ItemVariantDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ItemVariantDescription2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ItemVariantId)
                    .HasColumnName("ItemVariantID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemNo);

                entity.HasIndex(e => e.ItemId)
                    .HasName("IX_Items")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abcprofit).HasColumnName("ABCProfit");

                entity.Property(e => e.Abcsales).HasColumnName("ABCSales");

                entity.Property(e => e.AlternativeItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Attrib1Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Attrib2Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Attrib3Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Attrib4Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Attrib5Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeMask)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCompUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BomcostPriceDistribution).HasColumnName("BOMCostPriceDistribution");

                entity.Property(e => e.Bommethod).HasColumnName("BOMMethod");

                entity.Property(e => e.BomreceiptPrint).HasColumnName("BOMReceiptPrint");

                entity.Property(e => e.BomreceivingExplode).HasColumnName("BOMReceivingExplode");

                entity.Property(e => e.Bomtype).HasColumnName("BOMType");

                entity.Property(e => e.BudgetProfit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BudgetQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BudgetedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CommonItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompPriceInclVat)
                    .HasColumnName("CompPriceInclVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ComparisonUnitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPurchasedCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryofOriginCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CukaiCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Depth).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptiononPos)
                    .HasColumnName("DescriptiononPOS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue01Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue02Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue03Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue04Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue05Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue06Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue07Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue08Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue09Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionValue10Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DispensePrinterGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Durability)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DutyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DutyDuePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DutyUnitConversion).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ExpirationCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExplodeBominStatemPosting).HasColumnName("ExplodeBOMinStatemPosting");

                entity.Property(e => e.ForInventory).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForPurchase).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForSale).HasDefaultValueSql("((0))");

                entity.Property(e => e.FreightType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Height).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCapacityValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemErrorCheckCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemFamilyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ItemNo2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTrackingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastCountingPeriodUpdate).HasColumnType("datetime");

                entity.Property(e => e.LastDirectCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastUnitCostCalcDate).HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LifecycleEndingDate).HasColumnType("datetime");

                entity.Property(e => e.LifecycleLength)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LifecycleStartingDate).HasColumnType("datetime");

                entity.Property(e => e.LiterQty)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LotNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotSize).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ManualEstimatedDailySale).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumInventory).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaximumOrderQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinimumOrderQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ModifyingDateofStatus).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NextCountingPeriod)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMultiple).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalVendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoscostCalculation).HasColumnName("POSCostCalculation");

                entity.Property(e => e.PriceIncludesVat).HasColumnName("PriceIncludesVAT");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomno)
                    .HasColumnName("ProductionBOMNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionTimeMin).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProfitGoalPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProfitPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PurchUnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PutawayTemplateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PutawayUnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperBaseCompUnit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecipeCategory)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeMainIngredient)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeStyle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeVersionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReorderCycle)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReorderPoint).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReorderQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReplenDataProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReplenDistributionRuleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReplenishasItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReplenishmentGradeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReplenishmentSalesProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RolledupCapOverheadCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupCapacityCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupMaterialCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupMfgOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RolledupSubcontractedCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoundingPrecision).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SafetyLeadTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SafetyStockQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalesUnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SearchDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SeasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceItemGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SingleLevelCapOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelCapacityCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelMaterialCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelMfgOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelSubcontrdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SpecialEquipmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StandardCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StoreForwardSalesProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreStockCoverReqdDays).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SuggestedQtyonPos)
                    .HasColumnName("SuggestedQtyonPOS")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TariffNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferMultiple).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitListPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPriceIncludingVat)
                    .HasColumnName("UnitPriceIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UompopuponPos).HasColumnName("UOMPopuponPOS");

                entity.Property(e => e.UseEanstandardBarc).HasColumnName("UseEANStandardBarc");

                entity.Property(e => e.VariantFrameworkCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGrPrice)
                    .HasColumnName("VATBusPostingGrPrice")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarehForwardSalesProfile)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehStockCoverReqdDays).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WarrantyPeriod)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WastagePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Width).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.XMinimumInventoryNotused)
                    .HasColumnName("xMinimumInventoryNOTUSED")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.XReplenMethodNotused).HasColumnName("xReplenMethodNOTUSED");
            });

            modelBuilder.Entity<JournalLineDimension>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.JournalTemplateName, e.JournalBatchName, e.JournalLineNo, e.AllocationLineNo, e.DimensionCode })
                    .HasName("JournalLineDimension$0");

                entity.HasIndex(e => e.JournalLineDimensionId)
                    .HasName("IX_JournalLineDimension")
                    .IsUnique();

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalLineDimensionId)
                    .HasColumnName("JournalLineDimensionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NewDimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LedgerEntryDimension>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.EntryNo, e.DimensionCode })
                    .HasName("LedgerEntryDimension$0");

                entity.HasIndex(e => e.LedgerEntryDimensionId)
                    .HasName("IX_LedgerEntryDimension")
                    .IsUnique();

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DimensionValueCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LedgerEntryDimensionId)
                    .HasColumnName("LedgerEntryDimensionID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationCode)
                    .HasName("PK_Location");

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_Location")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CrossDockBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossDockDueDateCalc)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.InboundBombinCode)
                    .HasColumnName("InboundBOMBinCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InboundProductionBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpenShopFloorBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundBombinCode)
                    .HasColumnName("OutboundBOMBinCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundProductionBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PickAccordingtoFefo).HasColumnName("PickAccordingtoFEFO");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PutawayTemplateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UseAdcs).HasColumnName("UseADCS");
            });

            modelBuilder.Entity<MachineCenter>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Machine Center$0");

                entity.HasIndex(e => e.MachineCenterId)
                    .HasName("IX_MachineCenter")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Capacity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConcurrentCapacities).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Efficiency).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.FixedScrapQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MachineCenterId)
                    .HasColumnName("MachineCenterID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MaximumEfficiency).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaximumProcessTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinimumEfficiency).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinimumProcessTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MoveTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MoveTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QueueTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QueueTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SearchName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SendAheadQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SetupTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SetupTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WaitTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WaitTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManufacturingSetup>(entity =>
            {
                entity.Property(e => e.ManufacturingSetupId).HasColumnName("ManufacturingSetupID");

                entity.Property(e => e.CombinedMpsmrpcalculation).HasColumnName("CombinedMPSMRPCalculation");

                entity.Property(e => e.ComponentsatLocation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentProductionForecast)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DampenerPercentofLotSize).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DampenerTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultSafetyLeadTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FirmPlannedOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MachineCenterNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomnos)
                    .HasColumnName("ProductionBOMNos")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReleasedOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SimulatedOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingSetup>(entity =>
            {
                entity.Property(e => e.MarketingSetupId)
                    .HasColumnName("MarketingSetupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttachmentStorageLocation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BusRelCodeforBankAccs)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusRelCodeforCustomers)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusRelCodeforVendors)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CouponNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefCompanySalutationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultLanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultPersonSalutationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultSalesCycleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultSalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultTerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultTodoDateCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Delimiters)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLoggingProfileName)
                    .HasColumnName("EMailLoggingProfileName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLoggingUserId)
                    .HasColumnName("EMailLoggingUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MergefieldLanguageId).HasColumnName("MergefieldLanguageID");

                entity.Property(e => e.OpportunityNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodicDiscountNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QueueFolderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StorageFolderName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TodoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoSeries>(entity =>
            {
                entity.HasKey(e => e.NoSeriesCode);

                entity.HasIndex(e => e.NoSeriesId)
                    .HasName("IX_NoSeries")
                    .IsUnique();

                entity.Property(e => e.NoSeriesCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeriesDateOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoSeriesDefaultNos).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoSeriesDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeriesId)
                    .HasColumnName("NoSeriesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NoSeriesManualNos).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NoSeriesLine>(entity =>
            {
                entity.HasKey(e => new { e.NoSeriesCode, e.SeqLineNo })
                    .HasName("NoSeriesLine$0");

                entity.HasIndex(e => e.NoSeriesLineId)
                    .HasName("IX_NoSeriesLine")
                    .IsUnique();

                entity.Property(e => e.NoSeriesCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EndingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsOpen).HasColumnName("isOpen");

                entity.Property(e => e.LastDateUsed).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastNoUsed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeriesLineId)
                    .HasColumnName("NoSeriesLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.StartingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarningNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Opportunity>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Opportunity$0");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("IX_Opportunity")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompanyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("OpportunityID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesCycleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WizardCampaignDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WizardChancesofSuccessPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WizardContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WizardEstimatedClosingDate).HasColumnType("datetime");

                entity.Property(e => e.WizardEstimatedValueLcy)
                    .HasColumnName("WizardEstimatedValueLCY")
                    .HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<OpportunityEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("OpportunityEntry$0");

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.CalcdCurrentValueLcy)
                    .HasColumnName("CalcdCurrentValueLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChancesofSuccessPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CloseOpportunityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ContactCompanyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateofChange).HasColumnType("datetime");

                entity.Property(e => e.DaysOpen).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.EstimatedCloseDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedValueLcy)
                    .HasColumnName("EstimatedValueLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OpportunityEntryId)
                    .HasColumnName("OpportunityEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpportunityNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProbabilityPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalesCycleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCycleStageDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PaymentMethod$0");

                entity.HasIndex(e => e.PaymentMethodId)
                    .HasName("IX_PaymentMethod")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnName("PaymentMethodID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentTerms>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PaymentTerms$0");

                entity.HasIndex(e => e.PaymentTermsId)
                    .HasName("IX_PaymentTerms")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountDateCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DueDateCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermsId)
                    .HasColumnName("PaymentTermsID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PhysInventoryLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("PhysInventoryLedgerEntry$0");

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysInventoryLedgerEntryId)
                    .HasColumnName("PhysInventoryLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.QtyCalculated).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPhysInventory).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersPurchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhysInvtCountingPeriod>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PhysInvtCountingPeriod$0");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PhysInvtCountingPeriodId)
                    .HasColumnName("PhysInvtCountingPeriodID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PhysInvtItemSelection>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.VariantCode, e.LocationCode, e.PhysInvtCountingPeriodCode })
                    .HasName("PhysInvtItemSelection$0");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastCountingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NextCountingPeriod)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhysInvtItemSelectionId)
                    .HasColumnName("PhysInvtItemSelectionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasKey(e => new { e.CategoryCode, e.Code });

                entity.HasIndex(e => e.ProductGroupId)
                    .HasName("IX_ProductGroup")
                    .IsUnique();

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ProductGroupId)
                    .HasColumnName("ProductGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WarehouseClassCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionBomheader>(entity =>
            {
                entity.HasKey(e => e.ProductionBomheaderNo);

                entity.ToTable("ProductionBOMHeader");

                entity.HasIndex(e => e.ProductionBomheaderId)
                    .HasName("IX_ProductionBOMHeader")
                    .IsUnique();

                entity.Property(e => e.ProductionBomheaderNo)
                    .HasColumnName("ProductionBOMHeaderNo")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bomtype).HasColumnName("BOMType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomheaderId)
                    .HasColumnName("ProductionBOMHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductionBomheaderStatus).HasColumnName("ProductionBOMHeaderStatus");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionBomline>(entity =>
            {
                entity.HasKey(e => new { e.ProductionBomno, e.VersionCode, e.SeqLineNo });

                entity.ToTable("ProductionBOMLine");

                entity.HasIndex(e => e.ProductionBomlineId)
                    .HasName("IX_ProductionBOMLine")
                    .IsUnique();

                entity.Property(e => e.ProductionBomno)
                    .HasColumnName("ProductionBOMNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depth).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Length).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Position2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Position3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomheaderId).HasColumnName("ProductionBOMHeaderID");

                entity.Property(e => e.ProductionBomlineId)
                    .HasColumnName("ProductionBOMLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductionLeadTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantityper).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingLinkCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Width).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<ProductionOrderComponent>(entity =>
            {
                entity.HasKey(e => new { e.Status, e.ProdOrderNo, e.ProdOrderLineNo, e.SeqLineNo })
                    .HasName("ProductionOrderComponent$0");

                entity.HasIndex(e => e.ProductionOrderComponentId)
                    .HasName("IX_ProductionOrderComponent")
                    .IsUnique();

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Depth).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DirectCostAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.DueDateTime).HasColumnType("datetime");

                entity.Property(e => e.DueTime).HasColumnType("datetime");

                entity.Property(e => e.ExpectedQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ExpectedQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Length).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalVariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Position2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Position3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionLeadTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionOrderComponentId)
                    .HasColumnName("ProductionOrderComponentID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductionOrderLineId).HasColumnName("ProductionOrderLineID");

                entity.Property(e => e.QtyPicked).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPickedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantityper).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoutingLinkCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Width).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<ProductionOrderHeader>(entity =>
            {
                entity.HasKey(e => new { e.Status, e.ProdOrderNo })
                    .HasName("ProductionOrder$0");

                entity.HasIndex(e => e.ProductionOrderHeaderId)
                    .HasName("IX_ProductionOrderHeader")
                    .IsUnique();

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.EndingDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndingTime).HasColumnType("datetime");

                entity.Property(e => e.FinishedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmPlannedOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionOrderHeaderId)
                    .HasColumnName("ProductionOrderHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReplanRefNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SimulatedOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.StartingDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartingTime).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<ProductionOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.Status, e.ProdOrderNo, e.SeqLineNo })
                    .HasName("ProductionOrderLine$0");

                entity.HasIndex(e => e.ProductionOrderLineId)
                    .HasName("IX_ProductionOrderLine")
                    .IsUnique();

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostAmountAcy)
                    .HasColumnName("CostAmountACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.EndingDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndingTime).HasColumnType("datetime");

                entity.Property(e => e.FinishedQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.FinishedQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mpsorder).HasColumnName("MPSOrder");

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProductionBomno)
                    .HasColumnName("ProductionBOMNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomversionCode)
                    .HasColumnName("ProductionBOMVersionCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionOrderHeaderId).HasColumnName("ProductionOrderHeaderID");

                entity.Property(e => e.ProductionOrderLineId)
                    .HasColumnName("ProductionOrderLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingVersionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SingleLevelCapOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelCapacityCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelMaterialCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelMfgOvhdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SingleLevelSubcontrdCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.StartingDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartingTime).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostAcy)
                    .HasColumnName("UnitCostACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchCommentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.No, e.DocumentSeqLineNo, e.SeqLineNo })
                    .HasName("PurchCommentLine$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PurchCommentLineId)
                    .HasColumnName("PurchCommentLineID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PurchaseContractHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseContractHeaderNo)
                    .HasName("PurchaseContractHeader$0");

                entity.HasIndex(e => e.PurchaseContractHeaderId)
                    .HasName("IX_PurchaseContractHeader")
                    .IsUnique();

                entity.Property(e => e.PurchaseContractHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyerGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasColumnName("BuyerID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseContractHeaderId)
                    .HasColumnName("PurchaseContractHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RtcfilterField).HasColumnName("RTCFilterField");

                entity.Property(e => e.ValidFromDate).HasColumnType("datetime");

                entity.Property(e => e.ValidToDate).HasColumnType("datetime");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseContractLines>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseContractHeaderId, e.SeqLineNo })
                    .HasName("PurchaseContractLines$0");

                entity.Property(e => e.PurchaseContractHeaderId).HasColumnName("PurchaseContractHeaderID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.GoalAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseAmountLcyinternal)
                    .HasColumnName("PurchaseAmountLCYInternal")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PurchaseContractLinesId)
                    .HasColumnName("PurchaseContractLinesID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaseDiscLcyinternal)
                    .HasColumnName("PurchaseDiscLCYInternal")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseCrMemoHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseCrMemoHeaderNo)
                    .HasName("PurchaseCrMemoHeader$0");

                entity.HasIndex(e => e.PurchaseCrMemoHeaderId)
                    .HasName("IX_PurchaseCrMemoHeader")
                    .IsUnique();

                entity.Property(e => e.PurchaseCrMemoHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreAssignedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreAssignedNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtCrMemoNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PurchaseCrMemoHeaderId)
                    .HasColumnName("PurchaseCrMemoHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatcountry)
                    .HasColumnName("VATCountry")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCrMemoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseCrMemoLine>(entity =>
            {
                entity.HasKey(e => e.SeqLineNo)
                    .HasName("PurchaseCrMemoLine$0");

                entity.HasIndex(e => e.PurchaseCrMemoLineId)
                    .HasName("IX_PurchaseCrMemoLine")
                    .IsUnique();

                entity.Property(e => e.SeqLineNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingType).HasColumnName("FAPostingType");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerRefType).HasColumnName("ICPartnerRefType");

                entity.Property(e => e.IcpartnerReference)
                    .HasColumnName("ICPartnerReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineAmountLcy)
                    .HasColumnName("JobLineAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscAmountLcy)
                    .HasColumnName("JobLineDiscAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTotalPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTotalPriceLcy)
                    .HasColumnName("JobTotalPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitPriceLcy)
                    .HasColumnName("JobUnitPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCrMemoHeaderId).HasColumnName("PurchaseCrMemoHeaderID");

                entity.Property(e => e.PurchaseCrMemoLineId)
                    .HasColumnName("PurchaseCrMemoLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalvageValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPriceLcy)
                    .HasColumnName("UnitPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseInvoiceHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseInvoiceHeaderNo)
                    .HasName("PurchaseInvoiceHeader$0");

                entity.HasIndex(e => e.PurchaseInvoiceHeaderId)
                    .HasName("IX_PurchaseInvoiceHeader")
                    .IsUnique();

                entity.Property(e => e.PurchaseInvoiceHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromFaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRegistrationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCountrye)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreAssignedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreAssignedNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PurchaseInvoiceHeaderId)
                    .HasColumnName("PurchaseInvoiceHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatcountry)
                    .HasColumnName("VATCountry")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorInvoiceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseInvoiceLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("PurchaseInvoiceLine$0");

                entity.HasIndex(e => e.PurchaseInvoiceLineId)
                    .HasName("IX_PurchaseInvoiceLine")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingType).HasColumnName("FAPostingType");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerRefType).HasColumnName("ICPartnerRefType");

                entity.Property(e => e.IcpartnerReference)
                    .HasColumnName("ICPartnerReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineAmountLcy)
                    .HasColumnName("JobLineAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscAmountLcy)
                    .HasColumnName("JobLineDiscAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobLineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTotalPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTotalPriceLcy)
                    .HasColumnName("JobTotalPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobUnitPriceLcy)
                    .HasColumnName("JobUnitPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseInvoiceHeaderId).HasColumnName("PurchaseInvoiceHeaderID");

                entity.Property(e => e.PurchaseInvoiceLineId)
                    .HasColumnName("PurchaseInvoiceLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalvageValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPriceLcy)
                    .HasColumnName("UnitPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseLineDiscount>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.VendorNo, e.StartingDate, e.CurrencyCode, e.VariantCode, e.UnitofMeasureCode, e.MinimumQuantity })
                    .HasName("Purchase Line Discount$0");

                entity.HasIndex(e => e.PurchaseLineDiscountId)
                    .HasName("IX_PurchaseLineDiscount")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PurchaseLineDiscountId)
                    .HasColumnName("PurchaseLineDiscountID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PurchasePrepaymentPercent>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.VendorNo, e.StartingDate })
                    .HasName("PurchasePrepaymentPercent$0");

                entity.HasIndex(e => e.PurchasePrepaymentPercentId)
                    .HasName("IX_PurchasePrepaymentPercent")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PrepaymentPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PurchasePrepaymentPercentId)
                    .HasColumnName("PurchasePrepaymentPercentID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PurchasePrice>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.VendorNo, e.StartingDate, e.CurrencyCode, e.VariantCode, e.UnitofMeasureCode, e.MinimumQuantity })
                    .HasName("PurchasePrice$0");

                entity.HasIndex(e => e.PurchasePriceId)
                    .HasName("IX_PurchasePrice")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PurchasePriceId)
                    .HasColumnName("PurchasePriceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WholesalePrice).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<PurchaseRcptHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseRcptHeaderNo)
                    .HasName("PurchaseRcptHeader$0");

                entity.HasIndex(e => e.PurchaseRcptHeaderId)
                    .HasName("IX_PurchaseRcptHeader_1")
                    .IsUnique();

                entity.Property(e => e.PurchaseRcptHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.AbndivisionPartNo)
                    .HasColumnName("ABNDivisionPartNo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ActualVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentAppliesto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Basadjustment).HasColumnName("BASAdjustment");

                entity.Property(e => e.BuyfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContactno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromisedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseRcptHeaderId)
                    .HasColumnName("PurchaseRcptHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatcountry)
                    .HasColumnName("VATCountry")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseRcptLine>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseRcptHeaderId, e.SeqLineNo })
                    .HasName("PurchaseRcptLine$0");

                entity.HasIndex(e => e.PurchaseRcptLineId)
                    .HasName("IX_PurchaseRcptLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("IX_PurchaseRcptLine_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Quantity, e.OrderNo, e.OrderType, e.OrderLineNo })
                    .HasName("idxPurchaseRcptLineOrderNoTypeLine");

                entity.Property(e => e.PurchaseRcptHeaderId).HasColumnName("PurchaseRcptHeaderID");

                entity.Property(e => e.AllowInvoiceDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.AppltoItemEntry).HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AttachedtoLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correction).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeprAcquisitionCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate)
                    .HasColumnName("DepruntilFAPostingDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DirectUnitCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FapostingType)
                    .HasColumnName("FAPostingType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeBaseAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemRcptEntryNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobCurrencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyFactor)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineAmountLcy)
                    .HasColumnName("JobLineAmountLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineDiscAmountLcy)
                    .HasColumnName("JobLineDiscAmountLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineDiscountAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineDiscountPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineType).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTotalPrice)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobTotalPriceLcy)
                    .HasColumnName("JobTotalPriceLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobUnitPrice)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobUnitPriceLcy)
                    .HasColumnName("JobUnitPriceLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LineDiscountPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nonstock).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadRate)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedReceiptDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PromisedReceiptDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PurchaseRcptLineId)
                    .HasColumnName("PurchaseRcptLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyRcdNotInvoiced)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyperUnitofMeasure)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestedReceiptDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingReferenceNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesOrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalvageValue)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialOrderSalesLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecialOrderSalesNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxLiable).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPriceLcy)
                    .HasColumnName("UnitPriceLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitVolume)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseDuplicationList).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType)
                    .HasColumnName("VATCalculationType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseRequisitionHeader>(entity =>
            {
                entity.HasKey(e => e.RequisitionNo)
                    .HasName("PK_RequisitionHeader");

                entity.HasIndex(e => e.RequisitionHeaderId)
                    .HasName("IX_RequisitionHeader")
                    .IsUnique();

                entity.Property(e => e.RequisitionNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PurchaseNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestNotes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterId)
                    .HasColumnName("RequesterID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionHeaderId)
                    .HasColumnName("RequisitionHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PurchaseRequisitionLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("PK_RequisitionLine");

                entity.HasIndex(e => e.RequisitionLineId)
                    .HasName("IX_RequisitionLine")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcceptActionMessage).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActionMessage).HasDefaultValueSql("((0))");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DemandDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DemandLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.DemandOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DemandQtyAvailable)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DemandQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DemandQuantityBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DemandRefNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.DemandSubtype).HasDefaultValueSql("((0))");

                entity.Property(e => e.DemandType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DirectUnitCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndingDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndingTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinishedQtyBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinishedQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GenBusinessPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.LineDiscountPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LowLevelCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mpsorder)
                    .HasColumnName("MPSOrder")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeededQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeededQuantityBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetQuantityBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nonstock).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderPromisingId)
                    .HasColumnName("OrderPromisingID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPromisingLineId)
                    .HasColumnName("OrderPromisingLineID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderPromisingLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderPromisingSubLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalDueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalVariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadRate)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanningFlexibility).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanningLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanningLineOrigin).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProdOrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomno)
                    .HasColumnName("ProductionBOMNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBomversionCode)
                    .HasColumnName("ProductionBOMVersionCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyperUomdemand)
                    .HasColumnName("QtyperUOMDemand")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityPo)
                    .HasColumnName("QuantityPO")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecurringFrequency)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RecurringMethod).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefOrderStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefOrderType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RelatedtoPlanningLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainingQtyBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainingQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplenishmentSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestNotes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterId)
                    .HasColumnName("RequesterID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionLineId)
                    .HasColumnName("RequisitionLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RequisitionheaderId).HasColumnName("RequisitionheaderID");

                entity.Property(e => e.Reserve).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingReferenceNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingVersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartingDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartingTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplyFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferShipmentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureCodeDemand)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchasesHeader>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.No })
                    .HasName("PurchaseHeader$0");

                entity.HasIndex(e => e.PurchaseHeaderId)
                    .HasName("IX_PurchaseHeader_1")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BizTalkPurchOrderCnfmn).HasDefaultValueSql("((0))");

                entity.Property(e => e.BizTalkPurchaseCreditMemo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BizTalkPurchaseInvoice).HasDefaultValueSql("((0))");

                entity.Property(e => e.BizTalkPurchaseQuote).HasDefaultValueSql("((0))");

                entity.Property(e => e.BizTalkPurchaseReceipt).HasDefaultValueSql("((0))");

                entity.Property(e => e.BuyerGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasColumnName("BuyerID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromFaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromIcpartnerCode)
                    .HasColumnName("BuyfromICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedBySourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateSent)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralComments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Icdirection).HasColumnName("ICDirection");

                entity.Property(e => e.Icstatus).HasColumnName("ICStatus");

                entity.Property(e => e.InStoreCreatedEntry).HasDefaultValueSql("((0))");

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscountValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IsInvoice).HasColumnName("isInvoice");

                entity.Property(e => e.IsReceive).HasColumnName("isReceive");

                entity.Property(e => e.ItemRegistrationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastPostingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrepaymentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrepmtCrMemoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastReceivingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastReturnShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OnlyTwoDimensions).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderClass)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OwnershipSendDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoIcpartnerCode)
                    .HasColumnName("PaytoICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.PrepaymentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtCrMemoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtCrMemoNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtPaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtPaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtPmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PrepmtPostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PromisedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseHeaderId)
                    .HasColumnName("PurchaseHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecivingPickingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefPrno)
                    .HasColumnName("RefPRNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RetailPurchaseDestFilter).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailPurchaseSourceFilter).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailSpecialOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnShipmentNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RtcfilterField)
                    .HasColumnName("RTCFilterField")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendIcdocument).HasColumnName("SendICDocument");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeReceived)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeSent)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatcountry)
                    .HasColumnName("VATCountry")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAuthorizationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCrMemoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorInvoiceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorQuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchasesLine>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseHeaderId, e.SeqLineNo })
                    .HasName("PurchaseLine$0");

                entity.HasIndex(e => e.PurchaseLineId)
                    .HasName("IX_PurchaseLine_1")
                    .IsUnique();

                entity.HasIndex(e => e.RefPrno)
                    .HasName("idxPurchasesLineRefPRNo");

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo })
                    .HasName("idxPurchasesLineNoType");

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.SeqLineNo })
                    .HasName("IX_PurchasesLine")
                    .IsUnique();

                entity.Property(e => e.PurchaseHeaderId).HasColumnName("PurchaseHeaderID");

                entity.Property(e => e.AllowInvoiceDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowItemChargeAssignment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtRcdNotInvoiced)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmtRcdNotInvoicedLcy)
                    .HasColumnName("AmtRcdNotInvoicedLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppltoItemEntry).HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AttachedtoSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompletelyReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConfigurationId)
                    .HasColumnName("ConfigurationID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossDocDifference)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeprAcquisitionCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate)
                    .HasColumnName("DepruntilFAPostingDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DirectUnitCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DropShipment).HasDefaultValueSql("((0))");

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingType)
                    .HasColumnName("FAPostingType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Finished).HasDefaultValueSql("((0))");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerRefType)
                    .HasColumnName("ICPartnerRefType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IcpartnerReference)
                    .HasColumnName("ICPartnerReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscAmounttoInvoice)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvDiscountAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobCurrencyFactor)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineAmountLcy)
                    .HasColumnName("JobLineAmountLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineDiscAmountLcy)
                    .HasColumnName("JobLineDiscAmountLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineDiscountAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineDiscountPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobLineType).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTotalPrice)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobTotalPriceLcy)
                    .HasColumnName("JobTotalPriceLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobUnitPrice)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobUnitPriceLcy)
                    .HasColumnName("JobUnitPriceLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LineAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineDiscountPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mpsorder)
                    .HasColumnName("MPSOrder")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetWeight)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nonstock).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalQuantitybase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutstandingAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutstandingAmountLcy)
                    .HasColumnName("OutstandingAmountLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutstandingQtyBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutstandingQuantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OverheadRate)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.PlanningFlexibility).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaymentLine).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaymentPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaymentTaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentTaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentTaxLiable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaymentVatdifference)
                    .HasColumnName("PrepaymentVATDifference")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaymentVatidentifier)
                    .HasColumnName("PrepaymentVATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentVatpercent)
                    .HasColumnName("PrepaymentVATPercent")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtAmountInvInclVat)
                    .HasColumnName("PrepmtAmountInvInclVAT")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtAmountInvLcy)
                    .HasColumnName("PrepmtAmountInvLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtAmtDeducted)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtAmtInclVat)
                    .HasColumnName("PrepmtAmtInclVAT")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtAmtInv)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtAmttoDeduct)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtLineAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtVatbaseAmt)
                    .HasColumnName("PrepmtVATBaseAmt")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtVatcalcType)
                    .HasColumnName("PrepmtVATCalcType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtVatdiffDeducted)
                    .HasColumnName("PrepmtVATDiffDeducted")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepmtVatdifftoDeduct)
                    .HasColumnName("PrepmtVATDifftoDeduct")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromisedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseLineId)
                    .HasColumnName("PurchaseLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyRcdNotInvoiced)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyRcdNotInvoicedBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyReceivedBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyperUnitofMeasure)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtytoInvoice)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtytoInvoiceBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtytoReceive)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QtytoReceiveBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityDifference)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityReceived)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefPrlineNo)
                    .HasColumnName("RefPRLineNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefPrno)
                    .HasColumnName("RefPRNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReservedForLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RetQtyShpdNotInvdBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnQtyShipped)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnQtyShippedBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnQtyShippedNotInvd)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnQtytoShip)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnQtytoShipBase)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnShipmentSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnShpdNotInvd)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnShpdNotInvdLcy)
                    .HasColumnName("ReturnShpdNotInvdLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingReferenceNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SafetyLeadTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalvageValue)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecialOrderSalesNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialOrderSalesSeqLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SystemCreatedEntry).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxLiable).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPriceLcy)
                    .HasColumnName("UnitPriceLCY")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitRetailValue)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitVolume)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseDuplicationList).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType)
                    .HasColumnName("VATCalculationType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchasesPayablesSetup>(entity =>
            {
                entity.Property(e => e.PurchasesPayablesSetupId).HasColumnName("PurchasesPayablesSetupID");

                entity.Property(e => e.AllowVatdifference).HasColumnName("AllowVATDifference");

                entity.Property(e => e.BlanketOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CalcInvDiscperVatid).HasColumnName("CalcInvDiscperVATID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnableVendorGstamountAcy).HasColumnName("EnableVendorGSTAmountACY");

                entity.Property(e => e.GstprodPostingGroup)
                    .HasColumnName("GSTProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostDatedCheckBatch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostDatedCheckTemplate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedCreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedInvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedNonTaxCreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedNonTaxInvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedPrepmtCrMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedPrepmtInvNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedReceiptNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedReturnShptNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedTaxCreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedTaxInvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreGstprodPostingGroup)
                    .HasColumnName("PreGSTProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuoteNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitionNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Qualification$0");

                entity.HasIndex(e => e.QualificationId)
                    .HasName("IX_Qualification")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.QualificationId)
                    .HasColumnName("QualificationID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReasonCode>(entity =>
            {
                entity.HasKey(e => new { e.ReasonCodeGroupNo, e.Code })
                    .HasName("Reason Code$0");

                entity.HasIndex(e => e.ReasonCodeId)
                    .HasName("IX_ReasonCode")
                    .IsUnique();

                entity.Property(e => e.ReasonCodeGroupNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlaccountNo)
                    .HasColumnName("GLAccountNo")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonCodeId)
                    .HasColumnName("ReasonCodeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReasonCodeGroups>(entity =>
            {
                entity.HasKey(e => e.ReasonCodeGroupsNo)
                    .HasName("Reason Code Groups$0");

                entity.HasIndex(e => e.ReasonCodeGroupsId)
                    .HasName("IX_ReasonCodeGroups")
                    .IsUnique();

                entity.Property(e => e.ReasonCodeGroupsNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonCodeGroupsId)
                    .HasColumnName("ReasonCodeGroupsID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Relative>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Relative$0");

                entity.HasIndex(e => e.RelativeId)
                    .HasName("IX_Relative")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .HasColumnName("RelativeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReportSelections>(entity =>
            {
                entity.HasKey(e => new { e.Usage, e.Sequence })
                    .HasName("ReportSelections$0");

                entity.HasIndex(e => e.ReportSelectionsId)
                    .HasName("IX_ReportSelections")
                    .IsUnique();

                entity.Property(e => e.Usage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportSelectionsId)
                    .HasColumnName("ReportSelectionsID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReservationEntry>(entity =>
            {
                entity.HasKey(e => new { e.EntryNo, e.Positive })
                    .HasName("ReservationEntry$0");

                entity.HasIndex(e => e.ReservationEntryId)
                    .HasName("IX_ReservationEntry")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.NewLotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewSerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoHandleBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoInvoiceBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityInvoicedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReservationEntryId)
                    .HasColumnName("ReservationEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReservedPickandShipQty).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SourceBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Resource$0");

                entity.HasIndex(e => e.RecourceId)
                    .HasName("IX_Resource")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContractClass)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Education)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentDate).HasColumnType("datetime");

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerPurchGlaccNo)
                    .HasColumnName("ICPartnerPurchGLAccNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecourceId)
                    .HasColumnName("RecourceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ResourceGroupNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SearchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceZoneFilter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WhtproductPostingGroup)
                    .HasColumnName("WHTProductPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResourcePrice>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.Type, e.Code, e.WorkTypeCode, e.CurrencyCode })
                    .HasName("ResourcePrice$0");

                entity.HasIndex(e => e.ResourcePriceId)
                    .HasName("IX_ResourcePrice")
                    .IsUnique();

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ResourcePriceId)
                    .HasColumnName("ResourcePriceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<ReturnReason>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("ReturnReason$0");

                entity.HasIndex(e => e.ReturnReasonId)
                    .HasName("IX_ReturnReason")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnReasonId)
                    .HasColumnName("ReturnReasonID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReturnReceiptHeader>(entity =>
            {
                entity.HasKey(e => e.ReturnReceiptHeaderNo)
                    .HasName("ReturnReceiptHeader$0");

                entity.HasIndex(e => e.ReturnReceiptHeaderId)
                    .HasName("IX_ReturnReceiptHeader")
                    .IsUnique();

                entity.Property(e => e.ReturnReceiptHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Eu3partyTrade).HasColumnName("EU3PartyTrade");

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTrackingNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PromisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecivingPickingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReceiptHeaderId)
                    .HasColumnName("ReturnReceiptHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatcountry)
                    .HasColumnName("VATCountry")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReturnReceiptLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("ReturnReceiptLine$0");

                entity.HasIndex(e => e.ReturnReceiptLineId)
                    .HasName("IX_ReturnReceiptLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReturnReceiptHeaderId, e.SeqLineNo })
                    .HasName("IX_ReturnReceiptLine_1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeBaseAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyInvoicedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnQtyRcdNotInvd).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReceiptHeaderId).HasColumnName("ReturnReceiptHeaderID");

                entity.Property(e => e.ReturnReceiptLineId)
                    .HasColumnName("ReturnReceiptLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReturnShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.ReturnShipmentHeaderNo)
                    .HasName("ReturnShipmentHeader$0");

                entity.HasIndex(e => e.ReturnShipmentHeaderId)
                    .HasName("IX_ReturnShipmentHeader")
                    .IsUnique();

                entity.Property(e => e.ReturnShipmentHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecivingPickingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnShipmentHeaderId)
                    .HasColumnName("ReturnShipmentHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcountryRegionCode)
                    .HasColumnName("VATCountryRegionCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAuthorizationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReturnShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("ReturnShipmentLine$0");

                entity.HasIndex(e => e.ReturnShipmentLineId)
                    .HasName("IX_ReturnShipmentLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReturnShipmentHeaderId, e.SeqLineNo })
                    .HasName("IX_ReturnShipmentLine_1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedFano)
                    .HasColumnName("BudgetedFANo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FapostingType).HasColumnName("FAPostingType");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeBaseAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaintenanceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyInvoicedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnQtyShippedNoInvd).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnShipmentHeaderId).HasColumnName("ReturnShipmentHeaderID");

                entity.Property(e => e.ReturnShipmentLineId)
                    .HasColumnName("ReturnShipmentLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalvageValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPriceLcy)
                    .HasColumnName("UnitPriceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoutingHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("RoutingHeader$0");

                entity.HasIndex(e => e.RoutingHeaderId)
                    .HasName("IX_RoutingHeader")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingHeaderId)
                    .HasColumnName("RoutingHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoutingStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoutingLine>(entity =>
            {
                entity.HasKey(e => new { e.RoutingNo, e.VersionCode, e.OperationNo })
                    .HasName("RoutingLine$0");

                entity.HasIndex(e => e.RoutingLineId)
                    .HasName("IX_RoutingLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.RoutingHeaderId, e.VersionCode, e.OperationNo })
                    .HasName("IX_RoutingLine_1")
                    .IsUnique();

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConcurrentCapacities).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FixedScrapQtyAccum).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.FixedScrapQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LotSize).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaximumProcessTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinimumProcessTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MoveTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MoveTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NextOperationNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousOperationNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingHeaderId).HasColumnName("RoutingHeaderID");

                entity.Property(e => e.RoutingLineId)
                    .HasColumnName("RoutingLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoutingLinkCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RunTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RunTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapFactorPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ScrapFactorPercentAccumulated).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SendAheadQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SetupTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SetupTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StandardTaskCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCostper).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WaitTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WaitTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoutingLink>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("RoutingLink$0");

                entity.HasIndex(e => e.RoutingLinkId)
                    .HasName("IX_RoutingLink")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.RoutingLinkId)
                    .HasColumnName("RoutingLinkID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RoutingPersonnel>(entity =>
            {
                entity.HasKey(e => new { e.RoutingNo, e.VersionCode, e.OperationNo, e.SeqLineNo })
                    .HasName("RoutingPersonnel$0");

                entity.HasIndex(e => e.RoutingPersonnelId)
                    .HasName("IX_RoutingPersonnel")
                    .IsUnique();

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingPersonnelId)
                    .HasColumnName("RoutingPersonnelID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RoutingQualityMeasure>(entity =>
            {
                entity.HasKey(e => new { e.RoutingNo, e.VersionCode, e.OperationNo, e.SeqLineNo })
                    .HasName("RoutingQualityMeasure$0");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MeanTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QltyMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingQualityMeasureId)
                    .HasColumnName("RoutingQualityMeasureID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RoutingTool>(entity =>
            {
                entity.HasKey(e => new { e.RoutingNo, e.VersionCode, e.OperationNo, e.SeqLineNo })
                    .HasName("RoutingTool$0");

                entity.HasIndex(e => e.RoutingToolId)
                    .HasName("IX_RoutingTool")
                    .IsUnique();

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingToolId)
                    .HasColumnName("RoutingToolID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesCommentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.No, e.DocumentSeqLineNo, e.SeqLineNo })
                    .HasName("SalesCommentLine$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SalesCommentLineId)
                    .HasColumnName("SalesCommentLineID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesCrMemoHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("SalesCrMemoHeader$0");

                entity.HasIndex(e => e.SalesCrMemoHeaderId)
                    .HasName("IX_SalesCrMemoHeader")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashierId)
                    .HasColumnName("CashierID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Eu3partyTrade).HasColumnName("EU3PartyTrade");

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LandedCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.Posid)
                    .HasColumnName("POSID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostingTime).HasColumnType("datetime");

                entity.Property(e => e.PreAssignedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreAssignedNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtCrMemoNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCrMemoHeaderId)
                    .HasColumnName("SalesCrMemoHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeSent).HasColumnType("datetime");

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcountryRegionCode)
                    .HasColumnName("VATCountryRegionCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesCrMemoLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("SalesCrMemoLine$0");

                entity.HasIndex(e => e.SalesCrMemoLineId)
                    .HasName("IX_SalesCrMemoLine")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppliestoDocType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerRefType).HasColumnName("ICPartnerRefType");

                entity.Property(e => e.IcpartnerReference)
                    .HasColumnName("ICPartnerReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCrMemoHeaderId).HasColumnName("SalesCrMemoHeaderID");

                entity.Property(e => e.SalesCrMemoLineId)
                    .HasColumnName("SalesCrMemoLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATpercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesHeader>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.SalesHeaderNo });

                entity.HasIndex(e => e.SalesHeaderId)
                    .HasName("IX_SalesHeader")
                    .IsUnique();

                entity.HasIndex(e => e.SalesHeaderNo)
                    .HasName("IX_SalesHeader_1");

                entity.Property(e => e.SalesHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentAppliesto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Basadjustment).HasColumnName("BASAdjustment");

                entity.Property(e => e.BilltoAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerTemplateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoIcpartnerCode)
                    .HasColumnName("BilltoICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerQuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Icdirection).HasColumnName("ICDirection");

                entity.Property(e => e.Icstatus).HasColumnName("ICStatus");

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscountValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IsReceive).HasColumnName("isReceive");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastPostingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrepaymentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrepmtCrMemoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastReturnReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastShippingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderClass)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTrackingNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.PrepaymentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtCrMemoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtCrMemoNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtPaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtPaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepmtPmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PrepmtPostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PromisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReceiptNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesHeaderId)
                    .HasColumnName("SalesHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerTemplateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoFaxNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoIcpartnerCode)
                    .HasColumnName("SelltoICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoPhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendIcdocument).HasColumnName("SendICDocument");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountryRegionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcountryRegionCode)
                    .HasColumnName("VATCountryRegionCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesInvoiceHeader>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceHeaderNo);

                entity.HasIndex(e => e.SelltoCustomerNo)
                    .HasName("IX_SalesInvoiceHeader");

                entity.HasIndex(e => new { e.SalesInvoiceHeaderId, e.ShipmentDate, e.DocumentType })
                    .HasName("idxSIHDocType");

                entity.HasIndex(e => new { e.ShipmentDate, e.SalesInvoiceHeaderId, e.DocumentType })
                    .HasName("idxSIHDoctypeID");

                entity.HasIndex(e => new { e.SalesInvoiceHeaderNo, e.SelltoCustomerNo, e.PostingDate, e.ShipmentDate, e.PostingDescription, e.ShortcutDimension1Code, e.ShortcutDimension2Code, e.GenBusPostingGroup, e.BalAccountType, e.ExternalDocumentNo, e.LandedCost })
                    .HasName("idxSalesInvoiceHeaderLandedCost");

                entity.Property(e => e.SalesInvoiceHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoHouseNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CashierId)
                    .HasColumnName("CashierID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerContactDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DaytimePhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryReferenceNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Eu3partyTrade).HasColumnName("EU3PartyTrade");

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceAgreementNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinancedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LandedCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NonRefundAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTrackingNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAtDeliveryLimit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentAtOrderEntryLimit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentAtPurchaseOrderLimit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentValue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.Posid)
                    .HasColumnName("POSID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostingTime).HasColumnType("datetime");

                entity.Property(e => e.PreAssignedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreAssignedNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RetailZonesCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RetailZonesDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RingBackDate).HasColumnType("datetime");

                entity.Property(e => e.SalesInvoiceHeaderId)
                    .HasColumnName("SalesInvoiceHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SelltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SelltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SelltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToTelephone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoHouseNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpocreatedEntry).HasColumnName("SPOCreatedEntry");

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeSent).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmountIncdTax)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalLiter)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalQty)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalTax)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcountryRegionCode)
                    .HasColumnName("VATCountryRegionCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesInvoiceLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo });

                entity.HasIndex(e => e.SalesInvoiceHeaderId)
                    .HasName("IX_SalesInvoiceLine_1");

                entity.HasIndex(e => e.SalesInvoiceLineId)
                    .HasName("IX_SalesInvoiceLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.RecordNo })
                    .HasName("idxSILRecordnoDocNo");

                entity.HasIndex(e => new { e.SalesInvoiceHeaderId, e.RowStatus })
                    .HasName("idxSalesInvoiceLine_ID_Status");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppliestoDocType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigurationId)
                    .HasColumnName("ConfigurationID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CukaiCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CukaiCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryReferenceNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryUserId)
                    .HasColumnName("DeliveryUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerRefType).HasColumnName("ICPartnerRefType");

                entity.Property(e => e.IcpartnerReference)
                    .HasColumnName("ICPartnerReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTrackingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NolaterthanDate).HasColumnType("datetime");

                entity.Property(e => e.NonRefundAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OfferNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OptionValueText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderLineNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentAtDeliveryLimit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentAtOrderEntryLimit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentAtPurchaseOrderLimit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceHeaderId)
                    .HasColumnName("SalesInvoiceHeaderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesInvoiceLineId)
                    .HasColumnName("SalesInvoiceLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpodocumentMethod).HasColumnName("SPODocumentMethod");

                entity.Property(e => e.SpowhseLocation)
                    .HasColumnName("SPOWhseLocation")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreSalesLocation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.SeqLineNo });

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppliestoDocType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CukaiCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CukaiCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerRefType).HasColumnName("ICPartnerRefType");

                entity.Property(e => e.IcpartnerReference)
                    .HasColumnName("ICPartnerReference")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscAmounttoInvoice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginallyOrderedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginallyOrderedVarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutstandingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutstandingAmountLcy)
                    .HasColumnName("OutstandingAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutstandingQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutstandingQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PlannedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepaymentPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepaymentTaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentTaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentVatdifference)
                    .HasColumnName("PrepaymentVATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepaymentVatidentifier)
                    .HasColumnName("PrepaymentVATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentVatpercent)
                    .HasColumnName("PrepaymentVATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtAmountInvInclVat)
                    .HasColumnName("PrepmtAmountInvInclVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtAmountInvLcy)
                    .HasColumnName("PrepmtAmountInvLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtAmtDeducted).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtAmtInclVat)
                    .HasColumnName("PrepmtAmtInclVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtAmtInv).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtAmttoDeduct).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtLineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtVatbaseAmt)
                    .HasColumnName("PrepmtVATBaseAmt")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtVatcalcType).HasColumnName("PrepmtVATCalcType");

                entity.Property(e => e.PrepmtVatdiffDeducted)
                    .HasColumnName("PrepmtVATDiffDeducted")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PrepmtVatdifftoDeduct)
                    .HasColumnName("PrepmtVATDifftoDeduct")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PromisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyInvoicedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShippedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShippedNotInvdBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShippedNotInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoInvoice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoInvoiceBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoShip).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoShipBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityShipped).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RetQtyRcdNotInvdBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnQtyRcdNotInvd).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnQtyReceived).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnQtyReceivedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnQtytoReceive).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnQtytoReceiveBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnRcdNotInvd).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnRcdNotInvdLcy)
                    .HasColumnName("ReturnRcdNotInvdLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDiscountGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesHeaderId).HasColumnName("SalesHeaderID");

                entity.Property(e => e.SalesLineId)
                    .HasColumnName("SalesLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedNotInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShippedNotInvoicedLcy)
                    .HasColumnName("ShippedNotInvoicedLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialOrderPurchaseNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesLineDiscount>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Code, e.SalesType, e.SalesCode, e.StartingDate, e.CurrencyCode, e.VariantCode, e.UnitofMeasureCode, e.MinimumQuantity })
                    .HasName("Sales Line Discount$0");

                entity.HasIndex(e => e.SalesLineDiscountId)
                    .HasName("IX_SalesLineDiscount")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalesLineDiscountId)
                    .HasColumnName("SalesLineDiscountID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesPrepaymentPercent>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.SalesType, e.SalesCode, e.StartingDate })
                    .HasName("SalesPrepaymentPercent$0");

                entity.HasIndex(e => e.SalesPrepaymentPercentId)
                    .HasName("IX_SalesPrepaymentPercent")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PrepaymentPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalesPrepaymentPercentId)
                    .HasColumnName("SalesPrepaymentPercentID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesPrice>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.SalesType, e.SalesCode, e.StartingDate, e.CurrencyCode, e.VariantCode, e.UnitofMeasureCode, e.MinimumQuantity })
                    .HasName("Sales Price$0");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostplusPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PriceIncludesVat).HasColumnName("PriceIncludesVAT");

                entity.Property(e => e.SalesPriceId)
                    .HasColumnName("SalesPriceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGrPrice)
                    .HasColumnName("VATBusPostingGrPrice")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesReceivablesSetup>(entity =>
            {
                entity.Property(e => e.SalesReceivablesSetupId).HasColumnName("SalesReceivablesSetupID");

                entity.Property(e => e.AllowVatdifference).HasColumnName("AllowVATDifference");

                entity.Property(e => e.BlanketOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CalcInvDiscperVatid).HasColumnName("CalcInvDiscperVATID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroupDimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension01Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dimension02Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dimension03Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dimension04Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dimension05Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinChrgMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FreeOfChargeNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InclPdcinCrLimitCheck).HasColumnName("InclPDCinCrLimitCheck");

                entity.Property(e => e.InvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedFinChrgMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedReminderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostDatedCheckBatch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostDatedCheckTemplate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedCreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedInvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedNonTaxCreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedNonTaxInvoiceNos)
                    .HasColumnName("PostedNonTaxInvoiceNos_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedPrepmtCrMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedPrepmtInvNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedReturnReceiptNos)
                    .HasColumnName("PostedReturnReceiptNos_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedShipmentNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedTaxCreditMemoNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedTaxInvoiceNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreGstprodPostingGroup)
                    .HasColumnName("PreGSTProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuoteNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnOrderNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonDimensionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.SalesShipmentHeaderNo);

                entity.HasIndex(e => e.SalesShipmentHeaderId)
                    .HasName("IX_SalesShipmentHeader")
                    .IsUnique();

                entity.HasIndex(e => new { e.SalesShipmentHeaderId, e.SalesShipmentHeaderNo, e.ShipmentDate, e.SalespersonCode, e.SelltoCustomerName, e.DocumentType })
                    .HasName("idxSalesShipmentHeaderType");

                entity.HasIndex(e => new { e.SalesShipmentHeaderId, e.SalesShipmentHeaderNo, e.ShipmentDate, e.SelltoCustomerName, e.SalespersonCode, e.DocumentType })
                    .HasName("idxSalesShipmentHeaderSalesType");

                entity.Property(e => e.SalesShipmentHeaderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BilltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Eu3partyTrade).HasColumnName("EU3PartyTrade");

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTrackingNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PromisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesShipmentHeaderId)
                    .HasColumnName("SalesShipmentHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelltoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiptoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatcountry)
                    .HasColumnName("VATCountry")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo });

                entity.HasIndex(e => e.SalesShipmentLineId)
                    .HasName("IX_SalesShipmentLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.SalesShipmentHeaderId, e.SeqLineNo })
                    .HasName("IX_SalesShipmentLine_1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BilltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BlanketOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossReferenceTypeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CukaiCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CukaiCost)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerDiscGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPriceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationBookCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepruntilFapostingDate).HasColumnName("DepruntilFAPostingDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DuplicateinDepreciationBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FapostingDate)
                    .HasColumnName("FAPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeBaseAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LineDiscountPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PromisedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyInvoicedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShippedNotInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityOrder)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesShipmentHeaderId).HasColumnName("SalesShipmentHeaderID");

                entity.Property(e => e.SalesShipmentLineId)
                    .HasColumnName("SalesShipmentLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SelltoCustomerNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("UnitCostLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCrossRef)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbaseAmount)
                    .HasColumnName("VATBaseAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalespersonPurchaser>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Salesperson_Purchaser$0");

                entity.ToTable("Salesperson_Purchaser");

                entity.HasIndex(e => e.SalesPersonPurchaserId)
                    .HasName("IX_Salesperson_Purchaser")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommissionPercent)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("EMail2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FloatAmount)
                    .HasColumnType("decimal(38, 5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RetailCommissionBlocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesPersonPurchaserId)
                    .HasColumnName("SalesPerson_PurchaserID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SearchEmail)
                    .HasColumnName("SearchEMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Store)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShopCalendar>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("ShopCalendar$0");

                entity.HasIndex(e => e.ShopCalendarId)
                    .HasName("IX_ShopCalendar")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ShopCalendarId)
                    .HasColumnName("ShopCalendarID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ShopCalendarHoliday>(entity =>
            {
                entity.HasKey(e => new { e.ShopCalendarCode, e.Date })
                    .HasName("ShopCalendarHoliday$0");

                entity.HasIndex(e => e.ShopCalendarHolidayId)
                    .HasName("IX_ShopCalendarHoliday")
                    .IsUnique();

                entity.Property(e => e.ShopCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndingDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ShopCalendarHolidayId)
                    .HasColumnName("ShopCalendarHolidayID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StartingDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopCalendarWorkingDays>(entity =>
            {
                entity.HasKey(e => new { e.ShopCalendarCode, e.Day, e.StartingTime, e.EndingTime, e.WorkShiftCode })
                    .HasName("ShopCalendarWorkingDays$0");

                entity.HasIndex(e => e.ShopCalendarWorkingDaysId)
                    .HasName("IX_ShopCalendarWorkingDays")
                    .IsUnique();

                entity.Property(e => e.ShopCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkShiftCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ShopCalendarWorkingDaysId)
                    .HasColumnName("ShopCalendarWorkingDaysID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SourceCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("SourceCode$0");

                entity.HasIndex(e => e.SourceCodeId)
                    .HasName("IX_SourceCode")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCodeId)
                    .HasColumnName("SourceCodeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SourceCodeSetup>(entity =>
            {
                entity.Property(e => e.SourceCodeSetupId)
                    .HasColumnName("SourceCodeSetupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdjustAddReportingCurrency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustCost)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bomjournal)
                    .IsRequired()
                    .HasColumnName("BOMJournal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CapacityJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CashReceiptJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CloseIncomeStatement)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressBankAccLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressBomledger)
                    .IsRequired()
                    .HasColumnName("CompressBOMLedger")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressCheckLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressCustLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressFaledger)
                    .IsRequired()
                    .HasColumnName("CompressFALedger")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressGl)
                    .IsRequired()
                    .HasColumnName("CompressGL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressInsuranceLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressItemLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressJobLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressMaintenanceLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressResLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressVatentries)
                    .IsRequired()
                    .HasColumnName("CompressVATEntries")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressVendLedger)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompressWhseEntries)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Consolidation)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumptionJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedDocument)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRateAdjmt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceChargeMemo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FinanciallyVoidedCheck)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FixedAssetGljournal)
                    .IsRequired()
                    .HasColumnName("FixedAssetGLJournal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FixedAssetJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Flushing)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IcgeneralJournal)
                    .IsRequired()
                    .HasColumnName("ICGeneralJournal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostCost)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemReclassJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobGljournal)
                    .IsRequired()
                    .HasColumnName("JobGLJournal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobGlwip)
                    .IsRequired()
                    .HasColumnName("JobGLWIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OutputJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysInventoryJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostRecognition)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostValue)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseEntryApplication)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Purchases)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reminder)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevaluationJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reversal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sales)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesEntryApplication)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceManagement)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransBankRectoGenJnl)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Transfer)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnappliedPurchEntryAppln)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnappliedSalesEntryAppln)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatsettlement)
                    .IsRequired()
                    .HasColumnName("VATSettlement")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseItemJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseMovement)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhsePhysInvtJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhsePick)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhsePutaway)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseReclassificationJournal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.HasKey(e => e.StatementNo)
                    .HasName("Statement$0");

                entity.HasIndex(e => e.StatementId)
                    .HasName("IX_Statement")
                    .IsUnique();

                entity.Property(e => e.StatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedbyUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShiftNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CalculatedDate).HasColumnType("datetime");

                entity.Property(e => e.CalculatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.PostedTime).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPostermFilterInternal)
                    .HasColumnName("StaffPOSTermFilterInternal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatementDate).HasColumnType("datetime");

                entity.Property(e => e.StatementId)
                    .HasColumnName("StatementID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransEndingDate).HasColumnType("datetime");

                entity.Property(e => e.TransEndingTime).HasColumnType("datetime");

                entity.Property(e => e.TransStartingDate).HasColumnType("datetime");

                entity.Property(e => e.TransStartingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StatementLine>(entity =>
            {
                entity.HasKey(e => new { e.StatementNo, e.SeqLineNo })
                    .HasName("StatementLine$0");

                entity.HasIndex(e => e.StatementLineId)
                    .HasName("IX_StatementLine")
                    .IsUnique();

                entity.Property(e => e.StatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddedtoDrawer).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ChangeTender).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CountedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CountedAmountinLcy)
                    .HasColumnName("CountedAmountinLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DifferenceAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DifferenceinLcy)
                    .HasColumnName("DifferenceinLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.PosterminalNo)
                    .HasColumnName("POSTerminalNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RealExchangeRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemovedfromDrawer).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatementCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatementLineId)
                    .HasColumnName("StatementLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenderType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenderTypeCardNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenderTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.TransAmountinLcy)
                    .HasColumnName("TransAmountinLCY")
                    .HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<StatementSalesEntry>(entity =>
            {
                entity.HasKey(e => new { e.StatementNo, e.SeqLineNo })
                    .HasName("StatementSalesEntry$0");

                entity.HasIndex(e => e.StatementSalesEntryId)
                    .HasName("IX_StatementSalesEntry")
                    .IsUnique();

                entity.Property(e => e.StatementNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BilltoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LandedCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Liter).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Payment).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatementSalesEntryId)
                    .HasColumnName("StatementSalesEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Tax).HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<StockDeliveryHeader>(entity =>
            {
                entity.HasKey(e => e.DocumentNo)
                    .HasName("PK_StockDeliveryHeader_1");

                entity.HasIndex(e => e.StockDeliveryHeaderId)
                    .HasName("IX_StockDeliveryHeader")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.FromLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("lastModifiedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockDeliveryHeaderId)
                    .HasColumnName("StockDeliveryHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockReqNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockDeliveryLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo });

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.FromLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderLineNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockDeliveryHeaderId).HasColumnName("StockDeliveryHeaderID");

                entity.Property(e => e.StockDeliveryLineId)
                    .HasColumnName("StockDeliveryLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StockReqNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockRequisitionHeader>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.DocumentType })
                    .HasName("PK_StockRequisitionHeader_1");

                entity.HasIndex(e => e.StockRequisitionHeaderId)
                    .HasName("IX_StockRequisitionHeader")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.FromLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("lastModifiedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockRequisitionHeaderId)
                    .HasColumnName("StockRequisitionHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ToLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockRequisitionLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.DocumentType, e.SeqLineNo });

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutstandingQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutstandingQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderLineNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyDeliveryBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityDelivery).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockRequisitionHeaderId).HasColumnName("StockRequisitionHeaderID");

                entity.Property(e => e.StockRequisitionLineId)
                    .HasColumnName("StockRequisitionLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ToLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockReturnReceiptHeader>(entity =>
            {
                entity.HasKey(e => e.DocumentNo)
                    .HasName("PK_StockReturnReceiptHeader_1");

                entity.HasIndex(e => e.StockReturnReceiptHeaderId)
                    .HasName("IX_StockReturnReceiptHeader")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.FromLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("lastModifiedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockReqNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockReturnReceiptHeaderId)
                    .HasColumnName("StockReturnReceiptHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ToLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockReturnReceiptLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo });

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderLineNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedReturnReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockReqNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockReturnReceiptHeaderId).HasColumnName("StockReturnReceiptHeaderID");

                entity.Property(e => e.StockReturnReceiptLineId)
                    .HasColumnName("StockReturnReceiptLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ToLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockkeepingUnit>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.ItemNo, e.VariantCode })
                    .HasName("StockkeepingUnit$0");

                entity.HasIndex(e => e.StockkeepingUnitId)
                    .HasName("IX_StockkeepingUnit")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentsatLocation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastCountingPeriodUpdate).HasColumnType("datetime");

                entity.Property(e => e.LastDirectCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LotSize).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaximumInventory).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaximumOrderQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinimumOrderQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NextCountingPeriod)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMultiple).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PutawayTemplateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PutawayUnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReorderCycle)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReorderPoint).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReorderQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SafetyLeadTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SafetyStockQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialEquipmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StandardCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.StockkeepingUnitId)
                    .HasColumnName("StockkeepingUnitID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VendorItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TenderType>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.Code })
                    .HasName("TenderType$0");

                entity.HasIndex(e => e.TenderTypeId)
                    .HasName("IX_TenderType")
                    .IsUnique();

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AboveMinChangeTenderType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AskforCardAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankDiffGlacc)
                    .HasColumnName("BankDiffGLAcc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeLineonReceipt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeTendCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChargePercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ChargetoAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckPayee)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DifferenceGlacc)
                    .HasColumnName("DifferenceGLAcc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndorsementLine1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EndorsementLine2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceinPrinter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxAmountAllowed).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MaxAmountEntered).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinAmountAllowed).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinAmountEntered).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinChange).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NoinTransaction)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OvertenderMaxAmt).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PoscountEntries).HasColumnName("POSCountEntries");

                entity.Property(e => e.PospickupWarningAmount)
                    .HasColumnName("POSPickupWarningAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PospickupWarningText)
                    .HasColumnName("POSPickupWarningText")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrintinCidreport).HasColumnName("PrintinCIDReport");

                entity.Property(e => e.RemoveFloatType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoundingTo).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SlipBackinPrinter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SlipFrontinPrinter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenderTypeId)
                    .HasColumnName("TenderTypeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TrackingSpecification>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("TrackingSpecification$0");

                entity.HasIndex(e => e.TrackingSpecificationId)
                    .HasName("IX_TrackingSpecification")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BufferValue1).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BufferValue2).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BufferValue3).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BufferValue4).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BufferValue5).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.NewLotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewSerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyDifference).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyDifferenceBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoHandle).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoHandleBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoInvoice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoInvoiceBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityHandledBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityInvoicedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityactualHandledBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingSpecificationId)
                    .HasColumnName("TrackingSpecificationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransferHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("TransferHeader$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasColumnName("BuyerID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedBySourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PreReceiveReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.RecivingPickingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RtcfilteringType).HasColumnName("RTCFilteringType");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpocreatedEntry).HasColumnName("SPOCreatedEntry");

                entity.Property(e => e.SpotransferStatus).HasColumnName("SPOTransferStatus");

                entity.Property(e => e.Storefrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Storeto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferHeaderId)
                    .HasColumnName("TransferHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromDepartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoDepartCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("TransferLine$0");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActualQtytoReceive).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ActualQtytoReceiveBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ConfigurationId)
                    .HasColumnName("ConfigurationID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutstandingQtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OutstandingQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyDifference).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyDifferenceBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyReceivedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShippedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyinTransit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyinTransitBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoReceive).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoReceiveBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoShip).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoShipBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityReceived).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityShipped).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferLineId)
                    .HasColumnName("TransferLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferReceiptHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("TransferReceiptHeader$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PreReceiveReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.RecivingPickingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Storefrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Storeto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderDate).HasColumnType("datetime");

                entity.Property(e => e.TransferOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferReceiptHeaderId)
                    .HasColumnName("TransferReceiptHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCountrye)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferReceiptLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("TransferReceiptLine$0");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActualQtytoReceive).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ActualQtytoReceiveBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyDifference).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyDifferenceBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferReceiptLineId)
                    .HasColumnName("TransferReceiptLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferRoute>(entity =>
            {
                entity.HasKey(e => new { e.TransferfromCode, e.TransfertoCode })
                    .HasName("TransferRoute$0");

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferRouteId)
                    .HasColumnName("TransferRouteID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransferShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("TransferShipmentHeader$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryExitPoint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.RecivingPickingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Storefrom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Storeto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSpecification)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderDate).HasColumnType("datetime");

                entity.Property(e => e.TransferOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferShipmentHeaderId)
                    .HasColumnName("TransferShipmentHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCounty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportMethod)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("TransferShipmentLine$0");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InTransitCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QuantityBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTime)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferShipmentLineId)
                    .HasColumnName("TransferShipmentLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransferfromBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransferfromCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransfertoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitVolume).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsperParcel).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitOfMeasures>(entity =>
            {
                entity.HasKey(e => e.Uomcode);

                entity.HasIndex(e => e.UnitOfMeasureId)
                    .HasName("IX_UnitOfMeasures_1")
                    .IsUnique();

                entity.Property(e => e.Uomcode)
                    .HasColumnName("UOMCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PosminDenominator)
                    .HasColumnName("POSMinDenominator")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitOfMeasureId)
                    .HasColumnName("UnitOfMeasureID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Uomdescription)
                    .HasColumnName("UOMDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValidationPeriod>(entity =>
            {
                entity.HasKey(e => e.ValidationNo)
                    .HasName("ValidationPeriod$0");

                entity.HasIndex(e => e.ValidationPeriodId)
                    .HasName("IX_ValidationPeriod")
                    .IsUnique();

                entity.Property(e => e.ValidationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.EndingTime).HasColumnType("datetime");

                entity.Property(e => e.EndingTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.FriEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.FriEndingTime).HasColumnType("datetime");

                entity.Property(e => e.FriStartingTime).HasColumnType("datetime");

                entity.Property(e => e.FriTimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MonEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.MonEndingTime).HasColumnType("datetime");

                entity.Property(e => e.MonStartingTime).HasColumnType("datetime");

                entity.Property(e => e.MonTimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.SatEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.SatEndingTime).HasColumnType("datetime");

                entity.Property(e => e.SatStartingTime).HasColumnType("datetime");

                entity.Property(e => e.SatTimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.StartingTime).HasColumnType("datetime");

                entity.Property(e => e.SunEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.SunEndingTime).HasColumnType("datetime");

                entity.Property(e => e.SunStartingTime).HasColumnType("datetime");

                entity.Property(e => e.SunTimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThuEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThuEndingTime).HasColumnType("datetime");

                entity.Property(e => e.ThuStartingTime).HasColumnType("datetime");

                entity.Property(e => e.ThuTimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.TueEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.TueEndingTime).HasColumnType("datetime");

                entity.Property(e => e.TueStartingTime).HasColumnType("datetime");

                entity.Property(e => e.TueTimewithinBounds).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValidationPeriodId)
                    .HasColumnName("ValidationPeriodID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WedEndTimeAfterMidnight).HasDefaultValueSql("((0))");

                entity.Property(e => e.WedEndingTime).HasColumnType("datetime");

                entity.Property(e => e.WedStartingTime).HasColumnType("datetime");

                entity.Property(e => e.WedTimewithinBounds).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ValueEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("ValueEntry$0");

                entity.HasIndex(e => e.ValueEntryId)
                    .HasName("IX_ValueEntry")
                    .IsUnique();

                entity.HasIndex(e => new { e.CostperUnit, e.ItemLedgerEntryNo })
                    .HasName("ValueEntry_ItemLedgerEntryNo_CostperUnit");

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostAmountActual).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostAmountActualAcy)
                    .HasColumnName("CostAmountActualACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostAmountExpected).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostAmountExpectedAcy)
                    .HasColumnName("CostAmountExpectedACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostAmountNonInvtbl).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostAmountNonInvtblAcy)
                    .HasColumnName("CostAmountNonInvtblACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostPostedtoGl)
                    .HasColumnName("CostPostedtoGL")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostPostedtoGlacy)
                    .HasColumnName("CostPostedtoGLACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostperUnit).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CostperUnitAcy)
                    .HasColumnName("CostperUnitACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Division)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpCostPostedtoGlacy)
                    .HasColumnName("ExpCostPostedtoGLACY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ExpectedCostPostedtoGl)
                    .HasColumnName("ExpectedCostPostedtoGL")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvAdjustGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicedQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemChargeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemLedgerEntryQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTaskNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProdOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseAmountActual).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PurchaseAmountExpected).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAmountActual).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalesAmountExpected).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SalespersPurchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourcePostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationDate).HasColumnType("datetime");

                entity.Property(e => e.ValueEntryId)
                    .HasColumnName("ValueEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ValuedQuantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VatamountLine>(entity =>
            {
                entity.HasKey(e => new { e.Vatidentifier, e.VatcalculationType, e.TaxGroupCode, e.UseTax, e.Positive })
                    .HasName("VATAmountLine$0");

                entity.ToTable("VATAmountLine");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("AmountIncludingVAT")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CalculatedVatamount)
                    .HasColumnName("CalculatedVATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvDiscBaseAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.InvoiceDiscountAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatamountLineId)
                    .HasColumnName("VATAmountLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Vatbase)
                    .HasColumnName("VATBase")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");
            });

            modelBuilder.Entity<VatbusinessPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("VATBusinessPostingGroup$0");

                entity.ToTable("VATBusinessPostingGroup");

                entity.HasIndex(e => e.VatBusinessPostingGroupId)
                    .HasName("IX_VATBusinessPostingGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.VatBusinessPostingGroupId)
                    .HasColumnName("VatBusinessPostingGroupID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Vatentry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("VATEntry$0");

                entity.ToTable("VATEntry");

                entity.HasIndex(e => e.VatEntryId)
                    .HasName("IX_VATEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AddCurrRemUnrealAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AddCurrRemUnrealBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AddCurrVatdifference)
                    .HasColumnName("AddCurrVATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AddCurrencyUnrealizedAmt).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AddCurrencyUnrealizedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdditionalCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdditionalCurrencyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Base).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BilltoPaytoNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eu3partyTrade).HasColumnName("EU3PartyTrade");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InternalRefNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingUnrealizedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingUnrealizedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShiptoOrderAddressCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxGroupUsed)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnrealizedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnrealizedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnrealizedVatentryNo).HasColumnName("UnrealizedVATEntryNo");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatEntryId)
                    .HasColumnName("VatEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VatbaseDiscountPercent)
                    .HasColumnName("VATBaseDiscountPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatdifference)
                    .HasColumnName("VATDifference")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VatpostingSetup>(entity =>
            {
                entity.HasKey(e => new { e.VatbusPostingGroup, e.VatprodPostingGroup })
                    .HasName("VATPostingSetup$0");

                entity.ToTable("VATPostingSetup");

                entity.HasIndex(e => e.VatpostingSetupId)
                    .HasName("IX_VATPostingSetup")
                    .IsUnique();

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PosterminalVatcode)
                    .HasColumnName("POSTerminalVATCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchVatunrealAccount)
                    .HasColumnName("PurchVATUnrealAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVataccount)
                    .HasColumnName("PurchaseVATAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChrgVatacc)
                    .HasColumnName("ReverseChrgVATAcc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReverseChrgVatunrealAcc)
                    .HasColumnName("ReverseChrgVATUnrealAcc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVataccount)
                    .HasColumnName("SalesVATAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVatunrealAccount)
                    .HasColumnName("SalesVATUnrealAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnrealizedVattype).HasColumnName("UnrealizedVATType");

                entity.Property(e => e.VatcalculationType).HasColumnName("VATCalculationType");

                entity.Property(e => e.Vatidentifier)
                    .HasColumnName("VATIdentifier")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatpercent)
                    .HasColumnName("VATPercent")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VatpostingSetupId)
                    .HasColumnName("VATPostingSetupID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VatproductPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("VATProductPostingGroup$0");

                entity.ToTable("VATProductPostingGroup");

                entity.HasIndex(e => e.VatproductPostingGroupId)
                    .HasName("IX_VATProductPostingGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.VatproductPostingGroupId)
                    .HasColumnName("VATProductPostingGroupID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VendorLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("VendorLedgerEntry$0");

                entity.HasIndex(e => e.VendorLedgerEntryId)
                    .HasName("IX_VendorLedgerEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.AcceptedPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AdjustedCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmounttoApply).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AppliedEntryno).HasDefaultValueSql("((0))");

                entity.Property(e => e.AppliestoDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppliestoId)
                    .HasColumnName("AppliestoID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BalAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyfromVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedatDate).HasColumnType("datetime");

                entity.Property(e => e.ClosedbyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyAmountLcy)
                    .HasColumnName("ClosedbyAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ClosedbyCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("InvDiscountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnHold)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalAmtLcy)
                    .HasColumnName("OriginalAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalCurrencyFactor).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.OriginalPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscRcdLcy)
                    .HasColumnName("PmtDiscRcdLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PmtDiscToleranceDate).HasColumnType("datetime");

                entity.Property(e => e.PmtDiscountDate).HasColumnType("datetime");

                entity.Property(e => e.PmtToleranceLcy)
                    .HasColumnName("PmtToleranceLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseLcy)
                    .HasColumnName("PurchaseLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingAmtLcy)
                    .HasColumnName("RemainingAmtLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReversedEntryNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReversedbyEntryNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VendorLedgerEntryId)
                    .HasColumnName("VendorLedgerEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorLedgerEntryDetailed>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("VendorLedgerEntryDetailed$0");

                entity.HasIndex(e => e.VendorLedgerEntryDetailedId)
                    .HasName("IX_VendorLedgerEntryDetailed")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("AmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("CreditAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("DebitAmountLCY")
                    .HasColumnType("decimal(38, 5)");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InitialEntryDueDate).HasColumnType("datetime");

                entity.Property(e => e.InitialEntryGlobalDim1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InitialEntryGlobalDim2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPaymentTolerance).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingPmtDiscPossible).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatprodPostingGroup)
                    .HasColumnName("VATProdPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorLedgerEntryDetailedId)
                    .HasColumnName("VendorLedgerEntryDetailedID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorPostingGroup>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.HasIndex(e => e.VendorPostingGroupId)
                    .HasName("IX_VendorPostingGroup")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CreditCurrApplnRndgAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreditRoundingAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebitCurrApplnRndgAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebitRoundingAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InterestAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRoundingAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PayablesAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDiscDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentToleranceCreditAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentToleranceDebitAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceChargeAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroupId)
                    .HasColumnName("VendorPostingGroupID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VendorSalesPrice>(entity =>
            {
                entity.HasKey(e => new { e.VendorNo, e.DivisionCode, e.ItemCategoryCode, e.ProductGroupCode, e.SuggestedRetailPrice })
                    .HasName("VendorSalesPrice$0");

                entity.HasIndex(e => e.VendorSalesPriceId)
                    .HasName("IX_VendorSalesPrice")
                    .IsUnique();

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuggestedRetailPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.VendorSalesPriceId)
                    .HasColumnName("VendorSalesPriceID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Vendors>(entity =>
            {
                entity.HasKey(e => e.VendorNo);

                entity.HasIndex(e => e.VendorId)
                    .HasName("IX_Vendors")
                    .IsUnique();

                entity.Property(e => e.VendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedAmount).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.BuyerGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasColumnName("BuyerID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FinChargeTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GenBusPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IcpartnerCode)
                    .HasColumnName("ICPartnerCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDiscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnName("lastModifiedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OurAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermsCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaytoVendorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaymentPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PricesIncludingVat).HasColumnName("PricesIncludingVAT");

                entity.Property(e => e.PrimaryContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCenter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RtcfilterField).HasColumnName("RTCFilterField");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAreaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelexAnswerBack)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatbusPostingGroup)
                    .HasColumnName("VATBusPostingGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatregistrationNo)
                    .HasColumnName("VATRegistrationNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VendorContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorFaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VendorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorTelexNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseEmployee>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LocationCode })
                    .HasName("WarehouseEmployee$0");

                entity.HasIndex(e => e.WarehouseEmployeeId)
                    .HasName("IX_WarehouseEmployee")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.WarehouseEmployeeId)
                    .HasColumnName("WarehouseEmployeeID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WarehouseEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo)
                    .HasName("WarehouseEntry$0");

                entity.HasIndex(e => e.WarehouseEntryId)
                    .HasName("IX_WarehouseEntry")
                    .IsUnique();

                entity.Property(e => e.EntryNo).ValueGeneratedNever();

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteringDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseEntryId)
                    .HasColumnName("WarehouseEntryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WhseDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseJournalBatch>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.Name, e.LocationCode })
                    .HasName("WarehouseJournalBatch$0");

                entity.HasIndex(e => e.WarehouseJournalBatchId)
                    .HasName("IX_WarehouseJournalBatch")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteringNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseJournalBatchId)
                    .HasColumnName("WarehouseJournalBatchID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WarehouseJournalLine>(entity =>
            {
                entity.HasKey(e => new { e.JournalTemplateName, e.JournalBatchName, e.LocationCode, e.SeqLineNo })
                    .HasName("WarehouseJournalLine$0");

                entity.HasIndex(e => e.WarehouseJournalLineId)
                    .HasName("IX_WarehouseJournalLine")
                    .IsUnique();

                entity.Property(e => e.JournalTemplateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FromBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FromBinTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.NewLotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NewSerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhysInvtCountingPeriodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyAbsolute).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyAbsoluteBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyCalculated).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyCalculatedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPhysInventory).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPhysInventoryBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteringDate).HasColumnType("datetime");

                entity.Property(e => e.RegisteringNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseJournalLineId)
                    .HasColumnName("WarehouseJournalLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.WhseDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseJournalTemplate>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("WarehouseJournalTemplate$0");

                entity.HasIndex(e => e.WarehouseJournalTemplateId)
                    .HasName("IX_WarehouseJournalTemplate")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteringNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteringReportId).HasColumnName("RegisteringReportID");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestReportId).HasColumnName("TestReportID");

                entity.Property(e => e.WarehouseJournalTemplateId)
                    .HasColumnName("WarehouseJournalTemplateID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WarehouseReceiptHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("WarehouseReceiptHeader$0");

                entity.HasIndex(e => e.WarehouseReceiptHeaderId)
                    .HasName("IX_WarehouseReceiptHeader")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentDate).HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime).HasColumnType("datetime");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossDockBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossDockZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastReceivingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseReceiptHeaderId)
                    .HasColumnName("WarehouseReceiptHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseReceiptLine>(entity =>
            {
                entity.HasKey(e => new { e.No, e.SeqLineNo })
                    .HasName("WarehouseReceiptLine$0");

                entity.HasIndex(e => e.WarehouseReceiptLineId)
                    .HasName("IX_WarehouseReceiptLine")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrossDockBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossDockZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyOutstanding).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyOutstandingBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyReceived).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyReceivedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoCrossDock).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoCrossDockBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoReceive).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoReceiveBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseReceiptLineId)
                    .HasColumnName("WarehouseReceiptLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseReceiptPostedHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("WarehouseReceiptPostedHeader$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentDate).HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime).HasColumnType("datetime");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.VendorShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseReceiptPostedHeaderId)
                    .HasColumnName("WarehouseReceiptPostedHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WhseReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseReceiptPostedLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("WarehouseReceiptPostedLine$0");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CrossDockBinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CrossDockZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedSourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.QtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyCrossDocked).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyCrossDockedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPutAway).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPutAwayBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseReceiptPostedLineId)
                    .HasColumnName("WarehouseReceiptPostedLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WarrantyDate).HasColumnType("datetime");

                entity.Property(e => e.WhseReceiptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseRegister>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("WarehouseRegister$0");

                entity.HasIndex(e => e.WarehouseRegisterId)
                    .HasName("IX_WarehouseRegister")
                    .IsUnique();

                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JournalBatchName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseRegisterId)
                    .HasColumnName("WarehouseRegisterID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WarehouseRequest>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.LocationCode, e.SourceType, e.SourceSubtype, e.SourceNo })
                    .HasName("WarehouseRequest$0");

                entity.HasIndex(e => e.WarehouseRequestId)
                    .HasName("IX_WarehouseRequest")
                    .IsUnique();

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DestinationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseRequestId)
                    .HasColumnName("WarehouseRequestID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WarehouseSetup>(entity =>
            {
                entity.Property(e => e.WarehouseSetupId).HasColumnName("WarehouseSetupID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PostedWhseReceiptNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedWhseShipmentNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredWhseMovementNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredWhsePickNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredWhsePutawayNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseInternalPickNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseInternalPutawayNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseMovementNos)
                    .HasColumnName("Whse_MovementNos")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhsePickNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhsePutawayNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseReceiptNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhseShipNos)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("WarehouseShipmentHeader$0");

                entity.HasIndex(e => e.WarehouseShipmentHeaderId)
                    .HasName("IX_WarehouseShipmentHeader")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentDate).HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime).HasColumnType("datetime");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastShippingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingNoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseShipmentHeaderId)
                    .HasColumnName("WarehouseShipmentHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("WarehouseShipmentLine$0");

                entity.HasIndex(e => e.WarehouseShipmentLineId)
                    .HasName("IX_WarehouseShipmentLine")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyOutstanding).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyOutstandingBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPicked).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyPickedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShipped).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyShippedBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoShip).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtytoShipBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseShipmentLineId)
                    .HasColumnName("WarehouseShipmentLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseShipmentPostedHeader>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("WarehouseShipmentPostedHeader$0");

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("AssignedUserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentDate).HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime).HasColumnType("datetime");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseShipmentPostedHeaderId)
                    .HasColumnName("WarehouseShipmentPostedHeaderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WhseShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseShipmentPostedLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.SeqLineNo })
                    .HasName("WarehouseShipmentPostedLine$0");

                entity.Property(e => e.DocumentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostedSourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.QtyBase).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QtyperUnitofMeasure).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.ShelfNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SourceNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VariantCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseShipmentPostedLineId)
                    .HasColumnName("WarehouseShipmentPostedLineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WhseShipmentNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkCenter>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("Work Center$0");

                entity.HasIndex(e => e.WorkCenterId)
                    .HasName("IX_WorkCenter")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateWorkCenter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarRoundingPrecision).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Capacity).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectUnitCost).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Efficiency).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.GenProdPostingGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension1Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalDimension2Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IndirectCostPercent).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.MaximumEfficiency).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.MinimumEfficiency).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeries)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OverheadRate).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QueueTime).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.QueueTimeUnitofMeasCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SearchName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShopCalendarCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubcontractorNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(38, 5)");

                entity.Property(e => e.UnitofMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterGroupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterId)
                    .HasColumnName("WorkCenterID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WorkCenterGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("Work Center Group$0");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('System')");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterGroupId)
                    .HasColumnName("WorkCenterGroupID")
                    .ValueGeneratedOnAdd();
            });
        }
    }
}
