﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdministrativeRequest3.  ISO2002 ID# _aqKmMQxREeqEbo60f0v6aw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of admin service to be used with this message.
/// </summary>
public partial record AdministrativeRequest3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment75 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext28 Context { get; init; } 
    /// <summary>
    /// Identification of the administrative service to process.
    /// </summary>
    public IsoMax20000Text? AdministrativeServiceIdentification { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
