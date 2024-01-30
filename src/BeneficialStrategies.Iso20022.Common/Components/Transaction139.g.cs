﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction139.  ISO2002 ID# _K1XcwYzHEeujJfnIQ4NlpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
public partial record Transaction139
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    public AdditionalFee2? AdditionalFee { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
