﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChequeTypeCode.  ISO2002 ID# _a-7JuNp-Ed-ak6NoX_4Aeg_815766643.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cheque.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChequeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IChequeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a-7JuNp-Ed-ak6NoX_4Aeg_815766643")]
public partial class ChequeTypeCodeDropdownRow : EnumMetadataItem<ChequeTypeCode>, IChequeTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of cheque.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChequeTypeCodeDropdownRow(ChequeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
