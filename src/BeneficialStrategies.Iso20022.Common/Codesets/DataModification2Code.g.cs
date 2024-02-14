﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataModification2Code.  ISO2002 ID# _ax9EtNp-Ed-ak6NoX_4Aeg_-1133981230.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the type of modification to be applied on a data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ax9EtNp-Ed-ak6NoX_4Aeg_-1133981230")]
[Description(@"Specified the type of modification to be applied on a data set.")]
[DerivedFrom(typeof(DataModificationCode))]
public enum DataModification2Code
{
    /// <summary>
    /// Insert a new set of data.
    /// Encoded/decoded by serializers as &quot;INSE&quot;.
    /// </summary>
    [EnumMember(Value = "INSE")]
    [IsoId("_ax9Etdp-Ed-ak6NoX_4Aeg_-1011150674")]
    [Description(@"Insert a new set of data.")]
    InsertNewDataSet = DataModificationCode.InsertNewDataSet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delete an existing set of data.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ax9Ettp-Ed-ak6NoX_4Aeg_-1011150656")]
    [Description(@"Delete an existing set of data.")]
    DeleteDataSet = DataModificationCode.DeleteDataSet, // same ordinal as derivation source for type conversions
    
}
