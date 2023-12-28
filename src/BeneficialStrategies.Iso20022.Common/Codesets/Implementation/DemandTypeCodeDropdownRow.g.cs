﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DemandTypeCode.  ISO2002 ID# _XvpRYHyVEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of demand for payment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DemandTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDemandTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XvpRYHyVEeGWJuGCfvwOsQ")]
public partial class DemandTypeCodeDropdownRow : EnumMetadataItem<DemandTypeCode>, IDemandTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of demand for payment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DemandTypeCodeDropdownRow(DemandTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}