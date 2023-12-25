﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProcessingStatusCode.  ISO2002 ID# _aLN009p-Ed-ak6NoX_4Aeg_-1445203123.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProcessingStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IProcessingStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aLN009p-Ed-ak6NoX_4Aeg_-1445203123")]
public partial class ProcessingStatusCodeDropdownRow : EnumMetadataItem<ProcessingStatusCode>, IProcessingStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the processing status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProcessingStatusCodeDropdownRow(ProcessingStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
