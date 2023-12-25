﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AgreementItemActionCode.  ISO2002 ID# _OTgzMjc4-AOSNFX-8224496.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of action concerning registration information.
/// The default value is OPEN.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OTgzMjc4-AOSNFX-8224496")]
[Description(@"Specifies the type of action concerning registration information. The default value is OPEN.")]
public enum AgreementItemActionCode
{
    /// <summary>
    /// Deactivate agreement item.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_OTMxOTY3-AOSNFX-0262741L")]
    [Description(@"Deactivate agreement item.")]
    DEAC,
    
    /// <summary>
    /// Hold the agreement item.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_OTMxOTY2-AOSNFX-0262741L")]
    [Description(@"Hold the agreement item.")]
    HOLD,
    
    /// <summary>
    /// Modify agreement item information.
    /// </summary>
    [EnumMember(Value = "MDFY")]
    [IsoId("_OTMxOTY1-AOSNFX-0262740L")]
    [Description(@"Modify agreement item information.")]
    MDFY,
    
    /// <summary>
    /// Reactivate agreement item.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_OTMxOTY4-AOSNFX-0262741L")]
    [Description(@"Reactivate agreement item.")]
    REAC,
    
    /// <summary>
    /// Register item as new agreement.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_OTMxOTY0-AOSNFX-0262740L")]
    [Description(@"Register item as new agreement.")]
    OPEN,
    
    /// <summary>
    /// Send status with full agreement information details.
    /// </summary>
    [EnumMember(Value = "SYNC")]
    [IsoId("_OTMxOTcw-AOSNFX-0262741L")]
    [Description(@"Send status with full agreement information details.")]
    SYNC,
    
    /// <summary>
    /// Verify agreement item information.
    /// </summary>
    [EnumMember(Value = "VRFY")]
    [IsoId("_OTMxOTY5-AOSNFX-0262741L")]
    [Description(@"Verify agreement item information.")]
    VRFY,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AgreementItemActionCodeMetadataExtensions
{
    private static readonly AgreementItemActionCodeDropdownSource _dropdownSource = new AgreementItemActionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAgreementItemActionCodeDropdownRow GetMetadata(this AgreementItemActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


