﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClearingAccountType3Code.  ISO2002 ID# _8eUqAHX-Eee_qcLXasnA4g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the clearing account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8eUqAHX-Eee_qcLXasnA4g")]
[Description(@"Specifies the clearing account type.")]
[DerivedFrom(typeof(ClearingAccountTypeCode))]
public enum ClearingAccountType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetOmnibusClientAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-IqE4XX-Eee_qcLXasnA4g")]
    [Description(@"??")]
    NetOmnibusClientAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndividuallySegregatedAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-StYwXX-Eee_qcLXasnA4g")]
    [Description(@"??")]
    IndividuallySegregatedAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "House".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-afbwXX-Eee_qcLXasnA4g")]
    [Description(@"??")]
    House,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GrossOmnibusClientAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-iXlYXX-Eee_qcLXasnA4g")]
    [Description(@"??")]
    GrossOmnibusClientAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClearingAccountType3CodeMetadataExtensions
{
    private static readonly ClearingAccountType3CodeDropdownSource _dropdownSource = new ClearingAccountType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClearingAccountType3CodeDropdownRow GetMetadata(this ClearingAccountType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

