﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMSecuritySchemeCode.  ISO2002 ID# _zqg0kIr4EeSvuOJS0mmL0g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Key exchange security scheme on an ATM for the host manager.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMSecuritySchemeCodeDropdownSource"/>.
/// Implements <seealso cref="IATMSecuritySchemeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zqg0kIr4EeSvuOJS0mmL0g")]
public partial class ATMSecuritySchemeCodeDropdownRow : EnumMetadataItem<ATMSecuritySchemeCode>, IATMSecuritySchemeCodeDropdownRow
{
    /// <summary>
    /// Key exchange security scheme on an ATM for the host manager.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMSecuritySchemeCodeDropdownRow(ATMSecuritySchemeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
