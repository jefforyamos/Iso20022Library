﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfiguration7.  ISO2002 ID# _-APT0dqHEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor configuration to be downloaded from the terminal management system.
/// </summary>
public partial record AcceptorConfiguration7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    public TerminalManagementDataSet23? DataSet { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
