﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UserInterface5Code.  ISO2002 ID# _7Gewga13EeWMg5rOByfExw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Destination of the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUserInterface5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7Gewga13EeWMg5rOByfExw")]
public partial class UserInterface5CodeDropdownSource : EnumMetadataManager<UserInterface5Code,IUserInterface5CodeDropdownRow,UserInterface5CodeDropdownRow>
{
    public UserInterface5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UserInterface5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
