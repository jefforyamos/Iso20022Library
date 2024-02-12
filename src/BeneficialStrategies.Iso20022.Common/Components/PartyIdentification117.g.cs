﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification117.  ISO2002 ID# _FOOTEY-1Eeaoj_JbcpWKgg.
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
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
[IsoId("_FOOTEY-1Eeaoj_JbcpWKgg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Party Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification117
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification117 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification117( System.String reqAnyBIC,GenericIdentification36 reqProprietaryIdentification )
    {
        AnyBIC = reqAnyBIC;
        ProprietaryIdentification = reqProprietaryIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    [IsoId("_FevbUY-1Eeaoj_JbcpWKgg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Any BIC")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICDec2014Identifier AnyBIC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String AnyBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AnyBIC { get; init; } 
    #else
    public System.String AnyBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_FevbU4-1Eeaoj_JbcpWKgg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proprietary Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification36 ProprietaryIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification36 ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36 ProprietaryIdentification { get; init; } 
    #else
    public GenericIdentification36 ProprietaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    [IsoId("_FevbVY-1Eeaoj_JbcpWKgg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name And Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress13? NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress13? NameAndAddress { get; init; } 
    #else
    public NameAndAddress13? NameAndAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
