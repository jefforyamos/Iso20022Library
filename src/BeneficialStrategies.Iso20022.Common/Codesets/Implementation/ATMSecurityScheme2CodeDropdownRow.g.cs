﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMSecurityScheme2Code.  ISO2002 ID# _pdrXsIr5EeSvuOJS0mmL0g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Key exchange security schemes implemented in the hardware security module of the ATM.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMSecurityScheme2CodeDropdownSource"/>.
/// Implements <seealso cref="IATMSecurityScheme2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pdrXsIr5EeSvuOJS0mmL0g")]
public partial class ATMSecurityScheme2CodeDropdownRow : EnumMetadataItem<ATMSecurityScheme2Code>, IATMSecurityScheme2CodeDropdownRow
{
    /// <summary>
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMSecurityScheme2CodeDropdownRow(ATMSecurityScheme2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
