﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxExemptReason3Code.  ISO2002 ID# _DljS4SDAEeWPMvNwVtiMsA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxExemptReason3CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxExemptReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DljS4SDAEeWPMvNwVtiMsA")]
public partial class TaxExemptReason3CodeDropdownRow : EnumMetadataItem<TaxExemptReason3Code>, ITaxExemptReason3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxExemptReason3CodeDropdownRow(TaxExemptReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}