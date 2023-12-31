﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxTypeCode.  ISO2002 ID# _Yk2T89p-Ed-ak6NoX_4Aeg_1366299042.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITaxTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yk2T89p-Ed-ak6NoX_4Aeg_1366299042")]
public partial class TaxTypeCodeDropdownRow : EnumMetadataItem<TaxTypeCode>, ITaxTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxTypeCodeDropdownRow(TaxTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
