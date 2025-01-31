using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mohua_web_.Entities;

public partial class DsuContext : DbContext
{
    public DsuContext()
    {
    }

    public DsuContext(DbContextOptions<DsuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAmrutprojectdetail> TblAmrutprojectdetails { get; set; }

    public virtual DbSet<TblAmrutsummary> TblAmrutsummaries { get; set; }

    public virtual DbSet<TblApiSbm> TblApiSbms { get; set; }

    public virtual DbSet<TblApiSbmGfc> TblApiSbmGfcs { get; set; }

    public virtual DbSet<TblApiSbmOdf> TblApiSbmOdfs { get; set; }

    public virtual DbSet<TblLogin> TblLogins { get; set; }

    public virtual DbSet<TblMasterLgd> TblMasterLgds { get; set; }

    public virtual DbSet<TblNulmApiSepbeneficiary> TblNulmApiSepbeneficiaries { get; set; }

    public virtual DbSet<TblNulmApiSepgroup> TblNulmApiSepgroups { get; set; }

    public virtual DbSet<TblNulmApiSmidalf> TblNulmApiSmidalves { get; set; }

    public virtual DbSet<TblNulmApiSmidshg> TblNulmApiSmidshgs { get; set; }

    public virtual DbSet<TblNulmApiSuh> TblNulmApiSuhs { get; set; }

    public virtual DbSet<TblNulmApiSusvcov> TblNulmApiSusvcovs { get; set; }

    public virtual DbSet<TblPmay> TblPmays { get; set; }

    public virtual DbSet<TblPmsvanidhi> TblPmsvanidhis { get; set; }

    public virtual DbSet<TblSbmBacklog> TblSbmBacklogs { get; set; }

    public virtual DbSet<TblScm> TblScms { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAmrutprojectdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_amrutprojectdetail");

            entity.Property(e => e.Approvedcentralassistanceincr).HasColumnName("approvedcentralassistanceincr");
            entity.Property(e => e.Approvedcostincr).HasColumnName("approvedcostincr");
            entity.Property(e => e.District)
                .HasMaxLength(256)
                .HasColumnName("district");
            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.Projectcount).HasColumnName("projectcount");
            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.State)
                .HasMaxLength(256)
                .HasColumnName("state");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.Ulbname)
                .HasMaxLength(256)
                .HasColumnName("ulbname");
        });

        modelBuilder.Entity<TblAmrutsummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_amrutsummary");

            entity.Property(e => e.Approvedprojectcostincr).HasColumnName("approvedprojectcostincr");
            entity.Property(e => e.Approvedprojects).HasColumnName("approvedprojects");
            entity.Property(e => e.Centralassistanceapprovedincr).HasColumnName("centralassistanceapprovedincr");
            entity.Property(e => e.Centralassistanceoutlayincr).HasColumnName("centralassistanceoutlayincr");
            entity.Property(e => e.Contractawardedprojectcostincr).HasColumnName("contractawardedprojectcostincr");
            entity.Property(e => e.Contractawardedprojectcount).HasColumnName("contractawardedprojectcount");
            entity.Property(e => e.Dprapprovedprojectcostincr).HasColumnName("dprapprovedprojectcostincr");
            entity.Property(e => e.Dprapprovedprojectcount).HasColumnName("dprapprovedprojectcount");
            entity.Property(e => e.Nitissuedprojectcostincr).HasColumnName("nitissuedprojectcostincr");
            entity.Property(e => e.Nitissuedprojectcount).HasColumnName("nitissuedprojectcount");
            entity.Property(e => e.Projectcostincr).HasColumnName("projectcostincr");
            entity.Property(e => e.Projectcount).HasColumnName("projectcount");
            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Statename)
                .HasMaxLength(256)
                .HasColumnName("statename");
        });

        modelBuilder.Entity<TblApiSbm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_api_sbm");

            entity.Property(e => e.Districtcode).HasColumnName("districtcode");
            entity.Property(e => e.Districtname)
                .HasMaxLength(256)
                .HasColumnName("districtname");
            entity.Property(e => e.Generation).HasColumnName("generation");
            entity.Property(e => e.Lgdcode).HasColumnName("lgdcode");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Noofwards100perd2d).HasColumnName("noofwards100perd2d");
            entity.Property(e => e.Noofwards100perss).HasColumnName("noofwards100perss");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statename)
                .HasMaxLength(256)
                .HasColumnName("statename");
            entity.Property(e => e.Totalwards).HasColumnName("totalwards");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.Ulbname)
                .HasMaxLength(256)
                .HasColumnName("ulbname");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<TblApiSbmGfc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_api_sbm_gfc");

            entity.Property(e => e.District)
                .HasMaxLength(256)
                .HasColumnName("district");
            entity.Property(e => e.Districtid).HasColumnName("districtid");
            entity.Property(e => e.Gfcrating).HasColumnName("gfcrating");
            entity.Property(e => e.Lgdcode).HasColumnName("lgdcode");
            entity.Property(e => e.State)
                .HasMaxLength(256)
                .HasColumnName("state");
            entity.Property(e => e.Stateid).HasColumnName("stateid");
            entity.Property(e => e.Ulbid).HasColumnName("ulbid");
            entity.Property(e => e.Ulbname)
                .HasMaxLength(256)
                .HasColumnName("ulbname");
        });

        modelBuilder.Entity<TblApiSbmOdf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_api_sbm_odf");

            entity.Property(e => e.Certificate)
                .HasMaxLength(256)
                .HasColumnName("certificate");
            entity.Property(e => e.District)
                .HasMaxLength(256)
                .HasColumnName("district");
            entity.Property(e => e.Districtid).HasColumnName("districtid");
            entity.Property(e => e.Lgdcode).HasColumnName("lgdcode");
            entity.Property(e => e.State)
                .HasMaxLength(256)
                .HasColumnName("state");
            entity.Property(e => e.Stateid).HasColumnName("stateid");
            entity.Property(e => e.Ulb)
                .HasMaxLength(256)
                .HasColumnName("ulb");
            entity.Property(e => e.Ulbid).HasColumnName("ulbid");
        });

        modelBuilder.Entity<TblLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_login_pkey");

            entity.ToTable("tbl_login");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Confirmpassword)
                .HasMaxLength(255)
                .HasColumnName("confirmpassword");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .HasColumnName("designation");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Logindatetime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("logindatetime");
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.Sessionid)
                .HasMaxLength(255)
                .HasColumnName("sessionid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Studsessid)
                .HasMaxLength(255)
                .HasColumnName("studsessid");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.Userrole).HasColumnName("userrole");
            entity.Property(e => e.Usertype)
                .HasMaxLength(255)
                .HasColumnName("usertype");
        });

        modelBuilder.Entity<TblMasterLgd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_master_lgd");

            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblNulmApiSepbeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nulm_api_sepbeneficiary");

            entity.Property(e => e.BeneficiaryCode)
                .HasMaxLength(256)
                .HasColumnName("beneficiary_code");
            entity.Property(e => e.BeneficieryName)
                .HasMaxLength(256)
                .HasColumnName("beneficiery_name");
            entity.Property(e => e.CashCreditLimit).HasColumnName("cash_credit_limit");
            entity.Property(e => e.CclSanctionDate)
                .HasMaxLength(256)
                .HasColumnName("ccl_sanction_date");
            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.LoanSanctionedAmnt).HasColumnName("loan_sanctioned_amnt");
            entity.Property(e => e.LoanSanctionedDate)
                .HasMaxLength(256)
                .HasColumnName("loan_sanctioned_date");
            entity.Property(e => e.Mudraloantype)
                .HasMaxLength(256)
                .HasColumnName("mudraloantype");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblNulmApiSepgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nulm_api_sepgroup");

            entity.Property(e => e.CashCreditLimit).HasColumnName("cash_credit_limit");
            entity.Property(e => e.CclSanctionDate)
                .HasMaxLength(256)
                .HasColumnName("ccl_sanction_date");
            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(256)
                .HasColumnName("group_code");
            entity.Property(e => e.GroupName)
                .HasMaxLength(256)
                .HasColumnName("group_name");
            entity.Property(e => e.LoanSanctionedAmnt).HasColumnName("loan_sanctioned_amnt");
            entity.Property(e => e.LoanSanctionedDate)
                .HasMaxLength(256)
                .HasColumnName("loan_sanctioned_date");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblNulmApiSmidalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nulm_api_smidalf");

            entity.Property(e => e.AlfAddress)
                .HasMaxLength(256)
                .HasColumnName("alf_address");
            entity.Property(e => e.AlfCode)
                .HasMaxLength(256)
                .HasColumnName("alf_code");
            entity.Property(e => e.AlfContactno)
                .HasMaxLength(256)
                .HasColumnName("alf_contactno");
            entity.Property(e => e.AlfDof)
                .HasMaxLength(256)
                .HasColumnName("alf_dof");
            entity.Property(e => e.AlfName)
                .HasMaxLength(256)
                .HasColumnName("alf_name");
            entity.Property(e => e.Column1)
                .HasMaxLength(256)
                .HasColumnName("column1");
            entity.Property(e => e.DisbursedmentDate)
                .HasMaxLength(256)
                .HasColumnName("disbursedment_date");
            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.RfStatus)
                .HasMaxLength(256)
                .HasColumnName("rf_status");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblNulmApiSmidshg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nulm_api_smidshg");

            entity.Property(e => e.DisbursedmentDate)
                .HasMaxLength(256)
                .HasColumnName("disbursedment_date");
            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.RfStatus)
                .HasMaxLength(256)
                .HasColumnName("rf_status");
            entity.Property(e => e.ShgDof)
                .HasMaxLength(256)
                .HasColumnName("shg_dof");
            entity.Property(e => e.ShgGroupcode)
                .HasMaxLength(256)
                .HasColumnName("shg_groupcode");
            entity.Property(e => e.ShgName)
                .HasMaxLength(256)
                .HasColumnName("shg_name");
            entity.Property(e => e.ShgType)
                .HasMaxLength(256)
                .HasColumnName("shg_type");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblNulmApiSuh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nulm_api_suh");

            entity.Property(e => e.Address)
                .HasMaxLength(256)
                .HasColumnName("address");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.DistrictCode).HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.ShelterName)
                .HasMaxLength(256)
                .HasColumnName("shelter_name");
            entity.Property(e => e.Sheltersubtype)
                .HasMaxLength(256)
                .HasColumnName("sheltersubtype");
            entity.Property(e => e.Sheltertype)
                .HasMaxLength(256)
                .HasColumnName("sheltertype");
            entity.Property(e => e.StateCode).HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode).HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblNulmApiSusvcov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nulm_api_susvcov");

            entity.Property(e => e.CitySurvey)
                .HasMaxLength(256)
                .HasColumnName("city_survey");
            entity.Property(e => e.DistrictCode)
                .HasMaxLength(256)
                .HasColumnName("district_code");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(256)
                .HasColumnName("district_name");
            entity.Property(e => e.NoOfIdcardIssued)
                .HasMaxLength(256)
                .HasColumnName("no_of_idcard_issued");
            entity.Property(e => e.NoofVendorsMarketsCompleted)
                .HasMaxLength(256)
                .HasColumnName("noof_vendors_markets_completed");
            entity.Property(e => e.Novendingzone)
                .HasMaxLength(256)
                .HasColumnName("novendingzone");
            entity.Property(e => e.StateCode)
                .HasMaxLength(256)
                .HasColumnName("state_code");
            entity.Property(e => e.StateName)
                .HasMaxLength(256)
                .HasColumnName("state_name");
            entity.Property(e => e.UlbCode)
                .HasMaxLength(256)
                .HasColumnName("ulb_code");
            entity.Property(e => e.UlbName)
                .HasMaxLength(256)
                .HasColumnName("ulb_name");
        });

        modelBuilder.Entity<TblPmay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_pmay");

            entity.Property(e => e.Approveddate)
                .HasMaxLength(256)
                .HasColumnName("approveddate");
            entity.Property(e => e.Centralassistanceinvolved).HasColumnName("centralassistanceinvolved");
            entity.Property(e => e.Centralassistancereleased).HasColumnName("centralassistancereleased");
            entity.Property(e => e.Citycode).HasColumnName("citycode");
            entity.Property(e => e.Cityname)
                .HasMaxLength(256)
                .HasColumnName("cityname");
            entity.Property(e => e.Component)
                .HasMaxLength(256)
                .HasColumnName("component");
            entity.Property(e => e.Districtlgcode).HasColumnName("districtlgcode");
            entity.Property(e => e.Districtname)
                .HasMaxLength(256)
                .HasColumnName("districtname");
            entity.Property(e => e.Housesallotted).HasColumnName("housesallotted");
            entity.Property(e => e.Housescompleted).HasColumnName("housescompleted");
            entity.Property(e => e.Housesoccupied).HasColumnName("housesoccupied");
            entity.Property(e => e.Housesunderprogress).HasColumnName("housesunderprogress");
            entity.Property(e => e.Housesunoccupied).HasColumnName("housesunoccupied");
            entity.Property(e => e.Housesyettogrounded).HasColumnName("housesyettogrounded");
            entity.Property(e => e.Lgdcode).HasColumnName("lgdcode");
            entity.Property(e => e.Nameshittingmp)
                .HasMaxLength(256)
                .HasColumnName("nameshittingmp");
            entity.Property(e => e.Noofhouse).HasColumnName("noofhouse");
            entity.Property(e => e.Parlconstname)
                .HasMaxLength(256)
                .HasColumnName("parlconstname");
            entity.Property(e => e.Projectcost).HasColumnName("projectcost");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statename)
                .HasMaxLength(256)
                .HasColumnName("statename");
            entity.Property(e => e.Ucreceived).HasColumnName("ucreceived");
        });

        modelBuilder.Entity<TblPmsvanidhi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_pmsvanidhi");

            entity.Property(e => e.Datapulledon)
                .HasMaxLength(256)
                .HasColumnName("datapulledon");
            entity.Property(e => e.Firsttermdisbursedamount).HasColumnName("firsttermdisbursedamount");
            entity.Property(e => e.Firsttermdisbursedcount).HasColumnName("firsttermdisbursedcount");
            entity.Property(e => e.Firsttermeligibleapplicationcount).HasColumnName("firsttermeligibleapplicationcount");
            entity.Property(e => e.Firsttermineligiblecount).HasColumnName("firsttermineligiblecount");
            entity.Property(e => e.Firsttermreturnedcount).HasColumnName("firsttermreturnedcount");
            entity.Property(e => e.Firsttermsanctionedamount).HasColumnName("firsttermsanctionedamount");
            entity.Property(e => e.Firsttermtotalsanctionedcount).HasColumnName("firsttermtotalsanctionedcount");
            entity.Property(e => e.Localbodycode).HasColumnName("localbodycode");
            entity.Property(e => e.Secondtermdisbursedamount).HasColumnName("secondtermdisbursedamount");
            entity.Property(e => e.Secondtermdisbursedcount).HasColumnName("secondtermdisbursedcount");
            entity.Property(e => e.Secondtermeligibleapplicationcount).HasColumnName("secondtermeligibleapplicationcount");
            entity.Property(e => e.Secondtermineligiblecount).HasColumnName("secondtermineligiblecount");
            entity.Property(e => e.Secondtermreturnedcount).HasColumnName("secondtermreturnedcount");
            entity.Property(e => e.Secondtermsanctionedamount).HasColumnName("secondtermsanctionedamount");
            entity.Property(e => e.Secondtermtotalsanctionedcount).HasColumnName("secondtermtotalsanctionedcount");
            entity.Property(e => e.Statecode).HasColumnName("statecode");
            entity.Property(e => e.Statename)
                .HasMaxLength(256)
                .HasColumnName("statename");
            entity.Property(e => e.Thirdtermdisbursedamount).HasColumnName("thirdtermdisbursedamount");
            entity.Property(e => e.Thirdtermdisbursedcount).HasColumnName("thirdtermdisbursedcount");
            entity.Property(e => e.Thirdtermeligibleapplicationcount).HasColumnName("thirdtermeligibleapplicationcount");
            entity.Property(e => e.Thirdtermineligiblecount).HasColumnName("thirdtermineligiblecount");
            entity.Property(e => e.Thirdtermreturnedcount).HasColumnName("thirdtermreturnedcount");
            entity.Property(e => e.Thirdtermsanctionedamount).HasColumnName("thirdtermsanctionedamount");
            entity.Property(e => e.Thirdtermtotalsanctionedcount).HasColumnName("thirdtermtotalsanctionedcount");
            entity.Property(e => e.Ulbname)
                .HasMaxLength(256)
                .HasColumnName("ulbname");
        });

        modelBuilder.Entity<TblSbmBacklog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_sbm_backlog");

            entity.Property(e => e.Censuscode).HasColumnName("censuscode");
            entity.Property(e => e.Districtname)
                .HasMaxLength(256)
                .HasColumnName("districtname");
            entity.Property(e => e.Generationmtd).HasColumnName("generationmtd");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Processedmtd).HasColumnName("processedmtd");
            entity.Property(e => e.Statename)
                .HasMaxLength(256)
                .HasColumnName("statename");
            entity.Property(e => e.Swmid).HasColumnName("swmid");
            entity.Property(e => e.Totalwards).HasColumnName("totalwards");
            entity.Property(e => e.Ulbcode).HasColumnName("ulbcode");
            entity.Property(e => e.Ulbname)
                .HasMaxLength(256)
                .HasColumnName("ulbname");
            entity.Property(e => e.Wardswith100percentd2dcollection).HasColumnName("wardswith100percentd2dcollection");
            entity.Property(e => e.Wardswith100percentsourcesegregation).HasColumnName("wardswith100percentsourcesegregation");
            entity.Property(e => e.Wasteprocessingprecentage)
                .HasMaxLength(256)
                .HasColumnName("wasteprocessingprecentage");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<TblScm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_scm");

            entity.Property(e => e.ActualDateOfProjectCompleti)
                .HasMaxLength(65535)
                .HasColumnName("actual_date_of_project_completi");
            entity.Property(e => e.ActualDateOfProjectStart)
                .HasMaxLength(65535)
                .HasColumnName("actual_date_of_project_start");
            entity.Property(e => e.Bonds).HasColumnName("bonds");
            entity.Property(e => e.Category)
                .HasMaxLength(65535)
                .HasColumnName("category");
            entity.Property(e => e.CityName)
                .HasMaxLength(65535)
                .HasColumnName("city_name");
            entity.Property(e => e.ConvergenceWithOtherMissions).HasColumnName("convergence_with_other_missions");
            entity.Property(e => e.Debt).HasColumnName("debt");
            entity.Property(e => e.FinancialProgress)
                .HasMaxLength(65535)
                .HasColumnName("financial_progress");
            entity.Property(e => e.GeometryX).HasColumnName("geometry_x");
            entity.Property(e => e.GeometryY).HasColumnName("geometry_y");
            entity.Property(e => e.InternalCategory)
                .HasMaxLength(65535)
                .HasColumnName("internal_category");
            entity.Property(e => e.Isdeleted)
                .HasMaxLength(65535)
                .HasColumnName("isdeleted");
            entity.Property(e => e.Loans).HasColumnName("loans");
            entity.Property(e => e.Milestone)
                .HasMaxLength(65535)
                .HasColumnName("milestone");
            entity.Property(e => e.Objectid).HasColumnName("objectid");
            entity.Property(e => e.OtherSources).HasColumnName("other_sources");
            entity.Property(e => e.OwnResources).HasColumnName("own_resources");
            entity.Property(e => e.PId)
                .HasMaxLength(65535)
                .HasColumnName("p_id");
            entity.Property(e => e.PhysicalProgress)
                .HasMaxLength(65535)
                .HasColumnName("physical_progress");
            entity.Property(e => e.Ppp).HasColumnName("ppp");
            entity.Property(e => e.PrjCost).HasColumnName("prj_cost");
            entity.Property(e => e.ProjectEndDate)
                .HasMaxLength(65535)
                .HasColumnName("project_end_date");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(65535)
                .HasColumnName("project_name");
            entity.Property(e => e.Scm).HasColumnName("scm");
            entity.Property(e => e.StateName)
                .HasMaxLength(65535)
                .HasColumnName("state_name");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalWo).HasColumnName("total_wo");
            entity.Property(e => e.Utilization).HasColumnName("utilization");
            entity.Property(e => e.ValueTotal).HasColumnName("value_total");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
