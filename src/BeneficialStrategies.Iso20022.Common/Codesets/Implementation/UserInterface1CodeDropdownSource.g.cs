﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UserInterface1Code.  ISO2002 ID# _TUc4MgEcEeCQm6a_G2yO_w_-1884432238.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of user interface to display or print information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUserInterface1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUc4MgEcEeCQm6a_G2yO_w_-1884432238")]
public partial class UserInterface1CodeDropdownSource : EnumMetadataManager<UserInterface1Code,IUserInterface1CodeDropdownRow,UserInterface1CodeDropdownRow>
{
    public UserInterface1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UserInterface1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
