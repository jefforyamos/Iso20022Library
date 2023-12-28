﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Eligibility1Code.  ISO2002 ID# _ahHzZNp-Ed-ak6NoX_4Aeg_-1375297258.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of investor. The rules that apply to each type of client are different.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Eligibility1CodeDropdownSource"/>.
/// Implements <seealso cref="IEligibility1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahHzZNp-Ed-ak6NoX_4Aeg_-1375297258")]
public partial class Eligibility1CodeDropdownRow : EnumMetadataItem<Eligibility1Code>, IEligibility1CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of investor. The rules that apply to each type of client are different.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Eligibility1CodeDropdownRow(Eligibility1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}