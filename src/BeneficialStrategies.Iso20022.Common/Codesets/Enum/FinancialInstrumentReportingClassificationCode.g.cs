﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialInstrumentReportingClassificationCode.  ISO2002 ID# __esiMPPQEeS_qLctCs2aRQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the financial instrument reporting classification for both equity and non-equity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__esiMPPQEeS_qLctCs2aRQ")]
[Description(@"Specifies the financial instrument reporting classification for both equity and non-equity.")]
public enum FinancialInstrumentReportingClassificationCode
{
    /// <summary>
    /// Contract is of type securitised derivatives.
    /// Encoded/decoded by serializers as "SDRV".
    /// </summary>
    [EnumMember(Value = "SDRV")]
    [IsoId("_DSY2QPPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type securitised derivatives.")]
    SecuritisedDerivative,
    
    /// <summary>
    /// Contract is of type structured finance products (SFPs).
    /// Encoded/decoded by serializers as "SFPS".
    /// </summary>
    [EnumMember(Value = "SFPS")]
    [IsoId("_HLvGYfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type structured finance products (SFPs).")]
    StructuredFinanceProduct,
    
    /// <summary>
    /// Contract is of type bonds.
    /// 
    /// Encoded/decoded by serializers as "BOND".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_IBJEYfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type bonds. ")]
    Bond,
    
    /// <summary>
    /// Contract is of type emission allowances.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_IYM5gfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type emission allowances.")]
    EmissionAllowance,
    
    /// <summary>
    /// Contract is of type contract for difference (CFD).
    /// 
    /// Encoded/decoded by serializers as "CFDS".
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_K1KEIfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type contract for difference (CFD). ")]
    ContractForDifference,
    
    /// <summary>
    /// Contract is of type derivative.
    /// 
    /// Encoded/decoded by serializers as "DERV".
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_LLeSYfPREeS_qLctCs2aRQ")]
    [Description(@"Contract is of type derivative. ")]
    Derivative,
    
    /// <summary>
    /// Contract is of type shares.
    /// Encoded/decoded by serializers as "SHRS".
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_cna1oAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type shares.")]
    Share,
    
    /// <summary>
    /// Contract is of type electronic traded funds.
    /// Encoded/decoded by serializers as "ETFS".
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_hr5cIAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type electronic traded funds.")]
    ElectronicTradedFund,
    
    /// <summary>
    /// Contract is of type depositary receipt.
    /// Encoded/decoded by serializers as "DPRS".
    /// </summary>
    [EnumMember(Value = "DPRS")]
    [IsoId("_oxp94AjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type depositary receipt.")]
    DepositaryReceipt,
    
    /// <summary>
    /// Contract is of type other equity-like financial instrument.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_zYziwAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type other equity-like financial instrument.")]
    Other,
    
    /// <summary>
    /// Contract is of type certificates.
    /// Encoded/decoded by serializers as "CRFT".
    /// </summary>
    [EnumMember(Value = "CRFT")]
    [IsoId("_zY9TwAjqEeW36pGcc5RpFw")]
    [Description(@"Contract is of type certificates.")]
    Certificate,
    
    /// <summary>
    /// Contract is of type exchange traded note.
    /// Encoded/decoded by serializers as "ETNS".
    /// </summary>
    [EnumMember(Value = "ETNS")]
    [IsoId("_2_VMYAnNEeW1sbwBDSZgiA")]
    [Description(@"Contract is of type exchange traded note.")]
    ExchangeTradedNote,
    
    /// <summary>
    /// Contract is of type exchange traded commodities.
    /// Encoded/decoded by serializers as "ETCS".
    /// </summary>
    [EnumMember(Value = "ETCS")]
    [IsoId("_6zeMYAnNEeW1sbwBDSZgiA")]
    [Description(@"Contract is of type exchange traded commodities.")]
    ExchangeTradedCommodities,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialInstrumentReportingClassificationCodeMetadataExtensions
{
    private static readonly FinancialInstrumentReportingClassificationCodeDropdownSource _dropdownSource = new FinancialInstrumentReportingClassificationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialInstrumentReportingClassificationCodeDropdownRow GetMetadata(this FinancialInstrumentReportingClassificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


