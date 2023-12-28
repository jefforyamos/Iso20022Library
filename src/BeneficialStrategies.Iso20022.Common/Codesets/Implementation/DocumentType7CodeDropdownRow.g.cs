﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DocumentType7Code.  ISO2002 ID# _bUOYsNxJEeioifFt1dhnJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DocumentType7CodeDropdownSource"/>.
/// Implements <seealso cref="IDocumentType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bUOYsNxJEeioifFt1dhnJA")]
public partial class DocumentType7CodeDropdownRow : EnumMetadataItem<DocumentType7Code>, IDocumentType7CodeDropdownRow
{
    /// <summary>
    /// Specifies a type of financial or commercial document.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DocumentType7CodeDropdownRow(DocumentType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
