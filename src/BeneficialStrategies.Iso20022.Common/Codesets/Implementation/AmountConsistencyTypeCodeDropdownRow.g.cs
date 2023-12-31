﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AmountConsistencyTypeCode.  ISO2002 ID# _O4iB4ASsEeusZ4O-nsxv_w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AmountConsistencyTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAmountConsistencyTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_O4iB4ASsEeusZ4O-nsxv_w")]
public partial class AmountConsistencyTypeCodeDropdownRow : EnumMetadataItem<AmountConsistencyTypeCode>, IAmountConsistencyTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AmountConsistencyTypeCodeDropdownRow(AmountConsistencyTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
