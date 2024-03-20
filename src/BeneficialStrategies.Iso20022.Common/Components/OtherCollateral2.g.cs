﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherCollateral2.  ISO2002 ID# _Yy_0kV9_EeSMgPeFpRHeJw.
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
/// Provides details about the letter of credit or bank guarantee, or other collateral, posted as collateral.
/// </summary>
[IsoId("_Yy_0kV9_EeSMgPeFpRHeJw")]
[DisplayName("Other Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherCollateral2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherCollateral2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherCollateral2( ActiveCurrencyAndAmount reqCollateralValue )
    {
        CollateralValue = reqCollateralValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_dSzFAG8HEeSo8eobdW7kLw")]
    [DisplayName("Collateral Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollId")]
    #endif
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralIdentification { get; init; } 
    #else
    public System.String? CollateralIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the unique identification of the letter of credit.
    /// </summary>
    [IsoId("_Z1A_wGtHEeSbWPR2J8BFBg")]
    [DisplayName("Letter Of Credit Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfCdtId")]
    #endif
    [IsoXmlTag("LttrOfCdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LetterOfCreditIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LetterOfCreditIdentification { get; init; } 
    #else
    public System.String? LetterOfCreditIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    [IsoId("_ZO008V9_EeSMgPeFpRHeJw")]
    [DisplayName("Letter Of Credit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfCdtAmt")]
    #endif
    [IsoXmlTag("LttrOfCdtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    [IsoId("_ZO00819_EeSMgPeFpRHeJw")]
    [DisplayName("Guarantee Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntAmt")]
    #endif
    [IsoXmlTag("GrntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a description and an amount of another type of collateral.
    /// </summary>
    [IsoId("_ZO009V9_EeSMgPeFpRHeJw")]
    [DisplayName("Other Type Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTpOfColl")]
    #endif
    [IsoXmlTag("OthrTpOfColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; init; } 
    #else
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the other collateral was issued.
    /// </summary>
    [IsoId("_ZO00919_EeSMgPeFpRHeJw")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat14Choice_? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat14Choice_? IssueDate { get; init; } 
    #else
    public DateFormat14Choice_? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the other collateral expires.
    /// </summary>
    [IsoId("_ZO00-V9_EeSMgPeFpRHeJw")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    #else
    public DateFormat14Choice_? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the collateral deposited in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_SrSO4GtFEeSbWPR2J8BFBg")]
    [DisplayName("Limited Coverage Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdCvrgInd")]
    #endif
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedCoverageIndicator { get; init; } 
    #else
    public System.String? LimitedCoverageIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    [IsoId("_ZO00-19_EeSMgPeFpRHeJw")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification33Choice_? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification33Choice_? Issuer { get; init; } 
    #else
    public PartyIdentification33Choice_? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation date of the other collateral when it was taken as collateral.
    /// </summary>
    [IsoId("_ZO00_V9_EeSMgPeFpRHeJw")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_ZO00_19_EeSMgPeFpRHeJw")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_ZO01AV9_EeSMgPeFpRHeJw")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_ZO01A19_EeSMgPeFpRHeJw")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    [IsoId("_ZO01BV9_EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollVal")]
    #endif
    [IsoXmlTag("CollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount CollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Bfb6UGA2EeSMf75YyPqG7w")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_VW3XwGA2EeSMf75YyPqG7w")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
