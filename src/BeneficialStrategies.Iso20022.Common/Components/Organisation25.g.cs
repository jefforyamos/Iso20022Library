﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation25.  ISO2002 ID# _oze7gY0QEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant performing the transaction.
/// </summary>
public partial record Organisation25
{
    #nullable enable
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    public GenericIdentification32? Identification { get; init; } 
    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    public IsoMax70Text? CommonName { get; init; } 
    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    public LocationCategory1Code? LocationCategory { get; init; } 
    /// <summary>
    /// Location and contact information of the merchant performing the transaction.
    /// </summary>
    public CommunicationAddress5? LocationAndContact { get; init; } 
    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    public IsoMax140Text? SchemeData { get; init; } 
    
    #nullable disable
}
