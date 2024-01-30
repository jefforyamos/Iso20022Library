﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorDiagnosticRequest3.  ISO2002 ID# _eDmqETTKEeO5e9wx3yvd8g.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic request from an acceptor.
/// </summary>
public partial record AcceptorDiagnosticRequest3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment29 Environment { get; init; } 
    
    #nullable disable
}
