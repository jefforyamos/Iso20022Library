﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD4.  ISO2002 ID# _1dzicDL3EeKU9IrkkToqcw_-1985913164.
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
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_1dzicDL3EeKU9IrkkToqcw_-1985913164")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionSD4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionSD4( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1dzicTL3EeKU9IrkkToqcw_1311981779")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place And Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// New par value of a security.
    /// </summary>
    [IsoId("_1dzicjL3EeKU9IrkkToqcw_-1252990966")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("New Par Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? NewParValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NewParValue { get; init; } 
    #else
    public System.Decimal? NewParValue { get; set; } 
    #endif
    
    /// <summary>
    /// Old par value of the event security represents the previously established par value that has changed in par value event. Used in combination with new par value element to represent the difference.
    /// </summary>
    [IsoId("_1dziczL3EeKU9IrkkToqcw_1931064911")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Old Par Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? OldParValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OldParValue { get; init; } 
    #else
    public System.Decimal? OldParValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event agent is charging a cancellation and or issuance fee upon the exchange of securities.
    /// </summary>
    [IsoId("_1dzidDL3EeKU9IrkkToqcw_-1824148456")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Fee Required Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExchangeFeeRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangeFeeRequiredFlag { get; init; } 
    #else
    public System.String? ExchangeFeeRequiredFlag { get; set; } 
    #endif
    
    /// <summary>
    /// GCA VS-specific flag that indicates whether a composite record has been generated as a result of custodian information that has not yet been confirmed in the market.
    /// </summary>
    [IsoId("_1dzidTL3EeKU9IrkkToqcw_166643569")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Custodian Shell Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CustodianShellFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustodianShellFlag { get; init; } 
    #else
    public System.String? CustodianShellFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer requires a holder to present the entire account balance in order to be eligible for the offer.
    /// </summary>
    [IsoId("_1dzidjL3EeKU9IrkkToqcw_512871924")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Must All Shares Be Submitted Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MustAllSharesBeSubmittedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MustAllSharesBeSubmittedFlag { get; init; } 
    #else
    public System.String? MustAllSharesBeSubmittedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the lottery that has been drawn as a part of the corporate action event.
    /// </summary>
    [IsoId("_1d8sYDL3EeKU9IrkkToqcw_-643503849")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lottery Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD6? LotteryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD6? LotteryDetails { get; init; } 
    #else
    public CorporateActionSD6? LotteryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the dividend as whole or in part qualifies for lower/ favourable tax rate.
    /// </summary>
    [IsoId("_1d8sYTL3EeKU9IrkkToqcw_-308326275")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Qualified Dividend Tax Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; init; } 
    #else
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the company that will remain (possibly a new name), usually designated after a merger.
    /// </summary>
    [IsoId("_1d8sYjL3EeKU9IrkkToqcw_-1163046817")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Surviving Company")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SurvivingCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SurvivingCompany { get; init; } 
    #else
    public System.String? SurvivingCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates when all or part of the distribution is paid from foreign sourced income of the issuer.
    /// </summary>
    [IsoId("_1d8sYzL3EeKU9IrkkToqcw_1468724564")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Foreign Income Source Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ForeignIncomeSourceFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForeignIncomeSourceFlag { get; init; } 
    #else
    public System.String? ForeignIncomeSourceFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
