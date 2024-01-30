﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet8.  ISO2002 ID# _BS2goTV8EeODSIIQsYYKhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of requested data set.
/// </summary>
public partial record TerminalManagementDataSet8
{
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    public required DataSetIdentification3 Identification { get; init; } 
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? POIChallenge { get; init; } 
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Transport key encrypted by the TM (Terminal manager) key encryption RSA key.
    /// </summary>
    public ContentInformationType7? EncryptedKey { get; init; } 
    
    #nullable disable
}
