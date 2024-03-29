﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalSystemErrorHandlingCode.  ISO2002 ID# _Y2fRg3hdEeidzqjNEfehPg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the error code as generated by the system in the response, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y2fRg3hdEeidzqjNEfehPg")]
[Description(@"Specifies the error code as generated by the system in the response, as published in an external balance type code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalSystemErrorHandling1Code))]
public enum ExternalSystemErrorHandlingCode
{
    /// <summary>
    /// Specifies the error code when the data requested are not yet available.
    /// Encoded/decoded by serializers as &quot;X020&quot;.
    /// </summary>
    [EnumMember(Value = "X020")]
    [IsoId("_uhBFY_RYEeuLhpyIdtJzwg")]
    [Description(@"Specifies the error code when the data requested are not yet available.")]
    DataNotYetAvailable,
    
    /// <summary>
    /// Specifies the error code when the data requested generates a message size that exceed the processing capacity.
    /// Encoded/decoded by serializers as &quot;X030&quot;.
    /// </summary>
    [EnumMember(Value = "X030")]
    [IsoId("_uhBFZvRYEeuLhpyIdtJzwg")]
    [Description(@"Specifies the error code when the data requested generates a message size that exceed the processing capacity.")]
    MessageSizeLimitExceeded,
    
    /// <summary>
    /// Specifies the error code when the data requested have not been found.
    /// Encoded/decoded by serializers as &quot;X050&quot;.
    /// </summary>
    [EnumMember(Value = "X050")]
    [IsoId("_uhK2YPRYEeuLhpyIdtJzwg")]
    [Description(@"Specifies the error code when the data requested have not been found.")]
    DataNotAvailable,
    
}
