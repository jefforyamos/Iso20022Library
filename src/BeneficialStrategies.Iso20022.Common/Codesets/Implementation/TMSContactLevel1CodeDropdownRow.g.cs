﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TMSContactLevel1Code.  ISO2002 ID# _TUAMNQEcEeCQm6a_G2yO_w_-248608949.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Level of urgency in contacting the terminal management system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TMSContactLevel1CodeDropdownSource"/>.
/// Implements <seealso cref="ITMSContactLevel1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUAMNQEcEeCQm6a_G2yO_w_-248608949")]
public partial class TMSContactLevel1CodeDropdownRow : EnumMetadataItem<TMSContactLevel1Code>, ITMSContactLevel1CodeDropdownRow
{
    /// <summary>
    /// Level of urgency in contacting the terminal management system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TMSContactLevel1CodeDropdownRow(TMSContactLevel1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
