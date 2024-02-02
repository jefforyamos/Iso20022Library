﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccount206.  ISO2002 ID# _vO6vwdASEeuSBa1PsnseFg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[DataContract]
[XmlType]
public partial record CashAccount206
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DataMember]
    public required AccountIdentificationAndName7 AccountIdentification { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [DataMember]
    public IsoAnyBICDec2014Identifier? Servicer { get; init; } 
    /// <summary>
    /// Additional means of identification of the account, as designated by the account servicer in agreement with the account owner.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountTypeDescription { get; init; } 
    
    #nullable disable
}
