﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProcessingStatus1Code.  ISO2002 ID# _aLED19p-Ed-ak6NoX_4Aeg_-1833350814.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLED19p-Ed-ak6NoX_4Aeg_-1833350814")]
[Description(@"Specifies the processing status.")]
[DerivedFrom(typeof(ProcessingStatusCode))]
public enum ProcessingStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Complete".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLED2Np-Ed-ak6NoX_4Aeg_-1833350782")]
    [Description(@"??")]
    Complete,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreliminaryConfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLN00Np-Ed-ak6NoX_4Aeg_-1833350781")]
    [Description(@"??")]
    PreliminaryConfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreliminaryUnconfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLN00dp-Ed-ak6NoX_4Aeg_-1833350780")]
    [Description(@"??")]
    PreliminaryUnconfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForInformationOnly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLN00tp-Ed-ak6NoX_4Aeg_-1833350752")]
    [Description(@"??")]
    ForInformationOnly,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProcessingStatus1CodeMetadataExtensions
{
    private static readonly ProcessingStatus1CodeDropdownSource _dropdownSource = new ProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProcessingStatus1CodeDropdownRow GetMetadata(this ProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

