﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationContent7.  ISO2002 ID# _U97pgdqGEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the acceptor configuration.
/// </summary>
public partial record AcceptorConfigurationContent7
{
    #nullable enable
    
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; } 
    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    public TMSProtocolParameters3? TMSProtocolParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    public AcquirerProtocolParameters11? AcquirerProtocolParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    public MerchantConfigurationParameters3? MerchantParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    public PaymentTerminalParameters5? TerminalParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    public ApplicationParameters7? ApplicationParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    public HostCommunicationParameter5? HostCommunicationParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    public SecurityParameters11? SecurityParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    public SaleToPOIProtocolParameter1? SaleToPOIParameters { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
