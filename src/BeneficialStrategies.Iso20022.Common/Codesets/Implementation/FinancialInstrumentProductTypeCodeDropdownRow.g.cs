﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FinancialInstrumentProductTypeCode.  ISO2002 ID# _apBLINp-Ed-ak6NoX_4Aeg_335334060.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of product or financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FinancialInstrumentProductTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IFinancialInstrumentProductTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_apBLINp-Ed-ak6NoX_4Aeg_335334060")]
public partial class FinancialInstrumentProductTypeCodeDropdownRow : EnumMetadataItem<FinancialInstrumentProductTypeCode>, IFinancialInstrumentProductTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of product or financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FinancialInstrumentProductTypeCodeDropdownRow(FinancialInstrumentProductTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}