﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnvelopedData4.  ISO2002 ID# _vJy54WizEeS87LmvcA55sg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with encryption key.
/// </summary>
public partial record EnvelopedData4
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    public Recipient4Choice_[] Recipient { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    public EncryptedContent3? EncryptedContent { get; init; } 
    
    #nullable disable
}
