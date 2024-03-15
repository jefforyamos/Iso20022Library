﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount46.  ISO2002 ID# _NB8LcSLxEeS91KOsP2gZVg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_NB8LcSLxEeS91KOsP2gZVg")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount46
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccount46 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccount46( AccountIdentification1 reqIdentification,AccountStatus2Code reqStatus,OwnershipType1Choice_ reqOwnershipType )
    {
        Identification = reqIdentification;
        Status = reqStatus;
        OwnershipType = reqOwnershipType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Nb-cGSLxEeS91KOsP2gZVg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification1 Identification { get; init; } 
    #else
    public AccountIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the current state of an account, for example, enabled or deleted.
    /// </summary>
    [IsoId("_Nb-cGyLxEeS91KOsP2gZVg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatus2Code Status { get; init; } 
    #else
    public AccountStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_Nb-cHSLxEeS91KOsP2gZVg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_Nb-cHyLxEeS91KOsP2gZVg")]
    [DisplayName("Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsgnt")]
    #endif
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Designation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Designation { get; init; } 
    #else
    public System.String? Designation { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, for example, wrapper, ISA.
    /// </summary>
    [IsoId("_Nb-cISLxEeS91KOsP2gZVg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountType1Choice_? Type { get; init; } 
    #else
    public AccountType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Ownership status of the account, for example, joint owners.
    /// </summary>
    [IsoId("_Nb-cIyLxEeS91KOsP2gZVg")]
    [DisplayName("Ownership Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrshTp")]
    #endif
    [IsoXmlTag("OwnrshTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OwnershipType1Choice_ OwnershipType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OwnershipType1Choice_ OwnershipType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OwnershipType1Choice_ OwnershipType { get; init; } 
    #else
    public OwnershipType1Choice_ OwnershipType { get; set; } 
    #endif
    
    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_Nb-cJSLxEeS91KOsP2gZVg")]
    [DisplayName("Tax Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxXmptn")]
    #endif
    [IsoXmlTag("TaxXmptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxExemptionReason1Choice_? TaxExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptionReason1Choice_? TaxExemption { get; init; } 
    #else
    public TaxExemptionReason1Choice_? TaxExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency at which a statement is issued.
    /// </summary>
    [IsoId("_Nb-cJyLxEeS91KOsP2gZVg")]
    [DisplayName("Statement Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtFrqcy")]
    #endif
    [IsoXmlTag("StmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementFrequencyReason1Choice_? StatementFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyReason1Choice_? StatementFrequency { get; init; } 
    #else
    public StatementFrequencyReason1Choice_? StatementFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_Nb-cKSLxEeS91KOsP2gZVg")]
    [DisplayName("Reference Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefCcy")]
    #endif
    [IsoXmlTag("RefCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? ReferenceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ReferenceCurrency { get; init; } 
    #else
    public string? ReferenceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_Nb-cKyLxEeS91KOsP2gZVg")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_Nb-cLSLxEeS91KOsP2gZVg")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference1Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference1Code? IncomePreference { get; init; } 
    #else
    public IncomePreference1Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies, for income on the fund that is to be reinvested, parameters for the reinvestment. If the reinvestment percentage is less than one hundred percent, the remaining percentage will be invested according to the investor’s subsequent instructions.
    /// </summary>
    [IsoId("_Nb-cLyLxEeS91KOsP2gZVg")]
    [DisplayName("Reinvestment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtDtls")]
    #endif
    [IsoXmlTag("RinvstmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reinvestment1? ReinvestmentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reinvestment1? ReinvestmentDetails { get; init; } 
    #else
    public Reinvestment1? ReinvestmentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_Nb-cMSLxEeS91KOsP2gZVg")]
    [DisplayName("Tax Withholding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxWhldgMtd")]
    #endif
    [IsoXmlTag("TaxWhldgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; init; } 
    #else
    public TaxWithholdingMethod2Code? TaxWithholdingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the letter of intent.
    /// </summary>
    [IsoId("_Nb-cMyLxEeS91KOsP2gZVg")]
    [DisplayName("Letter Intent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrInttDtls")]
    #endif
    [IsoXmlTag("LttrInttDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LetterIntent1? LetterIntentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LetterIntent1? LetterIntentDetails { get; init; } 
    #else
    public LetterIntent1? LetterIntentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_Nb-cNSLxEeS91KOsP2gZVg")]
    [DisplayName("Accumulation Right Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltnRghtRef")]
    #endif
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccumulationRightReference { get; init; } 
    #else
    public System.String? AccumulationRightReference { get; set; } 
    #endif
    
    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_Nb-cNyLxEeS91KOsP2gZVg")]
    [DisplayName("Required Signatories Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdSgntriesNb")]
    #endif
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RequiredSignatoriesNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RequiredSignatoriesNumber { get; init; } 
    #else
    public System.UInt64? RequiredSignatoriesNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_Nb-cOSLxEeS91KOsP2gZVg")]
    [DisplayName("Fund Family Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndFmlyNm")]
    #endif
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FundFamilyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundFamilyName { get; init; } 
    #else
    public System.String? FundFamilyName { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_Nb-cOyLxEeS91KOsP2gZVg")]
    [DisplayName("Rounding Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgDtls")]
    #endif
    [IsoXmlTag("RndgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingParameters1? RoundingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingParameters1? RoundingDetails { get; init; } 
    #else
    public RoundingParameters1? RoundingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Nb-cPSLxEeS91KOsP2gZVg")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_Nb-cPyLxEeS91KOsP2gZVg")]
    [DisplayName("Funds Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndsDtls")]
    #endif
    [IsoXmlTag("FndsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument29? FundsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument29? FundsDetails { get; init; } 
    #else
    public FinancialInstrument29? FundsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_Nb-cQSLxEeS91KOsP2gZVg")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<CashAccount12> CashAccount { get; init; } = new ValueList<CashAccount12>(){};
    
    /// <summary>
    /// Part of the investment account to or from which securities entries are made.
    /// </summary>
    [IsoId("_Nb-cQyLxEeS91KOsP2gZVg")]
    [DisplayName("Securities Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcct")]
    #endif
    [IsoXmlTag("SctiesAcct")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<SecuritiesAccount4> SecuritiesAccount { get; init; } = new ValueList<SecuritiesAccount4>(){};
    
    /// <summary>
    /// Specifies information about blocked accounts.
    /// </summary>
    [IsoId("_Nb-cRSLxEeS91KOsP2gZVg")]
    [DisplayName("Blocked Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdSts")]
    #endif
    [IsoXmlTag("BlckdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Blocked1? BlockedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Blocked1? BlockedStatus { get; init; } 
    #else
    public Blocked1? BlockedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of usage of the account.
    /// </summary>
    [IsoId("_Nb-cRyLxEeS91KOsP2gZVg")]
    [DisplayName("Account Usage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctUsgTp")]
    #endif
    [IsoXmlTag("AcctUsgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountUsageType1Choice_? AccountUsageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountUsageType1Choice_? AccountUsageType { get; init; } 
    #else
    public AccountUsageType1Choice_? AccountUsageType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if documentary evidence has been provided for the foreign resident.
    /// </summary>
    [IsoId("_Nb-cSSLxEeS91KOsP2gZVg")]
    [DisplayName("Foreign Status Certification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnStsCertfctn")]
    #endif
    [IsoXmlTag("FrgnStsCertfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Provided1Code? ForeignStatusCertification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Provided1Code? ForeignStatusCertification { get; init; } 
    #else
    public Provided1Code? ForeignStatusCertification { get; set; } 
    #endif
    
    /// <summary>
    /// Date the investor signs the open account form.
    /// </summary>
    [IsoId("_Nb-cSyLxEeS91KOsP2gZVg")]
    [DisplayName("Account Signature Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSgntrDtTm")]
    #endif
    [IsoXmlTag("AcctSgntrDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? AccountSignatureDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means by which the investor submits the open account form.
    /// </summary>
    [IsoId("_Nb-cTSLxEeS91KOsP2gZVg")]
    [DisplayName("Transaction Channel Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxChanlTp")]
    #endif
    [IsoXmlTag("TxChanlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    #else
    public TransactionChannelType1Choice_? TransactionChannelType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the category of the investment account.
    /// </summary>
    [IsoId("_Nb-cTyLxEeS91KOsP2gZVg")]
    [DisplayName("Investment Account Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctCtgy")]
    #endif
    [IsoXmlTag("InvstmtAcctCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; init; } 
    #else
    public InvestmentAccountCategory1Choice_? InvestmentAccountCategory { get; set; } 
    #endif
    
    
    #nullable disable
    
}
