﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RenounceableStatus1Code.  ISO2002 ID# _ZshGqNp-Ed-ak6NoX_4Aeg_-603219895.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the renounceable status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZshGqNp-Ed-ak6NoX_4Aeg_-603219895")]
[Description(@"Specifies the renounceable status.")]
[DerivedFrom(typeof(RenounceableStatusCode))]
public enum RenounceableStatus1Code
{
    /// <summary>
    /// Intermediate securities cannot be sold.
    /// Encoded/decoded by serializers as &quot;NREN&quot;.
    /// </summary>
    [EnumMember(Value = "NREN")]
    [IsoId("_Zsq3oNp-Ed-ak6NoX_4Aeg_-603219863")]
    [Description(@"Intermediate securities cannot be sold.")]
    NonRenounceable = RenounceableStatusCode.NonRenounceable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediate securities can be sold.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_Zsq3odp-Ed-ak6NoX_4Aeg_-603219862")]
    [Description(@"Intermediate securities can be sold.")]
    Renounceable = RenounceableStatusCode.Renounceable, // same ordinal as derivation source for type conversions
    
}
