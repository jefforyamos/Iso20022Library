﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AttestationValue1Code.  ISO2002 ID# _HnrOEAMlEeujMs2LsB3mMw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Attestation status value.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AttestationValue1CodeDropdownSource"/>.
/// Implements <seealso cref="IAttestationValue1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_HnrOEAMlEeujMs2LsB3mMw")]
public partial class AttestationValue1CodeDropdownRow : EnumMetadataItem<AttestationValue1Code>, IAttestationValue1CodeDropdownRow
{
    /// <summary>
    /// Attestation status value.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AttestationValue1CodeDropdownRow(AttestationValue1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
