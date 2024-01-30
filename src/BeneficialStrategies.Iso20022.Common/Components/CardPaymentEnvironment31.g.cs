﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment31.  ISO2002 ID# _1GvAoVOZEeO1RfnvbrvgKg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
public partial record CardPaymentEnvironment31
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    public required Acquirer2 Acquirer { get; init; } 
    /// <summary>
    /// Indicates if the acquirer is available to perform payment transactions.
    /// </summary>
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; } 
    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    public GenericIdentification32? MerchantIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    public GenericIdentification32? POIIdentification { get; init; } 
    
    #nullable disable
}
