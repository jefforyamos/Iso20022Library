﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxWrapperAmountTypeCode.  ISO2002 ID# _vrqp8F24EeiFXdiLi_Nf4A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxWrapperAmountTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ITaxWrapperAmountTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vrqp8F24EeiFXdiLi_Nf4A")]
public partial class TaxWrapperAmountTypeCodeDropdownRow : EnumMetadataItem<TaxWrapperAmountTypeCode>, ITaxWrapperAmountTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxWrapperAmountTypeCodeDropdownRow(TaxWrapperAmountTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
