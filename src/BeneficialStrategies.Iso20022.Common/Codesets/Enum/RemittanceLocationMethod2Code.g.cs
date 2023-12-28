﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RemittanceLocationMethod2Code.  ISO2002 ID# _ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090")]
[Description(@"Specifies the method used to deliver the remittance advice information.")]
[DerivedFrom(typeof(RemittanceLocationMethodCode))]
public enum RemittanceLocationMethod2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8tdp-Ed-ak6NoX_4Aeg_-517543060")]
    [Description(@"??")]
    Fax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ElectronicDataInterchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8ttp-Ed-ak6NoX_4Aeg_-517543029")]
    [Description(@"??")]
    ElectronicDataInterchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UniformResourceIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8t9p-Ed-ak6NoX_4Aeg_-517543028")]
    [Description(@"??")]
    UniformResourceIdentifier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EMail".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8uNp-Ed-ak6NoX_4Aeg_-517542998")]
    [Description(@"??")]
    EMail,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Post".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8udp-Ed-ak6NoX_4Aeg_-517542968")]
    [Description(@"??")]
    Post,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SMS".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZshGoNp-Ed-ak6NoX_4Aeg_-333762381")]
    [Description(@"??")]
    SMS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RemittanceLocationMethod2CodeMetadataExtensions
{
    private static readonly RemittanceLocationMethod2CodeDropdownSource _dropdownSource = new RemittanceLocationMethod2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRemittanceLocationMethod2CodeDropdownRow GetMetadata(this RemittanceLocationMethod2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


