﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMExceptionAcknowledgement1.  ISO2002 ID# _slQhsK5GEeWCgYcWSNgX5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM exception.
/// </summary>
[DataContract]
[XmlType]
public partial record ATMExceptionAcknowledgement1
{
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [DataMember]
    public required AutomatedTellerMachine3 ATM { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed, if any.
    /// </summary>
    [DataMember]
    public required ATMContext20 Context { get; init; } 
    /// <summary>
    /// Acknowledgement of the exception advice.
    /// </summary>
    [DataMember]
    public required ATMTransaction28 Transaction { get; init; } 
    
    #nullable disable
}
