﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConfirmationPartyDetails2.  ISO2002 ID# _ATv35dokEeC60axPepSq7g_1662656387.
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
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_ATv35dokEeC60axPepSq7g_1662656387")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Confirmation Party Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConfirmationPartyDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ConfirmationPartyDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ConfirmationPartyDetails2( PartyIdentification32Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun & Bradstreet Identification.
    /// </summary>
    [IsoId("_AT5o4NokEeC60axPepSq7g_1548817321")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification32Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification32Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32Choice_ Identification { get; init; } 
    #else
    public PartyIdentification32Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_AT5o4dokEeC60axPepSq7g_665584034")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Alternate Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification5? AlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_AT5o4tokEeC60axPepSq7g_-1328560672")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcessingIdentification { get; init; } 
    #else
    public System.String? ProcessingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_AT5o49okEeC60axPepSq7g_1969334271")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyTextInformation5? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyTextInformation5? AdditionalInformation { get; init; } 
    #else
    public PartyTextInformation5? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Capacity of customer placing the order. Primarily used by futures exchanges to indicate the CTI code (customer type indicator) as required by the US CFTC (Commodity Futures Trading Commission).
    /// </summary>
    [IsoId("_AT5o5NokEeC60axPepSq7g_972261918")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investor Capacity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorCapacity3Choice_? InvestorCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorCapacity3Choice_? InvestorCapacity { get; init; } 
    #else
    public InvestorCapacity3Choice_? InvestorCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Capacity of customer placing the order. Primarily used by futures exchanges to indicate the CTI code (customer type indicator) as required by the US CFTC (Commodity Futures Trading Commission).
    /// </summary>
    [IsoId("_AT5o5dokEeC60axPepSq7g_-24810435")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trading Party Capacity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingPartyCapacity1Choice_? TradingPartyCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingPartyCapacity1Choice_? TradingPartyCapacity { get; init; } 
    #else
    public TradingPartyCapacity1Choice_? TradingPartyCapacity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
