﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AddressType2Code.  ISO2002 ID# _bm2sYNp-Ed-ak6NoX_4Aeg_595056355.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of address.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AddressType2CodeDropdownSource"/>.
/// Implements <seealso cref="IAddressType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bm2sYNp-Ed-ak6NoX_4Aeg_595056355")]
public partial class AddressType2CodeDropdownRow : EnumMetadataItem<AddressType2Code>, IAddressType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of address.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AddressType2CodeDropdownRow(AddressType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
