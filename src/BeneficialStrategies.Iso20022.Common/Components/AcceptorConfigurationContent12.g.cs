﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationContent12.  ISO2002 ID# _F5K64XIiEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the acceptor configuration.
/// </summary>
public partial record AcceptorConfigurationContent12
{
    #nullable enable
    
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; } 
    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    public TMSProtocolParameters7? TMSProtocolParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    public AcquirerProtocolParameters16? AcquirerProtocolParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to a service provider.
    /// </summary>
    public ServiceProviderParameters3? ServiceProviderParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    public MerchantConfigurationParameters6? MerchantParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    public PaymentTerminalParameters8? TerminalParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    public ApplicationParameters12? ApplicationParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    public HostCommunicationParameter6? HostCommunicationParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    public SecurityParameters15? SecurityParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    public SaleToPOIProtocolParameter3? SaleToPOIParameters { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    public TerminalPackageType4? TerminalPackage { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
