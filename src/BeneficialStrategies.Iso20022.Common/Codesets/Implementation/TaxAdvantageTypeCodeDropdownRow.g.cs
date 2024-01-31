﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxAdvantageTypeCode.  ISO2002 ID# _8nnPAVf1EeOuDtoQo1qilA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code for the form of tax advantage on the dividend.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxAdvantageTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITaxAdvantageTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8nnPAVf1EeOuDtoQo1qilA")]
public partial class TaxAdvantageTypeCodeDropdownRow : EnumMetadataItem<TaxAdvantageTypeCode>, ITaxAdvantageTypeCodeDropdownRow
{
    /// <summary>
    /// Code for the form of tax advantage on the dividend.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxAdvantageTypeCodeDropdownRow(TaxAdvantageTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
