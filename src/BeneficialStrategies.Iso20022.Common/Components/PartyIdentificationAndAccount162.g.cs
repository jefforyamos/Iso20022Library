﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount162.  ISO2002 ID# _z0KCO7XEEeiTob_PrFFUxA.
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
/// Provides information about identification and account of the party.
/// </summary>
[IsoId("_z0KCO7XEEeiTob_PrFFUxA")]
[DisplayName("Party Identification And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount162
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndAccount162 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndAccount162( PartyIdentification120Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_0GJxFbXEEeiTob_PrFFUxA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification120Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification120Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_ Identification { get; init; } 
    #else
    public PartyIdentification120Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_0GJxHbXEEeiTob_PrFFUxA")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_0GJxJbXEEeiTob_PrFFUxA")]
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
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_0GJxLbXEEeiTob_PrFFUxA")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification7? AlternateIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
