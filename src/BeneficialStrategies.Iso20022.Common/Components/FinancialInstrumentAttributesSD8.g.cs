﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributesSD8.  ISO2002 ID# _Z4b8UV2qEeOb__BffbPEig.
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
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_Z4b8UV2qEeOb__BffbPEig")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributesSD8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributesSD8( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_aRumEV2qEeOb__BffbPEig")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the security was issued.
    /// </summary>
    [IsoId("_aRumE12qEeOb__BffbPEig")]
    [DisplayName("Country Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfListg")]
    #endif
    [IsoXmlTag("CtryOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfListing { get; init; } 
    #else
    public string? CountryOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Country of source income for the security.
    /// </summary>
    [IsoId("_aRumG12qEeOb__BffbPEig")]
    [DisplayName("Income Source Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmSrcCtry")]
    #endif
    [IsoXmlTag("IncmSrcCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? IncomeSourceCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? IncomeSourceCountry { get; init; } 
    #else
    public string? IncomeSourceCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_aRumI12qEeOb__BffbPEig")]
    [DisplayName("DTC Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCAsstClss")]
    #endif
    [IsoXmlTag("DTCAsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClass1Code? DTCAssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClass1Code? DTCAssetClass { get; init; } 
    #else
    public AssetClass1Code? DTCAssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Further classification of instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_aRumK12qEeOb__BffbPEig")]
    [DisplayName("DTC Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCAsstTp")]
    #endif
    [IsoXmlTag("DTCAsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAssetType1Code? DTCAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAssetType1Code? DTCAssetType { get; init; } 
    #else
    public DTCAssetType1Code? DTCAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security is eligible for holding at DTC.
    /// </summary>
    [IsoId("_aRumM12qEeOb__BffbPEig")]
    [DisplayName("Security Eligibility Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyElgbltyInd")]
    #endif
    [IsoXmlTag("SctyElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SecurityEligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityEligibilityIndicator { get; init; } 
    #else
    public System.String? SecurityEligibilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Ticket symbol for the event security (underlying security).
    /// </summary>
    [IsoId("_aRumO12qEeOb__BffbPEig")]
    [DisplayName("Ticker Symbol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TckrSymb")]
    #endif
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TickerSymbol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TickerSymbol { get; init; } 
    #else
    public System.String? TickerSymbol { get; set; } 
    #endif
    
    /// <summary>
    /// Security whose characteristics mirror the event security for purposes of FCP eligibility and tax relief. Certain derivative securities like HOLDR may have certain events where the source of payments are from an underlying security.
    /// </summary>
    [IsoId("_aRumQ12qEeOb__BffbPEig")]
    [DisplayName("Linked Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdScty")]
    #endif
    [IsoXmlTag("LkdScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification15? LinkedSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15? LinkedSecurity { get; init; } 
    #else
    public SecurityIdentification15? LinkedSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_odHGsF2qEeOb__BffbPEig")]
    [DisplayName("Originating Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtgSctyId")]
    #endif
    [IsoXmlTag("OrgtgSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    #else
    public OtherIdentification2? OriginatingSecurityIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
