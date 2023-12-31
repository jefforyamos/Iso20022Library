﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SWIFTServiceLevel2Code.  ISO2002 ID# _ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code identifying which SWIFT service level applies to the payment instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SWIFTServiceLevel2CodeDropdownSource"/>.
/// Implements <seealso cref="ISWIFTServiceLevel2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378")]
public partial class SWIFTServiceLevel2CodeDropdownRow : EnumMetadataItem<SWIFTServiceLevel2Code>, ISWIFTServiceLevel2CodeDropdownRow
{
    /// <summary>
    /// Code identifying which SWIFT service level applies to the payment instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SWIFTServiceLevel2CodeDropdownRow(SWIFTServiceLevel2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
