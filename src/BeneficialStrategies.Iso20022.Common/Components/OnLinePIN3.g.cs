﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OnLinePIN3.  ISO2002 ID# _--rKsS_tEeO4w-IWHJMI9g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted personal identification number (PIN) and related information.
/// </summary>
public partial record OnLinePIN3
{
    #nullable enable
    
    /// <summary>
    /// Encrypted PIN (Personal Identification Number).
    /// </summary>
    public required ContentInformationType7 EncryptedPINBlock { get; init; } 
    /// <summary>
    /// PIN (Personal Identification Number) format before encryption.
    /// </summary>
    public required PINFormat3Code PINFormat { get; init; } 
    /// <summary>
    /// Additional information required to verify the PIN (Personal Identification Number.
    /// </summary>
    public IsoMax35Text? AdditionalInput { get; init; } 
    
    #nullable disable
}
