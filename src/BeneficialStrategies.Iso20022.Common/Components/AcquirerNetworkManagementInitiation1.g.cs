﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerNetworkManagementInitiation1.  ISO2002 ID# _QugKoHvDEeSKFIcWw3l4Yw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the network management.
/// </summary>
public partial record AcquirerNetworkManagementInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardTransactionEnvironment6 Environment { get; init; } 
    /// <summary>
    /// Network management transaction.
    /// </summary>
    public required CardTransaction11 Transaction { get; init; } 
    
    #nullable disable
}
