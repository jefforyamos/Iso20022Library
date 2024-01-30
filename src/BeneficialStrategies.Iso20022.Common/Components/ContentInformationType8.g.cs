﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContentInformationType8.  ISO2002 ID# _KpedcTF5EeO118ZQJgaQSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing authenticated data.
/// </summary>
public partial record ContentInformationType8
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    public required ContentType1Code ContentType { get; init; } 
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    public AuthenticatedData3? AuthenticatedData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
