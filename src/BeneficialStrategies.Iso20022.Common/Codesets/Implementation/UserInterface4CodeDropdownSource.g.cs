﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UserInterface4Code.  ISO2002 ID# _xKxc4IO_EeSWSLYdc10LRg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Destination of the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUserInterface4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xKxc4IO_EeSWSLYdc10LRg")]
public partial class UserInterface4CodeDropdownSource : EnumMetadataManager<UserInterface4Code,IUserInterface4CodeDropdownRow,UserInterface4CodeDropdownRow>
{
    public UserInterface4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UserInterface4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}