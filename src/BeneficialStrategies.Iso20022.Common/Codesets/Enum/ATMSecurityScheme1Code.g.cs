﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMSecurityScheme1Code.  ISO2002 ID# _SATuUIr5EeSvuOJS0mmL0g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Key exchange security scheme in activation on the ATM for the host manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SATuUIr5EeSvuOJS0mmL0g")]
[Description(@"Key exchange security scheme in activation on the ATM for the host manager.")]
[DerivedFrom(typeof(ATMSecuritySchemeCode))]
public enum ATMSecurityScheme1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApplicationRemoteKeyLoading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YwVQoYr5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    ApplicationRemoteKeyLoading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificateRemoteKeyLoading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y5_i84r5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    CertificateRemoteKeyLoading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FrenchRemoteKeyLoading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y_cDoYr5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    FrenchRemoteKeyLoading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GermanRemoteKeyLoading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZF9iY4r5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    GermanRemoteKeyLoading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LuxemburgRemoteKeyLoading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZK00QYr5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    LuxemburgRemoteKeyLoading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManualKeyEntry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQxEMYr5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    ManualKeyEntry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PKIKeyDownload".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZZuy84r5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    PKIKeyDownload,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SignatureRemoteKeyLoading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZfmKY4r5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    SignatureRemoteKeyLoading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unitialised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZinCIYr5EeSvuOJS0mmL0g")]
    [Description(@"??")]
    Unitialised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMSecurityScheme1CodeMetadataExtensions
{
    private static readonly ATMSecurityScheme1CodeDropdownSource _dropdownSource = new ATMSecurityScheme1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMSecurityScheme1CodeDropdownRow GetMetadata(this ATMSecurityScheme1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


