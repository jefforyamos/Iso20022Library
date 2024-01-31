﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CertificateType2Code.  ISO2002 ID# _GXDp0BODEeKjmvxNCObNeQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certificate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CertificateType2CodeDropdownSource"/>.
/// Implements <seealso cref="ICertificateType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GXDp0BODEeKjmvxNCObNeQ")]
public partial class CertificateType2CodeDropdownRow : EnumMetadataItem<CertificateType2Code>, ICertificateType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of certificate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CertificateType2CodeDropdownRow(CertificateType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
