﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MailType1Code.  ISO2002 ID# _gpYLECCXEeWJd9HF2tO7BA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of mail service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMailType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gpYLECCXEeWJd9HF2tO7BA")]
public partial class MailType1CodeDropdownSource : EnumMetadataManager<MailType1Code,IMailType1CodeDropdownRow,MailType1CodeDropdownRow>
{
    public MailType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MailType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
