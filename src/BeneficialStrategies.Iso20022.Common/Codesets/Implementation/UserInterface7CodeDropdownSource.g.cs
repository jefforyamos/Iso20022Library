﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UserInterface7Code.  ISO2002 ID# _VtKV4FBAEeedyPuM0kK2EQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Clearing agent dedicated interface.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUserInterface7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VtKV4FBAEeedyPuM0kK2EQ")]
public partial class UserInterface7CodeDropdownSource : EnumMetadataManager<UserInterface7Code,IUserInterface7CodeDropdownRow,UserInterface7CodeDropdownRow>
{
    public UserInterface7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UserInterface7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
