﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary43.  ISO2002 ID# _VT_kAW1NEeiqaPNRWUnGNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
public partial record Intermediary43
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    public required PartyIdentification139 Identification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public Account27? Account { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public IRole4Choice? Role { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    public ContactIdentification2? ContactPerson { get; init; } 
    
    #nullable disable
}
