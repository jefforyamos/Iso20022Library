﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingNonExtensionStatusAdvice1.  ISO2002 ID# _-GdIZ3ltEeG7BsjMvd1mEw_177542708.
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
/// Details of a non-extension advice.
/// </summary>
[IsoId("_-GdIZ3ltEeG7BsjMvd1mEw_177542708")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Undertaking Non Extension Status Advice")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingNonExtensionStatusAdvice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingNonExtensionStatusAdvice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingNonExtensionStatusAdvice1( PartyIdentification43 reqNotifyingParty,Undertaking7 reqUndertakingIdentification )
    {
        NotifyingParty = reqNotifyingParty;
        UndertakingIdentification = reqUndertakingIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the notifying party.
    /// </summary>
    [IsoId("_-GdIaHltEeG7BsjMvd1mEw_313669436")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notifying Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 NotifyingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification43 NotifyingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 NotifyingParty { get; init; } 
    #else
    public PartyIdentification43 NotifyingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Gm5YHltEeG7BsjMvd1mEw_1749872346")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Undertaking Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking7 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Undertaking7 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking7 UndertakingIdentification { get; init; } 
    #else
    public Undertaking7 UndertakingIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
