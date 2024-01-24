﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IdentificationType2Code.  ISO2002 ID# _sowHEIA5EeSUJZYcWGKkkw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the source of the leg identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sowHEIA5EeSUJZYcWGKkkw")]
[Description(@"Indicates the source of the leg identification.")]
[DerivedFrom(typeof(IdentificationTypeCode))]
public enum IdentificationType2Code
{
    /// <summary>
    /// CDC is an abbreviation of China Central Depository & Clearing Co, Ltd, an entity undertake functions of centralized depository and settlement for inter-bank bond market in China.
    /// Encoded/decoded by serializers as "CDCO".
    /// </summary>
    [EnumMember(Value = "CDCO")]
    [IsoId("_w-exMYA5EeSUJZYcWGKkkw")]
    [Description(@"CDC is an abbreviation of China Central Depository & Clearing Co, Ltd, an entity undertake functions of centralized depository and settlement for inter-bank bond market in China.")]
    CDC = IdentificationTypeCode.CDC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CFETS is an abbreviation of China Foreign Exchange Trade System, which is a sub-institution of the PBC. Its main functions include: providing systems for FX trading, RMB lending, bond trading and exchange rate and interest rate derivatives trading; organizing FX trading, RMB lending, bond trading, and exchange rate and interest rate derivatives trading; providing clearing, information, risk management, and surveillance services on interbank markets; and engaging in other businesses authorized by the PBC.
    /// Encoded/decoded by serializers as "CFET".
    /// </summary>
    [EnumMember(Value = "CFET")]
    [IsoId("_xEboMYA5EeSUJZYcWGKkkw")]
    [Description(@"CFETS is an abbreviation of China Foreign Exchange Trade System, which is a sub-institution of the PBC. Its main functions include: providing systems for FX trading, RMB lending, bond trading and exchange rate and interest rate derivatives trading; organizing FX trading, RMB lending, bond trading, and exchange rate and interest rate derivatives trading; providing clearing, information, risk management, and surveillance services on interbank markets; and engaging in other businesses authorized by the PBC.")]
    CFETS = IdentificationTypeCode.CFETS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RIC Code is an abbreviation of Reuters Instrument Code. RIC as encoding rule which has been wildly adopted in FX market and defines information including trading category, tenor, trade instrument and so on.
    /// Encoded/decoded by serializers as "RICC".
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("_yjMFMYA5EeSUJZYcWGKkkw")]
    [Description(@"RIC Code is an abbreviation of Reuters Instrument Code. RIC as encoding rule which has been wildly adopted in FX market and defines information including trading category, tenor, trade instrument and so on.")]
    RICCode = IdentificationTypeCode.RICCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// User defined code.
    /// Encoded/decoded by serializers as "USDE".
    /// </summary>
    [EnumMember(Value = "USDE")]
    [IsoId("_yoKr0YA5EeSUJZYcWGKkkw")]
    [Description(@"User defined code.")]
    UserDefined = IdentificationTypeCode.UserDefined, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IdentificationType2CodeMetadataExtensions
{
    private static readonly IdentificationType2CodeDropdownSource _dropdownSource = new IdentificationType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIdentificationType2CodeDropdownRow GetMetadata(this IdentificationType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


