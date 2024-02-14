﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount78.  ISO2002 ID# _APRnktokEeC60axPepSq7g_-1228300605.
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
/// Party and account details.
/// </summary>
[IsoId("_APRnktokEeC60axPepSq7g_-1228300605")]
[DisplayName("Party Identification And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount78
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndAccount78 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndAccount78( PartyIdentification32Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_APRnk9okEeC60axPepSq7g_-1342139671")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification32Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification32Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32Choice_ Identification { get; init; } 
    #else
    public PartyIdentification32Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_APRnlNokEeC60axPepSq7g_1955755272")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification5? AlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_APRnldokEeC60axPepSq7g_-264334851")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSide1Code? Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSide1Code? Side { get; init; } 
    #else
    public ClearingSide1Code? Side { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the clearing member account at the CCP through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_APbYkNokEeC60axPepSq7g_1035721620")]
    [DisplayName("Clearing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcct")]
    #endif
    [IsoXmlTag("ClrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount20? ClearingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount20? ClearingAccount { get; init; } 
    #else
    public SecuritiesAccount20? ClearingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_APbYkdokEeC60axPepSq7g_-1573255774")]
    [DisplayName("Processing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgId")]
    #endif
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcessingIdentification { get; init; } 
    #else
    public System.String? ProcessingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_APbYktokEeC60axPepSq7g_1724639169")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    #else
    public PartyTextInformation1? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
