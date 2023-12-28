﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PINFormat4Code.  ISO2002 ID# _XsWNgIocEeSirOZJBRz_nA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format of an ATM PIN block before encryption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XsWNgIocEeSirOZJBRz_nA")]
[Description(@"Format of an ATM PIN block before encryption.")]
[DerivedFrom(typeof(PINFormatCode))]
public enum PINFormat4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ANSI0".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cX59sYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ANSI0,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bancomat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cdXsgYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    Bancomat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Banksys".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ch9RkYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    Banksys,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Diebold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cm6qEYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    Diebold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DieboldCO".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_csVVkYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    DieboldCO,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ECI2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cxdtMYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ECI2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ECI3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c2nS8YocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ECI3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EMVRSA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c7vqkYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    EMVRSA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IBM3624".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dA53YYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    IBM3624,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO0".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dHp_oYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ISO0,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dNsWMYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ISO1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dSkPIYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ISO2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dYIEkYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ISO3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO4".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ddshEYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ISO4,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO5".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_djMFEYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    ISO5,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VISA2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dqC7AYocEeSirOZJBRz_nA")]
    [Description(@"??")]
    VISA2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VISA3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dvrB4YocEeSirOZJBRz_nA")]
    [Description(@"??")]
    VISA3,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PINFormat4CodeMetadataExtensions
{
    private static readonly PINFormat4CodeDropdownSource _dropdownSource = new PINFormat4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPINFormat4CodeDropdownRow GetMetadata(this PINFormat4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

