﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMContext1.  ISO2002 ID# _qoQ9kIofEeSirOZJBRz_nA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed.
/// </summary>
[DataContract]
[XmlType]
public partial record ATMContext1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [DataMember]
    public IsoMax35Text? SessionReference { get; init; } 
    /// <summary>
    /// Withdrawal service provided by the ATM inside the session.
    /// </summary>
    [DataMember]
    public ATMService1? Service { get; init; } 
    
    #nullable disable
}
