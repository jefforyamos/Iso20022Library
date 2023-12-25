﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalUndertakingStatusCategoryCode.  ISO2002 ID# _-M07BW7iEeKo25nLKvGr8w_-365959647.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalUndertakingStatusCategoryCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalUndertakingStatusCategoryCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-M07BW7iEeKo25nLKvGr8w_-365959647")]
public partial class ExternalUndertakingStatusCategoryCodeDropdownRow : EnumMetadataItem<ExternalUndertakingStatusCategoryCode>, IExternalUndertakingStatusCategoryCodeDropdownRow
{
    /// <summary>
    /// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalUndertakingStatusCategoryCodeDropdownRow(ExternalUndertakingStatusCategoryCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
