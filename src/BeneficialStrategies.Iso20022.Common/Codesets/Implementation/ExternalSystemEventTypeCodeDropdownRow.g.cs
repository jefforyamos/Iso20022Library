﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalSystemEventTypeCode.  ISO2002 ID# _SrUekJ05Eeet_4BCDEBLdQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type an event generated within a system, as published in an system event type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalSystemEventTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalSystemEventTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SrUekJ05Eeet_4BCDEBLdQ")]
public partial class ExternalSystemEventTypeCodeDropdownRow : EnumMetadataItem<ExternalSystemEventTypeCode>, IExternalSystemEventTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type an event generated within a system, as published in an system event type code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalSystemEventTypeCodeDropdownRow(ExternalSystemEventTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
