﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UserInterface2Code.  ISO2002 ID# _TUmCEgEcEeCQm6a_G2yO_w_-457047932.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of interface to display a message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUserInterface2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUmCEgEcEeCQm6a_G2yO_w_-457047932")]
public partial class UserInterface2CodeDropdownSource : EnumMetadataManager<UserInterface2Code,IUserInterface2CodeDropdownRow,UserInterface2CodeDropdownRow>
{
    public UserInterface2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UserInterface2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}