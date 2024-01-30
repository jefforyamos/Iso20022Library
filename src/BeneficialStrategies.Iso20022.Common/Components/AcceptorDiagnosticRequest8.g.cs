﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorDiagnosticRequest8.  ISO2002 ID# _kRo00QujEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic request from an acceptor.
/// </summary>
public partial record AcceptorDiagnosticRequest8
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment74 Environment { get; init; } 
    /// <summary>
    /// Indicates if the availability of the acquirer must be tested.
    /// </summary>
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 
    
    #nullable disable
}
