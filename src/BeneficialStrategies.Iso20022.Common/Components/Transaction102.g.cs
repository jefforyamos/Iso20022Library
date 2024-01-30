﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction102.  ISO2002 ID# _Mt51QVW5EeeiG_nL4vgKnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment transaction.
/// </summary>
public partial record Transaction102
{
    #nullable enable
    
    /// <summary>
    /// Detailed description of an error that caused the message to be corrected/amended. Transmitted for further analysis.
    /// </summary>
    public DetailedError1? AmendedData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    /// <summary>
    /// Original message before correction/amendment.
    /// </summary>
    public IsoMax100KBinary? OriginalMessage { get; init; } 
    /// <summary>
    /// Message amended.
    /// </summary>
    public IsoMax100KBinary? MessageAmended { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
