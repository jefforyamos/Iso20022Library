﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CutOffData1.  ISO2002 ID# _dxXmUJXXEeaYkf5FCqYMeA.
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
/// Contains the new, current and previous cut offs for a netting cut off held at the central system.
/// </summary>
[IsoId("_dxXmUJXXEeaYkf5FCqYMeA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cut Off Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CutOffData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CutOffData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CutOffData1( PartyIdentification73Choice_ reqParticipantIdentification )
    {
        ParticipantIdentification = reqParticipantIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_d1TS4ZnvEeahw7LV9elg3w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Participant Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification73Choice_ ParticipantIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification73Choice_ ParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_ ParticipantIdentification { get; init; } 
    #else
    public PartyIdentification73Choice_ ParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_dNmEkJntEeaKH-pm9fIa8w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Netting Cut Off Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public NettingCutOff1? NettingCutOffDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _dNmEkJntEeaKH-pm9fIa8w
    
    
    #nullable disable
    
}
