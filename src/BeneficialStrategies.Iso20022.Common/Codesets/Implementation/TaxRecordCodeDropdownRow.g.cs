﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxRecordCode.  ISO2002 ID# _YiKMVtp-Ed-ak6NoX_4Aeg_-1942037713.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax details.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxRecordCodeDropdownSource"/>.
/// Implements <seealso cref="ITaxRecordCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YiKMVtp-Ed-ak6NoX_4Aeg_-1942037713")]
public partial class TaxRecordCodeDropdownRow : EnumMetadataItem<TaxRecordCode>, ITaxRecordCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of tax details.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxRecordCodeDropdownRow(TaxRecordCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
