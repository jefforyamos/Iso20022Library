﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationContent1.  ISO2002 ID# _Ksg2xX1DEeCF8NjrBemJWQ_1156169068.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the acceptor configuration.
/// </summary>
public partial record AcceptorConfigurationContent1
{
    #nullable enable
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    public AcquirerProtocolParameters1[] AcquirerProtocolParameters { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    public IsoMax10000Binary[] MerchantParameters { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    public ApplicationParameters1[] ApplicationParameters { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host.
    /// </summary>
    public HostCommunicationParameter1[] HostCommunicationParameters { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
