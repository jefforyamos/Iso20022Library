﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EquityInstrumentReportingClassification1Code.  ISO2002 ID# _hrceQAjsEeW36pGcc5RpFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the equity financial instruments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hrceQAjsEeW36pGcc5RpFw")]
[Description(@"Specifies the equity financial instruments.")]
[DerivedFrom(typeof(FinancialInstrumentReportingClassificationCode))]
public enum EquityInstrumentReportingClassification1Code
{
    /// <summary>
    /// Contract is of type shares.
    /// Encoded/decoded by serializers as "Share".
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_DpNkQQjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type shares.")]
    Share,
    
    /// <summary>
    /// Contract is of type other equity-like financial instrument.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DxPe4QjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type other equity-like financial instrument.")]
    Other,
    
    /// <summary>
    /// Contract is of type electronic traded funds.
    /// Encoded/decoded by serializers as "ElectronicTradedFund".
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_D4hyoQjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type electronic traded funds.")]
    ElectronicTradedFund,
    
    /// <summary>
    /// Contract is of type depositary receipt.
    /// Encoded/decoded by serializers as "DepositaryReceipt".
    /// </summary>
    [EnumMember(Value = "DPRS")]
    [IsoId("_EFnzcQjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type depositary receipt.")]
    DepositaryReceipt,
    
    /// <summary>
    /// Contract is of type certificates.
    /// Encoded/decoded by serializers as "Certificate".
    /// </summary>
    [EnumMember(Value = "CRFT")]
    [IsoId("_EO2A4QjtEeW36pGcc5RpFw")]
    [Description(@"Contract is of type certificates.")]
    Certificate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EquityInstrumentReportingClassification1CodeMetadataExtensions
{
    private static readonly EquityInstrumentReportingClassification1CodeDropdownSource _dropdownSource = new EquityInstrumentReportingClassification1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEquityInstrumentReportingClassification1CodeDropdownRow GetMetadata(this EquityInstrumentReportingClassification1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


