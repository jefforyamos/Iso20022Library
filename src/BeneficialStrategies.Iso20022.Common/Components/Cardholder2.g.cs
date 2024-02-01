﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cardholder2.  ISO2002 ID# _SqbqzAEcEeCQm6a_G2yO_w_912220241.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the cardholder.
/// </summary>
public partial record Cardholder2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    public CardholderIdentification1[] Identification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    public IsoMax45Text? Name { get; init; } 
    /// <summary>
    /// Data related to the authentication of the cardholder.
    /// </summary>
    public CardholderAuthentication2[] Authentication { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Numeric characters of the cardholder's address for verification.
    /// </summary>
    public AddressVerification1? AddressVerification { get; init; } 
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    public IsoMax70Text? PersonalData { get; init; } 
    
    #nullable disable
}
