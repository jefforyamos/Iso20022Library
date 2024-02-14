﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateType3Code.  ISO2002 ID# _ayZwotp-Ed-ak6NoX_4Aeg_-1375472823.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwotp-Ed-ak6NoX_4Aeg_-1375472823")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType3Code
{
    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ayZwo9p-Ed-ak6NoX_4Aeg_-1348690126")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various = DateTypeCode.Various, // same ordinal as derivation source for type conversions
    
}
