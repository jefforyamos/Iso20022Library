﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Provided1Code.  ISO2002 ID# _UbfaUBKFEeKj15WxqwlXPw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether items have been provided.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UbfaUBKFEeKj15WxqwlXPw")]
[Description(@"Specifies whether items have been provided.")]
[DerivedFrom(typeof(ProvidedCode))]
public enum Provided1Code
{
    /// <summary>
    /// Not provided.
    /// Encoded/decoded by serializers as &quot;NPRO&quot;.
    /// </summary>
    [EnumMember(Value = "NPRO")]
    [IsoId("_ba2ZIRKFEeKj15WxqwlXPw")]
    [Description(@"Not provided.")]
    NotProvided = ProvidedCode.NotProvided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provided.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_bllCcRKFEeKj15WxqwlXPw")]
    [Description(@"Provided.")]
    Provided = ProvidedCode.Provided, // same ordinal as derivation source for type conversions
    
}
