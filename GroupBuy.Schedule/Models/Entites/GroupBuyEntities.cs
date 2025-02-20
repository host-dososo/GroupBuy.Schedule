using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GroupBuy.Schedule.Models.Entites;

public partial class GroupBuyEntities : DbContext
{
    public GroupBuyEntities()
    {
    }

    public GroupBuyEntities(DbContextOptions<GroupBuyEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }

    public virtual DbSet<CashAmtLog> CashAmtLog { get; set; }

    public virtual DbSet<CashAmtLogRea> CashAmtLogRea { get; set; }

    public virtual DbSet<Counter> Counter { get; set; }

    public virtual DbSet<DebitAmtRea> DebitAmtRea { get; set; }

    public virtual DbSet<DefGooCategory1> DefGooCategory1 { get; set; }

    public virtual DbSet<DefGooCategory2> DefGooCategory2 { get; set; }

    public virtual DbSet<DefMerPayType> DefMerPayType { get; set; }

    public virtual DbSet<DefMerShiWay> DefMerShiWay { get; set; }

    public virtual DbSet<DefMerSupCategory> DefMerSupCategory { get; set; }

    public virtual DbSet<ErrorLog> ErrorLog { get; set; }

    public virtual DbSet<ErrorLogCashAmt> ErrorLogCashAmt { get; set; }

    public virtual DbSet<ErrorLogGooQty> ErrorLogGooQty { get; set; }

    public virtual DbSet<ErrorLogSp> ErrorLogSp { get; set; }

    public virtual DbSet<EventLogMerUsr> EventLogMerUsr { get; set; }

    public virtual DbSet<FBLoginIDtoPSID> FBLoginIDtoPSID { get; set; }

    public virtual DbSet<FilKin> FilKin { get; set; }

    public virtual DbSet<FilPur> FilPur { get; set; }

    public virtual DbSet<File> File { get; set; }

    public virtual DbSet<FindOut> FindOut { get; set; }

    public virtual DbSet<GiCity> GiCity { get; set; }

    public virtual DbSet<GiCountry> GiCountry { get; set; }

    public virtual DbSet<GiPostCode> GiPostCode { get; set; }

    public virtual DbSet<GooCategory1> GooCategory1 { get; set; }

    public virtual DbSet<GooCategory2> GooCategory2 { get; set; }

    public virtual DbSet<GooComment> GooComment { get; set; }

    public virtual DbSet<GooMerSup> GooMerSup { get; set; }

    public virtual DbSet<GooSocChannel> GooSocChannel { get; set; }

    public virtual DbSet<GooSpec> GooSpec { get; set; }

    public virtual DbSet<Goods> Goods { get; set; }

    public virtual DbSet<GroComment> GroComment { get; set; }

    public virtual DbSet<GroGooOfr> GroGooOfr { get; set; }

    public virtual DbSet<GroGooSpec> GroGooSpec { get; set; }

    public virtual DbSet<GroGoods> GroGoods { get; set; }

    public virtual DbSet<GroMerUrl> GroMerUrl { get; set; }

    public virtual DbSet<GroSocChannel> GroSocChannel { get; set; }

    public virtual DbSet<Group> Group { get; set; }

    public virtual DbSet<Hash> Hash { get; set; }

    public virtual DbSet<Job> Job { get; set; }

    public virtual DbSet<JobParameter> JobParameter { get; set; }

    public virtual DbSet<JobQueue> JobQueue { get; set; }

    public virtual DbSet<List> List { get; set; }

    public virtual DbSet<MemCart> MemCart { get; set; }

    public virtual DbSet<MemFavGoods> MemFavGoods { get; set; }

    public virtual DbSet<MemMerSocCha> MemMerSocCha { get; set; }

    public virtual DbSet<MemRegConfig> MemRegConfig { get; set; }

    public virtual DbSet<MemRegConfigType> MemRegConfigType { get; set; }

    public virtual DbSet<MemSocBindCode> MemSocBindCode { get; set; }

    public virtual DbSet<MemType> MemType { get; set; }

    public virtual DbSet<Member> Member { get; set; }

    public virtual DbSet<MerMemShiInfo> MerMemShiInfo { get; set; }

    public virtual DbSet<MerMember> MerMember { get; set; }

    public virtual DbSet<MerNotice> MerNotice { get; set; }

    public virtual DbSet<MerOrg> MerOrg { get; set; }

    public virtual DbSet<MerOrgPlan> MerOrgPlan { get; set; }

    public virtual DbSet<MerPayType> MerPayType { get; set; }

    public virtual DbSet<MerPicPoiDeliv> MerPicPoiDeliv { get; set; }

    public virtual DbSet<MerPicPoiDelivLog> MerPicPoiDelivLog { get; set; }

    public virtual DbSet<MerPicPoiType> MerPicPoiType { get; set; }

    public virtual DbSet<MerPicPoiUsr> MerPicPoiUsr { get; set; }

    public virtual DbSet<MerPicPoiUsrAuthCode> MerPicPoiUsrAuthCode { get; set; }

    public virtual DbSet<MerPicPoint> MerPicPoint { get; set; }

    public virtual DbSet<MerPlan> MerPlan { get; set; }

    public virtual DbSet<MerPlanParas> MerPlanParas { get; set; }

    public virtual DbSet<MerPromo> MerPromo { get; set; }

    public virtual DbSet<MerPromoRecord> MerPromoRecord { get; set; }

    public virtual DbSet<MerSchedJob> MerSchedJob { get; set; }

    public virtual DbSet<MerShiWay> MerShiWay { get; set; }

    public virtual DbSet<MerSocChannel> MerSocChannel { get; set; }

    public virtual DbSet<MerSupCategory> MerSupCategory { get; set; }

    public virtual DbSet<MerSupplier> MerSupplier { get; set; }

    public virtual DbSet<MerType> MerType { get; set; }

    public virtual DbSet<MerUseLog> MerUseLog { get; set; }

    public virtual DbSet<MerUsr> MerUsr { get; set; }

    public virtual DbSet<MerVarKey> MerVarKey { get; set; }

    public virtual DbSet<MerVariable> MerVariable { get; set; }

    public virtual DbSet<Merchant> Merchant { get; set; }

    public virtual DbSet<NumTable> NumTable { get; set; }

    public virtual DbSet<OrdCanRea> OrdCanRea { get; set; }

    public virtual DbSet<OrdItem> OrdItem { get; set; }

    public virtual DbSet<OrdItemDetail> OrdItemDetail { get; set; }

    public virtual DbSet<OrdStatus> OrdStatus { get; set; }

    public virtual DbSet<OrdType> OrdType { get; set; }

    public virtual DbSet<Order> Order { get; set; }

    public virtual DbSet<PickUp> PickUp { get; set; }

    public virtual DbSet<PromoCond> PromoCond { get; set; }

    public virtual DbSet<PromoLimit> PromoLimit { get; set; }

    public virtual DbSet<PromoOrderAct> PromoOrderAct { get; set; }

    public virtual DbSet<PromoRewGooSpec> PromoRewGooSpec { get; set; }

    public virtual DbSet<PromoRewMethod> PromoRewMethod { get; set; }

    public virtual DbSet<PromoReward> PromoReward { get; set; }

    public virtual DbSet<PromoTgt> PromoTgt { get; set; }

    public virtual DbSet<PurOrdDetail> PurOrdDetail { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }

    public virtual DbSet<SalChaApp> SalChaApp { get; set; }

    public virtual DbSet<SalChaOwnSocType> SalChaOwnSocType { get; set; }

    public virtual DbSet<SalChaType> SalChaType { get; set; }

    public virtual DbSet<SalChannel> SalChannel { get; set; }

    public virtual DbSet<Schema> Schema { get; set; }

    public virtual DbSet<Server> Server { get; set; }

    public virtual DbSet<Set> Set { get; set; }

    public virtual DbSet<Shipment> Shipment { get; set; }

    public virtual DbSet<SocType> SocType { get; set; }

    public virtual DbSet<State> State { get; set; }

    public virtual DbSet<SysAct> SysAct { get; set; }

    public virtual DbSet<SysFun> SysFun { get; set; }

    public virtual DbSet<SysFunAct> SysFunAct { get; set; }

    public virtual DbSet<SysRol> SysRol { get; set; }

    public virtual DbSet<SysRolFunAct> SysRolFunAct { get; set; }

    public virtual DbSet<SysTab> SysTab { get; set; }

    public virtual DbSet<SysUsr> SysUsr { get; set; }

    public virtual DbSet<SysUsrRol> SysUsrRol { get; set; }

    public virtual DbSet<WarHouBra> WarHouBra { get; set; }

    public virtual DbSet<WarHouMer> WarHouMer { get; set; }

    public virtual DbSet<WarHouTraLog> WarHouTraLog { get; set; }

    public virtual DbSet<WarHouTraRea> WarHouTraRea { get; set; }

    public virtual DbSet<v_GooSpec> v_GooSpec { get; set; }

    public virtual DbSet<v_MemCart> v_MemCart { get; set; }

    public virtual DbSet<v_MemRegConfig> v_MemRegConfig { get; set; }

    public virtual DbSet<v_MerMember> v_MerMember { get; set; }

    public virtual DbSet<v_MerNotice> v_MerNotice { get; set; }

    public virtual DbSet<v_MerPicPoiDelivLog> v_MerPicPoiDelivLog { get; set; }

    public virtual DbSet<v_MerPromo> v_MerPromo { get; set; }

    public virtual DbSet<v_MerSchedJob> v_MerSchedJob { get; set; }

    public virtual DbSet<v_MerUseLog> v_MerUseLog { get; set; }

    public virtual DbSet<v_MerVariable> v_MerVariable { get; set; }

    public virtual DbSet<v_OrdItemDetail> v_OrdItemDetail { get; set; }

    public virtual DbSet<v_PromoLimit> v_PromoLimit { get; set; }

    public virtual DbSet<v_PromoOrderAct> v_PromoOrderAct { get; set; }

    public virtual DbSet<v_PromoRewMethod> v_PromoRewMethod { get; set; }

    public virtual DbSet<v_PromoReward> v_PromoReward { get; set; }

    public virtual DbSet<v_Rand> v_Rand { get; set; }

    public virtual DbSet<v_RandNewId> v_RandNewId { get; set; }

    public virtual DbSet<v_RandomNumberView> v_RandomNumberView { get; set; }

    public virtual DbSet<v_ShipOrder> v_ShipOrder { get; set; }

    public virtual DbSet<v_SysFunAct> v_SysFunAct { get; set; }

    public virtual DbSet<v_WarHouBra> v_WarHouBra { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Chinese_Taiwan_Stroke_CI_AS");

        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.ToTable("AggregatedCounter", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<CashAmtLog>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("會員購物金記錄"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Amt)
                .HasComment("金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Kind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("種類(購物金0/訂單1)");
            entity.Property(e => e.MemberId).HasComment("會員序號");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("編號/單號");
            entity.Property(e => e.ReaCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("原因代碼");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("備注");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("類型(進項0/出項1)");
        });

        modelBuilder.Entity<CashAmtLogRea>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__CashAmtL__A25C5AA68AC5AF9C");

            entity.ToTable(tb => tb.HasComment("購物金原因表"));

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("原因代碼");
            entity.Property(e => e.CreatedTime)
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建者編號");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasComment("説明");
            entity.Property(e => e.UpdatedTime)
                .HasComment("編輯時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("編輯者編號");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_Counter");

            entity.ToTable("Counter", "HangFire");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<DebitAmtRea>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("折讓原因説明"));

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建者");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("原因説明");
            entity.Property(e => e.UpdatedTime)
                .HasComment("編輯時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("編輯者");
        });

