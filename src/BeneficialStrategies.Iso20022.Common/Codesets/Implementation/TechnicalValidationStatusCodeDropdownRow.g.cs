﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TechnicalValidationStatusCode.  ISO2002 ID# _Yll61Np-Ed-ak6NoX_4Aeg_771598790.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TechnicalValidationStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ITechnicalValidationStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yll61Np-Ed-ak6NoX_4Aeg_771598790")]
public partial class TechnicalValidationStatusCodeDropdownRow : EnumMetadataItem<TechnicalValidationStatusCode>, ITechnicalValidationStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TechnicalValidationStatusCodeDropdownRow(TechnicalValidationStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
