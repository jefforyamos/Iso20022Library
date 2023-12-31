﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EligibilityCode.  ISO2002 ID# _ahQ9UNp-Ed-ak6NoX_4Aeg_2052483881.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of investor. The rules that apply to each type of client are different.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EligibilityCodeDropdownSource"/>.
/// Implements <seealso cref="IEligibilityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahQ9UNp-Ed-ak6NoX_4Aeg_2052483881")]
public partial class EligibilityCodeDropdownRow : EnumMetadataItem<EligibilityCode>, IEligibilityCodeDropdownRow
{
    /// <summary>
    /// Identifies the type of investor. The rules that apply to each type of client are different.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EligibilityCodeDropdownRow(EligibilityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
