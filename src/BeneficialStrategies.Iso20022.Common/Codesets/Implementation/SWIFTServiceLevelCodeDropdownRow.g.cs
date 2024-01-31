﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SWIFTServiceLevelCode.  ISO2002 ID# _ZRGV99p-Ed-ak6NoX_4Aeg_1129333396.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the SWIFT service level that applies to the payment instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SWIFTServiceLevelCodeDropdownSource"/>.
/// Implements <seealso cref="ISWIFTServiceLevelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZRGV99p-Ed-ak6NoX_4Aeg_1129333396")]
public partial class SWIFTServiceLevelCodeDropdownRow : EnumMetadataItem<SWIFTServiceLevelCode>, ISWIFTServiceLevelCodeDropdownRow
{
    /// <summary>
    /// Specifies the SWIFT service level that applies to the payment instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SWIFTServiceLevelCodeDropdownRow(SWIFTServiceLevelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
