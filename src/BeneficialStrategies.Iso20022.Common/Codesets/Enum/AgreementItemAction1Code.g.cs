﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AgreementItemAction1Code.  ISO2002 ID# _OTgzMjc5-AOSNFX-8224496.
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
[IsoId("_OTgzMjc5-AOSNFX-8224496")]
[Description(@"Specifies the type of action concerning registration information.|The default value is OPEN.")]
[DerivedFrom(typeof(AgreementItemActionCode))]
public enum AgreementItemAction1Code
{
    /// <summary>
    /// Deactivate agreement item.
    /// Encoded/decoded by serializers as "DEAC".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_OTMxOTY3-AOSNFX-0262741")]
    [Description(@"Deactivate agreement item.")]
    Deactivate = AgreementItemActionCode.Deactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hold the agreement item.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_OTMxOTY2-AOSNFX-0262741")]
    [Description(@"Hold the agreement item.")]
    Hold = AgreementItemActionCode.Hold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modify agreement item information.
    /// Encoded/decoded by serializers as "MDFY".
    /// </summary>
    [EnumMember(Value = "MDFY")]
    [IsoId("_OTMxOTY1-AOSNFX-0262740")]
    [Description(@"Modify agreement item information.")]
    Modify = AgreementItemActionCode.Modify, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reactivate agreement item.
    /// Encoded/decoded by serializers as "REAC".
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_OTMxOTY4-AOSNFX-0262741")]
    [Description(@"Reactivate agreement item.")]
    Reactivate = AgreementItemActionCode.Reactivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Register item as new agreement.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_OTMxOTY0-AOSNFX-0262740")]
    [Description(@"Register item as new agreement.")]
    Register = AgreementItemActionCode.Register, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Send status with full agreement information details.
    /// Encoded/decoded by serializers as "SYNC".
    /// </summary>
    [EnumMember(Value = "SYNC")]
    [IsoId("_OTMxOTcw-AOSNFX-0262741")]
    [Description(@"Send status with full agreement information details.")]
    Synchronize = AgreementItemActionCode.Synchronize, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verify agreement item information.
    /// Encoded/decoded by serializers as "VRFY".
    /// </summary>
    [EnumMember(Value = "VRFY")]
    [IsoId("_OTMxOTY5-AOSNFX-0262741")]
    [Description(@"Verify agreement item information.")]
    Verify = AgreementItemActionCode.Verify, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AgreementItemAction1CodeMetadataExtensions
{
    private static readonly AgreementItemAction1CodeDropdownSource _dropdownSource = new AgreementItemAction1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAgreementItemAction1CodeDropdownRow GetMetadata(this AgreementItemAction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


