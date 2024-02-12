﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NotApplicable1Code.  ISO2002 ID# _bQMtUICCEeqdQubSe21TTw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies special purpose codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bQMtUICCEeqdQubSe21TTw")]
[Description(@"Specifies special purpose codes.")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum NotApplicable1Code
{
    /// <summary>
    /// Not applicable (N/A).
    /// Encoded/decoded by serializers as "NOAP".
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_eTsTgYCCEeqdQubSe21TTw")]
    [Description(@"Not applicable (N/A).")]
    NotApplicable = SpecialPurposeCode.NotApplicable, // same ordinal as derivation source for type conversions
    
}
