﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalSystemEventType1Code.  ISO2002 ID# _8OFBVqMgEeCJ6YNENx4h-w_1804878644.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type an event generated within a system, as published in an system event type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalSystemEventType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalSystemEventType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8OFBVqMgEeCJ6YNENx4h-w_1804878644")]
public partial class ExternalSystemEventType1CodeDropdownRow : EnumMetadataItem<ExternalSystemEventType1Code>, IExternalSystemEventType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type an event generated within a system, as published in an system event type code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalSystemEventType1CodeDropdownRow(ExternalSystemEventType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
