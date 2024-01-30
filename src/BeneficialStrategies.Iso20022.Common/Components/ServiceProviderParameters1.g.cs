﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ServiceProviderParameters1.  ISO2002 ID# _iGGCMDAKEeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provider parameters of the point of interaction (POI).
/// </summary>
public partial record ServiceProviderParameters1
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the service provider.
    /// </summary>
    public GenericIdentification176? ServiceProviderIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Version of the service provider parameters.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification of payment application relevant for this service provider.
    /// </summary>
    public IsoMax35Text? ApplicationIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Service provider host configuration.
    /// </summary>
    public AcquirerHostConfiguration8? Host { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of non financial action supported by the Service Provider.
    /// </summary>
    public NonFinancialRequestType1Code? NonFinancialActionSupported { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
