﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCurrencyConversionResponse5.  ISO2002 ID# _Qg_mQdtZEee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency conversion outcome from the service provider.
/// </summary>
[DataContract]
[XmlType]
public partial record AcceptorCurrencyConversionResponse5
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment69 Environment { get; init; } 
    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction77 Transaction { get; init; } 
    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [DataMember]
    public required CurrencyConversion16 CurrencyConversionResult { get; init; } 
    
    #nullable disable
}
