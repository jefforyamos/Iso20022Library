﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Authorisation1Code.  ISO2002 ID# _bjbk9Np-Ed-ak6NoX_4Aeg_300324450.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Authorisation1CodeDropdownSource"/>.
/// Implements <seealso cref="IAuthorisation1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bjbk9Np-Ed-ak6NoX_4Aeg_300324450")]
public partial class Authorisation1CodeDropdownRow : EnumMetadataItem<Authorisation1Code>, IAuthorisation1CodeDropdownRow
{
    /// <summary>
    /// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Authorisation1CodeDropdownRow(Authorisation1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
