﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OfficialDocumentTypeCode.  ISO2002 ID# _6Y3R0HhNEee6_vnrijrKgg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Official document type used for identification or authentication
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OfficialDocumentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IOfficialDocumentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6Y3R0HhNEee6_vnrijrKgg")]
public partial class OfficialDocumentTypeCodeDropdownRow : EnumMetadataItem<OfficialDocumentTypeCode>, IOfficialDocumentTypeCodeDropdownRow
{
    /// <summary>
    /// Official document type used for identification or authentication
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OfficialDocumentTypeCodeDropdownRow(OfficialDocumentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}