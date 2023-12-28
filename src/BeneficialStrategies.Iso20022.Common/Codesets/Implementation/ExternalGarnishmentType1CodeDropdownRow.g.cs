﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalGarnishmentType1Code.  ISO2002 ID# _DsFkYInoEeOORMXOfBk1Bw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the garnishment type as published in an external document type code list.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalGarnishmentType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalGarnishmentType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DsFkYInoEeOORMXOfBk1Bw")]
public partial class ExternalGarnishmentType1CodeDropdownRow : EnumMetadataItem<ExternalGarnishmentType1Code>, IExternalGarnishmentType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the garnishment type as published in an external document type code list.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalGarnishmentType1CodeDropdownRow(ExternalGarnishmentType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}