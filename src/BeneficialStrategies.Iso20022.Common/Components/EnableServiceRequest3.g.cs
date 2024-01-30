﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnableServiceRequest3.  ISO2002 ID# _eiAfMS9AEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request to enable a service.
/// </summary>
public partial record EnableServiceRequest3
{
    #nullable enable
    
    /// <summary>
    /// Action to realise on a transaction.
    /// </summary>
    public required TransactionAction1Code TransactionAction { get; init; } 
    /// <summary>
    /// Services enabled before the start-up of a transaction.
    /// </summary>
    public RetailerService2Code? ServicesEnabled { get; init; } 
    /// <summary>
    /// Prompt or welcome message.
    /// </summary>
    public ActionMessage8? DisplayOutput { get; init; } 
    
    #nullable disable
}
