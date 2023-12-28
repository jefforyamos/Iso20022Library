﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RemittanceLocationMethod1Code.  ISO2002 ID# _ZsOLt9p-Ed-ak6NoX_4Aeg_91898271.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZsOLt9p-Ed-ak6NoX_4Aeg_91898271")]
[Description(@"Specifies the method used to deliver the remittance advice information.")]
[DerivedFrom(typeof(RemittanceLocationMethodCode))]
public enum RemittanceLocationMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsOLuNp-Ed-ak6NoX_4Aeg_146384951")]
    [Description(@"??")]
    Fax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ElectronicDataInterchange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8sNp-Ed-ak6NoX_4Aeg_146384986")]
    [Description(@"??")]
    ElectronicDataInterchange,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UniformResourceIdentifier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8sdp-Ed-ak6NoX_4Aeg_146385072")]
    [Description(@"??")]
    UniformResourceIdentifier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EMail".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8stp-Ed-ak6NoX_4Aeg_146385142")]
    [Description(@"??")]
    EMail,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Post".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsX8s9p-Ed-ak6NoX_4Aeg_146385419")]
    [Description(@"??")]
    Post,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RemittanceLocationMethod1CodeMetadataExtensions
{
    private static readonly RemittanceLocationMethod1CodeDropdownSource _dropdownSource = new RemittanceLocationMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRemittanceLocationMethod1CodeDropdownRow GetMetadata(this RemittanceLocationMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