        modelBuilder.Entity<DefGooCategory1>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("預設商品分類1(商家)"));

            entity.HasIndex(e => e.Num, "IX_DefGooCategory1").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Icon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("圖示");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("商品主分類名稱");
            entity.Property(e => e.Num).HasComment("主分類編號(from NumTable)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->啟用,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<DefGooCategory2>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("預設商品分類2(商家)"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GooCate1Id).HasComment("主分類序號(from GooCategory1)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Num).HasComment("分類編號(from NumTable)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->啟用,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<DefMerPayType>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("預設商家付款方式"));

            entity.HasIndex(e => e.Num, "IX_DefMerPayType").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Info)
                .HasMaxLength(100)
                .HasComment("其他資訊");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱");
            entity.Property(e => e.Num).HasComment("付款方式標號(1->面交付款、2->轉帳匯款、3->電子支付、4->儲值付款)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue((short)9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<DefMerShiWay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DefMerShipWay");

            entity.ToTable(tb => tb.HasComment("預設商家運送/取貨方式"));

            entity.HasIndex(e => e.Num, "IX_DefMerShiWay").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Fee)
                .HasComment("運費")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.FreeAmt)
                .HasComment("免運滿額值")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.FreeCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasComment("運費減免碼(Y->超過FreeAmt得享免運;N->不提供免運)");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱(1->自取面交、2->外送面交、3->貨運宅配、4->超商取貨)");
            entity.Property(e => e.Num).HasComment("編號");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue((short)9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<DefMerSupCategory>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("預設商家供應商分類"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Num).HasComment("編號(from NumTable)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停權,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ErrorLog_1");

            entity.ToTable(tb => tb.HasComment("SP錯誤紀錄"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("序號")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasComment("日期");
            entity.Property(e => e.From).HasComment("1: 後端 2: 前端 3: Store procedure 4:DB Table Trigger");
            entity.Property(e => e.Line)
                .HasMaxLength(30)
                .HasComment("錯誤行號");
            entity.Property(e => e.Message).HasComment("錯誤訊息");
            entity.Property(e => e.Number)
                .HasMaxLength(300)
                .HasComment("錯誤代碼");
            entity.Property(e => e.ParamValues)
                .HasComment("參數值(各參數以'#^'串接)")
                .HasColumnType("ntext");
            entity.Property(e => e.Severity)
                .HasMaxLength(30)
                .HasComment("錯誤嚴重性");
            entity.Property(e => e.SolveDate).HasComment("解決時間");
            entity.Property(e => e.SolveStatus)
                .HasMaxLength(300)
                .HasComment("解決狀態");
            entity.Property(e => e.Source)
                .HasMaxLength(300)
                .HasComment("錯誤程序名稱");
            entity.Property(e => e.State)
                .HasMaxLength(300)
                .HasComment("錯誤狀態號碼");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("(getdate())")
                .HasComment("時間");
        });

        modelBuilder.Entity<ErrorLogCashAmt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CashAmtEroLog");

            entity.ToTable(tb => tb.HasComment("SP錯誤紀錄"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasComment("序號");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasComment("日期");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.OperatorId).HasComment("操作人員序號");
            entity.Property(e => e.ParamValues)
                .HasComment("參數值(各參數以'#^'串接)")
                .HasColumnType("ntext");
            entity.Property(e => e.SolveDate).HasComment("解決時間");
            entity.Property(e => e.SolveStatus)
                .HasMaxLength(300)
                .HasComment("解決狀態");
            entity.Property(e => e.SourceType).IsUnicode(false);
            entity.Property(e => e.Time)
                .HasDefaultValueSql("(getdate())")
                .HasComment("時間");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasComment("錯誤程序名稱");
        });

        modelBuilder.Entity<ErrorLogGooQty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GooQtyEroLog");

            entity.ToTable(tb => tb.HasComment("SP錯誤紀錄"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasComment("序號");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasComment("日期");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.OperatorId).HasComment("操作人員序號");
            entity.Property(e => e.ParamValues)
                .HasComment("參數值(各參數以'#^'串接)")
                .HasColumnType("ntext");
            entity.Property(e => e.SolveDate).HasComment("解決時間");
            entity.Property(e => e.SolveStatus)
                .HasMaxLength(300)
                .HasComment("解決狀態");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("(getdate())")
                .HasComment("時間");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasComment("錯誤程序名稱");
        });

        modelBuilder.Entity<ErrorLogSp>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("SP錯誤紀錄"));

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasComment("序號");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasComment("日期");
            entity.Property(e => e.Line)
                .HasMaxLength(30)
                .HasComment("錯誤行號");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.Message)
                .HasMaxLength(3000)
                .HasComment("錯誤訊息");
            entity.Property(e => e.Number)
                .HasMaxLength(300)
                .HasComment("錯誤代碼");
            entity.Property(e => e.OperatorId).HasComment("操作人員序號");
            entity.Property(e => e.ParamValues)
                .HasComment("參數值(各參數以'#^'串接)")
                .HasColumnType("ntext");
            entity.Property(e => e.Procedure)
                .HasMaxLength(300)
                .HasComment("錯誤程序名稱");
            entity.Property(e => e.Severity)
                .HasMaxLength(30)
                .HasComment("錯誤嚴重性");
            entity.Property(e => e.SolveDate).HasComment("解決時間");
            entity.Property(e => e.SolveStatus)
                .HasMaxLength(300)
                .HasComment("解決狀態");
            entity.Property(e => e.State)
                .HasMaxLength(300)
                .HasComment("錯誤狀態號碼");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("(getdate())")
                .HasComment("時間");
        });

        modelBuilder.Entity<EventLogMerUsr>(entity =>
        {
            entity.HasKey(e => new { e.MerchantId, e.MerUsrId, e.VisitTime });

            entity.Property(e => e.MerchantId).HasComment("商家序號(Merchant)");
            entity.Property(e => e.MerUsrId).HasComment("商家使用者(管理帳號)序號");
            entity.Property(e => e.VisitTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("造訪時間")
                .HasColumnType("datetime");
            entity.Property(e => e.FunName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("系統功能名稱");
            entity.Property(e => e.MerUsrName).HasMaxLength(50);
            entity.Property(e => e.PageURL)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasComment("頁面網址");
        });

        modelBuilder.Entity<FBLoginIDtoPSID>(entity =>
        {
            entity.HasKey(e => new { e.login_ID, e.OwnSys, e.AppId });

            entity.ToTable(tb => tb.HasTrigger("SetCreatedTime"));

            entity.Property(e => e.login_ID)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("login ID by hash_hmac");
            entity.Property(e => e.OwnSys).HasComment("前台or後台  1:後台 0:前台");
            entity.Property(e => e.AppId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("FB 應用程式 ID");
            entity.Property(e => e.ASID)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Application scoped ID");
            entity.Property(e => e.AuthHashCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("授權 Messenger 通知按鈕旁邊授權碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PSID)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Page scoped ID");
            entity.Property(e => e.UID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.recipient_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Recipient ID");
        });

        modelBuilder.Entity<FilKin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FileKind");

            entity.ToTable(tb => tb.HasComment("檔案類型"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasComment("備註");
        });

        modelBuilder.Entity<FilPur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FilePurpose");

            entity.ToTable(tb => tb.HasComment("檔案用途"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("序號");
            entity.Property(e => e.FunctionId).HasComment("功能序號");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .HasComment("備註");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasComment("標題");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("檔案"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.ExtName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("副檔名");
            entity.Property(e => e.FilKinId).HasComment("檔案種類;1:圖檔/2:文件/3:音檔/4:影片/0:其他");
            entity.Property(e => e.FilPurId).HasComment("檔案用途(詳見表:檔案用途與來源表格對照表)");
            entity.Property(e => e.IsMaster)
                .HasDefaultValue(true)
                .HasComment("是否主圖");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.OrgName)
                .HasMaxLength(100)
                .HasComment("原始名稱");
            entity.Property(e => e.RowId).HasComment("來源資料列序號");
            entity.Property(e => e.SaveName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("儲存名稱");
            entity.Property(e => e.Size).HasComment("檔案大小");
            entity.Property(e => e.SysTabId).HasComment("來源表格序號");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<FindOut>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("從何得知"));

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("名稱");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("分類(A:商家)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GiCity>(entity =>
        {
            entity.HasKey(e => new { e.CountryCode, e.Code });

            entity.ToTable(tb => tb.HasComment("縣市區"));

            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((886))")
                .IsFixedLength()
                .HasComment("國家代碼(from Country)");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasComment("縣市代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue((short)9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GiCountry>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("國家"));

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("代碼(86->中國;886->台灣)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue((short)9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GiPostCode>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("郵遞區號"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CityName)
                .HasMaxLength(10)
                .HasComment("縣市名稱(from City)");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasComment("郵遞區號");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((886))")
                .IsFixedLength()
                .HasComment("國家代碼(from Country)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("鄉鎮區域名");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Rode)
                .HasMaxLength(50)
                .HasComment("道路");
            entity.Property(e => e.Scope)
                .HasMaxLength(50)
                .HasComment("投遞範圍");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GooCategory1>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商品分類1(商家)"));

            entity.HasIndex(e => new { e.MerchantId, e.Num }, "IX_GooCategory1").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Icon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("圖示");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("商品主分類名稱");
            entity.Property(e => e.Num).HasComment("主分類編號(from NumTable)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->啟用,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GooCategory2>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商品分類2(商家)"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GooCate1Id).HasComment("主分類序號(from GooCategory1)");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Num).HasComment("分類編號(from NumTable)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->啟用,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GooComment>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商品社群留言"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ComTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("留言時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .HasComment("留言內容");
            entity.Property(e => e.CommentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("留言Comment ID");
            entity.Property(e => e.DeletedTime).HasColumnType("datetime");
            entity.Property(e => e.IsFather).HasDefaultValue(true);
            entity.Property(e => e.MemId).HasComment("會員Member ID");
            entity.Property(e => e.MemName)
                .HasMaxLength(50)
                .HasComment("會員Member Name");
            entity.Property(e => e.MemSocId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("會員社群ID");
            entity.Property(e => e.MemSocName)
                .HasMaxLength(50)
                .HasComment("會員社群名稱");
            entity.Property(e => e.MerSchedJobId).HasComment("執行紀錄ID");
            entity.Property(e => e.MerSocChaId).HasComment("賣場商品頻道 ID");
            entity.Property(e => e.OrdId).HasComment("對應的訂單編號");
            entity.Property(e => e.OriFeedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("原始貼文ID (若留言在圖片貼文才有資料，此為圖片貼文的源頭貼文ID)");
            entity.Property(e => e.RootFeedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("最上層商品發文Id");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("狀態：(0->未處理留言, 1->已成立訂單留言, 2->毋須成立訂單留言, 9->已刪除留言)");
        });

        modelBuilder.Entity<GooMerSup>(entity =>
        {
            entity.HasKey(e => new { e.GoodsId, e.MerSupId });

            entity.ToTable(tb => tb.HasComment("商品和供應商家關聯表"));

            entity.Property(e => e.GoodsId).HasComment("商品序號");
            entity.Property(e => e.MerSupId).HasComment("供應商序號");
        });

        modelBuilder.Entity<GooSocChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GooMerSocChannel");

            entity.ToTable(tb => tb.HasComment("賣場商品頻道"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CommentAsOrder).HasComment("允許社群留言成立訂單");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GooId).HasComment("商品序號");
            entity.Property(e => e.MerSocChaId).HasComment("商家社群頻道序號");
            entity.Property(e => e.PubTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("發佈時間")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SocFeedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("商家社群頻道發文序號");
            entity.Property(e => e.SocPostId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("記錄FB 的 feed object id 對應的 post id (兩者都可抓取發文資料)");
            entity.Property(e => e.SocTypeId).HasComment("社群類別(Form SocType)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GooSpec>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商品規格"));

            entity.HasIndex(e => new { e.GoodsId, e.Code }, "IX_GooSpec").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.BuyMaxCnt)
                .HasComment("一個會員最多只能買多少個")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasComment("規格代碼(給社群留言成立訂單使用的代碼)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Description).HasComment("規格說明");
            entity.Property(e => e.GoodsId).HasComment("商品序號(from Goods)");
            entity.Property(e => e.IsSales)
                .HasDefaultValue(true)
                .HasComment("商品規格是否銷售(0->否/1->是)");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasComment("規格值");
            entity.Property(e => e.PriceBatch)
                .HasComment("批客價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceBuy)
                .HasComment("進價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceSell)
                .HasComment("售價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<Goods>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商品"));

            entity.HasIndex(e => new { e.MerchantId, e.Num }, "IX_Goods").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.BuyMaxCnt)
                .HasComment("一個會員最多只能買多少個")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Description).HasComment("商品介紹");
            entity.Property(e => e.DisOrdSocVarKey).HasComment("禁用下單洽詢客服社群 (對應 MerVariable)");
            entity.Property(e => e.DisOrder).HasComment("禁用下單");
            entity.Property(e => e.DisOrderRsn)
                .HasMaxLength(100)
                .HasComment("禁用下單原因");
            entity.Property(e => e.EndTime)
                .HasComment("下架時間")
                .HasColumnType("datetime");
            entity.Property(e => e.GooCat2Id).HasComment("商品次分類序號(from GoodsCategory)");
            entity.Property(e => e.IsTop).HasComment("是否置頂(0:否/1:是)");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("商品名稱");
            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("商品編號(from NumTable)");
            entity.Property(e => e.PreOrder).HasComment("是否開啓預購(0->關閉/1->開啓)");
            entity.Property(e => e.PriceBuy)
                .HasComment("進價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceSell)
                .HasComment("售價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.StartTime)
                .HasComment("上架時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GroComment>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("團購社群留言"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ComTime)
                .HasComment("留言時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .HasComment("留言內容");
            entity.Property(e => e.CommentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("留言Comment ID");
            entity.Property(e => e.DeletedTime)
                .HasDefaultValueSql("(NULL)")
                .HasComment("已匯入的留言在facebook上的貼文留言被刪除的時間")
                .HasColumnType("datetime");
            entity.Property(e => e.IsFather).HasDefaultValue(true);
            entity.Property(e => e.MemId).HasComment("會員Member ID");
            entity.Property(e => e.MemName)
                .HasMaxLength(50)
                .HasComment("會員Member Name");
            entity.Property(e => e.MemSocId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("會員社群ID");
            entity.Property(e => e.MemSocName)
                .HasMaxLength(50)
                .HasComment("會員社群名稱");
            entity.Property(e => e.MerSchedJobId).HasComment("執行紀錄ID");
            entity.Property(e => e.MerSocChaId).HasComment("團組社群頻道 ID");
            entity.Property(e => e.OrdId).HasComment("對應的訂單編號");
            entity.Property(e => e.OriFeedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("原始貼文ID (若留言在圖片貼文才有資料，此為圖片貼文的源頭貼文ID)");
            entity.Property(e => e.RootFeedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("最上層開團商品發文Id");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("狀態：(0->未處理留言, 1->已成立訂單留言, 2->毋須成立訂單留言, 9->已刪除留言)");
        });

        modelBuilder.Entity<GroGooOfr>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("團組商品折扣"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.DiscountAmt)
                .HasDefaultValue(0m)
                .HasComment("減少金額")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.DiscountPct)
                .HasDefaultValue(0m)
                .HasComment("減收折扣")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.GroGooId).HasComment("團組商品序號(from GroGoods)");
            entity.Property(e => e.MemTypeCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("適用會員類型(1:一般會員/2:批客/3:門市顧客 from MemType)");
            entity.Property(e => e.OptionCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("優惠選項代碼(1->每件減固定金額, 2->整單折扣)");
            entity.Property(e => e.Qty)
                .HasComment("起訂數量")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GroGooSpec>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("團組商品規格"));

            entity.HasIndex(e => new { e.GroGooId, e.GooSpeId, e.Code }, "IX_GroGooSpec").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasComment("訂購代碼(給社群留言成立訂單使用的代碼)");
            entity.Property(e => e.GooSpeId).HasComment("商品規格序號(from GooSpec)");
            entity.Property(e => e.GroGooId).HasComment("團組商品序號(from GroGoods)");
            entity.Property(e => e.IsUsed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("啟用碼(0->不啟用,1->啟用)");
            entity.Property(e => e.PriceBuy)
                .HasComment("進價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceSell)
                .HasComment("售價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceUnit)
                .HasComment("單價")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Qty)
                .HasComment("數量")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
        });

        modelBuilder.Entity<GroGoods>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("團組商品"));

            entity.HasIndex(e => new { e.GroupId, e.GoodsId }, "IX_GroGoods").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Content).HasComment("商品文案內容");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GoodsId).HasComment("商品序號(from Goods)");
            entity.Property(e => e.GroupId).HasComment("開團序號(from Group)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<GroMerUrl>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.MerSocChaId });

            entity.ToTable(tb => tb.HasComment("團組社群賣場網址"));

            entity.Property(e => e.GroupId).HasComment("團組Id");
            entity.Property(e => e.MerSocChaId).HasComment("商家社群Id(0:預設)");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("賣場網址");
            entity.Property(e => e.Version).HasComment("0: 原始版本 hashids(不支援負數) /1:改良版 hashids (支援負數)");
        });

        modelBuilder.Entity<GroSocChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GroMerSocChannel");

            entity.ToTable(tb => tb.HasComment("團購社群頻道"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CommentAsOrder).HasComment("允許社群留言成立訂單");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GroupId).HasComment("團組序號");
            entity.Property(e => e.MerSocChaId).HasComment("商家社群頻道序號");
            entity.Property(e => e.PubTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("發佈時間")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SocFeedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("商家社群頻道發文序號");
            entity.Property(e => e.SocPostId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("記錄FB 的 feed object id 對應的 post id (兩者都可抓取發文資料)");
            entity.Property(e => e.SocTypeId).HasComment("社群類別(Form SocType)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("團組"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ArriveTime)
                .HasComment("預計到貨日")
                .HasColumnType("datetime");
            entity.Property(e => e.Beginning)
                .HasComment("開團時間")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Ending)
                .HasComment("結團時間")
                .HasColumnType("datetime");
            entity.Property(e => e.FeedCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("貼文綁定代碼");
            entity.Property(e => e.IsHandOff)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("是否手動(快速)關團(0->否,1->是)");
            entity.Property(e => e.IsVip).HasComment("是否為Vip團");
            entity.Property(e => e.LasStoSta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("到貨狀態(0->未到貨,1->已到貨,2->部分到貨)");
            entity.Property(e => e.LasStoTime)
                .HasComment("最後到貨時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Memo).HasComment("備註");
            entity.Property(e => e.MerchantId).HasComment("所屬商家序號(from Merchant)");
            entity.Property(e => e.Num).HasComment("編號");
            entity.Property(e => e.OrderAmount).HasComment("訂單數量");
            entity.Property(e => e.Qty)
                .HasComment("開團數量")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.Title1).HasComment("團名主標");
            entity.Property(e => e.Title2).HasComment("團名副標");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.VenOrdSta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("叫貨狀態(0->未叫貨,1->已叫貨,2->無須叫貨)");
            entity.Property(e => e.VenOrdTime)
                .HasComment("叫貨時間")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.ToTable("Hash", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Field).HasMaxLength(100);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.ToTable("Job", "HangFire", tb => tb.HasTrigger("UpdMerSchedJobExp"));

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(20);
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.ToTable("JobParameter", "HangFire");

            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameter)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.ToTable("JobQueue", "HangFire");

            entity.Property(e => e.Queue).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FetchedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.ToTable("List", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemCart>(entity =>
        {
            entity.HasIndex(e => new { e.MemberId, e.MerchantId, e.GroGooSpeId }, "IX_MemCart_GGS");

            entity.HasIndex(e => new { e.MemberId, e.MerchantId, e.GooSpeId }, "IX_MemCart_GS");

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OrdTypCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Qty).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<MemFavGoods>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.GoodsId });

            entity.ToTable(tb => tb.HasComment("會員最愛好物商品"));

            entity.Property(e => e.MemberId).HasComment("會員序號");
            entity.Property(e => e.GoodsId).HasComment("商品序號");
        });

        modelBuilder.Entity<MemMerSocCha>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MerMemSocCha");

            entity.ToTable(tb => tb.HasComment("會員商家社群"));

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.MemberId).HasComment("會員社群Id");
            entity.Property(e => e.MerSocChaId).HasComment("商家社群Id");
            entity.Property(e => e.SocTypeId).HasComment("社群類別(Form SocType)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MemRegConfig>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("會員註冊設定檔"));

            entity.Property(e => e.Id).HasComment("唯一識別值");
            entity.Property(e => e.ConfigTypeCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("會員註冊設定檔種類代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.MerchantId).HasComment("商家ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.SocTypeId).HasComment("註冊社群渠道");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態 1:正常 0:停用 9:刪除");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.Value).HasComment("設定值");
        });

        modelBuilder.Entity<MemRegConfigType>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.Step });

            entity.ToTable(tb => tb.HasComment("會員註冊設定檔種類"));

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("代碼");
            entity.Property(e => e.Step).HasComment("註冊步驟 (第幾步驟)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("狀態 1:正常 0:停用 9:刪除");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MemSocBindCode>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.BindToSocTypeId }).HasName("PK_MemSocBindCode_1");

            entity.Property(e => e.BindToSocTypeId).HasComment("綁至哪個社群 (join to SocType table)");
            entity.Property(e => e.Code)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("驗證碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("申請綁定時的 Email");
            entity.Property(e => e.FBPSID)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("若是從 Messenger 對話綁定，則紀錄對話對方 PSID");
            entity.Property(e => e.MerchantId).HasComment("會員執行綁定時當下登入之商家");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("申請綁定時的 Mobile");
            entity.Property(e => e.SameItem)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("判定為相同使用者所依據屬性，第一位為 Email，第二位為 Mobile (Ex: 只相同 Email => 10,只相同 Mobile => 01,  Email和Mobile皆相同 => 11)");
            entity.Property(e => e.SendTime)
                .HasComment("發送時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MemType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("會員身分"));

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱(1:一般會員/2:批客/3:門市顧客)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort).HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("會員"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.AccFaiCount).HasComment("登入失敗次數統計");
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .HasComment("收貨地址");
            entity.Property(e => e.Birthday).HasComment("生日");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Email");
            entity.Property(e => e.FBAuthorize).HasComment("經使用者授權存取(0->否,1->是)，若使用者登入時原授權改為未授權，狀態需更新");
            entity.Property(e => e.FBLongLivedToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("Facebook 長時效 token");
            entity.Property(e => e.FBName)
                .HasMaxLength(50)
                .HasComment("FB暱名(FB上所顯示的名稱)");
            entity.Property(e => e.FBPSID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Facebook 的 PSID (根據FBRecipientLoginId發送初始message給user，回覆後取得該PSID)");
            entity.Property(e => e.FBRecipientLoginId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Facebook Login Connect with Messenger 取得的 Login Id");
            entity.Property(e => e.FBUsrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Facebook使用者ID (Facebook 的 ASID)");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("性別(1->男性,2->女性,0->其他)");
            entity.Property(e => e.GiCitCode)
                .HasMaxLength(10)
                .HasComment("縣市區代碼(From GiCity)");
            entity.Property(e => e.GiCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((886))")
                .IsFixedLength()
                .HasComment("國家代碼(From GiCountry)");
            entity.Property(e => e.GiPosCode)
                .HasMaxLength(10)
                .HasComment("鄉鎮市區代碼(From GiPostCode)");
            entity.Property(e => e.GiPosName)
                .HasMaxLength(50)
                .HasComment("鄉鎮區域名");
            entity.Property(e => e.HeadImgUrl)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("會員即時頭像(依據最後登入使用的社群)");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(12)
                .HasComment("身分證字號(身分證號碼10碼;外來人口統一證號(居留證號)11碼)");
            entity.Property(e => e.LasLogIP)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("最後登入網路位址");
            entity.Property(e => e.LasLogTime)
                .HasComment("最後登入日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.LineName)
                .HasMaxLength(50)
                .HasComment("LINE暱名(Line上所顯示的名稱)");
            entity.Property(e => e.LineNotifyToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("Line Notify Token");
            entity.Property(e => e.LineStaMessage)
                .HasMaxLength(500)
                .HasComment("Line狀態訊息");
            entity.Property(e => e.LineToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("LineToken");
            entity.Property(e => e.LineUsrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("LINE使用者ID");
            entity.Property(e => e.LogCount).HasComment("登入次數");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("手機號碼");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("聯絡電話");
            entity.Property(e => e.RealName)
                .HasMaxLength(50)
                .HasComment("真實姓名");
            entity.Property(e => e.Receiver)
                .HasMaxLength(50)
                .HasComment("收貨人姓名");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerMemShiInfo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家會員收貨資訊"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .HasComment("收貨人地址");
            entity.Property(e => e.CreatedTime)
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建者");
            entity.Property(e => e.GiCitCode)
                .HasMaxLength(10)
                .HasComment("收貨人縣市區代碼(From GiCity)");
            entity.Property(e => e.GiCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("收貨人國家代碼");
            entity.Property(e => e.GiPosCode)
                .HasMaxLength(10)
                .HasComment("收貨人鄉鎮市區代碼(From GiPostCode)");
            entity.Property(e => e.GiPosName)
                .HasMaxLength(50)
                .HasComment("鄉鎮區域名");
            entity.Property(e => e.IsMaster).HasComment("預設地址(0:否/1:是)");
            entity.Property(e => e.MemberId).HasComment("會員序號");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("收貨人名稱");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasComment("收貨人手機號碼");
            entity.Property(e => e.UpdatedTime)
                .HasComment("編輯時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("編輯者");
        });

        modelBuilder.Entity<MerMember>(entity =>
        {
            entity.HasKey(e => new { e.MerchantId, e.MemberId });

            entity.ToTable(tb => tb.HasComment("商家會員"));

            entity.HasIndex(e => new { e.MerchantId, e.Number }, "IX_MerMember").IsUnique();

            entity.Property(e => e.AmtNonPay)
                .HasDefaultValue(0m)
                .HasComment("未結單金額(trigger)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BonusPoint)
                .HasDefaultValue(0)
                .HasComment("紅利點數(trigger)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.LastDealDate).HasComment("最新成交日期(trigger)");
            entity.Property(e => e.MemTypCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasComment("會員類型代碼(from MemType)");
            entity.Property(e => e.MerPayTypId).HasComment("預設付款方式(From MerPayType)");
            entity.Property(e => e.MerPicPoiId).HasComment("預設取貨點(From MerPicPoint)");
            entity.Property(e => e.MerShiWayId).HasComment("預設交貨方式(From MerShiWay)");
            entity.Property(e => e.Number).HasComment("會員編號(from NumTable)");
            entity.Property(e => e.QtyNonArvl)
                .HasDefaultValue(0m)
                .HasComment("未到貨數量(trigger)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.QtyNonTake)
                .HasDefaultValue(0m)
                .HasComment("未取貨數量(trigger)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.RefMemberId).HasComment("推薦人ID");
            entity.Property(e => e.RefMerchantId).HasComment("推薦人商家");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.ShopAmt)
                .HasDefaultValue(0m)
                .HasComment("購物金")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerNotice>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Content)
                .HasMaxLength(1000)
                .HasComment("通知內容");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Data).HasComment("應用層判斷SysFunActId執行對應程序之所需客製化參數");
            entity.Property(e => e.IsFocus).HasComment("是否已聚焦(閱讀,點擊)過");
            entity.Property(e => e.MerchantId).HasComment("商家ID");
            entity.Property(e => e.State).HasComment("狀態 null:none/0:Running/1:Success/2:Warning/3:Error");
            entity.Property(e => e.SysFunActId).HasComment("作業功能ID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasComment("通知標題");
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("通知導向連結");
        });

        modelBuilder.Entity<MerOrg>(entity =>
        {
            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("客戶所屬組織名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UnitName)
                .HasMaxLength(50)
                .HasComment("單位名稱");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerOrgPlan>(entity =>
        {
            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.ExpiryDate)
                .HasComment("結束日期")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.LimitCnt).HasComment("方案可使用數上限");
            entity.Property(e => e.MerOrgId).HasComment("客戶所屬組織序號");
            entity.Property(e => e.MerPlanCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("商家方案代碼");
            entity.Property(e => e.Num).HasComment("編號(購買次數)");
            entity.Property(e => e.RemainCnt).HasComment("方案剩餘可使用數");
            entity.Property(e => e.StartingDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("開始日期")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->關閉,1->開啟,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPayType>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家付款方式"));

            entity.HasIndex(e => new { e.MerchantId, e.Num }, "IX_MerPayType").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Info)
                .HasMaxLength(100)
                .HasComment("其他資訊");
            entity.Property(e => e.MerchantId).HasComment("所屬商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱");
            entity.Property(e => e.Num).HasComment("付款方式標號(1->面交付款、2->轉帳匯款、3->電子支付、4->儲值付款)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPicPoiDeliv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ShipPicPoint");

            entity.ToTable(tb => tb.HasComment("取貨點配送"));

            entity.Property(e => e.ArrivedTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.DelivMan).HasMaxLength(50);
            entity.Property(e => e.DelivManMobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DelivType).HasComment("配送方式 1:親自運送");
            entity.Property(e => e.DeliverTime).HasColumnType("datetime");
            entity.Property(e => e.Number)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remark).HasMaxLength(300);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPicPoiDelivLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MerPicPoiDelivLog_1");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Qty).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Type)
                .HasDefaultValue((byte)1)
                .HasComment("1: 配送, 2:到貨");
        });

        modelBuilder.Entity<MerPicPoiType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPicPoiUsr>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家取貨點使用者"));

            entity.Property(e => e.Birthday)
                .HasComment("生日")
                .HasColumnType("datetime");
            entity.Property(e => e.ConAddress)
                .HasMaxLength(100)
                .HasComment("通訊地址");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasComment("信箱");
            entity.Property(e => e.HeadImgUrl)
                .IsUnicode(false)
                .HasComment("LINE頭照圖片");
            entity.Property(e => e.HoldAddress)
                .HasMaxLength(100)
                .HasComment("戶籍地址");
            entity.Property(e => e.IDNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("身分證字號");
            entity.Property(e => e.IDNoIssueCityCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("身分證發證城市");
            entity.Property(e => e.IDNoIssueDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("身分證發證日期");
            entity.Property(e => e.IDNoIssueType).HasComment("身分證發證類型 (0:初發,1:補發,2:換發)");
            entity.Property(e => e.IsJoinedOA).HasComment("是否已經加入取貨點 LINE 官方帳號");
            entity.Property(e => e.LasLogIP)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("最後登入網路位址");
            entity.Property(e => e.LasLogTime)
                .HasComment("最後登入日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.LineName)
                .HasMaxLength(100)
                .HasComment("Line暱稱");
            entity.Property(e => e.LineToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("Line Access Token");
            entity.Property(e => e.LineUsrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("LINE使用者ID");
            entity.Property(e => e.LogCount).HasComment("登入次數");
            entity.Property(e => e.MerPicPoiId).HasComment("取貨點id");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasComment("手機號碼");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("真實全名");
            entity.Property(e => e.Num).HasComment("取貨點管理者編號");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasComment("備註");
            entity.Property(e => e.Sex).HasComment("性別");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPicPoiUsrAuthCode>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("成為取貨點使用者邀請代碼"));

            entity.Property(e => e.AppliedTime)
                .HasComment("申請完成時間")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.HashCode)
                .HasMaxLength(50)
                .HasComment("雜湊亂數");
            entity.Property(e => e.MerPicPoiId).HasComment("取貨點ID");
            entity.Property(e => e.MerPicPoiUsrNum).HasComment("取貨點使用者 Num (From NumTable)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPicPoint>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家取貨點"));

            entity.HasIndex(e => new { e.MerchantId, e.Num }, "IX_MerPicPoint").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .HasComment("取貨點地址");
            entity.Property(e => e.Contacter)
                .HasMaxLength(30)
                .HasComment("聯絡人");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Memo)
                .HasMaxLength(300)
                .HasComment("備註");
            entity.Property(e => e.MerPicPoiTypeId).HasDefaultValue(1);
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("取貨點名稱");
            entity.Property(e => e.Num).HasComment("編號(from NumTable)");
            entity.Property(e => e.OpenTime)
                .HasMaxLength(30)
                .HasComment("取貨時間");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("聯絡電話");
            entity.Property(e => e.SharePct)
                .HasComment("取貨點分潤成數")
                .HasColumnType("decimal(7, 4)");
            entity.Property(e => e.Sort)
                .HasDefaultValue(9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPlan>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("商家方案"));

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->關閉,1->開啟,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPlanParas>(entity =>
        {
            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ManType)
                .HasMaxLength(50)
                .HasComment("管理型態");
            entity.Property(e => e.MerPlanCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("商家方案代碼(參閱 MerPlan)");
            entity.Property(e => e.ParaName)
                .HasMaxLength(50)
                .HasComment("方案參數名稱");
            entity.Property(e => e.ParaValue)
                .HasMaxLength(50)
                .HasComment("方案參數值");
            entity.Property(e => e.SysFunId).HasComment("系統功能Id");
        });

        modelBuilder.Entity<MerPromo>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家優惠活動"));

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("優惠說明");
            entity.Property(e => e.EndTime)
                .HasComment("優惠期間: 結束時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("優惠名稱");
            entity.Property(e => e.StartTime)
                .HasComment("優惠期間: 開始時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerPromoRecord>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.ActMemberId, e.CreatedTime, e.PromoRewardId });

            entity.ToTable(tb => tb.HasComment("優惠紀錄"));

            entity.Property(e => e.MemberId).HasComment("誰被優惠");
            entity.Property(e => e.ActMemberId).HasComment("執行對象");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("使用時間/創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.PromoRewardId).HasComment("適用優惠回饋");
            entity.Property(e => e.Creator).HasComment("創建人/觸發優惠回饋者");
            entity.Property(e => e.CreatorType).HasComment("0: 前台/1:後台");
            entity.Property(e => e.RewardUnit).HasMaxLength(5);
            entity.Property(e => e.RewardValue)
                .HasComment("回饋多少元")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SysTabId).HasComment("紀錄主體表ID，關聯 SysTab 表");
            entity.Property(e => e.TabRefId).HasComment("紀錄主體表對應ID Ex:dbo.Order => OrderId, dbo.GooSpec => GooSpecId ...");
        });

        modelBuilder.Entity<MerSchedJob>(entity =>
        {
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.ExpireAt)
                .HasComment("from HangFire.Job => ExpireAt")
                .HasColumnType("datetime");
            entity.Property(e => e.HashKey)
                .HasMaxLength(100)
                .HasComment("From HangFire.Hash");
            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("From HangFire.Job ");
            entity.Property(e => e.Result).HasComment("執行結果");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.SysFunActId).HasComment("作業功能");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerShiWay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MerShipWay");

            entity.ToTable(tb => tb.HasComment("商家運送/取貨方式"));

            entity.HasIndex(e => new { e.MerchantId, e.Num }, "IX_MerShiWay").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Fee)
                .HasComment("運費")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.FreeAmt)
                .HasComment("免運滿額值")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.FreeCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasComment("運費減免碼(Y->超過FreeAmt得享免運;N->不提供免運)");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱(1->自取面交、2->外送面交、3->貨運宅配、4->超商取貨)");
            entity.Property(e => e.Num).HasComment("編號");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(9999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerSocChannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MerSoc");

            entity.ToTable(tb => tb.HasComment("商家社群"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.AccToken)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("社群賣場網址(由系統所產生的LINE賣場網址(非自行輸入))");
            entity.Property(e => e.Authorized)
                .HasDefaultValue(true)
                .HasComment("經商家授權存取(0->否,1->是)，若商家登入時原授權改為未授權，狀態需更新");
            entity.Property(e => e.Bind).HasComment("與系統綁定(0->否,1->是)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.FBGroIdAdmPageIds).IsUnicode(false);
            entity.Property(e => e.FBGroIdBindPageId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Facebook 社團綁定的粉絲專頁 Id (只有在SocType=2時才可以有值)");
            entity.Property(e => e.IsNewPage).HasComment("是否為新版本粉專");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱(ex.LINE南屯、LINE北區…)");
            entity.Property(e => e.Num).HasComment("商家群組編號(from NumTable)");
            entity.Property(e => e.ParentId).HasComment("社群間父子關係 Ex: LINE社群底下多個聊天室 (父->子)(SocType:9 ->10)，該欄位寫入MerSocChaId");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.SocChaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("社群頻道ID");
            entity.Property(e => e.SocPrivacy).HasComment("社群公開與否(0->否,1->是)");
            entity.Property(e => e.SocTypeId).HasComment("社群類別(From SocType)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerSupCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SupplierCategory");

            entity.ToTable(tb => tb.HasComment("商家供應商分類"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Num).HasComment("編號(from NumTable)");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停權,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerSupplier>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家供應商"));

            entity.HasIndex(e => new { e.MerchantId, e.Num }, "IX_MerSupplier").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .HasComment("通訊地址");
            entity.Property(e => e.Contacter)
                .HasMaxLength(30)
                .HasComment("聯絡人");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Email");
            entity.Property(e => e.MerSupCatId).HasComment("供應商分類序號(from MerSupCategory)");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("手機號碼");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("供應商名稱");
            entity.Property(e => e.Num).HasComment("編號(from NumTable)");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("聯絡電話");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停權,1->使用中,9->刪除)");
            entity.Property(e => e.TaxId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("統一編號");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("商家類型"));

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->關閉,1->開啟,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<MerUseLog>(entity =>
        {
            entity.HasKey(e => new { e.MerchantId, e.Year, e.Month, e.Week });

            entity.Property(e => e.MerchantId).HasComment("商家序號(Merchant)");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasComment("年度");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("月份");
            entity.Property(e => e.Week)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("第幾週");
            entity.Property(e => e.StayHours).HasColumnType("decimal(4, 1)");
            entity.Property(e => e.Times).HasComment("次數");
        });

        modelBuilder.Entity<MerUsr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MerUser");

            entity.ToTable(tb => tb.HasComment("商家使用者(管理帳號)"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.AccFaiCount).HasComment("登入失敗次數統計");
            entity.Property(e => e.Account)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("帳號");
            entity.Property(e => e.Birthday).HasComment("生日");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Email");
            entity.Property(e => e.FBLongLivedToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("Facebook 長時效 token");
            entity.Property(e => e.FBName)
                .HasMaxLength(100)
                .HasComment("Facebook姓名");
            entity.Property(e => e.FBPSID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Facebook 的 PSID (根據FBRecipientLoginId發送初始message給user，回覆後取得該PSID)");
            entity.Property(e => e.FBRecipientLoginId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Facebook Login Connect with Messenger 取得的 Login Id");
            entity.Property(e => e.FBUsrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Facebook使用者ID (Facebook 的 ASID)");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("性別(1->男性,2->女性,0->其他)");
            entity.Property(e => e.HeadImgUrl)
                .IsUnicode(false)
                .HasComment("LINE頭照圖片");
            entity.Property(e => e.IsActive).HasComment("是否啓用");
            entity.Property(e => e.IsMaster)
                .HasDefaultValue(true)
                .HasComment("是否為最高管理者");
            entity.Property(e => e.LasLogIP)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("最後登入網路位址");
            entity.Property(e => e.LasLogTime)
                .HasComment("最後登入日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.LineFriChanged).HasComment("Friendship狀態變更註記");
            entity.Property(e => e.LineFriFlag).HasComment("是否為朋友");
            entity.Property(e => e.LineName)
                .HasMaxLength(100)
                .HasComment("Line暱稱");
            entity.Property(e => e.LineNotifyToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("Line Notify Token");
            entity.Property(e => e.LineStaMessage)
                .HasMaxLength(500)
                .HasComment("Line狀態訊息");
            entity.Property(e => e.LineToken)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("Line Access Token");
            entity.Property(e => e.LineUsrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("LINE使用者ID");
            entity.Property(e => e.LogCount).HasComment("登入次數");
            entity.Property(e => e.MerRolId)
                .HasDefaultValue(1)
                .HasComment("商家使用者角色(1->團主,2->小幫手)");
            entity.Property(e => e.MerchantId).HasComment("商家序號(Merchant)");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("手機號碼(小幫手可以空值,管理者不可空值)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("中文姓名");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasComment("密碼");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("聯絡電話");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.ValFaiCount).HasComment("記錄錯誤次數(三次后啓動驗證碼)");
        });

        modelBuilder.Entity<MerVarKey>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasComment("商家設定檔Key");
                    tb.HasTrigger("WriteNum");
                });

            entity.Property(e => e.DefValue).HasMaxLength(1000);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasComment("設定檔描述");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OwnSys)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("所屬系統(2:所有/1:商家管理/0:系統管理)");
            entity.Property(e => e.Unit).HasMaxLength(5);
        });

        modelBuilder.Entity<MerVariable>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家設定檔"));

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.KeyId).HasComment("設定檔識別");
            entity.Property(e => e.MerchantId).HasComment("商家ID");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.Value)
                .HasMaxLength(1000)
                .HasComment("設定值");
        });

        modelBuilder.Entity<Merchant>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasComment("商家");
                    tb.HasTrigger("tr_Merchant_c");
                });

            entity.HasIndex(e => e.Code, "IX_Merchant").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.AccOfTrans)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("商家轉賬的賬戶");
            entity.Property(e => e.AddPurUsrNum).HasComment("加購小幫手人數");
            entity.Property(e => e.AuthedSno)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("授權驗證序號");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("商家代碼(MerTypCode+Id左補0)");
            entity.Property(e => e.ConAddress)
                .HasMaxLength(300)
                .HasComment("聯絡人地址");
            entity.Property(e => e.ConGiCitCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("聯絡人縣市代碼(from GiCity)");
            entity.Property(e => e.ConGiCouCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((886))")
                .HasComment("聯絡人國家代碼(from GiCountry)");
            entity.Property(e => e.ConGiPosCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("聯絡人郵遞區號(ZipCode)(from GiPosCode)");
            entity.Property(e => e.ConGiPosName)
                .HasMaxLength(50)
                .HasComment("聯絡人鄉鎮區名稱(from GiPosCode)");
            entity.Property(e => e.ConMail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("聯絡人E-Mail");
            entity.Property(e => e.ConMobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("聯絡人手機號碼");
            entity.Property(e => e.ConName)
                .HasMaxLength(50)
                .HasComment("聯絡人姓名");
            entity.Property(e => e.ConPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("聯絡人電話");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Email");
            entity.Property(e => e.ExpiryDate).HasComment("到期日期");
            entity.Property(e => e.FbfUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("商家FB粉專網址");
            entity.Property(e => e.FbgUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("商家FB社群網址");
            entity.Property(e => e.FinOutId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("從何得知代碼");
            entity.Property(e => e.HashId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IgUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("商家IG網址");
            entity.Property(e => e.LineUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("商家LINE網址");
            entity.Property(e => e.MerPlaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("商家方案(0:精簡/A:基本/B:進階/C:豪華)(from MerPlan)");
            entity.Property(e => e.MerTypCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("商家類型(0:試用/1:正式/9:無限制)(from MerType)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.OrgPlanId).HasComment("所屬組織的方案序號");
            entity.Property(e => e.RefMerId).HasComment("推薦商家Id");
            entity.Property(e => e.RefSalChaId).HasComment("經銷渠道商Id");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.StartingDate).HasComment("起始日");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.TaxId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("商家統一編號/身分證號");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.UseAbleFbSocChaNum)
                .HasDefaultValue((short)1)
                .HasComment("Fb社群(粉轉，社群)可用數量");
            entity.Property(e => e.UseableUsrNum)
                .HasDefaultValue((short)1)
                .HasComment("可使用人數");
        });

        modelBuilder.Entity<NumTable>(entity =>
        {
            entity.HasKey(e => new { e.TabName, e.MerchantId });

            entity.ToTable(tb => tb.HasComment("取號表"));

            entity.Property(e => e.TabName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("表格名稱");
            entity.Property(e => e.MerchantId).HasComment("所屬商家序號");
            entity.Property(e => e.ColName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("欄位名稱");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Number).HasComment("目前編號");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<OrdCanRea>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("訂單取消原因"));

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("取消代碼");
            entity.Property(e => e.CreatedTime)
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建者");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasComment("取消説明");
            entity.Property(e => e.UpdatedTime)
                .HasComment("編輯時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("編輯者編號");
        });

        modelBuilder.Entity<OrdItem>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("訂單項目"));

            entity.HasIndex(e => new { e.OrderId, e.GoodsId }, "IX_OrdItem").IsUnique();

            entity.Property(e => e.Id).HasComment("訂單明細序號");
            entity.Property(e => e.DiscountAmt)
                .HasDefaultValue(0m)
                .HasComment("商品折扣減收金額(from GroGooOfr)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.DiscountPct)
                .HasDefaultValue(0m)
                .HasComment("商品折扣減收折扣(from GroGooOfr)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.GooOfrQty)
                .HasDefaultValue(0m)
                .HasComment("商品折扣起訂數量 (from GooOfr)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.GoodsDescription).HasComment("商品介紹(from Goods)");
            entity.Property(e => e.GoodsId).HasComment("商品序號(from Goods)");
            entity.Property(e => e.GoodsName)
                .HasMaxLength(100)
                .HasComment("商品名稱(from Goods)");
            entity.Property(e => e.GroArriveTime)
                .HasComment("預計到貨日(from Group)")
                .HasColumnType("datetime");
            entity.Property(e => e.GroGooId).HasComment("團組商品序號(from GroGoods)");
            entity.Property(e => e.GroGooOfrId).HasComment("團組商品折扣序號(from GroGooOfr)");
            entity.Property(e => e.GroVenOrdTime)
                .HasComment("叫貨日期(from Group)")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupId).HasComment("圖組序號(from Group)");
            entity.Property(e => e.MemTypeCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("適用會員類型(0->全部適用,1:一般/2:批客/3:過路客 from MemType)(from GroGooOfr)");
            entity.Property(e => e.MerSocChaId).HasComment("商家社群頻道序號(from MerSocChannel)");
            entity.Property(e => e.MerSocChaName)
                .HasMaxLength(100)
                .HasComment("商家社群頻道名稱(from MerSocChannel)");
            entity.Property(e => e.MerSupId).HasComment("商家供應商序號(from MerSupplier)");
            entity.Property(e => e.OptionCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("商品折扣優惠選項代碼(1->每件減固定金額, 2->整單折扣)(from GooOfr)");
            entity.Property(e => e.OrderId).HasComment("訂單序號(from Order)");
            entity.Property(e => e.SumShpTolAmt)
                .HasComment("合計應收金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SumTolAmt)
                .HasComment("合計金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SumTolQty)
                .HasComment("合計數量")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Title1)
                .HasMaxLength(300)
                .HasComment("團名主標(from Group)");
        });

        modelBuilder.Entity<OrdItemDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("訂單項目明細"));

            entity.HasIndex(e => new { e.OrdItemId, e.GooSpeId }, "IX_OrdItemDetail").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.GooSpeDescript)
                .HasMaxLength(100)
                .HasComment("商品規格描述(from GooSpec)");
            entity.Property(e => e.GooSpeId).HasComment("商品規格序號(from GooSpec)");
            entity.Property(e => e.GooSpeName)
                .HasMaxLength(30)
                .HasComment("商品規格名稱(from GooSpec)");
            entity.Property(e => e.GooSpePriceSell)
                .HasComment("商品規格售價(from GooSpec)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.GroGooSpeId).HasComment("團組商品規格序號");
            entity.Property(e => e.GroGooSpePriceSell)
                .HasDefaultValue(0m)
                .HasComment("團組商品規格售價")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MemPickUpTime)
                .HasComment("會員取貨時間")
                .HasColumnType("datetime");
            entity.Property(e => e.OrdItemId).HasComment("訂單項目序號(from OrdItem)");
            entity.Property(e => e.Qty)
                .HasComment("購買數量")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.RetQty)
                .HasDefaultValue(0m)
                .HasComment("配貨數量")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SubTolAmt)
                .HasComment("小計金額")
                .HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<OrdStatus>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_PayStatus");

            entity.ToTable(tb => tb.HasComment("訂單狀態"));

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("代碼(0->未付款;1->已付款)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<OrdType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("訂單類型"));

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("代碼(G:團購訂單/S:現場訂單)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasComment("訂單");
                    tb.HasTrigger("tr_CheckPromo");
                    tb.HasTrigger("tr_Order_c");
                    tb.HasTrigger("tr_Order_u");
                });

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ArrivalTime)
                .HasComment("到貨時間")
                .HasColumnType("datetime");
            entity.Property(e => e.AuthCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("授權號碼");
            entity.Property(e => e.BonPoiGet).HasComment("取得紅利點數(若該訂單使用紅利點數折抵金額則不計算該訂單取得紅利點數)");
            entity.Property(e => e.BonPoiUse).HasComment("使用紅利點數");
            entity.Property(e => e.BpDisAmount)
                .HasComment("紅利點數折抵金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BuyAddress)
                .HasMaxLength(100)
                .HasComment("購買人地址");
            entity.Property(e => e.BuyCitcode)
                .HasMaxLength(10)
                .HasComment("購買人縣市代碼(From GiCity)");
            entity.Property(e => e.BuyCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("購買人國家代碼(From GiCountry)");
            entity.Property(e => e.BuyEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("購買人email");
            entity.Property(e => e.BuyName)
                .HasMaxLength(40)
                .HasComment("購買人姓名");
            entity.Property(e => e.BuyPosCode)
                .HasMaxLength(10)
                .HasComment("購買人鄉鎮市區代碼(From GiPostCode)");
            entity.Property(e => e.BuyPosName)
                .HasMaxLength(50)
                .HasComment("購買人鄉鎮區域名");
            entity.Property(e => e.BuyTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("購買人連絡電話");
            entity.Property(e => e.CanTime)
                .HasComment("棄單日期")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間(訂購日(訂單成立時間))")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.DebitAmt)
                .HasDefaultValue(0m)
                .HasComment("折讓金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.DeliverTime)
                .HasComment("配送(取貨點)時間")
                .HasColumnType("datetime");
            entity.Property(e => e.GetTime)
                .HasComment("配貨日期")
                .HasColumnType("datetime");
            entity.Property(e => e.GetTolQty)
                .HasDefaultValue(0m)
                .HasComment("已配貨量")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MemPickUpCode)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasComment("會員取貨編號");
            entity.Property(e => e.MemReaName)
                .HasMaxLength(50)
                .HasComment("會員真實姓名");
            entity.Property(e => e.MemTypCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasComment("會員類型(1:一般會員/2:批客/3:門市顧客 from MerMember)");
            entity.Property(e => e.MemberId).HasComment("會員序號(from Member)");
            entity.Property(e => e.Memo)
                .HasMaxLength(300)
                .HasComment("備註");
            entity.Property(e => e.MerPayTypId).HasComment("付款方式序號(from MerPayType)");
            entity.Property(e => e.MerPicPoiId).HasComment("取貨點序號(from MerPickPoint)");
            entity.Property(e => e.MerShiWayId).HasComment("取貨方式序號(from MerShiWay)");
            entity.Property(e => e.MerSocChaId).HasComment("商家社群頻道序號(from MerSocChannel：Id)");
            entity.Property(e => e.MerSocChaName)
                .HasMaxLength(100)
                .HasComment("商家社群頻道名稱(from MerSocChannel：Name)");
            entity.Property(e => e.MerchantId).HasComment("商家序號(from Merchant)");
            entity.Property(e => e.Number)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("訂單單號(流水號8碼;ex:00000001)");
            entity.Property(e => e.OfrTolAmt)
                .HasDefaultValue(0m)
                .HasComment("折扣優惠總額(=各商品售價x數量的總和)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OrdCanCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("訂單取消代碼");
            entity.Property(e => e.OrdDebitCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("折讓訂單代碼");
            entity.Property(e => e.OrdPayStaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("收款狀態代碼(0->未收款;1->已收款)");
            entity.Property(e => e.OrdSocType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("訂單類別：(0->非社群訂單(ex.賣場訂單), 1->FB留言自動轉訂單, 2->FB留言手動轉訂單)");
            entity.Property(e => e.OrdStaCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("訂單狀態代碼(1:待配貨/2:/3:待揀貨/4:待出貨/5:已出貨(訂單完成)/6:結單/8:取消/9:棄單/0:斷貨)");
            entity.Property(e => e.OrdTolAmt)
                .HasDefaultValue(0m)
                .HasComment("訂單總額(=原始訂單金額-折扣優惠總額+運費)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OrdTolQty)
                .HasComment("訂購數量")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OrdTypCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("訂單類型代碼(G:團購訂單/S:現場加單/M:手動訂單...更多參考：OrdType)");
            entity.Property(e => e.OrderTime)
                .HasComment("訂購日期")
                .HasColumnType("datetime");
            entity.Property(e => e.OriOrdTolAmt)
                .HasDefaultValue(0m)
                .HasComment("原始訂單金額(=各商品項目售價x數量的總和)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OutTime)
                .HasComment("斷貨日期")
                .HasColumnType("datetime");
            entity.Property(e => e.PayTime)
                .HasComment("收款日期")
                .HasColumnType("datetime");
            entity.Property(e => e.RecAddress)
                .HasMaxLength(100)
                .HasComment("收件人地址");
            entity.Property(e => e.RecCitCode)
                .HasMaxLength(10)
                .HasComment("收件人縣市代碼(From GiCity)");
            entity.Property(e => e.RecCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("收件人國家代碼(From GiCountry)");
            entity.Property(e => e.RecEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("收件人email");
            entity.Property(e => e.RecName)
                .HasMaxLength(40)
                .HasComment("收件人姓名");
            entity.Property(e => e.RecPosCode)
                .HasMaxLength(10)
                .HasComment("收件人鄉鎮市區代碼(From GiPostCode)");
            entity.Property(e => e.RecPosName)
                .HasMaxLength(50)
                .HasComment("收件人鄉鎮區域名");
            entity.Property(e => e.RecTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("收件人連絡電話");
            entity.Property(e => e.RecTolAmt)
                .HasDefaultValue(0m)
                .HasComment("實收金額(已收金額)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShipFee)
                .HasComment("運費")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ShopAmt)
                .HasDefaultValue(0m)
                .HasComment("購物金(已收金額)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShortAmt)
                .HasDefaultValue(0m)
                .HasComment("欠款金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShpTolAmt)
                .HasDefaultValue(0m)
                .HasComment("應收金額(=訂單總額-(紅利折抵金額+折讓金額)=實收金額+欠款金額)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShpTolQty)
                .HasDefaultValue(0m)
                .HasComment("實際出貨量")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SocCommentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("社群留言Comment ID");
            entity.Property(e => e.SplSouId).HasComment("拆單序號來源");
            entity.Property(e => e.SplitTime)
                .HasComment("拆單時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UniCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("發票統一編號");
            entity.Property(e => e.UniTitle)
                .HasMaxLength(20)
                .HasComment("發票抬頭");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.VenOrdTime)
                .HasComment("叫貨日期")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<PickUp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PickUp__3214EC075D3247CC");

            entity.ToTable(tb => tb.HasComment("揀貨單號資料"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.BuyName)
                .HasMaxLength(30)
                .HasComment("訂購人名稱");
            entity.Property(e => e.CreatedTime)
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasComment("會員序號");
            entity.Property(e => e.MerPayTypId).HasComment("付款方式");
            entity.Property(e => e.MerPicPoiId).HasComment("取貨點序號");
            entity.Property(e => e.MerShiWayId).HasComment("收貨方式");
            entity.Property(e => e.Number)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("揀貨單號,流水號8碼(ex:0000001)");
            entity.Property(e => e.PicPoiDelivId).HasComment("取貨點配送單ID");
            entity.Property(e => e.PicPoiDelivTime)
                .HasComment("新增至取貨點配送單時間")
                .HasColumnType("datetime");
            entity.Property(e => e.PickTime)
                .HasComment("完成揀貨時間")
                .HasColumnType("datetime");
            entity.Property(e => e.RecAddrInpType)
                .HasDefaultValue(false)
                .HasComment("輸入類別(0:選擇,1:手動)");
            entity.Property(e => e.RecAddress)
                .HasMaxLength(300)
                .HasComment("收貨人地址");
            entity.Property(e => e.RecCitCode)
                .HasMaxLength(10)
                .HasComment("收件人縣市代碼(From GiCity)");
            entity.Property(e => e.RecCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("收件人國家代碼(From GiCountry)");
            entity.Property(e => e.RecNamInpType)
                .HasDefaultValue(false)
                .HasComment("輸入類別(0:選擇,1:手動)");
            entity.Property(e => e.RecName)
                .HasMaxLength(40)
                .HasComment("收貨人名稱");
            entity.Property(e => e.RecPosCode)
                .HasMaxLength(10)
                .HasComment("收件人鄉鎮市區代碼(From GiPostCode)");
            entity.Property(e => e.RecPosName)
                .HasMaxLength(50)
                .HasComment("收件人鄉鎮區域名");
            entity.Property(e => e.RecTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("收件人連絡電話");
            entity.Property(e => e.ShipFee)
                .HasComment("出貨運費")
                .HasColumnType("decimal(6, 2)");
        });

        modelBuilder.Entity<PromoCond>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("優惠條件"));

            entity.Property(e => e.ActTgtId).HasComment("執行對象ID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.IsRegAct).HasComment("優惠期間內註冊");
            entity.Property(e => e.MerPromoId).HasComment("關聯哪個優惠活動");
            entity.Property(e => e.PromoOrdActId).HasComment("執行行為: 針對下單行為優惠 ");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<PromoLimit>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("優惠限制"));

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.MerPromoId).HasComment("關聯哪個優惠活動");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.TypeId).HasComment("限制種類 (1:每人最多優惠/2:執行對象最多執行)");
            entity.Property(e => e.Unit)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.Value)
                .HasComment("限制值")
                .HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<PromoOrderAct>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("優惠下單行為"));

            entity.Property(e => e.ActLoc).HasComment("操作位置 (null:任意處/1:前台/2:現場/3:FB留言)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasComment("滿多少元/滿多少件 (元/件)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.Value)
                .HasComment("多少值")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ValueType).HasComment("1: 滿多少");
        });

        modelBuilder.Entity<PromoRewGooSpec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasComment("優惠活動贈送好禮商品規格"));

            entity.HasIndex(e => new { e.PromoRewardId, e.GooSpeId }, "IX_PromoRewGooSpec");
        });

        modelBuilder.Entity<PromoRewMethod>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("回饋方式"));

            entity.Property(e => e.AutoAdjWar).HasComment("是否自動調整庫存");
            entity.Property(e => e.CheckCode).HasMaxLength(50);
            entity.Property(e => e.CouType).HasComment("優惠券分類 (0:現場兌換區/1:線上優惠券)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.Type).HasComment("回饋類型 (1:後台手動執行回饋/2:設置前台活動專區優惠券)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<PromoReward>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("優惠回饋"));

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GooSpeId).HasComment("贈送何種商品");
            entity.Property(e => e.Limit)
                .HasComment("回饋上限 (固定單位:元)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MerPromoId).HasComment("關聯哪個優惠活動");
            entity.Property(e => e.PromoTgtId).HasComment("優惠對象");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.TypeId).HasComment("回饋種類(1:折扣整筆訂單/2:贈送購物金/3:贈送商品)");
            entity.Property(e => e.Unit)
                .HasMaxLength(2)
                .HasComment("回饋單位 (元/%/件)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.Value)
                .HasComment("回饋值")
                .HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<PromoTgt>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("優惠對象"));

            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("優惠對象名稱");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<PurOrdDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("叫貨單明細"));

            entity.HasIndex(e => new { e.PurOrdId, e.GooSpecId }, "IX_PurOrdDetail").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ArrQty)
                .HasComment("到貨數量")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Cost)
                .HasComment("成本")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ExpDate)
                .HasComment("有效日期")
                .HasColumnType("datetime");
            entity.Property(e => e.GooSpecId).HasComment("商品規格序號");
            entity.Property(e => e.PurAmt)
                .HasComment("採購(叫貨)金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.PurOrdId).HasComment("採購(叫貨)單序號");
            entity.Property(e => e.PurQty)
                .HasComment("採購(叫貨)數量")
                .HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PurOrder");

            entity.ToTable(tb => tb.HasComment("叫貨單"));

            entity.HasIndex(e => new { e.MerSupId, e.Num }, "IX_PurchaseOrder").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ActArrTime)
                .HasComment("實際到貨(入庫)時間")
                .HasColumnType("datetime");
            entity.Property(e => e.AdjAmt)
                .HasComment("調整金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.EstArrDate).HasComment("預計到貨日");
            entity.Property(e => e.MerSupId).HasComment("商家供應商序號");
            entity.Property(e => e.Num)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("採購單號(from NumTable)");
            entity.Property(e => e.PurStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("採購(叫貨)狀態(0:未到貨/1:已入庫/2:部分入庫/3:結單)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("備註");
            entity.Property(e => e.ShipAmt)
                .HasComment("運送金額(運費)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.TotalAmt)
                .HasComment("總金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<SalChaApp>(entity =>
        {
            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.AppId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("AppId");
            entity.Property(e => e.AppSecret)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("AppSecret");
            entity.Property(e => e.CallbackUrl).HasMaxLength(50);
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("應用程式名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.SalChaId).HasComment("銷售渠道Id");
            entity.Property(e => e.SocType).HasComment("社群類型");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<SalChaOwnSocType>(entity =>
        {
            entity.HasKey(e => new { e.SalChaId, e.OwnSocType });

            entity.Property(e => e.SalChaId).HasComment("銷售渠道Id");
            entity.Property(e => e.OwnSocType).HasComment("經營社群型態：FB :7, LINE:8，詳見 SocType");
        });

        modelBuilder.Entity<SalChaType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->關閉,1->開啟,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<SalChannel>(entity =>
        {
            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.HomePgImg)
                .HasMaxLength(100)
                .HasComment("首頁背景圖");
            entity.Property(e => e.HostUri)
                .HasMaxLength(50)
                .HasComment("Host Uri");
            entity.Property(e => e.LogoImg)
                .HasMaxLength(100)
                .HasComment("Logo圖檔");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("銷售商名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.SalChaType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("單位名稱");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.ToTable("Schema", "HangFire");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");

            entity.ToTable("Server", "HangFire");

            entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.ToTable("Set", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(256);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shipment__3214EC074B56E494");

            entity.ToTable(tb => tb.HasComment("出貨單號資料"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.BuyName)
                .HasMaxLength(30)
                .HasComment("訂購人名稱");
            entity.Property(e => e.Check)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("是否結單(0->未結單;1->已結單)");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasComment("出貨單編碼(8碼)");
            entity.Property(e => e.CreatedTime)
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.DebitAmt)
                .HasDefaultValue(0m)
                .HasComment("折讓金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MemberId).HasComment("會員序號");
            entity.Property(e => e.Memo)
                .HasComment("備注")
                .HasColumnType("ntext");
            entity.Property(e => e.MerPayTypId).HasComment("付款方式");
            entity.Property(e => e.MerPicPoiId).HasComment("取貨點序號");
            entity.Property(e => e.MerShiWayId).HasComment("收貨方式");
            entity.Property(e => e.Number)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("出貨單號,流水號8碼(ex:0000001)");
            entity.Property(e => e.RecAddrInpType).HasComment("地址輸入類別(0:選擇,1:手動)");
            entity.Property(e => e.RecAddress)
                .HasMaxLength(300)
                .HasComment("收貨人地址");
            entity.Property(e => e.RecCitCode)
                .HasMaxLength(10)
                .HasComment("收件人縣市代碼(From GiCity)");
            entity.Property(e => e.RecCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("收件人國家代碼(From GiCountry)");
            entity.Property(e => e.RecNamInpType)
                .HasDefaultValue(false)
                .HasComment("名稱輸入類別(0:選擇,1:手動)");
            entity.Property(e => e.RecName)
                .HasMaxLength(40)
                .HasComment("收貨人名稱");
            entity.Property(e => e.RecPosCode)
                .HasMaxLength(10)
                .HasComment("收件人鄉鎮市區代碼(From GiPostCode)");
            entity.Property(e => e.RecPosName)
                .HasMaxLength(50)
                .HasComment("收件人鄉鎮區域名");
            entity.Property(e => e.RecTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("收件人連絡電話");
            entity.Property(e => e.RecTolAmt)
                .HasComment("實收金額(已收金額)")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShipFee)
                .HasDefaultValue(0m)
                .HasComment("出貨運費(應補收運費)")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ShipPayStaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("收款狀態(0->未收款;1->已收款;2->部分收款)");
            entity.Property(e => e.ShipTime)
                .HasComment("出貨時間")
                .HasColumnType("datetime");
            entity.Property(e => e.ShopAmt)
                .HasDefaultValue(0m)
                .HasComment("購物金")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdDebitAmt)
                .HasDefaultValue(0m)
                .HasComment("合計訂單折讓金額")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdOfrAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdRectolAmt)
                .HasDefaultValue(0m)
                .HasComment("合計訂單實收款")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdShopAmt)
                .HasDefaultValue(0m)
                .HasComment("合計訂單購物金")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdShortAmt)
                .HasDefaultValue(0m)
                .HasComment("合計訂單欠款")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOriOrdTolAmt)
                .HasDefaultValue(0m)
                .HasComment("原始訂單金額(=各商品項目售價x數量的總和)")
                .HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<SocType>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("社群類別"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("社群類別：(1->FB社團, 2->FB粉專, 3->Line群組, 4->Line官方帳號), 5.IG");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParentId).HasComment("父層 Id (子社群依賴於某個父社群) ex: \"Line群組\"依賴於\"Line\"");
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.ToTable("State", "HangFire");

            entity.HasIndex(e => e.CreatedAt, "IX_HangFire_State_CreatedAt");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.State)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<SysAct>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasComment("系統動作"));

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("動作代碼");
            entity.Property(e => e.EnName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("英文名稱");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("中文名稱");
            entity.Property(e => e.isOpen)
                .HasDefaultValue(true)
                .HasComment("是否開啟");
        });

        modelBuilder.Entity<SysFun>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SysFunction");

            entity.ToTable(tb => tb.HasComment("系統功能"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("頁面英文名稱");
            entity.Property(e => e.Father)
                .HasDefaultValue(0)
                .HasComment("父階層序號");
            entity.Property(e => e.IsItem)
                .HasDefaultValue(false)
                .HasComment("是否為可操作頁面(0->否,1->是)");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasComment("中文名稱");
            entity.Property(e => e.OwnSys)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("所屬系統(1:商家管理/0:系統管理)");
            entity.Property(e => e.PageURL)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasComment("頁面網址");
            entity.Property(e => e.Sort)
                .HasDefaultValue(999)
                .HasComment("頁面排序");
            entity.Property(e => e.isOpen).HasComment("是否開啟(0->否,1->是)");
        });

        modelBuilder.Entity<SysFunAct>(entity =>
        {
            entity.HasKey(e => new { e.SysFunId, e.SysActCode });

            entity.ToTable(tb => tb.HasComment("系統功能動作"));

            entity.Property(e => e.SysFunId).HasComment("系統功能序號");
            entity.Property(e => e.SysActCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("系統動作代碼");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SysRol>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("系統角色"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<SysRolFunAct>(entity =>
        {
            entity.HasKey(e => new { e.SysRolId, e.SysFunId, e.SysActCode });

            entity.ToTable(tb => tb.HasComment("系統角色功能動作"));

            entity.Property(e => e.SysRolId).HasComment("系統角色序號");
            entity.Property(e => e.SysFunId).HasComment("系統功能序號");
            entity.Property(e => e.SysActCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("系統動作代碼");
        });

        modelBuilder.Entity<SysTab>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("系統資料表格"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("序號");
            entity.Property(e => e.Catalog)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("GroupBuy")
                .HasComment("Catalog");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasComment("建立/編輯 時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Name");
            entity.Property(e => e.Schema)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("dbo")
                .HasComment("Schema");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("BASE Table")
                .HasComment("Type");
        });

        modelBuilder.Entity<SysUsr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SystemUser");

            entity.ToTable(tb => tb.HasComment("系統使用者"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.AccessFailedCount).HasComment("登入失敗次數統計");
            entity.Property(e => e.Account)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("帳號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Email");
            entity.Property(e => e.LastLoginDateTime)
                .HasComment("最後登入日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.LastLoginIP)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("最後登入網路位址");
            entity.Property(e => e.LinHeadPicUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("LINE頭照圖片");
            entity.Property(e => e.LineFriChanged).HasComment("Friendship狀態變更註記");
            entity.Property(e => e.LineFriFlag).HasComment("是否為朋友");
            entity.Property(e => e.LineName)
                .HasMaxLength(100)
                .HasComment("Line暱稱");
            entity.Property(e => e.LineUsrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("LINE使用者ID");
            entity.Property(e => e.LoginCount).HasComment("登入次數");
            entity.Property(e => e.MerUsrId).HasComment("商家使者帳號");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("中文姓名");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasComment("密碼");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("備註");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<SysUsrRol>(entity =>
        {
            entity.HasKey(e => new { e.SysUsrId, e.SysRolId });

            entity.ToTable(tb => tb.HasComment("系統使用者角色"));

            entity.Property(e => e.SysUsrId).HasComment("系統使用者序號");
            entity.Property(e => e.SysRolId).HasComment("系統角色序號");
        });

        modelBuilder.Entity<WarHouBra>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("分倉"));

            entity.HasIndex(e => new { e.WarHouMerId, e.GooSpecId }, "IX_WarHouBra").IsUnique();

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.GooSpecId).HasComment("商品規格序號");
            entity.Property(e => e.Qty)
                .HasComment("數量")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.RetQty)
                .HasComment("保留量")
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
            entity.Property(e => e.WarHouMerId).HasComment("商家倉庫序號");
        });

        modelBuilder.Entity<WarHouMer>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("商家倉庫"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasComment("代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.MerchantId).HasComment("商家序號");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("名稱");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("備註");
            entity.Property(e => e.Sort)
                .HasDefaultValue(99999)
                .HasComment("排序");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("狀態(0->停用,1->使用中,9->刪除)");
            entity.Property(e => e.UpdatedTime)
                .HasComment("更新日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("更新人員");
        });

        modelBuilder.Entity<WarHouTraLog>(entity =>
        {
            entity.ToTable(tb => tb.HasComment("倉庫交易紀錄"));

            entity.Property(e => e.Id).HasComment("序號");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建人員");
            entity.Property(e => e.Kind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("種類(庫存調整0/叫貨1/出貨2/配貨3)");
            entity.Property(e => e.Qty)
                .HasComment("異動數量")
                .HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ReaCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("庫存變更原因(代碼)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasComment("備註");
            entity.Property(e => e.SourceId).HasComment("來源編號");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("類型(進項0/出項1/配進2/配出3/)");
            entity.Property(e => e.WarHouBraId).HasComment("分倉序號");
        });

        modelBuilder.Entity<WarHouTraRea>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_WarHouTraRea_1");

            entity.ToTable(tb => tb.HasComment("倉庫異動原因"));

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasComment("倉庫異動原因代碼");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("創建時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Creator).HasComment("創建者");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasComment("原因説明");
            entity.Property(e => e.UpdatedTime)
                .HasComment("編輯時間")
                .HasColumnType("datetime");
            entity.Property(e => e.Updater).HasComment("編輯者編號");
        });

        modelBuilder.Entity<v_GooSpec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_GooSpec");

            entity.Property(e => e.BuyMaxCnt).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Code).HasMaxLength(5);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.GooName).HasMaxLength(100);
            entity.Property(e => e.GooNum)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.PriceBatch).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceBuy).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceSell).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_MemCart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MemCart");

            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.FBName).HasMaxLength(50);
            entity.Property(e => e.GooName).HasMaxLength(100);
            entity.Property(e => e.GooSpeName).HasMaxLength(30);
            entity.Property(e => e.LineName).HasMaxLength(50);
            entity.Property(e => e.OrdTypCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Qty).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.RealName).HasMaxLength(50);
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_MemRegConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MemRegConfig");

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ConfigTypeCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TypeName).HasMaxLength(50);
            entity.Property(e => e.TypeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_MerMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerMember");

            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FBLongLivedToken)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FBName).HasMaxLength(50);
            entity.Property(e => e.FBPSID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FBRecipientLoginId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FBUsrId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GiCitCode).HasMaxLength(10);
            entity.Property(e => e.GiCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GiPosCode).HasMaxLength(10);
            entity.Property(e => e.GiPosName).HasMaxLength(50);
            entity.Property(e => e.HeadImgUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.IdNumber).HasMaxLength(12);
            entity.Property(e => e.LasLogIP)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LasLogTime).HasColumnType("datetime");
            entity.Property(e => e.LineName).HasMaxLength(50);
            entity.Property(e => e.LineNotifyToken)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LineStaMessage).HasMaxLength(500);
            entity.Property(e => e.LineToken)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.LineUsrId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MemTypCode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MerMemStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RealName).HasMaxLength(50);
            entity.Property(e => e.Receiver).HasMaxLength(50);
            entity.Property(e => e.ShopAmt).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<v_MerNotice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerNotice");

            entity.Property(e => e.Content).HasMaxLength(1000);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Expr1SysFunName).HasMaxLength(40);
            entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SysActCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysActName).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_MerPicPoiDelivLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerPicPoiDelivLog");

            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.DelivMan).HasMaxLength(50);
            entity.Property(e => e.DelivManMobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DelivNum)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DelivQty).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MemReaName).HasMaxLength(50);
            entity.Property(e => e.OrdNum)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RetQty).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<v_MerPromo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerPromo");

            entity.Property(e => e.ActLocName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ActTgtName).HasMaxLength(100);
            entity.Property(e => e.ActUnit).HasMaxLength(50);
            entity.Property(e => e.ActValue).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ActValueTypeName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.LimitTypeName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.LimitUnit)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.LimitValue).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PromoStatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PromoStatusName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.PromoTgtName).HasMaxLength(100);
            entity.Property(e => e.RewLimit).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.RewMtdCheckCode).HasMaxLength(50);
            entity.Property(e => e.RewMtdCouTypName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RewMtdName).HasMaxLength(50);
            entity.Property(e => e.RewMtdTypeName)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.RewTypeName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RewUnit).HasMaxLength(2);
            entity.Property(e => e.RewValue).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<v_MerSchedJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerSchedJob");

            entity.Property(e => e.ActEnName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ActName).HasMaxLength(10);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatorName).HasMaxLength(50);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.FatherFunName).HasMaxLength(40);
            entity.Property(e => e.FunEnName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FunName).HasMaxLength(40);
            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OwnSys)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PageURL)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.StateChName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(20);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<v_MerUseLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerUseLog");

            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.StayHours).HasColumnType("decimal(4, 1)");
            entity.Property(e => e.Week)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_MerVariable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MerVariable");

            entity.Property(e => e.Code)
                .HasMaxLength(1001)
                .IsUnicode(false);
            entity.Property(e => e.DefValue).HasMaxLength(1000);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OwnSys)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Unit).HasMaxLength(5);
            entity.Property(e => e.Value).HasMaxLength(1000);
        });

        modelBuilder.Entity<v_OrdItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrdItemDetail");

            entity.Property(e => e.BuyEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BuyName).HasMaxLength(40);
            entity.Property(e => e.BuyTel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.DebitAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.GiCitName).HasMaxLength(10);
            entity.Property(e => e.GooSpeName).HasMaxLength(30);
            entity.Property(e => e.GooSpePriceSell).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.GoodsName).HasMaxLength(100);
            entity.Property(e => e.GroGooSpePriceSell).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MemReaName).HasMaxLength(50);
            entity.Property(e => e.Memo).HasMaxLength(300);
            entity.Property(e => e.MerPayTypName).HasMaxLength(10);
            entity.Property(e => e.MerPicPoiName).HasMaxLength(50);
            entity.Property(e => e.MerShiWayName).HasMaxLength(10);
            entity.Property(e => e.Number)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OfrTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OrdPayStaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdStaCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OrdStaName).HasMaxLength(10);
            entity.Property(e => e.OrdTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OrdTolQty).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OrdTypCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdTypName).HasMaxLength(20);
            entity.Property(e => e.OriOrdTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Qty).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.RecAddress).HasMaxLength(100);
            entity.Property(e => e.RecCitCode).HasMaxLength(10);
            entity.Property(e => e.RecCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecName).HasMaxLength(40);
            entity.Property(e => e.RecPosCode).HasMaxLength(10);
            entity.Property(e => e.RecPosName).HasMaxLength(50);
            entity.Property(e => e.RecTel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RecTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.RetQty).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShopAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShortAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShpTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.SubTolAmt).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<v_PromoLimit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PromoLimit");

            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TypeName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<v_PromoOrderAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PromoOrderAct");

            entity.Property(e => e.ActLocName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ValueTypeName)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_PromoRewMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PromoRewMethod");

            entity.Property(e => e.CheckCode).HasMaxLength(50);
            entity.Property(e => e.CouTypName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TypeName)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_PromoReward>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PromoReward");

            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.GooName).HasMaxLength(100);
            entity.Property(e => e.GooSpeName).HasMaxLength(30);
            entity.Property(e => e.Limit).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.PromoTgtName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TypeName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Unit).HasMaxLength(2);
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<v_Rand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Rand");
        });

        modelBuilder.Entity<v_RandNewId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_RandNewId");
        });

        modelBuilder.Entity<v_RandomNumberView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_RandomNumberView");
        });

        modelBuilder.Entity<v_ShipOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ShipOrder");

            entity.Property(e => e.ArrivalTime).HasColumnType("datetime");
            entity.Property(e => e.AuthCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BpDisAmount).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BuyAddress).HasMaxLength(100);
            entity.Property(e => e.BuyCitcode).HasMaxLength(10);
            entity.Property(e => e.BuyCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BuyEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BuyName).HasMaxLength(40);
            entity.Property(e => e.BuyPosCode).HasMaxLength(10);
            entity.Property(e => e.BuyPosName).HasMaxLength(50);
            entity.Property(e => e.BuyTel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CanTime).HasColumnType("datetime");
            entity.Property(e => e.Check)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.DebitAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.DeliverTime).HasColumnType("datetime");
            entity.Property(e => e.GetTime).HasColumnType("datetime");
            entity.Property(e => e.GetTolQty).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MemPickUpCode)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.MemReaName).HasMaxLength(50);
            entity.Property(e => e.MemTypCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Memo).HasMaxLength(300);
            entity.Property(e => e.MerSocChaName).HasMaxLength(100);
            entity.Property(e => e.Number)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OfrTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OrdCanCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.OrdDebitCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.OrdPayStaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdSocType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdStaCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OrdTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OrdTolQty).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OrdTypCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrderTime).HasColumnType("datetime");
            entity.Property(e => e.OriOrdTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.OutTime).HasColumnType("datetime");
            entity.Property(e => e.PayTime).HasColumnType("datetime");
            entity.Property(e => e.PickFormNum)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PickTime).HasColumnType("datetime");
            entity.Property(e => e.RecAddress).HasMaxLength(100);
            entity.Property(e => e.RecCitCode).HasMaxLength(10);
            entity.Property(e => e.RecCouCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecName).HasMaxLength(40);
            entity.Property(e => e.RecPosCode).HasMaxLength(10);
            entity.Property(e => e.RecPosName).HasMaxLength(50);
            entity.Property(e => e.RecTel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RecTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShipCreatedTime).HasColumnType("datetime");
            entity.Property(e => e.ShipDebitAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShipFee).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ShipFormNum)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ShipMemo).HasColumnType("ntext");
            entity.Property(e => e.ShipPayStaCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShipRecTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShipShipFee).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ShipShopAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShipTime).HasColumnType("datetime");
            entity.Property(e => e.ShopAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShortAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShpTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.ShpTolQty).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SocCommentId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SplitTime).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TolOrdDebitAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdOfrAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdRectolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdShopAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOrdShortAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.TolOriOrdTolAmt).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.UniCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniTitle).HasMaxLength(20);
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            entity.Property(e => e.VenOrdTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<v_SysFunAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SysFunAct");

            entity.Property(e => e.OwnSys)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysActCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SysActEnName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SysActName).HasMaxLength(10);
            entity.Property(e => e.SysFunName)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_WarHouBra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_WarHouBra");

            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.GooName).HasMaxLength(100);
            entity.Property(e => e.GooSpecName).HasMaxLength(30);
            entity.Property(e => e.NotRetQty).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Qty).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.RetQty).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            entity.Property(e => e.WarHouMerStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
