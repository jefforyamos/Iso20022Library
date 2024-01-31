﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LocationCategory2Code.  ISO2002 ID# _H30HwHsIEeSR68OJvMfxJQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Location category of the place where the transaction is actually performed. 
/// It correspond partially to the ISO 8583: 1993, field number 22-4.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LocationCategory2CodeDropdownSource"/>.
/// Implements <seealso cref="ILocationCategory2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_H30HwHsIEeSR68OJvMfxJQ")]
public partial class LocationCategory2CodeDropdownRow : EnumMetadataItem<LocationCategory2Code>, ILocationCategory2CodeDropdownRow
{
    /// <summary>
    /// Location category of the place where the transaction is actually performed. 
    /// It correspond partially to the ISO 8583: 1993, field number 22-4.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LocationCategory2CodeDropdownRow(LocationCategory2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
