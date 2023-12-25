﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PriceReportFunctionCode.  ISO2002 ID# _bJkrQBl9EeKxsrht2duUcg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the function of the price report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PriceReportFunctionCodeDropdownSource"/>.
/// Implements <seealso cref="IPriceReportFunctionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bJkrQBl9EeKxsrht2duUcg")]
public partial class PriceReportFunctionCodeDropdownRow : EnumMetadataItem<PriceReportFunctionCode>, IPriceReportFunctionCodeDropdownRow
{
    /// <summary>
    /// Specifies the function of the price report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceReportFunctionCodeDropdownRow(PriceReportFunctionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
