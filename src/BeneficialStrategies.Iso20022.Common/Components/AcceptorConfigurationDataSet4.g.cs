﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationDataSet4.  ISO2002 ID# _aNbsAXInEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
public partial record AcceptorConfigurationDataSet4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    public required DataSetIdentification10 Identification { get; init; } 
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    public IsoTrueFalseIndicator? LastSequence { get; init; } 
    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    public GenericIdentification176? POIIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    public PartyType15Code? ConfigurationScope { get; init; } 
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    public required AcceptorConfigurationContent12 Content { get; init; } 
    
    #nullable disable
}
