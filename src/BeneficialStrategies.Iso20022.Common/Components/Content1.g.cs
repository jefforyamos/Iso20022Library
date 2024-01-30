﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Content1.  ISO2002 ID# _jrZ20EXWEeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of or reference to the content of a message.
/// </summary>
public partial record Content1
{
    #nullable enable
    
    /// <summary>
    /// Value of the content of or the reference to the message.
    /// </summary>
    public required IsoMax20KText Value { get; init; } 
    /// <summary>
    /// Digital signature of the content of or the reference to the message.
    /// </summary>
    public IsoMax140Binary? Signature { get; init; } 
    /// <summary>
    /// Signing certificate identification.
    /// </summary>
    public IsoMax70Text? CertificateIdentification { get; init; } 
    
    #nullable disable
}
