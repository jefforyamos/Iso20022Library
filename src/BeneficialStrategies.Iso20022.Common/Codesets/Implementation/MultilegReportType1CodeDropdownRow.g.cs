﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MultilegReportType1Code.  ISO2002 ID# _aM2zlNp-Ed-ak6NoX_4Aeg_-1038437267.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the method of execution reporting requested by issuer of the order.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MultilegReportType1CodeDropdownSource"/>.
/// Implements <seealso cref="IMultilegReportType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aM2zlNp-Ed-ak6NoX_4Aeg_-1038437267")]
public partial class MultilegReportType1CodeDropdownRow : EnumMetadataItem<MultilegReportType1Code>, IMultilegReportType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the method of execution reporting requested by issuer of the order.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MultilegReportType1CodeDropdownRow(MultilegReportType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
