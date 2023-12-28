﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RegistrationCode.  ISO2002 ID# _Za7nZtp-Ed-ak6NoX_4Aeg_-740425248.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RegistrationCodeDropdownSource"/>.
/// Implements <seealso cref="IRegistrationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Za7nZtp-Ed-ak6NoX_4Aeg_-740425248")]
public partial class RegistrationCodeDropdownRow : EnumMetadataItem<RegistrationCode>, IRegistrationCodeDropdownRow
{
    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RegistrationCodeDropdownRow(RegistrationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}