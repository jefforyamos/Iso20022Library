﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet19.  ISO2002 ID# _oaQqsY32EeWRwov1g9WL_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
public partial record TerminalManagementDataSet19
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    public required DataSetIdentification6 Identification { get; init; } 
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    public GenericIdentification71[] POIIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    public PartyType15Code? ConfigurationScope { get; init; } 
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    public required AcceptorConfigurationContent5 Content { get; init; } 
    
    #nullable disable
}
