﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AdministrativeTypeCode.  ISO2002 ID# _H-bSIDNKEeylu6lH-gut-A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that identifies an administrative type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AdministrativeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAdministrativeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_H-bSIDNKEeylu6lH-gut-A")]
public partial class AdministrativeTypeCodeDropdownRow : EnumMetadataItem<AdministrativeTypeCode>, IAdministrativeTypeCodeDropdownRow
{
    /// <summary>
    /// Code that identifies an administrative type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AdministrativeTypeCodeDropdownRow(AdministrativeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
